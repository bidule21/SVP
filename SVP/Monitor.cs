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
        private static Monitor MyMonitor;
        private sequence currentResult;
        private int currentShot = 0;
        public bool ShowNames { get; set; }
        private Timer timer;

        public static Monitor GetMonitor()
        {
            if (MyMonitor == null)
                MyMonitor = new Monitor();
            return MyMonitor;
        }

        private Monitor()
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
            lbResults.Location = new Point(3, (int)(this.Width * 0.5));
            rtResults.Location = new Point(3, (int)(this.Width * 0.5) + 40);
            rtResults.Width = this.Width;
            dgResultList.Location = new Point((int)(this.Width * 0.5), 0);
            dgResultList.Width = (int)(this.Width * 0.5);
            dgResultList.Height = this.rtResults.Location.Y;
            lbCurrentResult.Location = new Point((int)(this.Width * 0.5) - 100, (int)(this.Width * 0.5));
            timer = new Timer();
            timer.Interval = 5000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(currentResult != null)
            {
                if (currentShot == currentResult.shot.Count)
                {
                    DisplayAllShots();
                    currentShot = 0;
                    this.timer.Stop();
                }
                else
                {
                    DisplayShot(currentResult.shot.ElementAt(currentShot));
                    currentShot++;
                }
            }
        }

        internal void AddResult(sequence result)
        {
            dgResultList.Rows.Add(lbResults.Text, result.shot.Sum(x => x.value).ToString(), result.profile);
            dgResultList.FirstDisplayedScrollingRowIndex = dgResultList.RowCount - 1;
            DisplaySequence(result);
        }

        internal void DisplaySequence(sequence result)
        {
            this.currentResult = result;
            currentShot = 0;
            lbResults.Text = this.ShowNames ? result.member.ToString() : SVP.Properties.Settings.Default.DefaultName;
            timer.Start();
        }

        private void DrawShot(shot shot, Graphics graphics, Brush brush)
        {
            int size = (int)(pbTarget.Width / 11.5);
            int x = pbTarget.Width / 2;
            int y = pbTarget.Width / 2;
            double factor = (shot.factor_value / 2300) * (pbTarget.Width / 2);
            double angle = shot.angle * (Math.PI / 180);
            angle += (1.5 * Math.PI);
            x += (int)(Math.Cos(angle) * factor);
            y += (int)(Math.Sin(angle) * factor);
            graphics.FillEllipse(brush, x - (size / 2), y - (size / 2), size, size);
        }

        internal void DisplayShot(shot shot)
        {
            string shots = "";
            foreach(shot result in currentResult.shot)
            {
                if(result == shot)
                {
                    shots += "     " + @"\cf1 " + result.value.ToString();
                }
                else
                {
                    shots += "     \\cf0 " + result.value.ToString();
                }
            }
            rtResults.Rtf = @"{\rtf1\ansi {\colortbl; \red255\green0\blue0;}" + shots + "}";
            lbCurrentResult.Text = shot.value.ToString();
            pbTarget.Refresh();
            Graphics graphics = pbTarget.CreateGraphics();
            DrawShot(shot, graphics, Brushes.Red);
            graphics.Dispose();
        }
        internal void DisplayAllShots()
        {
            string shots = "";
            foreach (shot result in currentResult.shot)
                shots += "     " + result.value.ToString();

            rtResults.Rtf = @"{\rtf1\ansi" + shots + "}";
            lbCurrentResult.Text = currentResult.shot.Sum(x => x.value).ToString();
            pbTarget.Refresh();
            Graphics graphics = pbTarget.CreateGraphics();
            for(int i = 0; i < currentResult.shot.Count;i++)
            {
                if (i == 0)
                    DrawShot(currentResult.shot.ElementAt(i), graphics, Brushes.Green);
                else if (i == currentResult.shot.Count - 1)
                    DrawShot(currentResult.shot.ElementAt(i), graphics, Brushes.Blue);
                else
                    DrawShot(currentResult.shot.ElementAt(i), graphics, Brushes.Red);
            }
            graphics.Dispose();
        }
    }
}
