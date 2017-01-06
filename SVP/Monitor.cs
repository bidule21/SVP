using DisagLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SVP
{
    public partial class Monitor : Form
    {
        private DisplayResult currentResult;
        private int currentShot = 0;
        public Monitor()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            if (Screen.AllScreens.Length > 1)
            {
                this.DesktopLocation = new Point(Screen.AllScreens[1].WorkingArea.X, Screen.AllScreens[1].WorkingArea.Y);
                this.Height = Screen.AllScreens[1].WorkingArea.Height;
                this.Width = Screen.AllScreens[1].WorkingArea.Width;
            }else
            {
                this.Height = Screen.AllScreens[0].WorkingArea.Height;
                this.Width = Screen.AllScreens[0].WorkingArea.Width;
                this.TopMost = false;
            }
        }

        private void Monitor_Load(object sender, EventArgs e)
        {
            pbTarget.Location = new Point(0, 0);
            pbTarget.Height = (int)(this.Width * 0.5);
            pbTarget.Width = (int)(this.Width * 0.5);
            dgResultList.Location = new Point((int)(this.Width * 0.5), 0);
            dgResultList.Width = (int)(this.Width * 0.5);
            dgResultList.Height = this.Height;
            lbResults.Location = new Point(3, (int)(this.Width * 0.5));
            lbCurrentResult.Location = new Point((int)(this.Width * 0.5) - 100, (int)(this.Width * 0.5));
            Timer timer = new Timer();
            timer.Interval = 2000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(currentResult != null)
            {
                if (currentShot == currentResult.Results.Count)
                    currentShot = 0;
                DisplayShot(currentResult.Results[currentShot]);
                currentShot++;
            }
        }

        internal void AddResult(DisplayResult result)
        {
            this.currentResult = result;
            string results = "";
            foreach (RMResult r in result.Results)
                results += r.Rings.ToString() + "     ";
            lbResults.Text = string.Format("{0}\r\n {1}", result.Name, results);
            dgResultList.Rows.Add(result.Name, result.ResultSum.ToString());
        }

        internal void DisplayShot(RMResult shot)
        {
            lbCurrentResult.Text = shot.Rings.ToString();
            pbTarget.Refresh();
            Graphics graphics = pbTarget.CreateGraphics();
            int size = 40;
            int x = pbTarget.Width / 2;
            int y = pbTarget.Width / 2;
            double factor = (shot.FactorValue / 30000) * (pbTarget.Width / 2);
            double angle = shot.Angle;// * (Math.PI / 180);
            angle += (0.5 * Math.PI);
            x += (int)(Math.Sin(angle) * factor);
            y += (int)(Math.Cos(angle) * factor);
            graphics.FillEllipse(Brushes.Red, x - (size / 2), y - (size / 2), size, size);
            graphics.Dispose();
        }
    }
}
