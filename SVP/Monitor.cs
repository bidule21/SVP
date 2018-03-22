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
	public enum DisplaySetting
	{
		Everything,
		EverythingAnonym,
		ShotImageWithPoints,
		ShotImage
	}
    public partial class Monitor : Form
    {
        private static Monitor MyMonitor;
        private Sequence currentResult;
        private int currentShot = 0;
        private Timer timer;
		private List<Sequence> sequenceList;
        private Queue<Sequence> sequencesToDisplay;
		public DisplaySetting DisplaySetting { get; private set; }

		public static Monitor GetMonitor()
        {
            if (MyMonitor == null)
                MyMonitor = new Monitor();
            return MyMonitor;
        }

		public void SetDisplaySetting(DisplaySetting setting)
		{
            this.DisplaySetting = setting;
            if (setting != DisplaySetting.Everything)
			{
				lbCurrentResult.Text = "";
				rtResults.Text = "";
				lbResults.Text = "";
				dgResultList.Rows.Clear();
			}
            dgResultList.Rows.Clear();
            using (SVPEntitiesContainer context = new SVPEntitiesContainer())
            {
                foreach (Sequence result in sequenceList)
                {
                    Sequence seq = context.Sequences.Find(result.Id);
                    switch (DisplaySetting)
                    {
                        case DisplaySetting.Everything:
                                dgResultList.Rows.Add(seq.Member.ToString(), seq.Shots.Sum(x => x.Value).ToString(), seq.Profile);
                            break;
                        case DisplaySetting.EverythingAnonym:
                            dgResultList.Rows.Add(SVP.Properties.Settings.Default.DefaultName, seq.Shots.Sum(x => x.Value).ToString(), seq.Profile);
                            break;
                    }
                }
            }
		}

        private Monitor()
        {
            InitializeComponent();
			sequenceList = new List<Sequence>();
            sequencesToDisplay = new Queue<Sequence>();
            DisplaySetting = DisplaySetting.Everything;
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
                if (currentShot == currentResult.Shots.Count)
                {
                    DisplayAllShots();
                    currentShot = 0;
                    if (sequencesToDisplay.Count > 0)
                        currentResult = sequencesToDisplay.Dequeue();
                    else
                        currentResult = null;
                }
                else
                {
                    DisplayShot(currentResult.Shots.ElementAt(currentShot));
                    currentShot++;
                }
            }
        }

        internal void AddSequence(Sequence result)
        {
			sequenceList.Add(result);
			if (DisplaySetting == DisplaySetting.Everything || DisplaySetting == DisplaySetting.EverythingAnonym)
			{
                string name = (this.DisplaySetting == DisplaySetting.Everything) ? result.Member.ToString() : SVP.Properties.Settings.Default.DefaultName;
				dgResultList.Rows.Add(name, result.Shots.Sum(x => x.Value).ToString(), result.Profile);
				dgResultList.FirstDisplayedScrollingRowIndex = dgResultList.RowCount - 1;
			}
            sequencesToDisplay.Enqueue(result);
            if (currentResult == null && sequencesToDisplay.Count > 0)
                currentResult = sequencesToDisplay.Dequeue();
        }
        
        internal void DisplaySequence(Sequence result)
        {
            this.currentResult = result;
            currentShot = 0;
            lbResults.Text = (this.DisplaySetting == DisplaySetting.Everything) ? result.Member.ToString() : SVP.Properties.Settings.Default.DefaultName;
        }
        
        private void DrawShot(Shot shot, Graphics graphics, Brush brush)
        {
            int size = (int)(pbTarget.Width / 11.5);
            int x = pbTarget.Width / 2;
            int y = pbTarget.Width / 2;
            double factor = (shot.FactorValue/ 2300) * (pbTarget.Width / 2);
            double angle = shot.Angle * (Math.PI / 180);
            angle += (1.5 * Math.PI);
            x += (int)(Math.Cos(angle) * factor);
            y += (int)(Math.Sin(angle) * factor);
            graphics.FillEllipse(brush, x - (size / 2), y - (size / 2), size, size);
        }
        
        private void DisplayShot(Shot shot)
        {
            if (shot.Valid == false)
                return;
            string shots = "";
            foreach(Shot result in currentResult.Shots)
            {
                string value = result.Valid ? result.Value.ToString() : "X";
                if(result == shot)
                {
                    shots += "     " + @"\cf1 " + value;
                }
                else
                {
                    shots += "     \\cf0 " + value;
                }
            }
			if (DisplaySetting != DisplaySetting.ShotImage)
			{
				rtResults.Rtf = @"{\rtf1\ansi {\colortbl; \red255\green0\blue0;}" + shots + "}";
                if (shot.Valid)
                    lbCurrentResult.Text = shot.Value.ToString();
                else
                    lbCurrentResult.Text = "X";
			}
            pbTarget.Refresh();
            Graphics graphics = pbTarget.CreateGraphics();
            if (shot.Valid)
                DrawShot(shot, graphics, Brushes.Red);
            graphics.Dispose();
        }
        private void DisplayAllShots()
        {
            string shots = "";
            foreach (Shot result in currentResult.Shots)
                shots += "     " + result.Value.ToString();
        
			if (DisplaySetting != DisplaySetting.ShotImage)
			{
				rtResults.Rtf = @"{\rtf1\ansi" + shots + "}";
				lbCurrentResult.Text = currentResult.Shots.Sum(x => x.Value).ToString();
			}
            pbTarget.Refresh();
            Graphics graphics = pbTarget.CreateGraphics();
            for(int i = 0; i < currentResult.Shots.Count;i++)
            {
                if (currentResult.Shots.ElementAt(i).Valid == false)
                    continue;
                if (i == 0)
                    DrawShot(currentResult.Shots.ElementAt(i), graphics, Brushes.Green);
                else if (i == currentResult.Shots.Count - 1)
                    DrawShot(currentResult.Shots.ElementAt(i), graphics, Brushes.Blue);
                else
                    DrawShot(currentResult.Shots.ElementAt(i), graphics, Brushes.Red);
            }
            graphics.Dispose();
        }
    }
}
