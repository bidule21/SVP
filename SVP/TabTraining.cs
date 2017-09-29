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
            using (SVPEntitiesContainer context = new SVPEntitiesContainer())
            {
                cbClub.Items.AddRange(context.Clubs.OrderBy(x => x.Name).ToArray());
                foreach (var p in context.Profiles.OrderBy(x => x.Name))
                {
                    cbProfile.Items.Add(new ComboboxItem(p.Name, p.Id));
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
                using (SVPEntitiesContainer context = new SVPEntitiesContainer())
                {
                    cbMember.Items.Clear();
                    var club = context.Clubs.Include("Members").FirstOrDefault(x => x.Id == ((Club)(cbClub.SelectedItem)).Id);
                    foreach (Member m in club.Members.OrderBy(x => x.Name))
                        cbMember.Items.Add(m);
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cbClub.SelectedIndex < 0 || cbMember.SelectedIndex < 0)
                return;
            gbRead.Enabled = true;
            btnRead.Enabled = true;
            lblClub.Text = cbClub.SelectedItem.ToString();
            lblMember.Text = cbMember.SelectedItem.ToString();
            Profile p = null;
            using (SVPEntitiesContainer context = new SVPEntitiesContainer())
                p = context.Profiles.Where(x => x.Id == SVP.Properties.Settings.Default.DefaultProfile).FirstOrDefault();
            if (p != null)
                cbProfile.SelectedIndex = cbProfile.FindStringExact(p.Name);
            else if (cbProfile.Items.Count > 0)
                cbProfile.SelectedIndex = 0;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (cbProfile.SelectedIndex < 0)
                return;
            Sequence sequence;
            btnRead.Enabled = false;
            pBar.Visible = true;
            using (SVPEntitiesContainer context = new SVPEntitiesContainer())
            {
                Profile profile = context.Profiles.Where(x => x.Id == ((ComboboxItem)cbProfile.SelectedItem).Id).First();
                Task<List<RMResult>> ta = Task.Factory.StartNew<List<RMResult>>(() => readShots(profile.Value));
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
                sequence = new Sequence();
                sequence.Date = DateTime.Now;
                sequence.Member = ((Member)cbMember.SelectedItem);
                sequence.Profile = profile;

                context.Participants.Attach(sequence.Member);
                foreach (RMResult result in ta.Result)
                {
                    Shot s = new Shot();
                    s.Value = result.Rings;
                    s.Angle = result.Angle;
                    s.FactorValue = result.FactorValue;
                    s.ShotNumber = (short)result.ShotNumber;
                    s.Valid = (result.Validity == ValidFlag.Valid);
                    sequence.Shots.Add(s);
                }
                context.Sequences.Add(sequence);
                context.SaveChanges();
                sequence = context.Sequences.Where(x => x.Id == sequence.Id).FirstOrDefault();
                Member member = (Member)context.Participants.Where(x => x.Id == sequence.Member.Id).FirstOrDefault();
                Profile pro = context.Profiles.Where(x => x.Id == sequence.Profile.Id).FirstOrDefault();
                DataGridViewRow row = new DataGridViewRow();
                row.Tag = sequence.Id;
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = member.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = sequence.Shots.Sum(s => s.Value) });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = pro.ToString() });
                row.Cells.Add(new DataGridViewButtonCell() { UseColumnTextForButtonValue = true, Tag = sequence.Id });
                dvResults.Rows.Add(row);
            }
            pBar.Visible = false;
            Monitor.GetMonitor().AddResult(sequence);
        }

        private void btnDisplayShot_Click(object sender, EventArgs e)
        {
            using (SVPEntitiesContainer context = new SVPEntitiesContainer())
            {
                var sequence = context.Sequences.Where(x => x.Id == ((Sequence)((Button)sender).Tag).Id).FirstOrDefault();
                Monitor.GetMonitor().AddResult(sequence);
            }
        }

        private void TabTraining_Load(object sender, EventArgs e)
        {
            reload_Controls();
            using (SVPEntitiesContainer context = new SVPEntitiesContainer())
            {
                var sequences = context.Sequences.Include("Shots").Include("Profile").Include("Member");
                foreach (var sequence in sequences)
                {
                    if (sequence.Date.Date != DateTime.Today)
                        continue;
                    DataGridViewRow row = new DataGridViewRow();
                    row.Tag = sequence.Id;
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = sequence.Member.ToString() });
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = sequence.Shots.Sum(s => s.Value) });
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = sequence.Profile.ToString() });
                    DataGridViewButtonCell button = new DataGridViewButtonCell() { UseColumnTextForButtonValue = true };
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
            if (e.ColumnIndex == 3)
            {
                int sequence_id = (int)dvResults.Rows[e.RowIndex].Tag;
                using (SVPEntitiesContainer context = new SVPEntitiesContainer())
                {
                    Sequence seq = context.Sequences.Include("Shots").Where(x => x.Id == sequence_id).FirstOrDefault();
                    Monitor.GetMonitor().DisplaySequence(seq);
                }
            }
        }
    }
}
