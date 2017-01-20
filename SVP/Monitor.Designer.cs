namespace SVP
{
    partial class Monitor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgResultList = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbResults = new System.Windows.Forms.Label();
            this.lbCurrentResult = new System.Windows.Forms.Label();
            this.pbTarget = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgResultList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTarget)).BeginInit();
            this.SuspendLayout();
            // 
            // dgResultList
            // 
            this.dgResultList.AllowUserToAddRows = false;
            this.dgResultList.AllowUserToDeleteRows = false;
            this.dgResultList.AllowUserToResizeColumns = false;
            this.dgResultList.AllowUserToResizeRows = false;
            this.dgResultList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgResultList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgResultList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgResultList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResultList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.result});
            this.dgResultList.Location = new System.Drawing.Point(618, 12);
            this.dgResultList.MultiSelect = false;
            this.dgResultList.Name = "dgResultList";
            this.dgResultList.ReadOnly = true;
            this.dgResultList.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgResultList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgResultList.RowTemplate.Height = 40;
            this.dgResultList.Size = new System.Drawing.Size(301, 531);
            this.dgResultList.TabIndex = 0;
            this.dgResultList.TabStop = false;
            // 
            // name
            // 
            this.name.Frozen = true;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 103;
            // 
            // result
            // 
            this.result.Frozen = true;
            this.result.HeaderText = "Ergebnis";
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Width = 135;
            // 
            // lbResults
            // 
            this.lbResults.AutoSize = true;
            this.lbResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResults.Location = new System.Drawing.Point(12, 398);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(97, 58);
            this.lbResults.TabIndex = 2;
            this.lbResults.Text = "label1+\r\nblafasel\r\n";
            // 
            // lbCurrentResult
            // 
            this.lbCurrentResult.AutoSize = true;
            this.lbCurrentResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentResult.Location = new System.Drawing.Point(481, 398);
            this.lbCurrentResult.Name = "lbCurrentResult";
            this.lbCurrentResult.Size = new System.Drawing.Size(108, 37);
            this.lbCurrentResult.TabIndex = 3;
            this.lbCurrentResult.Text = "label2";
            // 
            // pbTarget
            // 
            this.pbTarget.Image = global::SVP.Properties.Resources.Zielscheibe;
            this.pbTarget.Location = new System.Drawing.Point(12, 12);
            this.pbTarget.Name = "pbTarget";
            this.pbTarget.Size = new System.Drawing.Size(548, 383);
            this.pbTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTarget.TabIndex = 1;
            this.pbTarget.TabStop = false;
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 555);
            this.Controls.Add(this.lbCurrentResult);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.pbTarget);
            this.Controls.Add(this.dgResultList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Monitor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Monitor";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Monitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgResultList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTarget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgResultList;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
        private System.Windows.Forms.PictureBox pbTarget;
        private System.Windows.Forms.Label lbResults;
        private System.Windows.Forms.Label lbCurrentResult;
    }
}

