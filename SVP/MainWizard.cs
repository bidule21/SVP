using System;
using System.Windows.Forms;

namespace SVP
{
    public partial class MainWizard : Form
    {
        public MainWizard()
        {
            InitializeComponent();
        }

        private void wizardControl1_SelectedPageChanged(object sender, EventArgs e)
        {

        }

        private void startPage_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            if (startTraining.Checked)
                throw new NotImplementedException();
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
            if(txtClubName.TextLength > 0)
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
            }else
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
            if(txtMemberFirstname.TextLength > 0 && txtMemberName.TextLength > 0 && txtMemberShortName.TextLength > 0 && cbMemberClub.SelectedIndex >= 0)
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
            if(rbAddProfile.Checked && txtProfileName.TextLength > 0)
            {

            }else if (rbEditProfile.Checked && cbProfile.SelectedIndex >= 0)
            {

            }else
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
                    cbProfile.Items.Add(new ComboboxItem(p.name, p.id));
                }
            }
        }
    }
}
