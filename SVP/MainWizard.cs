using DisagLib;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;

namespace SVP
{
    public partial class MainWizard : Form
    {
        private List<RMValue> SCH_Values;
        private List<RMValue> RIA_Values;
        private List<RMValue> KAL_Values;
        private List<RMValue> RIB_Values;
        private List<RMValue> TEA_Values;
        private profile profile;
        private DISAGRM machine;
        public MainWizard()
        {
            InitializeComponent();
            machine = new DISAGRM();
            SCH_Values = new List<RMValue>();
            SCH_Values.Add(new RMValue("LG10", "Luftgewehr 10er Band"));
            SCH_Values.Add(new RMValue("LG5", "Luftgewehr 5er Band"));
            SCH_Values.Add(new RMValue("LGES", "Luftgewehr Einzelscheibe"));
            SCH_Values.Add(new RMValue("LP", "LP"));
            SCH_Values.Add(new RMValue("ZS", "Zimmerstuzen 15m"));
            SCH_Values.Add(new RMValue("LS1", "Laufende Scheibe; ein Spiege"));
            SCH_Values.Add(new RMValue("LS2", "Laufende Scheibe; doppel Spiegel"));
            SCH_Values.Add(new RMValue("KK50", "50m Scheibe"));
            SCH_Values.Add(new RMValue("GK10", "100m - Scheibe für Groß und Kleinkalib"));
            SCH_Values.Add(new RMValue("GK5", "Kombischeibe 5-kreisig mit weißem Scheibenspiegel"));
            SCH_Values.Add(new RMValue("LPSF", "LP Schnellfeuer"));
            SCH_Values.Add(new RMValue("SCHFE", "Schnellfeuer- und Duell Scheibe."));
            SCH_Values.Add(new RMValue("USE1", "Benutzerdefiniert 1"));
            SCH_Values.Add(new RMValue("USE2", "Benutzerdefiniert 1"));

            RIA_Values = new List<RMValue>();
            RIA_Values.Add(new RMValue("GR", "Ganze Ringe"));
            RIA_Values.Add(new RMValue("ZR", "Zehntel Ringe"));
            RIA_Values.Add(new RMValue("KR", "Keine Ringe"));

            KAL_Values = new List<RMValue>();
            KAL_Values.Add(new RMValue(null, "Keine Angabe"));
            KAL_Values.Add(new RMValue("22", "22"));
            KAL_Values.Add(new RMValue("6MM", "6MM"));
            KAL_Values.Add(new RMValue("6.5MM", "6.5MM"));
            KAL_Values.Add(new RMValue("7MM", "7MM"));
            KAL_Values.Add(new RMValue("30", "30"));
            KAL_Values.Add(new RMValue("303", "303"));
            KAL_Values.Add(new RMValue("8MM", "8MM"));
            KAL_Values.Add(new RMValue("32", "32"));
            KAL_Values.Add(new RMValue("33", "33"));
            KAL_Values.Add(new RMValue("9MM", "9MM"));
            KAL_Values.Add(new RMValue("357", "357"));
            KAL_Values.Add(new RMValue("36", "36"));
            KAL_Values.Add(new RMValue("38", "38"));
            KAL_Values.Add(new RMValue("40", "40"));
            KAL_Values.Add(new RMValue("44", "44"));
            KAL_Values.Add(new RMValue("45", "45"));
            KAL_Values.Add(new RMValue("50", "50"));
            KAL_Values.Add(new RMValue("52", "52"));
            KAL_Values.Add(new RMValue("54", "54"));
            KAL_Values.Add(new RMValue("58", "58"));

            RIB_Values = new List<RMValue>();
            RIB_Values.Add(new RMValue("RB", "Ringberührungsmethode"));
            RIB_Values.Add(new RMValue("MI", "Schußlochmittelpunkt für Vorderlader"));

            TEA_Values = new List<RMValue>();
            TEA_Values.Add(new RMValue("KT", "Keine Teilerwertung"));
            TEA_Values.Add(new RMValue("ZT", "Teilerwertung mit zehntel Teiler"));
            TEA_Values.Add(new RMValue("HT", "Teilerwertung mit hundertstel Teile"));
        }

        private void wizardControl1_SelectedPageChanged(object sender, EventArgs e)
        {

        }

        private void startPage_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            if (startTraining.Checked)
                startPage.NextPage = startTrainingPage;
            if (startTempTraining.Checked)
                throw new NotImplementedException();
            if (startCompetition.Checked)
                throw new NotImplementedException();
            if (continueCompetition.Checked)
                throw new NotImplementedException();
            if (addMember.Checked)
                startPage.NextPage = addMemberPage;
            if (addClub.Checked)
                startPage.NextPage = addClubPage;
            if (rbManageProfile.Checked)
                startPage.NextPage = addProfilePage;
        }

        private void addClubPage_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            if (txtClubName.TextLength > 0)
            {
                using (svpEntities context = new svpEntities())
                {
                    club newClub = new club();
                    newClub.name = txtClubName.Text;
                    newClub.isTemporary = cbClubTemporary.Checked;
                    context.club.Add(newClub);
                    context.SaveChanges();
                }
                addClubPage.NextPage = startPage;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void addMemberPage_Initialize(object sender, AeroWizard.WizardPageInitEventArgs e)
        {
            using (svpEntities context = new svpEntities())
            {
                foreach (var c in context.club)
                {
                    cbMemberClub.Items.Add(new ComboboxItem(c.name, c.id));
                }
            }
        }

        private void addMemberPage_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            if (txtMemberFirstname.TextLength > 0 && txtMemberName.TextLength > 0 && txtMemberShortName.TextLength > 0 && cbMemberClub.SelectedIndex >= 0)
            {
                using (svpEntities context = new svpEntities())
                {
                    member newMember = new member();
                    newMember.firstname = txtMemberFirstname.Text;
                    newMember.name = txtMemberName.Text;
                    newMember.birthday = dtMemberBirthday.Value;
                    newMember.club_id = ((ComboboxItem)cbMemberClub.SelectedItem).Id;
                    context.member.Add(newMember);
                    context.SaveChanges();
                }
                addMemberPage.NextPage = startPage;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void rbEditProfile_CheckedChanged(object sender, EventArgs e)
        {
            cbProfile.Enabled = rbEditProfile.Checked;
            txtProfileName.Enabled = rbAddProfile.Checked;
        }

        private void rbAddProfile_CheckedChanged(object sender, EventArgs e)
        {
            cbProfile.Enabled = rbEditProfile.Checked;
            txtProfileName.Enabled = rbAddProfile.Checked;
        }

        private void addProfilePage_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            if (rbAddProfile.Checked && txtProfileName.TextLength > 0)
            {
                profile = new profile();
                profile.name = txtProfileName.Text;
                disagprofile disag = new disagprofile();
                profile.disagprofile.Add(disag);
            }
            else if (rbEditProfile.Checked && cbProfile.SelectedIndex >= 0)
            {
                profile = (profile)cbProfile.SelectedItem;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void addProfilePage_Initialize(object sender, AeroWizard.WizardPageInitEventArgs e)
        {
            using (svpEntities context = new svpEntities())
            {
                foreach (var p in context.profile)
                {
                    cbProfile.Items.Add(p);
                }
            }
        }

        private void MainWizard_Load(object sender, EventArgs e)
        {
            cbSch.Items.AddRange(SCH_Values.ToArray());
            cbSch.SelectedIndex = 0;
            cbRia.Items.AddRange(RIA_Values.ToArray());
            cbRia.SelectedIndex = 0;
            cbKal.Items.AddRange(KAL_Values.ToArray());
            cbKal.SelectedIndex = 0;
            cbRib.Items.AddRange(RIB_Values.ToArray());
            cbRib.SelectedIndex = 0;
            cbTea.Items.AddRange(TEA_Values.ToArray());
            cbTea.SelectedIndex = 0;
        }

        private string getProfileString()
        {
            string profile = "";
            profile = "SCH=" + ((RMValue)cbSch.SelectedItem).Value + ";";
            profile += "RIA=" + ((RMValue)cbRia.SelectedItem).Value + ";";
            if (((RMValue)cbKal.SelectedItem).Value != null)
                profile += "KAL=" + ((RMValue)cbKal.SelectedItem).Value + ";";
            profile += "RIB=" + ((RMValue)cbRib.SelectedItem).Value + ";";
            profile += "TEA=" + ((RMValue)cbTea.SelectedItem).Value + ";";

            if (numSsc.Value != -1)
                profile += "SSC=" + numSsc.Value + ";";
            if (numSge.Value != -1)
                profile += "SGE=" + numSge.Value + ";";
            if (numSzi.Value != -1)
                profile += "SZI=" + numSsc.Value + ";";

            if (!cbKsd.Checked)
                profile += "KSD;";
            if (cbTem.Checked)
                profile += "TEM;";

            if (txtDrt.Text.Length > 0)
                profile += "DRT=" + txtDrt.Text + ";";
            return profile;
        }

        private void setProfileString(string profile)
        {
            string[] keyValues = profile.Split(';');
            foreach (string keyValue in keyValues)
            {
                if (keyValue.Contains("="))
                {
                    string[] value = keyValue.Split('=');
                    switch (value[0])
                    {
                        case "SCH":
                            cbSch.SelectedItem = SCH_Values.Where(x => x.Value == value[1]);
                            break;
                        case "RIA":
                            cbRia.SelectedItem = RIA_Values.Where(x => x.Value == value[1]);
                            break;
                        case "KAL":
                            cbKal.SelectedItem = KAL_Values.Where(x => x.Value == value[1]);
                            break;
                        case "RIB":
                            cbRib.SelectedItem = RIB_Values.Where(x => x.Value == value[1]);
                            break;
                        case "TEA":
                            cbTea.SelectedItem = TEA_Values.Where(x => x.Value == value[1]);
                            break;
                        case "SSC":
                            numSsc.Value = int.Parse(value[1]);
                            break;
                        case "SGE":
                            numSge.Value = int.Parse(value[1]);
                            break;
                        case "SZI":
                            numSzi.Value = int.Parse(value[1]);
                            break;
                        case "DRT":
                            txtDrt.Text = value[1];
                            break;
                    }
                }
                else
                {
                    switch (keyValue)
                    {
                        case "KSD":
                            cbKsd.Checked = true;
                            break;
                        case "TEM":
                            cbTem.Checked = true;
                            break;
                    }
                }
            }
        }
        private void editProfilePage_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            using (svpEntities context = new svpEntities())
            {

                var disag = context.disagprofile.Where(x => x.profile_id == profile.id).FirstOrDefault();
                if (disag == null)
                {
                    profile.disagprofile.First().value = getProfileString();
                    context.profile.Add(profile);
                }
                else
                {
                    disag.value = getProfileString();
                    context.Entry(disag).State = System.Data.Entity.EntityState.Modified;
                }
                context.SaveChanges();
            }
        }

        private void editProfilePage_Initialize(object sender, AeroWizard.WizardPageInitEventArgs e)
        {
            using (svpEntities context = new svpEntities())
            {
                var disag = context.disagprofile.Where(x => x.profile_id == profile.id).FirstOrDefault();
                if (disag != null)
                    setProfileString(disag.value);
            }
        }

        private void btnTrainingRead_Click(object sender, EventArgs e)
        {
            if (cbTrainingClub.SelectedIndex >= 0 && cbTrainingMember.SelectedIndex >= 0)
            {
                btnTrainingRead.Enabled = false;
                using (svpEntities context = new svpEntities())
                {
                    disagprofile profile = context.disagprofile.Where(x => x.profile_id == this.profile.id).First();
                    System.Threading.Tasks.Task ta = System.Threading.Tasks.Task.Factory.StartNew<List<RMResult>>(() => readShots(profile.value));
                
                while (!ta.IsCompleted)
                {
                    Application.DoEvents();
                }


                }
            }
        }

        private List<RMResult> readShots(string profile)
        {
            var bla = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings;
            machine.Start(ConfigurationManager.AppSettings["ComPort"]);
            List<RMResult> results = machine.GetShots(profile);
            machine.Stop();
            return results;
        }

        private void TrainingPage_Initialize(object sender, AeroWizard.WizardPageInitEventArgs e)
        {
            using (svpEntities context = new svpEntities())
            {
                cbTrainingClub.Items.Clear();
                cbTrainingClub.Items.AddRange(context.club.ToArray());
            }
        }

        private void startTrainingPage_Initialize(object sender, AeroWizard.WizardPageInitEventArgs e)
        {
            using (svpEntities context = new svpEntities())
            {
                cbTrainingProfile.Items.Clear();
                cbTrainingProfile.Items.AddRange(context.profile.ToArray());
            }
        }

        private void cbTrainingClub_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (svpEntities context = new svpEntities())
            {
                cbTrainingMember.Items.Clear();
                cbTrainingMember.Items.AddRange(context.member.Where(x => x.club_id == ((club)(cbTrainingClub.SelectedItem)).id).ToArray());
            }
        }

        private void startTrainingPage_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            profile = (profile)cbTrainingProfile.SelectedItem;
        }
    }
}
