namespace SVP
{
    partial class TabSettings
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnManageProfile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnApplayDisplaySetting = new System.Windows.Forms.Button();
            this.rbDisplayShotImage = new System.Windows.Forms.RadioButton();
            this.rbDisplayShotImageWithPoints = new System.Windows.Forms.RadioButton();
            this.rbDisplayEverythingAnonym = new System.Windows.Forms.RadioButton();
            this.rbDisplayEverything = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnApplyNews = new System.Windows.Forms.Button();
            this.txtNews = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnManageManualProfile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnManageProfile
            // 
            this.btnManageProfile.Location = new System.Drawing.Point(0, 3);
            this.btnManageProfile.Name = "btnManageProfile";
            this.btnManageProfile.Size = new System.Drawing.Size(116, 23);
            this.btnManageProfile.TabIndex = 0;
            this.btnManageProfile.Text = "Profile Verwalten";
            this.btnManageProfile.UseVisualStyleBackColor = true;
            this.btnManageProfile.Click += new System.EventHandler(this.btnManageProfile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnApplayDisplaySetting);
            this.groupBox1.Controls.Add(this.rbDisplayShotImage);
            this.groupBox1.Controls.Add(this.rbDisplayShotImageWithPoints);
            this.groupBox1.Controls.Add(this.rbDisplayEverythingAnonym);
            this.groupBox1.Controls.Add(this.rbDisplayEverything);
            this.groupBox1.Location = new System.Drawing.Point(3, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 149);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Schussanzeige";
            // 
            // btnApplayDisplaySetting
            // 
            this.btnApplayDisplaySetting.Enabled = false;
            this.btnApplayDisplaySetting.Location = new System.Drawing.Point(183, 120);
            this.btnApplayDisplaySetting.Name = "btnApplayDisplaySetting";
            this.btnApplayDisplaySetting.Size = new System.Drawing.Size(81, 23);
            this.btnApplayDisplaySetting.TabIndex = 4;
            this.btnApplayDisplaySetting.Text = "Übernehmen";
            this.btnApplayDisplaySetting.UseVisualStyleBackColor = true;
            this.btnApplayDisplaySetting.Click += new System.EventHandler(this.btnApplayDisplaySetting_Click);
            // 
            // rbDisplayShotImage
            // 
            this.rbDisplayShotImage.AutoSize = true;
            this.rbDisplayShotImage.Location = new System.Drawing.Point(6, 88);
            this.rbDisplayShotImage.Name = "rbDisplayShotImage";
            this.rbDisplayShotImage.Size = new System.Drawing.Size(142, 17);
            this.rbDisplayShotImage.TabIndex = 3;
            this.rbDisplayShotImage.Text = "Nur Schussbild anzeigen";
            this.rbDisplayShotImage.UseVisualStyleBackColor = true;
            this.rbDisplayShotImage.CheckedChanged += new System.EventHandler(this.rbDisplay_CheckedChanged);
            // 
            // rbDisplayShotImageWithPoints
            // 
            this.rbDisplayShotImageWithPoints.AutoSize = true;
            this.rbDisplayShotImageWithPoints.Location = new System.Drawing.Point(6, 65);
            this.rbDisplayShotImageWithPoints.Name = "rbDisplayShotImageWithPoints";
            this.rbDisplayShotImageWithPoints.Size = new System.Drawing.Size(237, 17);
            this.rbDisplayShotImageWithPoints.TabIndex = 2;
            this.rbDisplayShotImageWithPoints.Text = "Nur Schussbild und dessen Punkte anzeigen";
            this.rbDisplayShotImageWithPoints.UseVisualStyleBackColor = true;
            this.rbDisplayShotImageWithPoints.CheckedChanged += new System.EventHandler(this.rbDisplay_CheckedChanged);
            // 
            // rbDisplayEverythingAnonym
            // 
            this.rbDisplayEverythingAnonym.AutoSize = true;
            this.rbDisplayEverythingAnonym.Location = new System.Drawing.Point(6, 42);
            this.rbDisplayEverythingAnonym.Name = "rbDisplayEverythingAnonym";
            this.rbDisplayEverythingAnonym.Size = new System.Drawing.Size(133, 17);
            this.rbDisplayEverythingAnonym.TabIndex = 1;
            this.rbDisplayEverythingAnonym.Text = "Alles anonym anzeigen";
            this.rbDisplayEverythingAnonym.UseVisualStyleBackColor = true;
            this.rbDisplayEverythingAnonym.CheckedChanged += new System.EventHandler(this.rbDisplay_CheckedChanged);
            // 
            // rbDisplayEverything
            // 
            this.rbDisplayEverything.AutoSize = true;
            this.rbDisplayEverything.Checked = true;
            this.rbDisplayEverything.Location = new System.Drawing.Point(6, 19);
            this.rbDisplayEverything.Name = "rbDisplayEverything";
            this.rbDisplayEverything.Size = new System.Drawing.Size(93, 17);
            this.rbDisplayEverything.TabIndex = 0;
            this.rbDisplayEverything.TabStop = true;
            this.rbDisplayEverything.Text = "Alles anzeigen";
            this.rbDisplayEverything.UseVisualStyleBackColor = true;
            this.rbDisplayEverything.CheckedChanged += new System.EventHandler(this.rbDisplay_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnApplyNews);
            this.groupBox2.Controls.Add(this.txtNews);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(285, 32);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(278, 149);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Monitor Laufschrift";
            // 
            // btnApplyNews
            // 
            this.btnApplyNews.Location = new System.Drawing.Point(191, 120);
            this.btnApplyNews.Name = "btnApplyNews";
            this.btnApplyNews.Size = new System.Drawing.Size(81, 23);
            this.btnApplyNews.TabIndex = 5;
            this.btnApplyNews.Text = "Übernehmen";
            this.btnApplyNews.UseVisualStyleBackColor = true;
            this.btnApplyNews.Click += new System.EventHandler(this.btnApplyNews_Click);
            // 
            // txtNews
            // 
            this.txtNews.Location = new System.Drawing.Point(38, 17);
            this.txtNews.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNews.Name = "txtNews";
            this.txtNews.Size = new System.Drawing.Size(228, 20);
            this.txtNews.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text:";
            // 
            // btnManageManualProfile
            // 
            this.btnManageManualProfile.Location = new System.Drawing.Point(122, 3);
            this.btnManageManualProfile.Name = "btnManageManualProfile";
            this.btnManageManualProfile.Size = new System.Drawing.Size(145, 23);
            this.btnManageManualProfile.TabIndex = 3;
            this.btnManageManualProfile.Text = "Manuelle Profile Verwalten";
            this.btnManageManualProfile.UseVisualStyleBackColor = true;
            this.btnManageManualProfile.Click += new System.EventHandler(this.btnManageManualProfile_Click);
            // 
            // TabSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnManageManualProfile);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnManageProfile);
            this.Name = "TabSettings";
            this.Size = new System.Drawing.Size(828, 569);
            this.Load += new System.EventHandler(this.TabSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageProfile;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbDisplayShotImage;
		private System.Windows.Forms.RadioButton rbDisplayShotImageWithPoints;
		private System.Windows.Forms.RadioButton rbDisplayEverythingAnonym;
		private System.Windows.Forms.RadioButton rbDisplayEverything;
		private System.Windows.Forms.Button btnApplayDisplaySetting;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnApplyNews;
        private System.Windows.Forms.TextBox txtNews;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnManageManualProfile;
    }
}
