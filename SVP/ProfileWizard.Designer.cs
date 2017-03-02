namespace SVP
{
    partial class ProfileWizard
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
            this.wizardControl1 = new AeroWizard.WizardControl();
            this.editProfilePage = new AeroWizard.WizardPage();
            this.cbSch = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDrt = new System.Windows.Forms.TextBox();
            this.cbRia = new System.Windows.Forms.ComboBox();
            this.cbTem = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbKsd = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.numSzi = new System.Windows.Forms.NumericUpDown();
            this.cbKal = new System.Windows.Forms.ComboBox();
            this.numSge = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.numSsc = new System.Windows.Forms.NumericUpDown();
            this.cbRib = new System.Windows.Forms.ComboBox();
            this.numTeg = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbTea = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.addProfilePage = new AeroWizard.WizardPage();
            this.cbProfile = new System.Windows.Forms.ComboBox();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rbEditProfile = new System.Windows.Forms.RadioButton();
            this.rbAddProfile = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.editProfilePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSzi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSsc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTeg)).BeginInit();
            this.addProfilePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // wizardControl1
            // 
            this.wizardControl1.BackColor = System.Drawing.Color.White;
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wizardControl1.Location = new System.Drawing.Point(0, 0);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.Pages.Add(this.addProfilePage);
            this.wizardControl1.Pages.Add(this.editProfilePage);
            this.wizardControl1.Size = new System.Drawing.Size(574, 415);
            this.wizardControl1.TabIndex = 0;
            this.wizardControl1.Title = "Schießstand Verwaltungs Programm";
            this.wizardControl1.SelectedPageChanged += new System.EventHandler(this.wizardControl1_SelectedPageChanged);
            // 
            // editProfilePage
            // 
            this.editProfilePage.Controls.Add(this.cbSch);
            this.editProfilePage.Controls.Add(this.label10);
            this.editProfilePage.Controls.Add(this.label9);
            this.editProfilePage.Controls.Add(this.txtDrt);
            this.editProfilePage.Controls.Add(this.cbRia);
            this.editProfilePage.Controls.Add(this.cbTem);
            this.editProfilePage.Controls.Add(this.label11);
            this.editProfilePage.Controls.Add(this.cbKsd);
            this.editProfilePage.Controls.Add(this.label12);
            this.editProfilePage.Controls.Add(this.numSzi);
            this.editProfilePage.Controls.Add(this.cbKal);
            this.editProfilePage.Controls.Add(this.numSge);
            this.editProfilePage.Controls.Add(this.label13);
            this.editProfilePage.Controls.Add(this.numSsc);
            this.editProfilePage.Controls.Add(this.cbRib);
            this.editProfilePage.Controls.Add(this.numTeg);
            this.editProfilePage.Controls.Add(this.label14);
            this.editProfilePage.Controls.Add(this.label15);
            this.editProfilePage.Controls.Add(this.cbTea);
            this.editProfilePage.Controls.Add(this.label16);
            this.editProfilePage.Controls.Add(this.label17);
            this.editProfilePage.Controls.Add(this.label18);
            this.editProfilePage.Name = "editProfilePage";
            this.editProfilePage.Size = new System.Drawing.Size(527, 261);
            this.editProfilePage.TabIndex = 4;
            this.editProfilePage.Text = "Profil bearbeiten";
            this.editProfilePage.Commit += new System.EventHandler<AeroWizard.WizardPageConfirmEventArgs>(this.editProfilePage_Commit);
            this.editProfilePage.Initialize += new System.EventHandler<AeroWizard.WizardPageInitEventArgs>(this.editProfilePage_Initialize);
            // 
            // cbSch
            // 
            this.cbSch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSch.FormattingEnabled = true;
            this.cbSch.Location = new System.Drawing.Point(102, 3);
            this.cbSch.Name = "cbSch";
            this.cbSch.Size = new System.Drawing.Size(179, 23);
            this.cbSch.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(298, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 15);
            this.label10.TabIndex = 48;
            this.label10.Text = "Zusätzlicher Text:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "Scheibentyp:";
            // 
            // txtDrt
            // 
            this.txtDrt.Location = new System.Drawing.Point(401, 3);
            this.txtDrt.MaxLength = 10;
            this.txtDrt.Name = "txtDrt";
            this.txtDrt.Size = new System.Drawing.Size(84, 23);
            this.txtDrt.TabIndex = 47;
            // 
            // cbRia
            // 
            this.cbRia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRia.FormattingEnabled = true;
            this.cbRia.Location = new System.Drawing.Point(102, 32);
            this.cbRia.Name = "cbRia";
            this.cbRia.Size = new System.Drawing.Size(179, 23);
            this.cbRia.TabIndex = 29;
            // 
            // cbTem
            // 
            this.cbTem.AutoSize = true;
            this.cbTem.Location = new System.Drawing.Point(301, 63);
            this.cbTem.Name = "cbTem";
            this.cbTem.Size = new System.Drawing.Size(215, 19);
            this.cbTem.TabIndex = 46;
            this.cbTem.Text = "Teiler auf der Scheibe nur markieren";
            this.cbTem.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 15);
            this.label11.TabIndex = 30;
            this.label11.Text = "Ringauswertung:";
            // 
            // cbKsd
            // 
            this.cbKsd.AutoSize = true;
            this.cbKsd.Checked = true;
            this.cbKsd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbKsd.Location = new System.Drawing.Point(301, 34);
            this.cbKsd.Name = "cbKsd";
            this.cbKsd.Size = new System.Drawing.Size(121, 19);
            this.cbKsd.TabIndex = 45;
            this.cbKsd.Text = "Scheibenaufdruck";
            this.cbKsd.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 15);
            this.label12.TabIndex = 31;
            this.label12.Text = "Kaliber:";
            // 
            // numSzi
            // 
            this.numSzi.Location = new System.Drawing.Point(198, 235);
            this.numSzi.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numSzi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numSzi.Name = "numSzi";
            this.numSzi.Size = new System.Drawing.Size(83, 23);
            this.numSzi.TabIndex = 44;
            this.numSzi.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // cbKal
            // 
            this.cbKal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKal.FormattingEnabled = true;
            this.cbKal.Location = new System.Drawing.Point(102, 61);
            this.cbKal.MaxDropDownItems = 22;
            this.cbKal.Name = "cbKal";
            this.cbKal.Size = new System.Drawing.Size(179, 23);
            this.cbKal.TabIndex = 32;
            // 
            // numSge
            // 
            this.numSge.Location = new System.Drawing.Point(198, 206);
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
            this.numSge.Size = new System.Drawing.Size(83, 23);
            this.numSge.TabIndex = 43;
            this.numSge.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 15);
            this.label13.TabIndex = 33;
            this.label13.Text = "Ringberechnung:";
            // 
            // numSsc
            // 
            this.numSsc.Location = new System.Drawing.Point(197, 177);
            this.numSsc.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numSsc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numSsc.Name = "numSsc";
            this.numSsc.Size = new System.Drawing.Size(83, 23);
            this.numSsc.TabIndex = 42;
            this.numSsc.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // cbRib
            // 
            this.cbRib.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRib.FormattingEnabled = true;
            this.cbRib.Location = new System.Drawing.Point(102, 90);
            this.cbRib.Name = "cbRib";
            this.cbRib.Size = new System.Drawing.Size(179, 23);
            this.cbRib.TabIndex = 34;
            // 
            // numTeg
            // 
            this.numTeg.Location = new System.Drawing.Point(198, 148);
            this.numTeg.Maximum = new decimal(new int[] {
            25000,
            0,
            0,
            0});
            this.numTeg.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numTeg.Name = "numTeg";
            this.numTeg.Size = new System.Drawing.Size(83, 23);
            this.numTeg.TabIndex = 41;
            this.numTeg.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 122);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 15);
            this.label14.TabIndex = 35;
            this.label14.Text = "Teilerauswertung:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 237);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(178, 15);
            this.label15.TabIndex = 40;
            this.label15.Text = "Schußzahl pro Zwischensumme:";
            // 
            // cbTea
            // 
            this.cbTea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTea.FormattingEnabled = true;
            this.cbTea.Location = new System.Drawing.Point(102, 119);
            this.cbTea.Name = "cbTea";
            this.cbTea.Size = new System.Drawing.Size(179, 23);
            this.cbTea.TabIndex = 36;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 208);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 15);
            this.label16.TabIndex = 39;
            this.label16.Text = "Schußzahl Gesamt:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 150);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 15);
            this.label17.TabIndex = 37;
            this.label17.Text = "Teilergrenze:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 179);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(129, 15);
            this.label18.TabIndex = 38;
            this.label18.Text = "Schußzahl pro Scheibe:";
            // 
            // addProfilePage
            // 
            this.addProfilePage.Controls.Add(this.cbProfile);
            this.addProfilePage.Controls.Add(this.txtProfileName);
            this.addProfilePage.Controls.Add(this.label8);
            this.addProfilePage.Controls.Add(this.label7);
            this.addProfilePage.Controls.Add(this.rbEditProfile);
            this.addProfilePage.Controls.Add(this.rbAddProfile);
            this.addProfilePage.Name = "addProfilePage";
            this.addProfilePage.Size = new System.Drawing.Size(527, 261);
            this.addProfilePage.TabIndex = 3;
            this.addProfilePage.Text = "Profile bearbeiten";
            this.addProfilePage.Commit += new System.EventHandler<AeroWizard.WizardPageConfirmEventArgs>(this.addProfilePage_Commit);
            this.addProfilePage.Initialize += new System.EventHandler<AeroWizard.WizardPageInitEventArgs>(this.addProfilePage_Initialize);
            // 
            // cbProfile
            // 
            this.cbProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfile.FormattingEnabled = true;
            this.cbProfile.Location = new System.Drawing.Point(84, 28);
            this.cbProfile.Name = "cbProfile";
            this.cbProfile.Size = new System.Drawing.Size(268, 23);
            this.cbProfile.TabIndex = 7;
            // 
            // txtProfileName
            // 
            this.txtProfileName.Enabled = false;
            this.txtProfileName.Location = new System.Drawing.Point(84, 91);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Size = new System.Drawing.Size(268, 23);
            this.txtProfileName.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Profilname:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Profil:";
            // 
            // rbEditProfile
            // 
            this.rbEditProfile.AutoSize = true;
            this.rbEditProfile.Checked = true;
            this.rbEditProfile.Location = new System.Drawing.Point(3, 3);
            this.rbEditProfile.Name = "rbEditProfile";
            this.rbEditProfile.Size = new System.Drawing.Size(181, 19);
            this.rbEditProfile.TabIndex = 3;
            this.rbEditProfile.TabStop = true;
            this.rbEditProfile.Text = "Bestehendes Profil bearbeiten";
            this.rbEditProfile.UseVisualStyleBackColor = true;
            this.rbEditProfile.CheckedChanged += new System.EventHandler(this.rbEditProfile_CheckedChanged);
            // 
            // rbAddProfile
            // 
            this.rbAddProfile.AutoSize = true;
            this.rbAddProfile.Location = new System.Drawing.Point(3, 66);
            this.rbAddProfile.Name = "rbAddProfile";
            this.rbAddProfile.Size = new System.Drawing.Size(134, 19);
            this.rbAddProfile.TabIndex = 2;
            this.rbAddProfile.Text = "Neues Profil anlegen";
            this.rbAddProfile.UseVisualStyleBackColor = true;
            this.rbAddProfile.CheckedChanged += new System.EventHandler(this.rbAddProfile_CheckedChanged);
            // 
            // ProfileWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 415);
            this.Controls.Add(this.wizardControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ProfileWizard";
            this.Load += new System.EventHandler(this.MainWizard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.editProfilePage.ResumeLayout(false);
            this.editProfilePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSzi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSsc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTeg)).EndInit();
            this.addProfilePage.ResumeLayout(false);
            this.addProfilePage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AeroWizard.WizardControl wizardControl1;
        private AeroWizard.WizardPage addProfilePage;
        private System.Windows.Forms.RadioButton rbAddProfile;
        private System.Windows.Forms.ComboBox cbProfile;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbEditProfile;
        private AeroWizard.WizardPage editProfilePage;
        private System.Windows.Forms.ComboBox cbSch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDrt;
        private System.Windows.Forms.ComboBox cbRia;
        private System.Windows.Forms.CheckBox cbTem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cbKsd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numSzi;
        private System.Windows.Forms.ComboBox cbKal;
        private System.Windows.Forms.NumericUpDown numSge;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numSsc;
        private System.Windows.Forms.ComboBox cbRib;
        private System.Windows.Forms.NumericUpDown numTeg;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbTea;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}