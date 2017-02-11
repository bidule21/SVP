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
                cbClub.Items.AddRange(context.club.ToArray());
                foreach (var p in context.profile)
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
            if (cbClub.SelectedIndex >= 0)
            {
                using (svpEntities context = new svpEntities())
                {
                    cbMember.Items.Clear();
                    foreach (member m in context.member.Where(x => x.club_id == ((club)(cbClub.SelectedItem)).id))
                        cbMember.Items.Add(new ComboboxItem(m.ToString(), m.id));
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            gbRead.Enabled = true;
            lblClub.Text = cbClub.SelectedItem.ToString();
            lblMember.Text = cbMember.SelectedItem.ToString();
            profile p = null;
            using (svpEntities context = new svpEntities())
                p = context.profile.Where(x => x.id == SVP.Properties.Settings.Default.DefaultProfile).FirstOrDefault();
            if (p != null)
                cbProfile.SelectedIndex = cbProfile.FindStringExact(p.name);
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
                context.sequence.Add(sequence);
                context.SaveChanges();

            }
        }

        private void TabTraining_Load(object sender, EventArgs e)
        {
            reload_Controls();
        }
    }
}
