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
using System.Linq.Expressions;

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
            cbPrice.Items.Clear();
            using (svpEntities context = new svpEntities())
            {
                foreach (var p in context.profile)
                {
                    cbPrice.Items.Add(new ComboboxItem(p.name, p.id));
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
                        cbClubGroup.Items.AddRange(context.group.Where(x => x.competition_id == currentCompetition.id).ToArray());
                    }
                    else
                    {
                        lblClubGroup.Text = "Verein: ";
                        btnNewClubGroup.Text = "Neuer Verein";
                        cbClubGroup.Items.AddRange(context.club.ToArray());
                    }
                }
                else
                {
                    cbClubGroup.Items.AddRange(context.club.ToArray());
                }
            }
        }


        private List<RMResult> readShots(string profile)
        {
            DISAGRM machine = new DISAGRM();
            try
            {
                machine.Start(SVP.Properties.Settings.Default.ComPort);
                Task<List<RMResult>> ta = Task.Factory.StartNew<List<RMResult>>(() => machine.GetShots(profile));
                ta.Wait(30000); //30 Sec
                if (ta.IsCompleted)
                    return ta.Result;
                else
                    throw new Exception("Die Maschine hat nicht schnell genug geantwortet");
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
            if (!currentCompetition.group_competition)
            {
                AddClubWizard wizard = new AddClubWizard();
                wizard.ShowDialog();
                reload_Controls();
            }
            else
            {
                AddGroupWizard wizard = new AddGroupWizard();
                wizard.ShowDialog();
                using (svpEntities context = new svpEntities())
                {
                    var group = wizard.Group;
                    group.competition_id = currentCompetition.id;
                    group.participant = new participant();
                    context.group.Add(group);
                    context.SaveChanges();
                    Console.WriteLine(group.id);
                }
                    reload_Controls();
            }
        }

        private void cbClub_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClubGroup.SelectedIndex >= 0)
            {
                cbMember.Items.Clear();
                using (svpEntities context = new svpEntities())
                {
                    if (currentCompetition.group_competition)
                    {
                        var group = context.group.Where(x => x.id == ((group)(cbClubGroup.SelectedItem)).id).First();
                        foreach (member m in group.member)
                            cbMember.Items.Add(m);
                    }
                    else
                    {
                        foreach (member m in context.member.Where(x => x.club_id == ((club)(cbClubGroup.SelectedItem)).id))
                            cbMember.Items.Add(m);
                    }
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cbMember.SelectedIndex >= 0)
            {
                gbRead.Enabled = true;
                btnRead.Enabled = true;
                lblClub.Text = cbClubGroup.SelectedItem.ToString();
                lblMember.Text = cbMember.SelectedItem.ToString();
                cbPrice.Items.Clear();
                foreach (var price in currentCompetition.price)
                {
                    if (currentCompetition.group_competition)
                    {
                    }
                    else
                    {
                        bool isInParticipants = false;
                        foreach (var participant in ((member)cbMember.SelectedItem).participant)
                        {
                            if (price.participant.Contains(participant))
                                isInParticipants = true;
                        }
                        if (!isInParticipants)
                            cbPrice.Items.Add(price);
                    }
                }
                cbPrice.SelectedIndex = 0;
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            btnRead.Enabled = false;
            pBar.Visible = true;
            cbPrice.Enabled = false;
            using (svpEntities context = new svpEntities())
            {
                disagprofile profile = ((price)cbPrice.SelectedItem).profile.disagprofile.FirstOrDefault();
                System.Threading.Tasks.Task<List<RMResult>> ta = System.Threading.Tasks.Task.Factory.StartNew<List<RMResult>>(() => readShots(profile.value));
                while (!ta.IsCompleted)
                {
                    Application.DoEvents();
                }
                if (ta.Result == null)
                {
                    pBar.Visible = false;
                    cbPrice.Enabled = true;
                    btnRead.Enabled = true;
                    return;
                }
                cbPrice.Items.Remove(cbPrice.SelectedItem);
                participant p = new participant();
                p.member.Add((member)cbMember.SelectedItem);

                sequence sequence = new sequence();
                sequence.date = DateTime.Now;
                sequence.member_id = ((ComboboxItem)cbMember.SelectedItem).Id;
                sequence.profile_id = profile.profile_id;
                sequence.participant.Add(p);

                price pr = (price)cbPrice.SelectedItem;
                pr.participant.Add(p);

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
                row.Cells.Add(new DataGridViewButtonCell() { UseColumnTextForButtonValue = true, Value = sequence });

                dvResults.Rows.Add(row);
                context.sequence.Add(sequence);
                context.SaveChanges();
                gbRead.Enabled = (cbPrice.Items.Count > 0);
                btnRead.Enabled = true;
                pBar.Visible = false;
                cbPrice.Enabled = true;
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

                    currentCompetition = context.competition.Include("price.profile.disagprofile").Where(x => x.id == wizard.Competition.id).FirstOrDefault();
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
            if (MessageBox.Show("Willst du das Pokalschießen wirklich beenden? Ein weiteres fortführen ist nicht möglich.", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

            }
        }

        private void btnReRead_Click(object sender, EventArgs e)
        {

        }

        private void dvResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                Monitor.GetMonitor().DisplaySequence((sequence)dvResults.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            }
        }

        private void cbPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblProfile.Text = ((price)cbPrice.SelectedItem).profile.ToString();
        }
    }
}
