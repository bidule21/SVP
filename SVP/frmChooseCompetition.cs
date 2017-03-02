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

        }

        private void frmChooseCompetition_Load(object sender, EventArgs e)
        {
            using (svpEntities context = new svpEntities())
            {
                
            }
        }
    }
}
