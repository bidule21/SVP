namespace SVP
{
    partial class frmManualProfileWizard
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
            this.gbProfile = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.numSge = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbProfile = new System.Windows.Forms.ComboBox();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rbEditProfile = new System.Windows.Forms.RadioButton();
            this.rbAddProfile = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.gbProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSge)).BeginInit();
            this.gbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProfile
            // 
            this.gbProfile.Controls.Add(this.btnSave);
            this.gbProfile.Controls.Add(this.numSge);
            this.gbProfile.Controls.Add(this.label16);
            this.gbProfile.Enabled = false;
            this.gbProfile.Location = new System.Drawing.Point(12, 159);
            this.gbProfile.Name = "gbProfile";
            this.gbProfile.Size = new System.Drawing.Size(502, 79);
            this.gbProfile.TabIndex = 0;
            this.gbProfile.TabStop = false;
            this.gbProfile.Text = "Profil";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(421, 46);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // numSge
            // 
            this.numSge.Location = new System.Drawing.Point(201, 14);
            this.numSge.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numSge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numSge.Name = "numSge";
            this.numSge.Size = new System.Drawing.Size(83, 20);
            this.numSge.TabIndex = 65;
            this.numSge.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 13);
            this.label16.TabIndex = 61;
            this.label16.Text = "Schußzahl Gesamt:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(433, 245);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Schließen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbProfile
            // 
            this.cbProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfile.FormattingEnabled = true;
            this.cbProfile.Location = new System.Drawing.Point(87, 44);
            this.cbProfile.Name = "cbProfile";
            this.cbProfile.Size = new System.Drawing.Size(268, 21);
            this.cbProfile.TabIndex = 29;
            // 
            // txtProfileName
            // 
            this.txtProfileName.Enabled = false;
            this.txtProfileName.Location = new System.Drawing.Point(87, 107);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Size = new System.Drawing.Size(268, 20);
            this.txtProfileName.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Profilname:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Profil:";
            // 
            // rbEditProfile
            // 
            this.rbEditProfile.AutoSize = true;
            this.rbEditProfile.Checked = true;
            this.rbEditProfile.Location = new System.Drawing.Point(6, 19);
            this.rbEditProfile.Name = "rbEditProfile";
            this.rbEditProfile.Size = new System.Drawing.Size(166, 17);
            this.rbEditProfile.TabIndex = 25;
            this.rbEditProfile.TabStop = true;
            this.rbEditProfile.Text = "Bestehendes Profil bearbeiten";
            this.rbEditProfile.UseVisualStyleBackColor = true;
            this.rbEditProfile.CheckedChanged += new System.EventHandler(this.rbProfile_CheckedChanged);
            // 
            // rbAddProfile
            // 
            this.rbAddProfile.AutoSize = true;
            this.rbAddProfile.Location = new System.Drawing.Point(6, 82);
            this.rbAddProfile.Name = "rbAddProfile";
            this.rbAddProfile.Size = new System.Drawing.Size(123, 17);
            this.rbAddProfile.TabIndex = 24;
            this.rbAddProfile.Text = "Neues Profil anlegen";
            this.rbAddProfile.UseVisualStyleBackColor = true;
            this.rbAddProfile.CheckedChanged += new System.EventHandler(this.rbProfile_CheckedChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(421, 105);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 30;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // gbMenu
            // 
            this.gbMenu.Controls.Add(this.rbEditProfile);
            this.gbMenu.Controls.Add(this.btnOk);
            this.gbMenu.Controls.Add(this.rbAddProfile);
            this.gbMenu.Controls.Add(this.cbProfile);
            this.gbMenu.Controls.Add(this.label7);
            this.gbMenu.Controls.Add(this.txtProfileName);
            this.gbMenu.Controls.Add(this.label8);
            this.gbMenu.Location = new System.Drawing.Point(12, 12);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(502, 141);
            this.gbMenu.TabIndex = 31;
            this.gbMenu.TabStop = false;
            this.gbMenu.Text = "Profil auswählen";
            // 
            // frmManualProfileWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 297);
            this.ControlBox = false;
            this.Controls.Add(this.gbMenu);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmManualProfileWizard";
            this.Text = "Profil bearbeiten";
            this.Load += new System.EventHandler(this.ProfileWizardNew_Load);
            this.gbProfile.ResumeLayout(false);
            this.gbProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSge)).EndInit();
            this.gbMenu.ResumeLayout(false);
            this.gbMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProfile;
        private System.Windows.Forms.NumericUpDown numSge;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbProfile;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbEditProfile;
        private System.Windows.Forms.RadioButton rbAddProfile;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.Label label16;
    }
}