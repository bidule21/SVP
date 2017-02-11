using DisagLib;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            Monitor.MyMonitor = new Monitor();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Monitor.MyMonitor.Show();
        }
    }
}
