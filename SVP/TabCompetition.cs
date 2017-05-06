using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DisagLib;
using System.Linq.Expressions;

namespace SVP
{
    public partial class TabCompetition : UserControl
    {
        private Competition currentCompetition;
        public TabCompetition()
        {
            InitializeComponent();
        }
        private void reload_Controls()
        {
            cbClubGroup.Items.Clear();
            cbPrice.Items.Clear();
            using (SVPEntitiesContainer context = new SVPEntitiesContainer())
            {
                foreach (var p in context.Profiles)
                {
                    cbPrice.Items.Add(new ComboboxItem(p.Name, p.Id));
                }
        
                gbCompetition.Enabled = (currentCompetition != null);
                gbMember.Enabled = (currentCompetition != null);
                if (currentCompetition != null)
                {
                    lblCompetitionName.Text = currentCompetition.Name;
                    dvCompetition.Rows.Clear();
                    foreach (Award a in currentCompetition.Awards)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = a.Name });
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = "Ehrenscheibe" });
                        dvCompetition.Rows.Add(row);
                    }
                    foreach (Price p in currentCompetition.Prices)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = p.Name });
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = "Pokal" });
                        dvCompetition.Rows.Add(row);
                    }
                    if (currentCompetition.GetType() == typeof(GroupCompetition))
                    {
                        lblClubGroup.Text = "Gruppe: ";
                        btnNewClubGroup.Text = "Neue Gruppe";
                        cbClubGroup.Items.AddRange(context.Participants.OfType<Group>().Where(x => x.GroupCompetition.Id == currentCompetition.Id).ToArray());
                    }
                    else
                    {
                        lblClubGroup.Text = "Verein: ";
                        btnNewClubGroup.Text = "Neuer Verein";
                        cbClubGroup.Items.AddRange(context.Clubs.ToArray());
                    }
                }
                else
                {
                    cbClubGroup.Items.AddRange(context.Clubs.ToArray());
                }
            }
        }


        private List<RMResult> readShots(string profile)
        {
            DISAGRM machine = new DISAGRM();
            try
            {
                machine.Start(SVP.Properties.Settings.Default.ComPort);
                Task<List<RMResult>> ta = Task.Factory.StartNew<List<RMResult>>(() => machine.GetShots(profile));
                ta.Wait(30000); //30 Sec
                if (ta.IsCompleted)
                    return ta.Result;
                else
                    throw new Exception("Die Maschine hat nicht schnell genug geantwortet");
            }
            catch (Exception e)
            {
                MessageBox.Show("Fehler beim einlesen der Ergebnisse:\r\n" + e.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                machine.Stop();
            }
            return null;
        }

        private void btnNewMember_Click(object sender, EventArgs e)
        {
            AddUserWizard wizard = new AddUserWizard();
            wizard.ShowDialog();
            cbClub_SelectedIndexChanged(null, null);
        }

        private void btnNewClub_Click(object sender, EventArgs e)
        {
            if (currentCompetition.GetType() != typeof(GroupCompetition))
            {
                AddClubWizard wizard = new AddClubWizard();
                wizard.ShowDialog();
            }
            else
            {
                AddGroupWizard wizard = new AddGroupWizard(currentCompetition);
                wizard.ShowDialog();
            }
            reload_Controls();
        }

        private void cbClub_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClubGroup.SelectedIndex >= 0)
            {
                cbMember.Items.Clear();
                using (SVPEntitiesContainer context = new SVPEntitiesContainer())
                {
                    if (currentCompetition.GetType() == typeof(GroupCompetition))
                    {
                        var group = context.Participants.Include("member").OfType<Group>().First(x => x.Id == ((Group)(cbClubGroup.SelectedItem)).Id);
                        foreach (Member m in group.Member)
                            cbMember.Items.Add(m);
                    }
                    else
                    {
                        foreach (Member m in context.Participants.OfType<Member>().Where(x => x.Club.Id == ((Club)(cbClubGroup.SelectedItem)).Id))
                            cbMember.Items.Add(m);
                    }
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cbMember.SelectedIndex >= 0)
            {
                gbRead.Enabled = true;
                btnRead.Enabled = true;
                lblClub.Text = cbClubGroup.SelectedItem.ToString();
                lblMember.Text = cbMember.SelectedItem.ToString();
                cbPrice.Items.Clear();
                using (SVPEntitiesContainer context = new SVPEntitiesContainer())
                {
                    foreach (var price in currentCompetition.Prices)
                    {
                            bool hasShotYet = false;
                            var sequences = context.Prices.Include("sequence").First(x => x.Id == price.Id).Sequences;
                            foreach (var sequence in sequences)
                                if (sequence.Member.Id == ((Member)cbMember.SelectedItem).Id)
                                    hasShotYet = true;
                            if (!hasShotYet)
                                cbPrice.Items.Add(price);
                    }
                }
                cbPrice.SelectedIndex = 0;
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            btnRead.Enabled = false;
            pBar.Visible = true;
            cbPrice.Enabled = false;
            using (SVPEntitiesContainer context = new SVPEntitiesContainer())
            {
                Profile profile = ((Price)cbPrice.SelectedItem).Profile;
                System.Threading.Tasks.Task<List<RMResult>> ta = System.Threading.Tasks.Task.Factory.StartNew<List<RMResult>>(() => readShots(profile.Value));
                while (!ta.IsCompleted)
                {
                    Application.DoEvents();
                }
                if (ta.Result == null)
                {
                    pBar.Visible = false;
                    cbPrice.Enabled = true;
                    btnRead.Enabled = true;
                    return;
                }
                cbPrice.Items.Remove(cbPrice.SelectedItem);
                Sequence sequence = new Sequence();
                sequence.Date = DateTime.Now;
                sequence.Member.Id = ((ComboboxItem)cbMember.SelectedItem).Id;
                sequence.Profile.Id = profile.Id;
                sequence.Price = ((Price)cbPrice.SelectedItem);
            
                foreach (RMResult result in ta.Result)
                {
                    Shot s = new Shot();
                    s.Value = result.Rings;
                    s.Angle = result.Angle;
                    s.FactorValue = result.FactorValue;
                    s.ShotNumber = (short)result.ShotNumber;
                    s.Valid = (result.Validity == ValidFlag.Valid);
                    sequence.Shots.Add(s);
                }
                DataGridViewRow row = new DataGridViewRow();
                row.Tag = sequence.Id;
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = sequence.Member.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = sequence.Shots.Sum(s => s.Value) });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = sequence.Profile.ToString() });
                row.Cells.Add(new DataGridViewButtonCell() { UseColumnTextForButtonValue = true, Value = sequence });
            
                dvResults.Rows.Add(row);
                context.Sequences.Add(sequence);
                context.SaveChanges();
                gbRead.Enabled = (cbPrice.Items.Count > 0);
                btnRead.Enabled = true;
                pBar.Visible = false;
                cbPrice.Enabled = true;
            }
        }

        private void TabTraining_Load(object sender, EventArgs e)
        {
            reload_Controls();
        }

        private void btnCreateCompetition_Click(object sender, EventArgs e)
        {
            AddCompetitionWizard wizard = new AddCompetitionWizard();
            if (wizard.ShowDialog() == DialogResult.OK && wizard.Competition != null)
            {
                using (SVPEntitiesContainer context = new SVPEntitiesContainer())
                {
                    context.Competitions.Add(wizard.Competition);
                    context.SaveChanges();
            
                    currentCompetition = context.Competitions.Include("price.profile.disagprofile").Where(x => x.Id == wizard.Competition.Id).FirstOrDefault();
                }
                reload_Controls();
            }
        }

        private void btnContinueCompetition_Click(object sender, EventArgs e)
        {
            frmChooseCompetition choose = new frmChooseCompetition();
            choose.ShowDialog();
            currentCompetition = choose.Competition;
            reload_Controls();
        }

        private void btnEditCompetition_Click(object sender, EventArgs e)
        {
            AddCompetitionWizard wizard = new AddCompetitionWizard(this.currentCompetition);
            if (wizard.ShowDialog() == DialogResult.OK)
            {
                using (SVPEntitiesContainer context = new SVPEntitiesContainer())
                {
                    context.SaveChanges(); //ToDo: Check if this is right.
            
                }
                reload_Controls();
            }
        }

        private void btnEndCompetition_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Willst du das Pokalschießen wirklich beenden? Ein weiteres fortführen ist nicht möglich.", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SVPEntitiesContainer context = new SVPEntitiesContainer())
                {
                    foreach(Price p in currentCompetition.Prices)
                    {
                        if (context.Prices.Include("sequence").FirstOrDefault(x => x.Id == p.Id).Sequences.Count() == 0)
                            continue;
                        var bestResult = context.Prices.Include("sequence").FirstOrDefault(x => x.Id == p.Id).Sequences.Max(x => x.Shots.Sum(y => y.Value));
                        var listWinnerSequences = context.Prices.Include("sequence").FirstOrDefault(x => x.Id == p.Id).Sequences.Where(y => y.Shots.Sum(z => z.Value) == bestResult);
                        if(listWinnerSequences.Count() == 1)
                        {
            
                        }
                        else
                        {
            
                        }
                        if (currentCompetition.GetType() != typeof(GroupCompetition))
                        {
            
                        }
                        else
                        {
            
                        }
                    }
                }
            }
        }

        private void dvResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                Monitor.GetMonitor().DisplaySequence((Sequence)dvResults.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            }
        }

        private void cbPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblProfile.Text = ((Price)cbPrice.SelectedItem).Profile.ToString();
        }
    }
}
