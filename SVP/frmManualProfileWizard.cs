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
    public partial class frmManualProfileWizard : Form
    {
        private ManualProfile profile;
        public frmManualProfileWizard()
        {
            InitializeComponent();
            profile = null;
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
                this.profile = (ManualProfile)cbProfile.SelectedItem;
                numSge.Value = profile.ShotCount;
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
                    cbProfile.Items.AddRange(context.Profiles.ToArray());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(string.Format("Fehler beim Laden der Profile\r\n{0}", ex.Message));
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
                        this.profile = new ManualProfile();
                        this.profile.Name = txtProfileName.Text;
                        this.profile.ShotCount = (short)numSge.Value;
                        context.Profiles.Add(this.profile);
                    }
                    else
                    {
                        this.profile = context.Profiles.OfType<ManualProfile>().FirstOrDefault(x => x.Id == this.profile.Id);
                        this.profile.ShotCount = (short)numSge.Value;
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
