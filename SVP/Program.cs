using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SVP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if(System.Diagnostics.Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1)
            {
                MessageBox.Show("SVP läuft bereits!", "SVP läuft bereits!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Application.Run(new frmMain());
        }
    }
}
