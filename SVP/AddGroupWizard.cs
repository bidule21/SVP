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
    public partial class AddGroupWizard : Form
    {
        private Group myGroup;
        public Group Group { get { return myGroup; } }
        private Competition currentCompetition;
        public AddGroupWizard(Competition competition)
        {
            InitializeComponent();
            this.currentCompetition = competition;
        }
        public AddGroupWizard(Competition competition, Group group)
        {
            InitializeComponent();
            this.currentCompetition = competition;
            this.myGroup = group;
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

        private void AddGroupWizardNew_Load(object sender, EventArgs e)
        {
            reloadControls();
            if (myGroup != null)
            {
                txtGroupName.Text = myGroup.Name;
                try
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
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Fehler beim Laden der Gruppe\r\n{0}", ex.Message));
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
            frmUserWizard wizard = new frmUserWizard();
            wizard.ShowDialog();
            reloadControls();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbMember.SelectedIndex < 0)
            {
                MessageBox.Show("Bitte einen Verein auswählen!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (DataGridViewRow vrow in dvMember.Rows)
                if ((int)vrow.Tag == ((Member)cbMember.SelectedItem).Id)
                    return;
            DataGridViewRow row = new DataGridViewRow();
            row.Cells.Add(new DataGridViewTextBoxCell() { Value = ((Member)cbMember.SelectedItem).ToString() });
            row.Cells.Add(new DataGridViewTextBoxCell() { Value = ((Member)cbMember.SelectedItem).Club.ToString() });
            row.Tag = ((Member)cbMember.SelectedItem).Id;
            dvMember.Rows.Add(row);
        }

        private void cbClub_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClub.SelectedIndex >= 0)
            {
                try
                {
                    using (SVPEntitiesContainer context = new SVPEntitiesContainer())
                    {
                        cbMember.Items.Clear();
                        cbMember.Items.AddRange(context.Participants.Include("club").OfType<Member>().Where(x => x.Club.Id == ((Club)(cbClub.SelectedItem)).Id).ToArray());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Fehler beim Laden der Mitglieder\r\n{0}", ex.Message));
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dvMember.Rows.Count == 0)
            {
                MessageBox.Show("Bitte Mitglieder zu der Gruppe hinzufügen!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (SVPEntitiesContainer context = new SVPEntitiesContainer())
                {
                    if (myGroup == null)
                        myGroup = new Group();
                    myGroup.Name = txtGroupName.Text;
                    myGroup.GroupCompetition = (GroupCompetition)currentCompetition;
                    context.Participants.Add(myGroup);
                    context.SaveChanges();

                    foreach (DataGridViewRow row in dvMember.Rows)
                    {
                        var member = context.Participants.OfType<Member>().Where(x => x.Id == (int)row.Tag).First();
                        myGroup.Member.Add(member);
                    }
                    context.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Fehler beim Speichern der Gruppe\r\n{0}", ex.Message));
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            myGroup = null;
            this.Close();
        }
    }
}
