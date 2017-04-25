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
        public frmDetermineWinner(price p)
        {
            InitializeComponent();
            this.Text += " " + p.name;
        }

        public frmDetermineWinner(award a)
        {
            InitializeComponent();
            this.Text += " " + a.name;
        }
    }
}
