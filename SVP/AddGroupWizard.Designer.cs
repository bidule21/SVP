namespace SVP
{
    partial class AddGroupWizard
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
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GroupOverview = new AeroWizard.WizardPage();
            this.lblClubGroup = new System.Windows.Forms.Label();
            this.cbClub = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMember = new System.Windows.Forms.ComboBox();
            this.btnNewClubGroup = new System.Windows.Forms.Button();
            this.btnNewMember = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dvMember = new System.Windows.Forms.DataGridView();
            this.PriceKind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.startPage.SuspendLayout();
            this.GroupOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvMember)).BeginInit();
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
            this.wizardControl1.Pages.Add(this.GroupOverview);
            this.wizardControl1.Size = new System.Drawing.Size(574, 415);
            this.wizardControl1.TabIndex = 0;
            this.wizardControl1.Title = "Schießstand Verwaltungs Programm";
            this.wizardControl1.Cancelling += new System.ComponentModel.CancelEventHandler(this.wizardControl1_Cancelling);
            this.wizardControl1.SelectedPageChanged += new System.EventHandler(this.wizardControl1_SelectedPageChanged);
            // 
            // startPage
            // 
            this.startPage.Controls.Add(this.txtGroupName);
            this.startPage.Controls.Add(this.label3);
            this.startPage.Name = "startPage";
            this.startPage.NextPage = this.GroupOverview;
            this.startPage.Size = new System.Drawing.Size(527, 261);
            this.startPage.TabIndex = 0;
            this.startPage.Text = "Neue Gruppe erstellen";
            this.startPage.Commit += new System.EventHandler<AeroWizard.WizardPageConfirmEventArgs>(this.startPage_Commit);
            this.startPage.Initialize += new System.EventHandler<AeroWizard.WizardPageInitEventArgs>(this.startPage_Initialize);
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(70, 50);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(236, 23);
            this.txtGroupName.TabIndex = 3;
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
            // GroupOverview
            // 
            this.GroupOverview.AllowBack = false;
            this.GroupOverview.Controls.Add(this.lblClubGroup);
            this.GroupOverview.Controls.Add(this.cbClub);
            this.GroupOverview.Controls.Add(this.label2);
            this.GroupOverview.Controls.Add(this.cbMember);
            this.GroupOverview.Controls.Add(this.btnNewClubGroup);
            this.GroupOverview.Controls.Add(this.btnNewMember);
            this.GroupOverview.Controls.Add(this.btnAdd);
            this.GroupOverview.Controls.Add(this.dvMember);
            this.GroupOverview.Name = "GroupOverview";
            this.GroupOverview.Size = new System.Drawing.Size(527, 261);
            this.GroupOverview.TabIndex = 3;
            this.GroupOverview.Text = "Übersicht";
            this.GroupOverview.Commit += new System.EventHandler<AeroWizard.WizardPageConfirmEventArgs>(this.GroupOverview_Commit);
            this.GroupOverview.Initialize += new System.EventHandler<AeroWizard.WizardPageInitEventArgs>(this.GroupOverview_Initialize);
            // 
            // lblClubGroup
            // 
            this.lblClubGroup.AutoSize = true;
            this.lblClubGroup.Location = new System.Drawing.Point(3, 179);
            this.lblClubGroup.Name = "lblClubGroup";
            this.lblClubGroup.Size = new System.Drawing.Size(42, 15);
            this.lblClubGroup.TabIndex = 18;
            this.lblClubGroup.Text = "Verein:";
            // 
            // cbClub
            // 
            this.cbClub.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbClub.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbClub.FormattingEnabled = true;
            this.cbClub.Location = new System.Drawing.Point(112, 176);
            this.cbClub.Name = "cbClub";
            this.cbClub.Size = new System.Drawing.Size(195, 23);
            this.cbClub.TabIndex = 17;
            this.cbClub.SelectedIndexChanged += new System.EventHandler(this.cbClub_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Schütze / Schützin:";
            // 
            // cbMember
            // 
            this.cbMember.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMember.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMember.FormattingEnabled = true;
            this.cbMember.Location = new System.Drawing.Point(112, 205);
            this.cbMember.Name = "cbMember";
            this.cbMember.Size = new System.Drawing.Size(195, 23);
            this.cbMember.TabIndex = 20;
            // 
            // btnNewClubGroup
            // 
            this.btnNewClubGroup.Location = new System.Drawing.Point(313, 176);
            this.btnNewClubGroup.Name = "btnNewClubGroup";
            this.btnNewClubGroup.Size = new System.Drawing.Size(93, 23);
            this.btnNewClubGroup.TabIndex = 21;
            this.btnNewClubGroup.Text = "Neuer Verein";
            this.btnNewClubGroup.UseVisualStyleBackColor = true;
            this.btnNewClubGroup.Click += new System.EventHandler(this.btnNewClubGroup_Click);
            // 
            // btnNewMember
            // 
            this.btnNewMember.Location = new System.Drawing.Point(313, 205);
            this.btnNewMember.Name = "btnNewMember";
            this.btnNewMember.Size = new System.Drawing.Size(93, 23);
            this.btnNewMember.TabIndex = 22;
            this.btnNewMember.Text = "Neuer Schütze";
            this.btnNewMember.UseVisualStyleBackColor = true;
            this.btnNewMember.Click += new System.EventHandler(this.btnNewMember_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(313, 234);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 23);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Hinzufügen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dvMember
            // 
            this.dvMember.AllowUserToAddRows = false;
            this.dvMember.AllowUserToDeleteRows = false;
            this.dvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PriceKind,
            this.PriceName});
            this.dvMember.Location = new System.Drawing.Point(3, 3);
            this.dvMember.Name = "dvMember";
            this.dvMember.ReadOnly = true;
            this.dvMember.RowHeadersVisible = false;
            this.dvMember.Size = new System.Drawing.Size(521, 165);
            this.dvMember.TabIndex = 0;
            // 
            // PriceKind
            // 
            this.PriceKind.HeaderText = "Verein";
            this.PriceKind.Name = "PriceKind";
            this.PriceKind.ReadOnly = true;
            this.PriceKind.Width = 260;
            // 
            // PriceName
            // 
            this.PriceName.HeaderText = "Name";
            this.PriceName.Name = "PriceName";
            this.PriceName.ReadOnly = true;
            this.PriceName.Width = 250;
            // 
            // AddGroupWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 415);
            this.ControlBox = false;
            this.Controls.Add(this.wizardControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddGroupWizard";
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.startPage.ResumeLayout(false);
            this.startPage.PerformLayout();
            this.GroupOverview.ResumeLayout(false);
            this.GroupOverview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvMember)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AeroWizard.WizardControl wizardControl1;
        private AeroWizard.WizardPage startPage;
        private AeroWizard.WizardPage GroupOverview;
        private System.Windows.Forms.DataGridView dvMember;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceKind;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceName;
        private System.Windows.Forms.Label lblClubGroup;
        private System.Windows.Forms.ComboBox cbClub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMember;
        private System.Windows.Forms.Button btnNewClubGroup;
        private System.Windows.Forms.Button btnNewMember;
        private System.Windows.Forms.Button btnAdd;
    }
}