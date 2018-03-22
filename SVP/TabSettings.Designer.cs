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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNews = new System.Windows.Forms.TextBox();
            this.btnApplyNews = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnManageProfile
            // 
            this.btnManageProfile.Location = new System.Drawing.Point(0, 4);
            this.btnManageProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnManageProfile.Name = "btnManageProfile";
            this.btnManageProfile.Size = new System.Drawing.Size(155, 28);
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
            this.groupBox1.Location = new System.Drawing.Point(4, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(360, 183);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Schussanzeige";
            // 
            // btnApplayDisplaySetting
            // 
            this.btnApplayDisplaySetting.Enabled = false;
            this.btnApplayDisplaySetting.Location = new System.Drawing.Point(244, 148);
            this.btnApplayDisplaySetting.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnApplayDisplaySetting.Name = "btnApplayDisplaySetting";
            this.btnApplayDisplaySetting.Size = new System.Drawing.Size(108, 28);
            this.btnApplayDisplaySetting.TabIndex = 4;
            this.btnApplayDisplaySetting.Text = "Übernehmen";
            this.btnApplayDisplaySetting.UseVisualStyleBackColor = true;
            this.btnApplayDisplaySetting.Click += new System.EventHandler(this.btnApplayDisplaySetting_Click);
            // 
            // rbDisplayShotImage
            // 
            this.rbDisplayShotImage.AutoSize = true;
            this.rbDisplayShotImage.Location = new System.Drawing.Point(8, 108);
            this.rbDisplayShotImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbDisplayShotImage.Name = "rbDisplayShotImage";
            this.rbDisplayShotImage.Size = new System.Drawing.Size(186, 21);
            this.rbDisplayShotImage.TabIndex = 3;
            this.rbDisplayShotImage.Text = "Nur Schussbild anzeigen";
            this.rbDisplayShotImage.UseVisualStyleBackColor = true;
            this.rbDisplayShotImage.CheckedChanged += new System.EventHandler(this.rbDisplay_CheckedChanged);
            // 
            // rbDisplayShotImageWithPoints
            // 
            this.rbDisplayShotImageWithPoints.AutoSize = true;
            this.rbDisplayShotImageWithPoints.Location = new System.Drawing.Point(8, 80);
            this.rbDisplayShotImageWithPoints.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbDisplayShotImageWithPoints.Name = "rbDisplayShotImageWithPoints";
            this.rbDisplayShotImageWithPoints.Size = new System.Drawing.Size(312, 21);
            this.rbDisplayShotImageWithPoints.TabIndex = 2;
            this.rbDisplayShotImageWithPoints.Text = "Nur Schussbild und dessen Punkte anzeigen";
            this.rbDisplayShotImageWithPoints.UseVisualStyleBackColor = true;
            this.rbDisplayShotImageWithPoints.CheckedChanged += new System.EventHandler(this.rbDisplay_CheckedChanged);
            // 
            // rbDisplayEverythingAnonym
            // 
            this.rbDisplayEverythingAnonym.AutoSize = true;
            this.rbDisplayEverythingAnonym.Location = new System.Drawing.Point(8, 52);
            this.rbDisplayEverythingAnonym.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbDisplayEverythingAnonym.Name = "rbDisplayEverythingAnonym";
            this.rbDisplayEverythingAnonym.Size = new System.Drawing.Size(175, 21);
            this.rbDisplayEverythingAnonym.TabIndex = 1;
            this.rbDisplayEverythingAnonym.Text = "Alles anonym anzeigen";
            this.rbDisplayEverythingAnonym.UseVisualStyleBackColor = true;
            this.rbDisplayEverythingAnonym.CheckedChanged += new System.EventHandler(this.rbDisplay_CheckedChanged);
            // 
            // rbDisplayEverything
            // 
            this.rbDisplayEverything.AutoSize = true;
            this.rbDisplayEverything.Checked = true;
            this.rbDisplayEverything.Location = new System.Drawing.Point(8, 23);
            this.rbDisplayEverything.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbDisplayEverything.Name = "rbDisplayEverything";
            this.rbDisplayEverything.Size = new System.Drawing.Size(121, 21);
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
            this.groupBox2.Location = new System.Drawing.Point(380, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 183);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Monitor Laufschrift";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text:";
            // 
            // txtNews
            // 
            this.txtNews.Location = new System.Drawing.Point(51, 21);
            this.txtNews.Name = "txtNews";
            this.txtNews.Size = new System.Drawing.Size(303, 22);
            this.txtNews.TabIndex = 1;
            // 
            // btnApplyNews
            // 
            this.btnApplyNews.Location = new System.Drawing.Point(255, 148);
            this.btnApplyNews.Margin = new System.Windows.Forms.Padding(4);
            this.btnApplyNews.Name = "btnApplyNews";
            this.btnApplyNews.Size = new System.Drawing.Size(108, 28);
            this.btnApplyNews.TabIndex = 5;
            this.btnApplyNews.Text = "Übernehmen";
            this.btnApplyNews.UseVisualStyleBackColor = true;
            this.btnApplyNews.Click += new System.EventHandler(this.btnApplyNews_Click);
            // 
            // TabSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnManageProfile);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TabSettings";
            this.Size = new System.Drawing.Size(1104, 700);
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
    }
}
