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

        private void TabShowCompetition_Load(object sender, EventArgs e)
        {
            using (SVPEntitiesContainer context = new SVPEntitiesContainer)
            {
                cbCompetitions.Items.Add(context.Competitions.ToArray());
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadCompetition(((Competition)cbCompetitions.SelectedItem).Id);
        }

        internal void LoadCompetition(int competitionID)
        {
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
                }
                foreach(Price p in competition.Prices)
                {
                    foreach(Sequence seq in p.Sequences.OrderBy(x => x.Shots.Sum(y => y.Value))) //ToDo: ThenBy NextSequence
                    {

                    }
                }
            }
        }
    }
}
