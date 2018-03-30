namespace SVP
{
    partial class frmAddGroupWizard
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
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvMember)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(60, 6);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(236, 20);
            this.txtGroupName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name:";
            // 
            // lblClubGroup
            // 
            this.lblClubGroup.AutoSize = true;
            this.lblClubGroup.Location = new System.Drawing.Point(15, 208);
            this.lblClubGroup.Name = "lblClubGroup";
            this.lblClubGroup.Size = new System.Drawing.Size(40, 13);
            this.lblClubGroup.TabIndex = 26;
            this.lblClubGroup.Text = "Verein:";
            // 
            // cbClub
            // 
            this.cbClub.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbClub.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbClub.FormattingEnabled = true;
            this.cbClub.Location = new System.Drawing.Point(124, 205);
            this.cbClub.Name = "cbClub";
            this.cbClub.Size = new System.Drawing.Size(195, 21);
            this.cbClub.TabIndex = 25;
            this.cbClub.SelectedIndexChanged += new System.EventHandler(this.cbClub_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Schütze / Schützin:";
            // 
            // cbMember
            // 
            this.cbMember.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMember.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMember.FormattingEnabled = true;
            this.cbMember.Location = new System.Drawing.Point(124, 234);
            this.cbMember.Name = "cbMember";
            this.cbMember.Size = new System.Drawing.Size(195, 21);
            this.cbMember.TabIndex = 28;
            // 
            // btnNewClubGroup
            // 
            this.btnNewClubGroup.Location = new System.Drawing.Point(325, 205);
            this.btnNewClubGroup.Name = "btnNewClubGroup";
            this.btnNewClubGroup.Size = new System.Drawing.Size(93, 23);
            this.btnNewClubGroup.TabIndex = 29;
            this.btnNewClubGroup.Text = "Neuer Verein";
            this.btnNewClubGroup.UseVisualStyleBackColor = true;
            this.btnNewClubGroup.Click += new System.EventHandler(this.btnNewClubGroup_Click);
            // 
            // btnNewMember
            // 
            this.btnNewMember.Location = new System.Drawing.Point(325, 234);
            this.btnNewMember.Name = "btnNewMember";
            this.btnNewMember.Size = new System.Drawing.Size(93, 23);
            this.btnNewMember.TabIndex = 30;
            this.btnNewMember.Text = "Neuer Schütze";
            this.btnNewMember.UseVisualStyleBackColor = true;
            this.btnNewMember.Click += new System.EventHandler(this.btnNewMember_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(325, 263);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 23);
            this.btnAdd.TabIndex = 31;
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
            this.dvMember.Location = new System.Drawing.Point(15, 32);
            this.dvMember.Name = "dvMember";
            this.dvMember.ReadOnly = true;
            this.dvMember.RowHeadersVisible = false;
            this.dvMember.Size = new System.Drawing.Size(521, 165);
            this.dvMember.TabIndex = 24;
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
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(463, 305);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 32;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(382, 305);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddGroupWizardNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 340);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblClubGroup);
            this.Controls.Add(this.cbClub);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMember);
            this.Controls.Add(this.btnNewClubGroup);
            this.Controls.Add(this.btnNewMember);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dvMember);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddGroupWizardNew";
            this.Text = "Gruppe bearbeiten";
            this.Load += new System.EventHandler(this.AddGroupWizardNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblClubGroup;
        private System.Windows.Forms.ComboBox cbClub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMember;
        private System.Windows.Forms.Button btnNewClubGroup;
        private System.Windows.Forms.Button btnNewMember;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dvMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceKind;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceName;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}