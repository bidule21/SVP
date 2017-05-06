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

        //TODO: swap member with participant to add group support
        private void frmDetermineWinner_Load(object sender, EventArgs e)
        {
            using (SVPEntitiesContainer context = new SVPEntitiesContainer())
            {
                var bestResult = context.Prices.Include("Sequences").FirstOrDefault(x => x.Id == price.Id).Sequences.Max(x => x.Shots.Sum(y => y.Value));
                int count = context.Prices.Include("Sequences").FirstOrDefault(x => x.Id == price.Id).Sequences.Where(x => x.Shots.Sum(y => y.Value) == bestResult).Count();
                int place = 1;
                foreach (var sequence in context.Prices.Include("Sequences.Member").Include("Sequences.Shots").FirstOrDefault(x => x.Id == price.Id).Sequences.OrderBy(x => x.Shots.Sum(y => y.Value)))
                {
                    bool reevaluateSeq = false;
                    //Sequence seq = (sequence.sequence1.Count() == 0) ? sequence : sequence.sequence1.First();
                    if(count > 1)
                    {
                        reevaluateSeq = true;
                    }else if (count < 1)
                    {
                        throw new Exception("Something really weird happend: found no Sequences with the Best Result");
                    }
                    DataGridViewRow row = new DataGridViewRow();
                    row.Tag = sequence.Id;
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = place++ });
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = sequence.Member.Name });
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = sequence.Shots.Sum(x => x.Value )});
                    row.Cells.Add(new DataGridViewCheckBoxCell() { Value = reevaluateSeq });
                    dvResultList.Rows.Add(row);
                }
            
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //TODO: reevaluate the checked Rows
        }
    }
}
