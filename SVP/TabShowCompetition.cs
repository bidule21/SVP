using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVP
{
    public partial class TabShowCompetition : UserControl
    {
        public TabShowCompetition()
        {
            InitializeComponent();
        }

        private void reloadContorls()
        {
            cbCompetitions.Items.Clear();
            using (SVPEntitiesContainer context = new SVPEntitiesContainer())
            {
                cbCompetitions.Items.AddRange(context.Competitions.ToArray());
            }
        }

        private void TabShowCompetition_Load(object sender, EventArgs e)
        {
            reloadContorls();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadCompetition(((Competition)cbCompetitions.SelectedItem).Id);
        }

        internal void LoadCompetition(int competitionID)
        {
            dvResults.Rows.Clear();
            using (SVPEntitiesContainer context = new SVPEntitiesContainer())
            {
                var competition = context.Competitions.Find(competitionID);
                foreach(Award a in competition.Awards)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = competition.Name });
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = "Ehrenscheibe"});
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = a.Name });
                    row.Cells.Add(new DataGridViewTextBoxCell());
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = a.Winner });
                    row.Cells.Add(new DataGridViewTextBoxCell());
                    row.Cells.Add(new DataGridViewTextBoxCell());
                    dvResults.Rows.Add(row);
                }
                foreach(Price p in competition.Prices)
                {
                    int place = 1;
                    foreach (Sequence seq in p.Sequences.OrderByDescending(x => x.Shots.Sum(y => y.Value)).ThenByDescending(x => (x.NextSequence == null) ? 0 : x.NextSequence.Shots.Sum(y => y.Value)))
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = competition.Name });
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = "Pokal" });
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = p.Name });
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = place++ });
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = seq.Member + ((p.Winner == seq.Member) ? " (Gewinner)" : "") });
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = seq.Shots.Sum(x => x.Value)});
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = (seq.NextSequence == null) ? "" : seq.NextSequence.Shots.Sum(x => x.Value).ToString() });
                        dvResults.Rows.Add(row);
                    }
                }
            }
        }

        private void TabShowCompetition_Enter(object sender, EventArgs e)
        {
            reloadContorls();
        }
    }
}
