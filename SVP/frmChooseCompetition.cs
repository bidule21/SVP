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
    public partial class frmChooseCompetition : Form
    {
        private Competition myCompetition;
        public Competition Competition { get { return myCompetition; } }
        public frmChooseCompetition()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (lbCompetitions.SelectedIndex >= 0)
            {
                using (SVPEntitiesContainer context = new SVPEntitiesContainer())
                {
                    myCompetition = context.Competitions.Include("Prices.Sequences.Member").Include("Prices.Sequences.Shots").Include("Awards").Include("Prices.Profile").FirstOrDefault(x => x.Id == ((ComboboxItem)lbCompetitions.SelectedItem).Id);
                }
            }
            this.Close();
        }

        private void frmChooseCompetition_Load(object sender, EventArgs e)
        {
            using (SVPEntitiesContainer context = new SVPEntitiesContainer())
            {
                var competitions = context.Competitions.Where(x => x.Finished == false);
                foreach(Competition competition in competitions)
                {
                    lbCompetitions.Items.Add(new ComboboxItem(competition.Name, competition.Id));
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            myCompetition = null;
            this.Close();
        }
    }
}
