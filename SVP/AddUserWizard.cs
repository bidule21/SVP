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
    public partial class AddUserWizard : Form
    {
        Member member;
        public AddUserWizard()
        {
            InitializeComponent();
            this.member = null;
        }

        public AddUserWizard(Member member)
        {
            InitializeComponent();
            this.member = member;
            txtMemberFirstname.Text = this.member.Firstname;
            txtMemberName.Text = this.member.Name;
            dtMemberBirthday.Value = this.member.Birthday.Value;
            txtMemberShortName.Text = this.member.Shortname;
            cbMemberClub.SelectedIndex = cbMemberClub.FindStringExact(member.Club.ToString());
        }

        private void txtMember_TextChanged(object sender, EventArgs e)
        {
            string nickname = txtMemberName.Text + txtMemberFirstname.Text;
            txtMemberShortName.Text = nickname.Substring(0, Math.Min(10, nickname.Length));
        }

        private void AddUserWizardNew_Load(object sender, EventArgs e)
        {
            using (SVPEntitiesContainer context = new SVPEntitiesContainer())
            {
                cbMemberClub.Items.AddRange(context.Clubs.ToArray());
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtMemberFirstname.TextLength <= 0)
            {
                MessageBox.Show("Bitte einen Vornamen eingeben!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMemberName.TextLength <= 0)
            {
                MessageBox.Show("Bitte einen Vornamen eingeben!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMemberShortName.TextLength <= 0)
            {
                MessageBox.Show("Bitte einen Vornamen eingeben!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbMemberClub.SelectedIndex < 0)
            {
                MessageBox.Show("Bitte einen Vornamen eingeben!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (SVPEntitiesContainer context = new SVPEntitiesContainer())
                {
                    if (this.member == null)
                    {
                        this.member = new Member();
                        this.member.Firstname = txtMemberFirstname.Text;
                        this.member.Name = txtMemberName.Text;
                        this.member.Birthday = dtMemberBirthday.Value;
                        this.member.Shortname = txtMemberShortName.Text;
                        var club = context.Clubs.FirstOrDefault(x => x.Id == ((Club)cbMemberClub.SelectedItem).Id);
                        club.Members.Add(this.member);
                    }
                    else
                    {
                        this.member = context.Participants.OfType<Member>().First(x => x.Id == this.member.Id);
                        this.member.Firstname = txtMemberFirstname.Text;
                        this.member.Name = txtMemberName.Text;
                        this.member.Birthday = dtMemberBirthday.Value;
                        this.member.Shortname = txtMemberShortName.Text;

                    }
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Fehler beim Speichern des Mitglieds\r\n{0}", ex.Message));
            }
            finally
            {
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
