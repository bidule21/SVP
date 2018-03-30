namespace SVP
{
    partial class frmAddCompetitionWizard
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
            this.txtCompetitionName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbGroupCompetition = new System.Windows.Forms.RadioButton();
            this.rbSingleCompetition = new System.Windows.Forms.RadioButton();
            this.dvCompetition = new System.Windows.Forms.DataGridView();
            this.PriceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceKind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbPrice = new System.Windows.Forms.GroupBox();
            this.btnAddPrice = new System.Windows.Forms.Button();
            this.cbProfile = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPriceName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbAward = new System.Windows.Forms.GroupBox();
            this.btnAddAward = new System.Windows.Forms.Button();
            this.txtAwardName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbPriceAward = new System.Windows.Forms.GroupBox();
            this.gbCompetition = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvCompetition)).BeginInit();
            this.gbPrice.SuspendLayout();
            this.gbAward.SuspendLayout();
            this.gbPriceAward.SuspendLayout();
            this.gbCompetition.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCompetitionName
            // 
            this.txtCompetitionName.Location = new System.Drawing.Point(54, 23);
            this.txtCompetitionName.Name = "txtCompetitionName";
            this.txtCompetitionName.Size = new System.Drawing.Size(236, 20);
            this.txtCompetitionName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name:";
            // 
            // rbGroupCompetition
            // 
            this.rbGroupCompetition.AutoSize = true;
            this.rbGroupCompetition.Enabled = false;
            this.rbGroupCompetition.Location = new System.Drawing.Point(9, 81);
            this.rbGroupCompetition.Name = "rbGroupCompetition";
            this.rbGroupCompetition.Size = new System.Drawing.Size(253, 17);
            this.rbGroupCompetition.TabIndex = 5;
            this.rbGroupCompetition.Text = "Ein Pokalschießen mit Gruppenwertung erstellen";
            this.rbGroupCompetition.UseVisualStyleBackColor = true;
            // 
            // rbSingleCompetition
            // 
            this.rbSingleCompetition.AutoSize = true;
            this.rbSingleCompetition.Checked = true;
            this.rbSingleCompetition.Location = new System.Drawing.Point(9, 56);
            this.rbSingleCompetition.Name = "rbSingleCompetition";
            this.rbSingleCompetition.Size = new System.Drawing.Size(240, 17);
            this.rbSingleCompetition.TabIndex = 4;
            this.rbSingleCompetition.TabStop = true;
            this.rbSingleCompetition.Text = "Ein Pokalschießen mit Einzelwertung erstellen";
            this.rbSingleCompetition.UseVisualStyleBackColor = true;
            // 
            // dvCompetition
            // 
            this.dvCompetition.AllowUserToAddRows = false;
            this.dvCompetition.AllowUserToDeleteRows = false;
            this.dvCompetition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvCompetition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PriceName,
            this.PriceKind});
            this.dvCompetition.Location = new System.Drawing.Point(6, 19);
            this.dvCompetition.Name = "dvCompetition";
            this.dvCompetition.ReadOnly = true;
            this.dvCompetition.RowHeadersVisible = false;
            this.dvCompetition.Size = new System.Drawing.Size(517, 180);
            this.dvCompetition.TabIndex = 8;
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
            // gbPrice
            // 
            this.gbPrice.Controls.Add(this.btnAddPrice);
            this.gbPrice.Controls.Add(this.cbProfile);
            this.gbPrice.Controls.Add(this.label4);
            this.gbPrice.Controls.Add(this.txtPriceName);
            this.gbPrice.Controls.Add(this.label2);
            this.gbPrice.Location = new System.Drawing.Point(7, 205);
            this.gbPrice.Name = "gbPrice";
            this.gbPrice.Size = new System.Drawing.Size(516, 88);
            this.gbPrice.TabIndex = 9;
            this.gbPrice.TabStop = false;
            this.gbPrice.Text = "Pokal hinzufügen";
            // 
            // btnAddPrice
            // 
            this.btnAddPrice.Location = new System.Drawing.Point(435, 59);
            this.btnAddPrice.Name = "btnAddPrice";
            this.btnAddPrice.Size = new System.Drawing.Size(75, 23);
            this.btnAddPrice.TabIndex = 8;
            this.btnAddPrice.Text = "Hinzufügen";
            this.btnAddPrice.UseVisualStyleBackColor = true;
            this.btnAddPrice.Click += new System.EventHandler(this.btnAddPrice_Click);
            // 
            // cbProfile
            // 
            this.cbProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfile.FormattingEnabled = true;
            this.cbProfile.Location = new System.Drawing.Point(68, 51);
            this.cbProfile.Name = "cbProfile";
            this.cbProfile.Size = new System.Drawing.Size(242, 21);
            this.cbProfile.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Wertung:";
            // 
            // txtPriceName
            // 
            this.txtPriceName.Location = new System.Drawing.Point(68, 22);
            this.txtPriceName.Name = "txtPriceName";
            this.txtPriceName.Size = new System.Drawing.Size(242, 20);
            this.txtPriceName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name:";
            // 
            // gbAward
            // 
            this.gbAward.Controls.Add(this.btnAddAward);
            this.gbAward.Controls.Add(this.txtAwardName);
            this.gbAward.Controls.Add(this.label1);
            this.gbAward.Location = new System.Drawing.Point(7, 299);
            this.gbAward.Name = "gbAward";
            this.gbAward.Size = new System.Drawing.Size(516, 88);
            this.gbAward.TabIndex = 10;
            this.gbAward.TabStop = false;
            this.gbAward.Text = "Ehrenscheibe hinzufügen";
            // 
            // btnAddAward
            // 
            this.btnAddAward.Location = new System.Drawing.Point(435, 59);
            this.btnAddAward.Name = "btnAddAward";
            this.btnAddAward.Size = new System.Drawing.Size(75, 23);
            this.btnAddAward.TabIndex = 9;
            this.btnAddAward.Text = "Hinzufügen";
            this.btnAddAward.UseVisualStyleBackColor = true;
            this.btnAddAward.Click += new System.EventHandler(this.btnAddAward_Click);
            // 
            // txtAwardName
            // 
            this.txtAwardName.Location = new System.Drawing.Point(96, 22);
            this.txtAwardName.Name = "txtAwardName";
            this.txtAwardName.Size = new System.Drawing.Size(214, 20);
            this.txtAwardName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name / Motiv:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(460, 532);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(379, 532);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbPriceAward
            // 
            this.gbPriceAward.Controls.Add(this.dvCompetition);
            this.gbPriceAward.Controls.Add(this.gbPrice);
            this.gbPriceAward.Controls.Add(this.gbAward);
            this.gbPriceAward.Enabled = false;
            this.gbPriceAward.Location = new System.Drawing.Point(12, 127);
            this.gbPriceAward.Name = "gbPriceAward";
            this.gbPriceAward.Size = new System.Drawing.Size(536, 399);
            this.gbPriceAward.TabIndex = 13;
            this.gbPriceAward.TabStop = false;
            this.gbPriceAward.Text = "Pokalschießen";
            // 
            // gbCompetition
            // 
            this.gbCompetition.Controls.Add(this.btnCreate);
            this.gbCompetition.Controls.Add(this.label3);
            this.gbCompetition.Controls.Add(this.rbSingleCompetition);
            this.gbCompetition.Controls.Add(this.txtCompetitionName);
            this.gbCompetition.Controls.Add(this.rbGroupCompetition);
            this.gbCompetition.Location = new System.Drawing.Point(12, 12);
            this.gbCompetition.Name = "gbCompetition";
            this.gbCompetition.Size = new System.Drawing.Size(536, 109);
            this.gbCompetition.TabIndex = 14;
            this.gbCompetition.TabStop = false;
            this.gbCompetition.Text = "Pokalschießen";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(448, 75);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "&OK";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // AddCompetitionWizard
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 563);
            this.ControlBox = false;
            this.Controls.Add(this.gbCompetition);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gbPriceAward);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddCompetitionWizard";
            this.Text = "Pokalschießen bearbeiten";
            this.Load += new System.EventHandler(this.AddCompetitionWizardNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvCompetition)).EndInit();
            this.gbPrice.ResumeLayout(false);
            this.gbPrice.PerformLayout();
            this.gbAward.ResumeLayout(false);
            this.gbAward.PerformLayout();
            this.gbPriceAward.ResumeLayout(false);
            this.gbCompetition.ResumeLayout(false);
            this.gbCompetition.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCompetitionName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbGroupCompetition;
        private System.Windows.Forms.RadioButton rbSingleCompetition;
        private System.Windows.Forms.DataGridView dvCompetition;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceKind;
        private System.Windows.Forms.GroupBox gbPrice;
        private System.Windows.Forms.ComboBox cbProfile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPriceName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddPrice;
        private System.Windows.Forms.GroupBox gbAward;
        private System.Windows.Forms.Button btnAddAward;
        private System.Windows.Forms.TextBox txtAwardName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbPriceAward;
        private System.Windows.Forms.GroupBox gbCompetition;
        private System.Windows.Forms.Button btnCreate;
    }
}