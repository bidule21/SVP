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
			this.rbDisplayShotImage = new System.Windows.Forms.RadioButton();
			this.rbDisplayShotImageWithPoints = new System.Windows.Forms.RadioButton();
			this.rbDisplayEverythingAnonym = new System.Windows.Forms.RadioButton();
			this.rbDisplayEverything = new System.Windows.Forms.RadioButton();
			this.btnApplayDisplaySetting = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
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
			this.groupBox1.Text = "Monitor Einstellungen";
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
			// TabSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnManageProfile);
			this.Name = "TabSettings";
			this.Size = new System.Drawing.Size(844, 477);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
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
	}
}
