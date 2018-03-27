using DisagLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVP
{
    public partial class ProfileWizard : Form
    {
        private List<RMValue> SCH_Values;
        private List<RMValue> RIA_Values;
        private List<RMValue> KAL_Values;
        private List<RMValue> RIB_Values;
        private List<RMValue> TEA_Values;
        private DisagProfile profile;
        public ProfileWizard()
        {
            InitializeComponent();
            profile = null;

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
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string name = "";
            if(rbAddProfile.Checked)
            {
                if(txtProfileName.Text.Length <= 0)
                {
                    MessageBox.Show("Bitte einen Namen eingeben!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                name = txtProfileName.Text;
            }
            else
            {
                if (cbProfile.SelectedIndex < 0)
                {
                    MessageBox.Show("Bitte einen Verein auswählen!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                this.profile = (DisagProfile)cbProfile.SelectedItem;
                setProfileString(this.profile.Value);
                name = profile.Name;
            }
            gbProfile.Text = name;
            gbProfile.Enabled = true;
            gbMenu.Enabled = false;
        }

        private void rbProfile_CheckedChanged(object sender, EventArgs e)
        {
            cbProfile.Enabled = rbEditProfile.Checked;
            txtProfileName.Enabled = rbAddProfile.Checked;
        }

        private void ProfileWizardNew_Load(object sender, EventArgs e)
        {
            try
            {
                using (SVPEntitiesContainer context = new SVPEntitiesContainer())
                {
                    cbProfile.Items.Clear();
                    cbProfile.Items.AddRange(context.Profiles.OfType<DisagProfile>().ToArray());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(string.Format("Fehler beim Laden der Profile\r\n{0}", ex.Message));
            }
            
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
                            cbSch.SelectedItem = SCH_Values.Where(x => x.Value == value[1]).FirstOrDefault();
                            break;
                        case "RIA":
                            cbRia.SelectedItem = RIA_Values.Where(x => x.Value == value[1]).FirstOrDefault();
                            break;
                        case "KAL":
                            cbKal.SelectedItem = KAL_Values.Where(x => x.Value == value[1]).FirstOrDefault();
                            break;
                        case "RIB":
                            cbRib.SelectedItem = RIB_Values.Where(x => x.Value == value[1]).FirstOrDefault();
                            break;
                        case "TEA":
                            cbTea.SelectedItem = TEA_Values.Where(x => x.Value == value[1]).FirstOrDefault();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SVPEntitiesContainer context = new SVPEntitiesContainer())
                {
                    if (this.profile == null)
                    {
                        this.profile = new DisagProfile();
                        this.profile.Name = txtProfileName.Text;
                        this.profile.Value = getProfileString();
                        context.Profiles.Add(this.profile);
                    }
                    else
                    {
                        this.profile = context.Profiles.OfType<DisagProfile>().FirstOrDefault(x => x.Id == this.profile.Id);
                        this.profile.Value = getProfileString();
                    }
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Fehler beim Speichern des Profiles\r\n{0}", ex.Message));
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
