using System;

namespace SVP
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpTraining = new System.Windows.Forms.TabPage();
            this.tpCompetition = new System.Windows.Forms.TabPage();
            this.tpShowCompetitions = new System.Windows.Forms.TabPage();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpTraining);
            this.tabControl1.Controls.Add(this.tpCompetition);
            this.tabControl1.Controls.Add(this.tpShowCompetitions);
            this.tabControl1.Controls.Add(this.tpSettings);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(836, 595);
            this.tabControl1.TabIndex = 0;
            // 
            // tpTraining
            // 
            this.tpTraining.Controls.Add(new TabTraining());
            this.tpTraining.Location = new System.Drawing.Point(4, 22);
            this.tpTraining.Name = "tpTraining";
            this.tpTraining.Padding = new System.Windows.Forms.Padding(3);
            this.tpTraining.Size = new System.Drawing.Size(828, 569);
            this.tpTraining.TabIndex = 0;
            this.tpTraining.Text = "Trainingsschießen";
            this.tpTraining.UseVisualStyleBackColor = true;
            // 
            // tpCompetition
            // 
            this.tpCompetition.Controls.Add(new TabCompetition());
            this.tpCompetition.Location = new System.Drawing.Point(4, 22);
            this.tpCompetition.Name = "tpCompetition";
            this.tpCompetition.Padding = new System.Windows.Forms.Padding(3);
            this.tpCompetition.Size = new System.Drawing.Size(828, 569);
            this.tpCompetition.TabIndex = 1;
            this.tpCompetition.Text = "Pokalschießen";
            this.tpCompetition.UseVisualStyleBackColor = true;
            // 
            // tpCompetition
            // 
            this.tpShowCompetitions.Controls.Add(new TabShowCompetition());
            this.tpShowCompetitions.Location = new System.Drawing.Point(4, 22);
            this.tpShowCompetitions.Name = "tpShowCompetitions";
            this.tpShowCompetitions.Padding = new System.Windows.Forms.Padding(3);
            this.tpShowCompetitions.Size = new System.Drawing.Size(828, 569);
            this.tpShowCompetitions.TabIndex = 1;
            this.tpShowCompetitions.Text = "Vergangene Pokalschießen";
            this.tpShowCompetitions.UseVisualStyleBackColor = true;
            // 
            // tpSettings
            // 
            this.tpSettings.Controls.Add(new TabSettings());
            this.tpSettings.Location = new System.Drawing.Point(4, 22);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettings.Size = new System.Drawing.Size(828, 569);
            this.tpSettings.TabIndex = 2;
            this.tpSettings.Text = "Einstellungen";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 595);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "SVP Testing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpTraining;
        private System.Windows.Forms.TabPage tpCompetition;
        private System.Windows.Forms.TabPage tpShowCompetitions;
        private System.Windows.Forms.TabPage tpSettings;
    }
}