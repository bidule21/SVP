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
    public partial class AddUserWizard : Form
    {

        public AddUserWizard()
        {
            InitializeComponent();
        }

        private void addMemberPage_Initialize(object sender, AeroWizard.WizardPageInitEventArgs e)
        {
            using (SVPEntitiesContainer context = new SVPEntitiesContainer())
            {
                cbMemberClub.Items.AddRange(context.Clubs.ToArray());
            }
        }

        private void addMemberPage_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            if (txtMemberFirstname.TextLength > 0 && txtMemberName.TextLength > 0 && txtMemberShortName.TextLength > 0 && cbMemberClub.SelectedIndex >= 0)
            {
                using (SVPEntitiesContainer context = new SVPEntitiesContainer())
                {
                    Member newMember = new Member();
                    newMember.Firstname = txtMemberFirstname.Text;
                    newMember.Name = txtMemberName.Text;
                    newMember.Birthday = dtMemberBirthday.Value;
                    newMember.Club = ((Club)cbMemberClub.SelectedItem);
                    cbMemberClub.SelectedIndex = -1;
                    txtMemberFirstname.Text = "";
                    txtMemberName.Text = "";
                    txtMemberShortName.Text = "";
                    cbMemberClub.Items.Clear();
                    context.Participants.Add(newMember);
                    context.SaveChanges();
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void updateNickname()
        {
            string nickname = (txtMemberName.Text + txtMemberFirstname.Text);
            txtMemberShortName.Text = nickname.Substring(0, Math.Min(10, nickname.Length));
        }

        private void txtMemberFirstname_TextChanged(object sender, EventArgs e)
        {
            updateNickname();
        }

        private void txtMemberName_TextChanged(object sender, EventArgs e)
        {
            updateNickname();
        }
    }
}
