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
    public partial class TabTraining : UserControl
    {
        public TabTraining()
        {
            InitializeComponent();
        }
        private void reload_Controls()
        {
            cbClub.Items.Clear();
            cbProfile.Items.Clear();
            using (svpEntities context = new svpEntities())
            {
                cbClub.Items.AddRange(context.club.OrderBy(x => x.name).ToArray());
                foreach (var p in context.profile.OrderBy(x => x.name))
                {
                    cbProfile.Items.Add(new ComboboxItem(p.name, p.id));
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
            AddClubWizard wizard = new AddClubWizard();
            wizard.ShowDialog();
            reload_Controls();
        }

        private void cbClub_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClub.SelectedIndex >= 0)
            {
                using (svpEntities context = new svpEntities())
                {
                    cbMember.Items.Clear();
                    foreach (member m in context.member.Where(x => x.club_id == ((club)(cbClub.SelectedItem)).id).OrderBy(x => x.name))
                        cbMember.Items.Add(new ComboboxItem(m.ToString(), m.id));
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            gbRead.Enabled = true;
            btnRead.Enabled = true;
            lblClub.Text = cbClub.SelectedItem.ToString();
            lblMember.Text = cbMember.SelectedItem.ToString();
            profile p = null;
            using (svpEntities context = new svpEntities())
                p = context.profile.Where(x => x.id == SVP.Properties.Settings.Default.DefaultProfile).FirstOrDefault();
            if (p != null)
                cbProfile.SelectedIndex = cbProfile.FindStringExact(p.name);
            else
                cbProfile.SelectedIndex = 0;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (cbProfile.SelectedIndex < 0)
                return;
            sequence sequence;
            btnRead.Enabled = false;
            pBar.Visible = true;
            using (svpEntities context = new svpEntities())
            {
                disagprofile profile = context.disagprofile.Where(x => x.profile_id == ((ComboboxItem)cbProfile.SelectedItem).Id).First();
                Task<List<RMResult>> ta = Task.Factory.StartNew<List<RMResult>>(() => readShots(profile.value));
                while (!ta.IsCompleted)
                {
                    Application.DoEvents();
                }
                if (ta.Result == null)
                {
                    pBar.Visible = false;
                    btnRead.Enabled = true;
                    return;
                }
                sequence = new sequence();
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
                context.sequence.Add(sequence);
                context.SaveChanges();
                sequence = context.sequence.Where(x => x.id == sequence.id).FirstOrDefault();
                member member = context.member.Where(x => x.id == sequence.member_id).FirstOrDefault();
                profile pro = context.profile.Where(x => x.id == sequence.profile_id).FirstOrDefault();
                DataGridViewRow row = new DataGridViewRow();
                row.Tag = sequence.id;
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = member.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = sequence.shot.Sum(s => s.value) });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = pro.ToString() });
				row.Cells.Add(new DataGridViewButtonCell() { UseColumnTextForButtonValue = true, Tag = sequence.id});
                dvResults.Rows.Add(row);
            }
            pBar.Visible = false;
            Monitor.GetMonitor().AddResult(sequence);
        }

        private void btnDisplayShot_Click(object sender, EventArgs e)
        {
            using (svpEntities context = new svpEntities())
            {
                var sequence = context.sequence.Where(x => x.id == ((sequence)((Button)sender).Tag).id).FirstOrDefault();
                Monitor.GetMonitor().DisplaySequence(sequence);
            }
        }

        private void TabTraining_Load(object sender, EventArgs e)
        {
            reload_Controls();
			using (svpEntities context = new svpEntities())
			{
				var sequences = context.sequence.Include("shot").Include("profile").Include("member");
				foreach (var sequence in sequences)
				{
                    if (sequence.date.Value.Date != DateTime.Today)
                        continue;
					DataGridViewRow row = new DataGridViewRow();
					row.Tag = sequence.id;
					row.Cells.Add(new DataGridViewTextBoxCell() { Value = sequence.member.ToString() });
					row.Cells.Add(new DataGridViewTextBoxCell() { Value = sequence.shot.Sum(s => s.value) });
					row.Cells.Add(new DataGridViewTextBoxCell() { Value = sequence.profile.ToString() });
					DataGridViewButtonCell button = new DataGridViewButtonCell() { UseColumnTextForButtonValue = true, Value = "Anzeigen" };
					row.Cells.Add(button);
					dvResults.Rows.Add(row);
				}
			}
				 
        }

        private void cbMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnStart.Enabled = (cbMember.SelectedIndex >= 0);
        }

        private void TabTraining_Enter(object sender, EventArgs e)
        {
            reload_Controls();
        }

        private void dvResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                int sequence_id = (int)dvResults.Rows[e.RowIndex].Cells[3].Tag;
                using (svpEntities context = new svpEntities())
                {
                    sequence seq = context.sequence.Where(x => x.id == sequence_id).FirstOrDefault();
                    Monitor.GetMonitor().DisplaySequence(seq);
                }
            }
        }
    }
}
