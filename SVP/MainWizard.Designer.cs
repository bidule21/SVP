namespace SVP
{
    partial class MainWizard
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
            this.startPage = new AeroWizard.WizardPage();
            this.rbManageProfile = new System.Windows.Forms.RadioButton();
            this.addClub = new System.Windows.Forms.RadioButton();
            this.addMember = new System.Windows.Forms.RadioButton();
            this.continueCompetition = new System.Windows.Forms.RadioButton();
            this.startCompetition = new System.Windows.Forms.RadioButton();
            this.startTempTraining = new System.Windows.Forms.RadioButton();
            this.startTraining = new System.Windows.Forms.RadioButton();
            this.addMemberPage = new AeroWizard.WizardPage();
            this.txtMemberShortName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtMemberBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtMemberFirstname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMemberClub = new System.Windows.Forms.ComboBox();
            this.addClubPage = new AeroWizard.WizardPage();
            this.cbClubTemporary = new System.Windows.Forms.CheckBox();
            this.txtClubName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addProfilePage = new AeroWizard.WizardPage();
            this.cbProfile = new System.Windows.Forms.ComboBox();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rbEditProfile = new System.Windows.Forms.RadioButton();
            this.rbAddProfile = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.startPage.SuspendLayout();
            this.addMemberPage.SuspendLayout();
            this.addClubPage.SuspendLayout();
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
            this.wizardControl1.Pages.Add(this.startPage);
            this.wizardControl1.Pages.Add(this.addMemberPage);
            this.wizardControl1.Pages.Add(this.addClubPage);
            this.wizardControl1.Pages.Add(this.addProfilePage);
            this.wizardControl1.Size = new System.Drawing.Size(574, 415);
            this.wizardControl1.TabIndex = 0;
            this.wizardControl1.Title = "Schießstand Verwaltungs Programm";
            this.wizardControl1.SelectedPageChanged += new System.EventHandler(this.wizardControl1_SelectedPageChanged);
            // 
            // startPage
            // 
            this.startPage.Controls.Add(this.rbManageProfile);
            this.startPage.Controls.Add(this.addClub);
            this.startPage.Controls.Add(this.addMember);
            this.startPage.Controls.Add(this.continueCompetition);
            this.startPage.Controls.Add(this.startCompetition);
            this.startPage.Controls.Add(this.startTempTraining);
            this.startPage.Controls.Add(this.startTraining);
            this.startPage.Name = "startPage";
            this.startPage.Size = new System.Drawing.Size(527, 261);
            this.startPage.TabIndex = 0;
            this.startPage.Text = "Was möchtest du tun?";
            this.startPage.Commit += new System.EventHandler<AeroWizard.WizardPageConfirmEventArgs>(this.startPage_Commit);
            // 
            // rbManageProfile
            // 
            this.rbManageProfile.AutoSize = true;
            this.rbManageProfile.Location = new System.Drawing.Point(3, 179);
            this.rbManageProfile.Name = "rbManageProfile";
            this.rbManageProfile.Size = new System.Drawing.Size(148, 19);
            this.rbManageProfile.TabIndex = 6;
            this.rbManageProfile.TabStop = true;
            this.rbManageProfile.Text = "Schießprofile verwalten";
            this.rbManageProfile.UseVisualStyleBackColor = true;
            // 
            // addClub
            // 
            this.addClub.AutoSize = true;
            this.addClub.Location = new System.Drawing.Point(3, 154);
            this.addClub.Name = "addClub";
            this.addClub.Size = new System.Drawing.Size(227, 19);
            this.addClub.TabIndex = 5;
            this.addClub.TabStop = true;
            this.addClub.Text = "Einen Verein / eine Gruppe hinzufügen";
            this.addClub.UseVisualStyleBackColor = true;
            // 
            // addMember
            // 
            this.addMember.AutoSize = true;
            this.addMember.Location = new System.Drawing.Point(3, 129);
            this.addMember.Name = "addMember";
            this.addMember.Size = new System.Drawing.Size(249, 19);
            this.addMember.TabIndex = 4;
            this.addMember.TabStop = true;
            this.addMember.Text = "Einen Schützen / eine Schützin hinzufügen";
            this.addMember.UseVisualStyleBackColor = true;
            // 
            // continueCompetition
            // 
            this.continueCompetition.AutoSize = true;
            this.continueCompetition.Enabled = false;
            this.continueCompetition.Location = new System.Drawing.Point(3, 104);
            this.continueCompetition.Name = "continueCompetition";
            this.continueCompetition.Size = new System.Drawing.Size(177, 19);
            this.continueCompetition.TabIndex = 3;
            this.continueCompetition.Text = "Ein Pokalschießen fortführen";
            this.continueCompetition.UseVisualStyleBackColor = true;
            // 
            // startCompetition
            // 
            this.startCompetition.AutoSize = true;
            this.startCompetition.Enabled = false;
            this.startCompetition.Location = new System.Drawing.Point(3, 79);
            this.startCompetition.Name = "startCompetition";
            this.startCompetition.Size = new System.Drawing.Size(189, 19);
            this.startCompetition.TabIndex = 2;
            this.startCompetition.Text = "Ein Pokalschießen durchführen";
            this.startCompetition.UseVisualStyleBackColor = true;
            // 
            // startTempTraining
            // 
            this.startTempTraining.AutoSize = true;
            this.startTempTraining.Enabled = false;
            this.startTempTraining.Location = new System.Drawing.Point(3, 54);
            this.startTempTraining.Name = "startTempTraining";
            this.startTempTraining.Size = new System.Drawing.Size(271, 19);
            this.startTempTraining.TabIndex = 1;
            this.startTempTraining.Text = "Ein temporäres Trainingsschießen durchführen";
            this.startTempTraining.UseVisualStyleBackColor = true;
            // 
            // startTraining
            // 
            this.startTraining.AutoSize = true;
            this.startTraining.Checked = true;
            this.startTraining.Location = new System.Drawing.Point(3, 29);
            this.startTraining.Name = "startTraining";
            this.startTraining.Size = new System.Drawing.Size(208, 19);
            this.startTraining.TabIndex = 0;
            this.startTraining.TabStop = true;
            this.startTraining.Text = "Ein Trainingsschießen durchführen";
            this.startTraining.UseVisualStyleBackColor = true;
            // 
            // addMemberPage
            // 
            this.addMemberPage.Controls.Add(this.txtMemberShortName);
            this.addMemberPage.Controls.Add(this.label6);
            this.addMemberPage.Controls.Add(this.dtMemberBirthday);
            this.addMemberPage.Controls.Add(this.txtMemberName);
            this.addMemberPage.Controls.Add(this.txtMemberFirstname);
            this.addMemberPage.Controls.Add(this.label4);
            this.addMemberPage.Controls.Add(this.label3);
            this.addMemberPage.Controls.Add(this.label2);
            this.addMemberPage.Controls.Add(this.label1);
            this.addMemberPage.Controls.Add(this.cbMemberClub);
            this.addMemberPage.Name = "addMemberPage";
            this.addMemberPage.Size = new System.Drawing.Size(527, 261);
            this.addMemberPage.TabIndex = 1;
            this.addMemberPage.Text = "Mitglied hinzufügen";
            this.addMemberPage.Commit += new System.EventHandler<AeroWizard.WizardPageConfirmEventArgs>(this.addMemberPage_Commit);
            this.addMemberPage.Initialize += new System.EventHandler<AeroWizard.WizardPageInitEventArgs>(this.addMemberPage_Initialize);
            // 
            // txtMemberShortName
            // 
            this.txtMemberShortName.Location = new System.Drawing.Point(180, 185);
            this.txtMemberShortName.Name = "txtMemberShortName";
            this.txtMemberShortName.Size = new System.Drawing.Size(100, 23);
            this.txtMemberShortName.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "label6";
            // 
            // dtMemberBirthday
            // 
            this.dtMemberBirthday.Location = new System.Drawing.Point(101, 102);
            this.dtMemberBirthday.Name = "dtMemberBirthday";
            this.dtMemberBirthday.Size = new System.Drawing.Size(228, 23);
            this.dtMemberBirthday.TabIndex = 7;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(101, 73);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(228, 23);
            this.txtMemberName.TabIndex = 6;
            // 
            // txtMemberFirstname
            // 
            this.txtMemberFirstname.Location = new System.Drawing.Point(101, 44);
            this.txtMemberFirstname.Name = "txtMemberFirstname";
            this.txtMemberFirstname.Size = new System.Drawing.Size(228, 23);
            this.txtMemberFirstname.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Geburtsdatum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vorname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Verein / Gruppe:";
            // 
            // cbMemberClub
            // 
            this.cbMemberClub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMemberClub.FormattingEnabled = true;
            this.cbMemberClub.Location = new System.Drawing.Point(101, 15);
            this.cbMemberClub.Name = "cbMemberClub";
            this.cbMemberClub.Size = new System.Drawing.Size(228, 23);
            this.cbMemberClub.TabIndex = 0;
            // 
            // addClubPage
            // 
            this.addClubPage.Controls.Add(this.cbClubTemporary);
            this.addClubPage.Controls.Add(this.txtClubName);
            this.addClubPage.Controls.Add(this.label5);
            this.addClubPage.Name = "addClubPage";
            this.addClubPage.Size = new System.Drawing.Size(527, 261);
            this.addClubPage.TabIndex = 2;
            this.addClubPage.Text = "Verein oder Gruppe hinzufügen";
            this.addClubPage.Commit += new System.EventHandler<AeroWizard.WizardPageConfirmEventArgs>(this.addClubPage_Commit);
            // 
            // cbClubTemporary
            // 
            this.cbClubTemporary.AutoSize = true;
            this.cbClubTemporary.Location = new System.Drawing.Point(6, 37);
            this.cbClubTemporary.Name = "cbClubTemporary";
            this.cbClubTemporary.Size = new System.Drawing.Size(177, 19);
            this.cbClubTemporary.TabIndex = 2;
            this.cbClubTemporary.Text = "Temporäre/r Gruppe / Verein";
            this.cbClubTemporary.UseVisualStyleBackColor = true;
            // 
            // txtClubName
            // 
            this.txtClubName.Location = new System.Drawing.Point(54, 8);
            this.txtClubName.Name = "txtClubName";
            this.txtClubName.Size = new System.Drawing.Size(184, 23);
            this.txtClubName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name: ";
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
            // MainWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 415);
            this.Controls.Add(this.wizardControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainWizard";
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.startPage.ResumeLayout(false);
            this.startPage.PerformLayout();
            this.addMemberPage.ResumeLayout(false);
            this.addMemberPage.PerformLayout();
            this.addClubPage.ResumeLayout(false);
            this.addClubPage.PerformLayout();
            this.addProfilePage.ResumeLayout(false);
            this.addProfilePage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AeroWizard.WizardControl wizardControl1;
        private AeroWizard.WizardPage startPage;
        private System.Windows.Forms.RadioButton addClub;
        private System.Windows.Forms.RadioButton addMember;
        private System.Windows.Forms.RadioButton continueCompetition;
        private System.Windows.Forms.RadioButton startCompetition;
        private System.Windows.Forms.RadioButton startTempTraining;
        private System.Windows.Forms.RadioButton startTraining;
        private AeroWizard.WizardPage addMemberPage;
        private System.Windows.Forms.DateTimePicker dtMemberBirthday;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtMemberFirstname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMemberClub;
        private AeroWizard.WizardPage addClubPage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbClubTemporary;
        private System.Windows.Forms.TextBox txtClubName;
        private System.Windows.Forms.TextBox txtMemberShortName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbManageProfile;
        private AeroWizard.WizardPage addProfilePage;
        private System.Windows.Forms.RadioButton rbAddProfile;
        private System.Windows.Forms.ComboBox cbProfile;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbEditProfile;
    }
}