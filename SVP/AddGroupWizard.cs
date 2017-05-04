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
    public partial class AddGroupWizard : Form
    {
        private Group myGroup;
        public Group Group { get { return myGroup; } }
        Competition currentCompetition;
        public AddGroupWizard(Competition competition)
        {
            InitializeComponent();
            this.currentCompetition = competition;
        }

        public AddGroupWizard(Competition competition, Group group)
        {
            InitializeComponent();
            myGroup = group;
            this.currentCompetition = competition;
        }

        private void startPage_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            if (txtGroupName.Text.Length == 0)
                e.Cancel = true;
            else if (myGroup != null)
            {
                myGroup.Name = txtGroupName.Text;
            }
            else
            {
                myGroup = new Group();
                myGroup.Name = txtGroupName.Text;
            }
        }

        private void startPage_Initialize(object sender, AeroWizard.WizardPageInitEventArgs e)
        {
            if (myGroup != null)
                txtGroupName.Text = myGroup.Name;
        }

        private void wizardControl1_SelectedPageChanged(object sender, EventArgs e)
        {
            reloadControls();
        }

        private void reloadControls()
        {
            using (SVPEntitiesContainer context = new SVPEntitiesContainer())
            {
                cbClub.Items.Clear();
                cbMember.Items.Clear();
                cbClub.Items.AddRange(context.Clubs.ToArray());
            }
        }

        private void GroupOverview_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            if(dvMember.Rows.Count == 0)
            {
                e.Cancel = true;
                return;
            }
            using (SVPEntitiesContainer context = new SVPEntitiesContainer())
            {
                myGroup.GroupCompetition = (GroupCompetition)currentCompetition;
                context.Participants.Add(myGroup);
                context.SaveChanges();
                Console.WriteLine(myGroup.Id);
                foreach (DataGridViewRow row in dvMember.Rows)
                {
                    var member = context.Participants.OfType<Member>().Where(x => x.Id == (int)row.Tag).First();
                    myGroup.Member.Add(member);
                }
                context.SaveChanges();
            
            }
        }

        private void cbClub_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClub.SelectedIndex >= 0)
            {
                using (SVPEntitiesContainer context = new SVPEntitiesContainer())
                {
                    cbMember.Items.Clear();
                    cbMember.Items.AddRange(context.Participants.Include("club").OfType<Member>().Where(x => x.Club.Id == ((Club)(cbClub.SelectedItem)).Id).ToArray());
                }
            }
        }

        private void btnNewClubGroup_Click(object sender, EventArgs e)
        {
            AddClubWizard wizard = new AddClubWizard();
            wizard.ShowDialog();
            reloadControls();
        }

        private void btnNewMember_Click(object sender, EventArgs e)
        {
            AddUserWizard wizard = new AddUserWizard();
            wizard.ShowDialog();
            reloadControls();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbMember.SelectedIndex >= 0)
            {
                foreach (DataGridViewRow vrow in dvMember.Rows)
                    if ((int)vrow.Tag == ((Member)cbMember.SelectedItem).Id)
                        return;
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = ((Member)cbMember.SelectedItem).ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = ((Member)cbMember.SelectedItem).Club.ToString() });
                row.Tag = ((Member)cbMember.SelectedItem).Id;
                dvMember.Rows.Add(row);
            }
        }

        private void GroupOverview_Initialize(object sender, AeroWizard.WizardPageInitEventArgs e)
        {
            if (myGroup != null)
            {
                using (SVPEntitiesContainer context = new SVPEntitiesContainer())
                {
                    foreach (Member member in myGroup.Member)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = member.ToString() });
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = member.Club.ToString() });
                        row.Tag = member.Id;
                        dvMember.Rows.Add(row);
                    }
                }
            }
        }

        private void wizardControl1_Cancelling(object sender, System.ComponentModel.CancelEventArgs e)
        {
            myGroup = null;
        }
    }
}
