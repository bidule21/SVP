using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DisagLib;

namespace SVP
{
    public partial class TabCompetition : UserControl
    {
        private competition currentCompetition;
        public TabCompetition()
        {
            InitializeComponent();
        }
        private void reload_Controls()
        {
            cbClubGroup.Items.Clear();
            cbProfile.Items.Clear();
            using (svpEntities context = new svpEntities())
            {
                cbClubGroup.Items.AddRange(context.club.ToArray());
                foreach (var p in context.profile)
                {
                    cbProfile.Items.Add(new ComboboxItem(p.name, p.id));
                }
            }
            gbCompetition.Enabled = (currentCompetition != null);
            gbMember.Enabled = (currentCompetition != null);
            if (currentCompetition != null)
            {
                lblCompetitionName.Text = currentCompetition.name;
                dvCompetition.Rows.Clear();
                foreach (award a in currentCompetition.award)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = a.name });
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = "Ehrenscheibe" });
                    dvCompetition.Rows.Add(row);
                }
                foreach (price p in currentCompetition.price)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = p.name });
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = "Pokal" });
                    dvCompetition.Rows.Add(row);
                }
                if (currentCompetition.group_competition == true)
                {
                    lblClubGroup.Text = "Gruppe: ";
                    btnNewClubGroup.Text = "Neue Gruppe";
                }
                else
                {
                    lblClubGroup.Text = "Verein: ";
                    btnNewClubGroup.Text = "Neuer Verein";
                }
            }

        }


        private List<RMResult> readShots(string profile)
        {
            DISAGRM machine = new DISAGRM();
            try
            {
                machine.Start(SVP.Properties.Settings.Default.ComPort);
                List<RMResult> results = machine.GetShots(profile);
                return results;
            }
            catch (Exception e)
            {
                MessageBox.Show("Fehler beim einlesen der Ergebnisse:\r\n" + e.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                machine.Stop();
            }
            return null;
        }

        private void btnNewMember_Click(object sender, EventArgs e)
        {
            AddUserWizard wizard = new AddUserWizard();
            wizard.ShowDialog();
            cbClub_SelectedIndexChanged(null, null);
        }

        private void btnNewClub_Click(object sender, EventArgs e)
        {
            AddClubWizard wizard = new AddClubWizard();
            wizard.ShowDialog();
            reload_Controls();
        }

        private void cbClub_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClubGroup.SelectedIndex >= 0)
            {
                using (svpEntities context = new svpEntities())
                {
                    cbMember.Items.Clear();
                    foreach (member m in context.member.Where(x => x.club_id == ((club)(cbClubGroup.SelectedItem)).id))
                        cbMember.Items.Add(new ComboboxItem(m.ToString(), m.id));
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cbMember.SelectedIndex >= 0)
            {
                gbRead.Enabled = true;
                btnReRead.Enabled = false;
                btnRead.Enabled = true;
                lblClub.Text = cbClubGroup.SelectedItem.ToString();
                lblMember.Text = cbMember.SelectedItem.ToString();
                profile p = null;
                using (svpEntities context = new svpEntities())
                    p = context.profile.Where(x => x.id == SVP.Properties.Settings.Default.DefaultProfile).FirstOrDefault();
                if (p != null)
                    cbProfile.SelectedIndex = cbProfile.FindStringExact(p.name);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            using (svpEntities context = new svpEntities())
            {
                disagprofile profile = context.disagprofile.Where(x => x.profile_id == ((ComboboxItem)cbProfile.SelectedItem).Id).First();
                System.Threading.Tasks.Task<List<RMResult>> ta = System.Threading.Tasks.Task.Factory.StartNew<List<RMResult>>(() => readShots(profile.value));
                while (!ta.IsCompleted)
                {
                    Application.DoEvents();
                }
                if (ta.Result == null)
                {
                    btnRead.Enabled = true;
                    return;
                }
                sequence sequence = new sequence();
                sequence.date = DateTime.Now;
                sequence.member_id = ((ComboboxItem)cbMember.SelectedItem).Id;
                sequence.profile_id = ((ComboboxItem)cbProfile.SelectedItem).Id;

                foreach (RMResult result in ta.Result)
                {
                    shot s = new shot();
                    s.value = result.Rings;
                    s.angle = result.Angle;
                    s.factor_value = result.FactorValue;
                    s.shot_number = result.ShotNumber;
                    s.valid = (result.Validity == ValidFlag.Valid);
                    sequence.shot.Add(s);
                }
                DataGridViewRow row = new DataGridViewRow();
                row.Tag = sequence.id;
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = sequence.member.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = sequence.shot.Sum(s => s.value) });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = sequence.profile.ToString() });
                row.Cells.Add(new DataGridViewButtonCell() { UseColumnTextForButtonValue = true, Value = sequence});
                
                dvResults.Rows.Add(row);
                context.sequence.Add(sequence);
                context.SaveChanges();
                btnRead.Enabled = false;
                btnReRead.Enabled = true;
            }
        }

        private void TabTraining_Load(object sender, EventArgs e)
        {
            reload_Controls();
        }

        private void btnCreateCompetition_Click(object sender, EventArgs e)
        {
            AddCompetitionWizard wizard = new AddCompetitionWizard();
            if (wizard.ShowDialog() == DialogResult.OK && wizard.Competition != null)
            {
                using (svpEntities context = new svpEntities())
                {
                    context.competition.Add(wizard.Competition);
                    context.SaveChanges();
                    currentCompetition = wizard.Competition;
                }
                reload_Controls();
            }
        }

        private void btnContinueCompetition_Click(object sender, EventArgs e)
        {

        }

        private void btnEditCompetition_Click(object sender, EventArgs e)
        {
            AddCompetitionWizard wizard = new AddCompetitionWizard(this.currentCompetition);
            if (wizard.ShowDialog() == DialogResult.OK)
            {
                using (svpEntities context = new svpEntities())
                {
                    context.SaveChanges();

                }
                reload_Controls();
            }
        }

        private void btnEndCompetition_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Willst du das Pokalschießen wirklich beenden? Ein weiteres fortführen ist nicht möglich.", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
            }
        }

        private void btnReRead_Click(object sender, EventArgs e)
        {

        }

        private void dvResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                Monitor.GetMonitor().DisplaySequence((sequence)dvResults.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            }
        }
    }
}
