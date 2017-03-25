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
        private group myGroup;
        public group Group { get { return myGroup; } }
        competition currentCompetition;
        public AddGroupWizard(competition competition)
        {
            InitializeComponent();
            this.currentCompetition = competition;
        }

        public AddGroupWizard(competition competition, group group)
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
                myGroup.name = txtGroupName.Text;
            }
            else
            {
                myGroup = new group();
                myGroup.name = txtGroupName.Text;
            }
        }

        private void startPage_Initialize(object sender, AeroWizard.WizardPageInitEventArgs e)
        {
            if (myGroup != null)
                txtGroupName.Text = myGroup.name;
        }

        private void wizardControl1_SelectedPageChanged(object sender, EventArgs e)
        {
            reloadControls();
        }

        private void reloadControls()
        {
            using (svpEntities context = new svpEntities())
            {
                cbClub.Items.Clear();
                cbMember.Items.Clear();
                cbClub.Items.AddRange(context.club.ToArray());
            }
        }

        private void GroupOverview_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            if(dvMember.Rows.Count == 0)
            {
                e.Cancel = true;
                return;
            }
            using (svpEntities context = new svpEntities())
            {
                myGroup.competition_id = currentCompetition.id;
                myGroup.participant = new participant();
                context.group.Add(myGroup);
                context.SaveChanges();
                Console.WriteLine(myGroup.id);
                foreach (DataGridViewRow row in dvMember.Rows)
                {
                    var member = context.member.Where(x => x.id == (int)row.Tag).First();
                    myGroup.member.Add(member);
                }
                context.SaveChanges();

            }
        }

        private void cbClub_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClub.SelectedIndex >= 0)
            {
                using (svpEntities context = new svpEntities())
                {
                    cbMember.Items.Clear();
                    cbMember.Items.AddRange(context.member.Include("club").Where(x => x.club_id == ((club)(cbClub.SelectedItem)).id).ToArray());
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
                    if ((int)vrow.Tag == ((member)cbMember.SelectedItem).id)
                        return;
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = ((member)cbMember.SelectedItem).ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = ((member)cbMember.SelectedItem).club.ToString() });
                row.Tag = ((member)cbMember.SelectedItem).id;
                dvMember.Rows.Add(row);
            }
        }

        private void GroupOverview_Initialize(object sender, AeroWizard.WizardPageInitEventArgs e)
        {
            if (myGroup != null)
            {
                using (svpEntities context = new svpEntities())
                {
                    foreach (member member in myGroup.member)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = member.ToString() });
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = member.club.ToString() });
                        row.Tag = member.id;
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
