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
    public partial class frmWinner : Form
    {
        public frmWinner(price price)
        {
            InitializeComponent();
        }

        public frmWinner(award award)
        {
            InitializeComponent();
        }

        private void frmWinner_Load(object sender, EventArgs e)
        {

        }
    }
}
