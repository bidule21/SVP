using DisagLib;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.Web;
using System.Web.Script.Serialization;
using System.Diagnostics;
using System.Net;

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
        private Monitor monitor;
        private DisplayResult lastResult;

        private List<DisplayResult> ReadCSV(string filename)
        {
            DisplayResult[] results = new DisplayResult[12];
            using (System.IO.StreamReader sr = new System.IO.StreamReader(filename))
            {
                string line = sr.ReadLine();
                line = sr.ReadLine();

                for (int i = 0; i < 12; i++)
                    results[i] = new DisplayResult("Schütze " + (i + 1), new List<RMResult>());
                while(line!=null)
                {
                    RMResult result = new RMResult();
                    
                    string[] values = line.Split(';');
                    result.ShotNumber = int.Parse(values[1]);
                    result.FactorValue = double.Parse(values[2]) / 10;
                    result.Angle = double.Parse(values[3]) / 10;
                    result.Rings = double.Parse(values[4]) / 10;
                    result.Validity = ValidFlag.Valid;
                    results[int.Parse(values[0]) - 1].Results.Add(result);
                    line = sr.ReadLine();
                }
            }
            List<DisplayResult> returnvalue = new List<DisplayResult>();
            for (int i = 0; i < 12; i++)
                returnvalue.Add(results[i]);
            return returnvalue;
        }

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
            SCH_Values.Add(new RMValue("USE2", "Benutzerdefiniert 2"));

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
            monitor = new Monitor();
            monitor.Show();

            DisplayResult result = new DisplayResult("Christopher Schenk", new List<RMResult>());
            var t = ReadCSV("test.csv");
            monitor.AddResult(t[10]);
            ShowResult(t[10]);
            lastResult = t[10];
        }

        private void ShowResult(DisplayResult result)
        {
            return; //Disabed
            try
            {
                JavaScriptSerializer ser = new JavaScriptSerializer();
                using (WebClient client = new WebClient())
                {

                    byte[] response =
                    client.UploadValues("http://" + SVP.Properties.Settings.Default.MonitorIP + "/put.php", new System.Collections.Specialized.NameValueCollection()
                    {
                    { "data", ser.Serialize(result) },
                    });

                    string rv = System.Text.Encoding.UTF8.GetString(response);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
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
                    txtClubName.Text = "";
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
                    cbMemberClub.SelectedIndex = -1;
                    txtMemberFirstname.Text = "";
                    txtMemberName.Text = "";
                    txtMemberShortName.Text = "";
                    cbMemberClub.Items.Clear();
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
                cbProfile.Items.Clear();
                cbProfile.Items.AddRange(context.profile.ToArray());
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

                var disagProfile = context.disagprofile.Where(x => x.profile_id == profile.id).FirstOrDefault();
                if (disagProfile == null)
                {
                    this.profile.disagprofile.First().value = getProfileString();
                    context.profile.Add(this.profile);
                }
                else
                {
                    disagProfile.value = getProfileString();
                    context.Entry((disagprofile)disagProfile).State = System.Data.Entity.EntityState.Modified;
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
                    disagprofile profile = context.disagprofile.Where(x => x.profile_id == ((ComboboxItem)cbTrainingSelectedProfile.SelectedItem).Id).First();
                    System.Threading.Tasks.Task<List<RMResult>> ta = System.Threading.Tasks.Task.Factory.StartNew<List<RMResult>>(() => readShots(profile.value));
                
                while (!ta.IsCompleted)
                {
                    Application.DoEvents();
                }
                    if (ta.Result == null)
                    {
                        btnTrainingRead.Enabled = true;
                        return;
                    }
                     lastResult = new DisplayResult(cbTrainingMember.SelectedItem.ToString(), ta.Result);
                    monitor.AddResult(lastResult);
                    ShowResult(lastResult);
                    MessageBox.Show(lastResult.ResultSum.ToString());
                }
            }
        }

        private List<RMResult> readShots(string profile)
        {
            try
            {
                machine.Start(SVP.Properties.Settings.Default.ComPort);
                List<RMResult> results = machine.GetShots(profile);
                return results;
            }
            catch(Exception e)
            {
                MessageBox.Show("Fehler beim einlesen der Ergebnisse:\r\n" + e.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                machine.Stop();
            }
            return null;
        }

        private void TrainingPage_Initialize(object sender, AeroWizard.WizardPageInitEventArgs e)
        {
            using (svpEntities context = new svpEntities())
            {
                cbTrainingSelectedProfile.Items.Clear();
                cbTrainingMember.Items.Clear();
                cbTrainingClub.Items.Clear();
                cbTrainingClub.Items.AddRange(context.club.ToArray());
                foreach(profile p in context.profile)
                    cbTrainingSelectedProfile.Items.Add(new ComboboxItem(p.name, p.id));
                cbTrainingSelectedProfile.SelectedIndex = cbTrainingSelectedProfile.FindStringExact(profile.ToString());
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
                foreach(member m in context.member.Where(x => x.club_id == ((club)(cbTrainingClub.SelectedItem)).id))
                    cbTrainingMember.Items.Add(new ComboboxItem(m.ToString(), m.id));
            }
        }

        private void startTrainingPage_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            if (cbTrainingProfile.SelectedIndex < 0)
                e.Cancel = true;
            monitor.ShowNames = cbTrainingShowNames.Checked;
            profile = (profile)cbTrainingProfile.SelectedItem;
        }

        private void TrainingPage_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            if(rbTrainingContinue.Checked)
            {
                using (svpEntities context = new svpEntities())
                {
                    sequence sequence = new sequence();
                    sequence.date = DateTime.Now;
                    sequence.member_id = ((ComboboxItem)cbTrainingMember.SelectedItem).Id;
                    sequence.profile_id = ((ComboboxItem)cbTrainingSelectedProfile.SelectedItem).Id;

                    foreach (RMResult result in lastResult.Results)
                    {
                        shot s = new shot();
                        s.value = result.Rings;
                        sequence.shot.Add(s);
                    }
                    context.sequence.Add(sequence);
                    context.SaveChanges();
                }
                cbTrainingClub.Items.Clear();
                cbTrainingMember.Items.Clear();
                cbTrainingClub.SelectedIndex = -1;
                cbTrainingMember.SelectedIndex = -1;
                cbTrainingClub.Text = "";
                cbTrainingMember.Text = "";
                btnTrainingRead.Enabled = true;
                TrainingPage_Initialize(this, null);
                TrainingPage.NextPage = TrainingPage;
            }
            else
            {
                TrainingPage.NextPage = null;
            }
        }
    }
}
