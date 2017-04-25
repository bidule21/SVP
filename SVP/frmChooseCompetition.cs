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
        private competition myCompetition;
        public competition Competition { get { return myCompetition; } }
        public frmChooseCompetition()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (lbCompetitions.SelectedIndex >= 0)
            {
                using (svpEntities context = new svpEntities())
                {
                    myCompetition = context.competition.Include("award").Include("price.profile.disagprofile").FirstOrDefault(x => x.id == ((ComboboxItem)lbCompetitions.SelectedItem).Id);
                }
            }
            this.Close();
        }

        private void frmChooseCompetition_Load(object sender, EventArgs e)
        {
            using (svpEntities context = new svpEntities())
            {
                var competitions = context.competition.Where(x => x.@sealed == false);
                foreach(competition competition in competitions)
                {
                    lbCompetitions.Items.Add(new ComboboxItem(competition.name, competition.id));
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
