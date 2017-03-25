namespace SVP
{
    partial class AddCompetitionWizard
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
            this.txtCompetitionName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbGroupCompetition = new System.Windows.Forms.RadioButton();
            this.rbSingleCompetition = new System.Windows.Forms.RadioButton();
            this.addPricePage = new AeroWizard.WizardPage();
            this.cbProfile = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPriceName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.competitionOverviewPage = new AeroWizard.WizardPage();
            this.rbFinished = new System.Windows.Forms.RadioButton();
            this.rbAddAward = new System.Windows.Forms.RadioButton();
            this.rbAddPrice = new System.Windows.Forms.RadioButton();
            this.dvCompetition = new System.Windows.Forms.DataGridView();
            this.PriceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceKind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addAwardPage = new AeroWizard.WizardPage();
            this.txtAwardName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.startPage.SuspendLayout();
            this.addPricePage.SuspendLayout();
            this.competitionOverviewPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvCompetition)).BeginInit();
            this.addAwardPage.SuspendLayout();
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
            this.wizardControl1.Pages.Add(this.addPricePage);
            this.wizardControl1.Pages.Add(this.addAwardPage);
            this.wizardControl1.Pages.Add(this.competitionOverviewPage);
            this.wizardControl1.Size = new System.Drawing.Size(574, 415);
            this.wizardControl1.TabIndex = 0;
            this.wizardControl1.Title = "Schießstand Verwaltungs Programm";
            this.wizardControl1.Cancelling += new System.ComponentModel.CancelEventHandler(this.wizardControl1_Cancelling);
            // 
            // startPage
            // 
            this.startPage.Controls.Add(this.txtCompetitionName);
            this.startPage.Controls.Add(this.label3);
            this.startPage.Controls.Add(this.rbGroupCompetition);
            this.startPage.Controls.Add(this.rbSingleCompetition);
            this.startPage.Name = "startPage";
            this.startPage.NextPage = this.addPricePage;
            this.startPage.Size = new System.Drawing.Size(527, 261);
            this.startPage.TabIndex = 0;
            this.startPage.Text = "Was möchtest du tun?";
            this.startPage.Commit += new System.EventHandler<AeroWizard.WizardPageConfirmEventArgs>(this.startPage_Commit);
            this.startPage.Initialize += new System.EventHandler<AeroWizard.WizardPageInitEventArgs>(this.startPage_Initialize);
            // 
            // txtCompetitionName
            // 
            this.txtCompetitionName.Location = new System.Drawing.Point(70, 50);
            this.txtCompetitionName.Name = "txtCompetitionName";
            this.txtCompetitionName.Size = new System.Drawing.Size(236, 23);
            this.txtCompetitionName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // rbGroupCompetition
            // 
            this.rbGroupCompetition.AutoSize = true;
            this.rbGroupCompetition.Location = new System.Drawing.Point(25, 108);
            this.rbGroupCompetition.Name = "rbGroupCompetition";
            this.rbGroupCompetition.Size = new System.Drawing.Size(281, 19);
            this.rbGroupCompetition.TabIndex = 1;
            this.rbGroupCompetition.Text = "Ein Pokalschießen mit Gruppenwertung erstellen";
            this.rbGroupCompetition.UseVisualStyleBackColor = true;
            // 
            // rbSingleCompetition
            // 
            this.rbSingleCompetition.AutoSize = true;
            this.rbSingleCompetition.Checked = true;
            this.rbSingleCompetition.Location = new System.Drawing.Point(25, 83);
            this.rbSingleCompetition.Name = "rbSingleCompetition";
            this.rbSingleCompetition.Size = new System.Drawing.Size(265, 19);
            this.rbSingleCompetition.TabIndex = 0;
            this.rbSingleCompetition.TabStop = true;
            this.rbSingleCompetition.Text = "Ein Pokalschießen mit Einzelwertung erstellen";
            this.rbSingleCompetition.UseVisualStyleBackColor = true;
            // 
            // addPricePage
            // 
            this.addPricePage.Controls.Add(this.cbProfile);
            this.addPricePage.Controls.Add(this.label4);
            this.addPricePage.Controls.Add(this.txtPriceName);
            this.addPricePage.Controls.Add(this.label2);
            this.addPricePage.Name = "addPricePage";
            this.addPricePage.NextPage = this.competitionOverviewPage;
            this.addPricePage.Size = new System.Drawing.Size(527, 261);
            this.addPricePage.TabIndex = 1;
            this.addPricePage.Text = "Einen Pokal hinzufügen";
            this.addPricePage.Commit += new System.EventHandler<AeroWizard.WizardPageConfirmEventArgs>(this.addPricePage_Commit);
            // 
            // cbProfile
            // 
            this.cbProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfile.FormattingEnabled = true;
            this.cbProfile.Location = new System.Drawing.Point(85, 55);
            this.cbProfile.Name = "cbProfile";
            this.cbProfile.Size = new System.Drawing.Size(242, 23);
            this.cbProfile.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Wertung:";
            // 
            // txtPriceName
            // 
            this.txtPriceName.Location = new System.Drawing.Point(85, 26);
            this.txtPriceName.Name = "txtPriceName";
            this.txtPriceName.Size = new System.Drawing.Size(242, 23);
            this.txtPriceName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // competitionOverviewPage
            // 
            this.competitionOverviewPage.AllowBack = false;
            this.competitionOverviewPage.Controls.Add(this.rbFinished);
            this.competitionOverviewPage.Controls.Add(this.rbAddAward);
            this.competitionOverviewPage.Controls.Add(this.rbAddPrice);
            this.competitionOverviewPage.Controls.Add(this.dvCompetition);
            this.competitionOverviewPage.Name = "competitionOverviewPage";
            this.competitionOverviewPage.Size = new System.Drawing.Size(527, 261);
            this.competitionOverviewPage.TabIndex = 3;
            this.competitionOverviewPage.Text = "Übersicht";
            this.competitionOverviewPage.Commit += new System.EventHandler<AeroWizard.WizardPageConfirmEventArgs>(this.competitionOverviewPage_Commit);
            this.competitionOverviewPage.Enter += new System.EventHandler(this.competitionOverviewPage_Enter);
            // 
            // rbFinished
            // 
            this.rbFinished.AutoSize = true;
            this.rbFinished.Location = new System.Drawing.Point(3, 239);
            this.rbFinished.Name = "rbFinished";
            this.rbFinished.Size = new System.Drawing.Size(199, 19);
            this.rbFinished.TabIndex = 3;
            this.rbFinished.Text = "Keine weiteren Preise hinzufügen";
            this.rbFinished.UseVisualStyleBackColor = true;
            this.rbFinished.CheckedChanged += new System.EventHandler(this.rbOverview_CheckedChanged);
            // 
            // rbAddAward
            // 
            this.rbAddAward.AutoSize = true;
            this.rbAddAward.Location = new System.Drawing.Point(3, 214);
            this.rbAddAward.Name = "rbAddAward";
            this.rbAddAward.Size = new System.Drawing.Size(183, 19);
            this.rbAddAward.TabIndex = 2;
            this.rbAddAward.Text = "Eine Ehrenscheibe hinzufügen";
            this.rbAddAward.UseVisualStyleBackColor = true;
            this.rbAddAward.CheckedChanged += new System.EventHandler(this.rbOverview_CheckedChanged);
            // 
            // rbAddPrice
            // 
            this.rbAddPrice.AutoSize = true;
            this.rbAddPrice.Checked = true;
            this.rbAddPrice.Location = new System.Drawing.Point(3, 189);
            this.rbAddPrice.Name = "rbAddPrice";
            this.rbAddPrice.Size = new System.Drawing.Size(149, 19);
            this.rbAddPrice.TabIndex = 1;
            this.rbAddPrice.TabStop = true;
            this.rbAddPrice.Text = "Einen Pokal hinzufügen";
            this.rbAddPrice.UseVisualStyleBackColor = true;
            this.rbAddPrice.CheckedChanged += new System.EventHandler(this.rbOverview_CheckedChanged);
            // 
            // dvCompetition
            // 
            this.dvCompetition.AllowUserToAddRows = false;
            this.dvCompetition.AllowUserToDeleteRows = false;
            this.dvCompetition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvCompetition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PriceName,
            this.PriceKind});
            this.dvCompetition.Location = new System.Drawing.Point(3, 3);
            this.dvCompetition.Name = "dvCompetition";
            this.dvCompetition.ReadOnly = true;
            this.dvCompetition.RowHeadersVisible = false;
            this.dvCompetition.Size = new System.Drawing.Size(521, 180);
            this.dvCompetition.TabIndex = 0;
            // 
            // PriceName
            // 
            this.PriceName.HeaderText = "Name";
            this.PriceName.Name = "PriceName";
            this.PriceName.ReadOnly = true;
            this.PriceName.Width = 250;
            // 
            // PriceKind
            // 
            this.PriceKind.HeaderText = "Art";
            this.PriceKind.Name = "PriceKind";
            this.PriceKind.ReadOnly = true;
            this.PriceKind.Width = 260;
            // 
            // addAwardPage
            // 
            this.addAwardPage.Controls.Add(this.txtAwardName);
            this.addAwardPage.Controls.Add(this.label1);
            this.addAwardPage.Name = "addAwardPage";
            this.addAwardPage.NextPage = this.competitionOverviewPage;
            this.addAwardPage.Size = new System.Drawing.Size(527, 261);
            this.addAwardPage.TabIndex = 2;
            this.addAwardPage.Text = "Ehrenscheibe hinzufügen";
            this.addAwardPage.Commit += new System.EventHandler<AeroWizard.WizardPageConfirmEventArgs>(this.addAwardPage_Commit);
            // 
            // txtAwardName
            // 
            this.txtAwardName.Location = new System.Drawing.Point(108, 30);
            this.txtAwardName.Name = "txtAwardName";
            this.txtAwardName.Size = new System.Drawing.Size(204, 23);
            this.txtAwardName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name / Motiv:";
            // 
            // AddCompetitionWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 415);
            this.ControlBox = false;
            this.Controls.Add(this.wizardControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddCompetitionWizard";
            this.Load += new System.EventHandler(this.AddCompetitionWizard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.startPage.ResumeLayout(false);
            this.startPage.PerformLayout();
            this.addPricePage.ResumeLayout(false);
            this.addPricePage.PerformLayout();
            this.competitionOverviewPage.ResumeLayout(false);
            this.competitionOverviewPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvCompetition)).EndInit();
            this.addAwardPage.ResumeLayout(false);
            this.addAwardPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AeroWizard.WizardControl wizardControl1;
        private AeroWizard.WizardPage startPage;
        private System.Windows.Forms.RadioButton rbGroupCompetition;
        private System.Windows.Forms.RadioButton rbSingleCompetition;
        private AeroWizard.WizardPage addPricePage;
        private System.Windows.Forms.TextBox txtPriceName;
        private System.Windows.Forms.Label label2;
        private AeroWizard.WizardPage addAwardPage;
        private System.Windows.Forms.TextBox txtAwardName;
        private System.Windows.Forms.Label label1;
        private AeroWizard.WizardPage competitionOverviewPage;
        private System.Windows.Forms.RadioButton rbFinished;
        private System.Windows.Forms.RadioButton rbAddAward;
        private System.Windows.Forms.RadioButton rbAddPrice;
        private System.Windows.Forms.DataGridView dvCompetition;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceKind;
        private System.Windows.Forms.TextBox txtCompetitionName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbProfile;
        private System.Windows.Forms.Label label4;
    }
}