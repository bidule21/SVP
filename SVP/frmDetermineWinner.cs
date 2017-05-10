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
    public partial class frmDetermineWinner : Form
    {
        private Price price;
        public frmDetermineWinner(Price p)
        {
            InitializeComponent();
            this.Text += " " + p.Name;
            this.price = p;
        }

        public frmDetermineWinner(Award a)
        {
            InitializeComponent();
            this.Text += " " + a.Name;
        }


        private void frmDetermineWinner_Load(object sender, EventArgs e)
        {
            reloadControls();
        }

        //TODO: check wether there is a NextSequence
        private void reloadControls()
        {
            dvResultList.Rows.Clear();
            using (SVPEntitiesContainer context = new SVPEntitiesContainer())
            {
                if (price.Competition is GroupCompetition)
                {
                    GroupCompetition competition = (GroupCompetition)price.Competition;
                    Dictionary<Group, Tuple<double, double>> groupResults = new Dictionary<Group, Tuple<double, double>>();
                    foreach (Group g in competition.Groups)
                    {

                        double nextResult = context.Sequences.Where(x => x.Member.Groups.Contains(g) && x.Price.Id == price.Id && x.NextSequence != null).Sum(y => y.NextSequence.Shots.Sum(z => z.Value));
                        double normalResult = context.Sequences.Where(x => x.Member.Groups.Contains(g) && x.Price.Id == price.Id).Sum(y => y.Shots.Sum(z => z.Value));

                        groupResults.Add(g, new Tuple<double, double>(normalResult, nextResult));
                    }
                    groupResults.OrderBy(x => x.Value.Item1).ThenBy(y => y.Value.Item2);
                    int place = 1;
                    KeyValuePair<Group, Tuple<double, double>>[] firstTwo = groupResults.Take(2).ToArray();
                    double lastResult = (firstTwo[0].Value.Item1 == firstTwo[1].Value.Item1 && (firstTwo[0].Value.Item2 != firstTwo[1].Value.Item2)) ? firstTwo[0].Value.Item1 : -1; //Check wether item2 is set
                    foreach (Group g in groupResults.Keys)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.Tag = g.Id;
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = place++ });
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = g.Name });
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = groupResults[g] });
                        row.Cells.Add(new DataGridViewCheckBoxCell() { Value = (groupResults[g].Item1 == lastResult) });
                        if (lastResult != -1)
                            lastResult = groupResults[g].Item1;
                        dvResultList.Rows.Add(row);
                    }
                    var bestResult = context.Prices.Include("Sequences").FirstOrDefault(x => x.Id == price.Id).Sequences.Max(x => x.Shots.Sum(y => y.Value));
                }
                else
                {
                    var bestResult = context.Prices.Include("Sequences").FirstOrDefault(x => x.Id == price.Id).Sequences.Max(x => x.Shots.Sum(y => y.Value));
                    int count = context.Prices.Include("Sequences").FirstOrDefault(x => x.Id == price.Id).Sequences.Where(x => x.Shots.Sum(y => y.Value) == bestResult).Count();
                    int place = 1;
                    foreach (var sequence in context.Prices.Include("Sequences.Member").Include("Sequences.Shots").FirstOrDefault(x => x.Id == price.Id).Sequences.OrderByDescending(x => x.NextSequence == null ? 0 : x.NextSequence.Shots.Sum(y => y.Value)).ThenByDescending(x => x.Shots.Sum(y => y.Value)))
                    {
                        bool reevaluateSeq = false;
                        if (count > 1)
                        {
                            reevaluateSeq = true;
                        }
                        else if (count < 1)
                        {
                            throw new Exception("Something really weird happend: found no Sequences with the Best Result");
                        }
                        string displayValue = sequence.Shots.Sum(x => x.Value).ToString();
                        if (sequence.NextSequence != null)
                            displayValue += " / " + sequence.NextSequence.Shots.Sum(x => x.Value).ToString();
                        DataGridViewRow row = new DataGridViewRow();
                        row.Tag = sequence.Member.Id;
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = place++ });
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = sequence.Member.Name });
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = displayValue });
                        row.Cells.Add(new DataGridViewCheckBoxCell() { Value = reevaluateSeq });
                        dvResultList.Rows.Add(row);
                    }
                }

            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            List<int> idsToReevaluate = new List<int>();
            foreach (DataGridViewRow row in dvResultList.Rows)
                if ((bool)row.Cells[3].Value == true)
                    idsToReevaluate.Add((int)row.Tag);
            frmReevaluate reevaluateFrm = null;
            using (SVPEntitiesContainer context = new SVPEntitiesContainer())
            {
                if (idsToReevaluate.Count == 0)
                {
                    Price p = context.Prices.Find(price.Id);
                    Participant winner = context.Participants.Find((int)dvResultList.Rows[0].Tag);
                    p.Winner = winner;
                    context.SaveChanges();
                    this.Close();
                    return;
                }
                

                if (price.Competition is GroupCompetition)
                {
                    GroupCompetition competition = (GroupCompetition)price.Competition;
                    reevaluateFrm = new frmReevaluate(price, context.Sequences.Where(x => competition.Groups.Where(y => y.Member.Contains(x.Member)).Count() > 0 && x.Price.Id == price.Id).ToList());
                }
                else
                {
                    reevaluateFrm = new frmReevaluate(price, context.Sequences.Where(x => idsToReevaluate.Contains(x.Member.Id) && x.Price.Id == price.Id).ToList());
                }
            }
            reevaluateFrm.ShowDialog();
            reloadControls();
        }
    }
}
