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
            this.startTrainingPage = new AeroWizard.WizardPage();
            this.label19 = new System.Windows.Forms.Label();
            this.cbTrainingProfile = new System.Windows.Forms.ComboBox();
            this.cbTrainingShowNames = new System.Windows.Forms.CheckBox();
            this.TrainingPage = new AeroWizard.WizardPage();
            this.cbTrainingClub = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rbTrainingContinue = new System.Windows.Forms.RadioButton();
            this.btnTrainingRead = new System.Windows.Forms.Button();
            this.cbTrainingMember = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.startPage.SuspendLayout();
            this.addMemberPage.SuspendLayout();
            this.addClubPage.SuspendLayout();
            this.addProfilePage.SuspendLayout();
            this.editProfilePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSzi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSsc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTeg)).BeginInit();
            this.startTrainingPage.SuspendLayout();
            this.TrainingPage.SuspendLayout();
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
            this.wizardControl1.Pages.Add(this.editProfilePage);
            this.wizardControl1.Pages.Add(this.startTrainingPage);
            this.wizardControl1.Pages.Add(this.TrainingPage);
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
            // startTrainingPage
            // 
            this.startTrainingPage.Controls.Add(this.label19);
            this.startTrainingPage.Controls.Add(this.cbTrainingProfile);
            this.startTrainingPage.Controls.Add(this.cbTrainingShowNames);
            this.startTrainingPage.Name = "startTrainingPage";
            this.startTrainingPage.Size = new System.Drawing.Size(527, 261);
            this.startTrainingPage.TabIndex = 5;
            this.startTrainingPage.Text = "Training starten";
            this.startTrainingPage.Commit += new System.EventHandler<AeroWizard.WizardPageConfirmEventArgs>(this.startTrainingPage_Commit);
            this.startTrainingPage.Initialize += new System.EventHandler<AeroWizard.WizardPageInitEventArgs>(this.startTrainingPage_Initialize);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 6);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(123, 15);
            this.label19.TabIndex = 2;
            this.label19.Text = "Standard Schießprofil:";
            // 
            // cbTrainingProfile
            // 
            this.cbTrainingProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrainingProfile.FormattingEnabled = true;
            this.cbTrainingProfile.Location = new System.Drawing.Point(132, 3);
            this.cbTrainingProfile.Name = "cbTrainingProfile";
            this.cbTrainingProfile.Size = new System.Drawing.Size(121, 23);
            this.cbTrainingProfile.TabIndex = 1;
            // 
            // cbTrainingShowNames
            // 
            this.cbTrainingShowNames.AutoSize = true;
            this.cbTrainingShowNames.Location = new System.Drawing.Point(3, 32);
            this.cbTrainingShowNames.Name = "cbTrainingShowNames";
            this.cbTrainingShowNames.Size = new System.Drawing.Size(181, 19);
            this.cbTrainingShowNames.TabIndex = 0;
            this.cbTrainingShowNames.Text = "Namen auf Monitor anzeigen";
            this.cbTrainingShowNames.UseVisualStyleBackColor = true;
            // 
            // TrainingPage
            // 
            this.TrainingPage.Controls.Add(this.cbTrainingClub);
            this.TrainingPage.Controls.Add(this.label22);
            this.TrainingPage.Controls.Add(this.lbResult);
            this.TrainingPage.Controls.Add(this.label20);
            this.TrainingPage.Controls.Add(this.radioButton2);
            this.TrainingPage.Controls.Add(this.rbTrainingContinue);
            this.TrainingPage.Controls.Add(this.btnTrainingRead);
            this.TrainingPage.Controls.Add(this.cbTrainingMember);
            this.TrainingPage.Name = "TrainingPage";
            this.TrainingPage.Size = new System.Drawing.Size(527, 261);
            this.TrainingPage.TabIndex = 6;
            this.TrainingPage.Text = "Training";
            this.TrainingPage.Initialize += new System.EventHandler<AeroWizard.WizardPageInitEventArgs>(this.TrainingPage_Initialize);
            // 
            // cbTrainingClub
            // 
            this.cbTrainingClub.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTrainingClub.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTrainingClub.FormattingEnabled = true;
            this.cbTrainingClub.Location = new System.Drawing.Point(116, 9);
            this.cbTrainingClub.Name = "cbTrainingClub";
            this.cbTrainingClub.Size = new System.Drawing.Size(121, 23);
            this.cbTrainingClub.TabIndex = 0;
            this.cbTrainingClub.SelectedIndexChanged += new System.EventHandler(this.cbTrainingClub_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 12);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(42, 15);
            this.label22.TabIndex = 6;
            this.label22.Text = "Verein:";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(241, 76);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 45);
            this.lbResult.TabIndex = 5;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 41);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(107, 15);
            this.label20.TabIndex = 4;
            this.label20.Text = "Schütze / Schützin:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 199);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(117, 19);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "Training beenden";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rbTrainingContinue
            // 
            this.rbTrainingContinue.AutoSize = true;
            this.rbTrainingContinue.Checked = true;
            this.rbTrainingContinue.Location = new System.Drawing.Point(6, 173);
            this.rbTrainingContinue.Name = "rbTrainingContinue";
            this.rbTrainingContinue.Size = new System.Drawing.Size(123, 19);
            this.rbTrainingContinue.TabIndex = 2;
            this.rbTrainingContinue.TabStop = true;
            this.rbTrainingContinue.Text = "Training fortsetzen";
            this.rbTrainingContinue.UseVisualStyleBackColor = true;
            // 
            // btnTrainingRead
            // 
            this.btnTrainingRead.Location = new System.Drawing.Point(6, 67);
            this.btnTrainingRead.Name = "btnTrainingRead";
            this.btnTrainingRead.Size = new System.Drawing.Size(229, 63);
            this.btnTrainingRead.TabIndex = 2;
            this.btnTrainingRead.Text = "Einlesen";
            this.btnTrainingRead.UseVisualStyleBackColor = true;
            this.btnTrainingRead.Click += new System.EventHandler(this.btnTrainingRead_Click);
            // 
            // cbTrainingMember
            // 
            this.cbTrainingMember.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTrainingMember.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTrainingMember.FormattingEnabled = true;
            this.cbTrainingMember.Location = new System.Drawing.Point(116, 38);
            this.cbTrainingMember.Name = "cbTrainingMember";
            this.cbTrainingMember.Size = new System.Drawing.Size(121, 23);
            this.cbTrainingMember.TabIndex = 1;
            // 
            // MainWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 415);
            this.Controls.Add(this.wizardControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainWizard";
            this.Load += new System.EventHandler(this.MainWizard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.startPage.ResumeLayout(false);
            this.startPage.PerformLayout();
            this.addMemberPage.ResumeLayout(false);
            this.addMemberPage.PerformLayout();
            this.addClubPage.ResumeLayout(false);
            this.addClubPage.PerformLayout();
            this.addProfilePage.ResumeLayout(false);
            this.addProfilePage.PerformLayout();
            this.editProfilePage.ResumeLayout(false);
            this.editProfilePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSzi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSsc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTeg)).EndInit();
            this.startTrainingPage.ResumeLayout(false);
            this.startTrainingPage.PerformLayout();
            this.TrainingPage.ResumeLayout(false);
            this.TrainingPage.PerformLayout();
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
        private AeroWizard.WizardPage startTrainingPage;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbTrainingProfile;
        private System.Windows.Forms.CheckBox cbTrainingShowNames;
        private AeroWizard.WizardPage TrainingPage;
        private System.Windows.Forms.ComboBox cbTrainingClub;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rbTrainingContinue;
        private System.Windows.Forms.Button btnTrainingRead;
        private System.Windows.Forms.ComboBox cbTrainingMember;
    }
}