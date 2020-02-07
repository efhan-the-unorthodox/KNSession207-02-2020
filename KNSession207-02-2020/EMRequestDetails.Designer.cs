namespace KNSession207_02_2020
{
    partial class EMRequestDetails
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDept = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAssetName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAssetSN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbTechNote = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvReplacementParts = new System.Windows.Forms.DataGridView();
            this.NamePart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewLinkColumn();
            this.partID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddtoList = new System.Windows.Forms.Button();
            this.nudAmt = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cbParts = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReplacementParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmt)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDept);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblAssetName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblAssetSN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Asset";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(642, 38);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(46, 17);
            this.lblDept.TabIndex = 11;
            this.lblDept.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(547, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Department:";
            // 
            // lblAssetName
            // 
            this.lblAssetName.AutoSize = true;
            this.lblAssetName.Location = new System.Drawing.Point(373, 38);
            this.lblAssetName.Name = "lblAssetName";
            this.lblAssetName.Size = new System.Drawing.Size(46, 17);
            this.lblAssetName.TabIndex = 9;
            this.lblAssetName.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Asset Name:";
            // 
            // lblAssetSN
            // 
            this.lblAssetSN.AutoSize = true;
            this.lblAssetSN.Location = new System.Drawing.Point(108, 38);
            this.lblAssetSN.Name = "lblAssetSN";
            this.lblAssetSN.Size = new System.Drawing.Size(46, 17);
            this.lblAssetSN.TabIndex = 7;
            this.lblAssetSN.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Asset S/N:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbTechNote);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtpEndDate);
            this.groupBox2.Controls.Add(this.dtpStartDate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 159);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selected Asset";
            // 
            // tbTechNote
            // 
            this.tbTechNote.Location = new System.Drawing.Point(6, 84);
            this.tbTechNote.Multiline = true;
            this.tbTechNote.Name = "tbTechNote";
            this.tbTechNote.Size = new System.Drawing.Size(756, 69);
            this.tbTechNote.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Technician Note:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(501, 36);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(257, 22);
            this.dtpEndDate.TabIndex = 15;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(89, 36);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(266, 22);
            this.dtpStartDate.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Completed On:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Start Date:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvReplacementParts);
            this.groupBox3.Controls.Add(this.btnAddtoList);
            this.groupBox3.Controls.Add(this.nudAmt);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cbParts);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 256);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 178);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Replacement Parts";
            // 
            // dgvReplacementParts
            // 
            this.dgvReplacementParts.AllowUserToAddRows = false;
            this.dgvReplacementParts.AllowUserToDeleteRows = false;
            this.dgvReplacementParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReplacementParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReplacementParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NamePart,
            this.Amount,
            this.Action,
            this.partID});
            this.dgvReplacementParts.Location = new System.Drawing.Point(9, 61);
            this.dgvReplacementParts.Name = "dgvReplacementParts";
            this.dgvReplacementParts.ReadOnly = true;
            this.dgvReplacementParts.RowHeadersVisible = false;
            this.dgvReplacementParts.RowHeadersWidth = 51;
            this.dgvReplacementParts.RowTemplate.Height = 24;
            this.dgvReplacementParts.Size = new System.Drawing.Size(753, 111);
            this.dgvReplacementParts.TabIndex = 18;
            this.dgvReplacementParts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReplacementParts_CellContentClick);
            // 
            // NamePart
            // 
            this.NamePart.HeaderText = "Part Name";
            this.NamePart.MinimumWidth = 6;
            this.NamePart.Name = "NamePart";
            this.NamePart.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.MinimumWidth = 6;
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            // 
            // partID
            // 
            this.partID.HeaderText = "partID";
            this.partID.MinimumWidth = 6;
            this.partID.Name = "partID";
            this.partID.ReadOnly = true;
            this.partID.Visible = false;
            // 
            // btnAddtoList
            // 
            this.btnAddtoList.Location = new System.Drawing.Point(618, 21);
            this.btnAddtoList.Name = "btnAddtoList";
            this.btnAddtoList.Size = new System.Drawing.Size(116, 23);
            this.btnAddtoList.TabIndex = 17;
            this.btnAddtoList.Text = "+ Add to List";
            this.btnAddtoList.UseVisualStyleBackColor = true;
            this.btnAddtoList.Click += new System.EventHandler(this.btnAddtoList_Click);
            // 
            // nudAmt
            // 
            this.nudAmt.Location = new System.Drawing.Point(438, 21);
            this.nudAmt.Name = "nudAmt";
            this.nudAmt.Size = new System.Drawing.Size(110, 22);
            this.nudAmt.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(372, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Amount:";
            // 
            // cbParts
            // 
            this.cbParts.FormattingEnabled = true;
            this.cbParts.Location = new System.Drawing.Point(88, 24);
            this.cbParts.Name = "cbParts";
            this.cbParts.Size = new System.Drawing.Size(241, 24);
            this.cbParts.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Part Name:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(279, 440);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(88, 29);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(411, 441);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 28);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EMRequestDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EMRequestDetails";
            this.Text = "EMRequestDetails";
            this.Load += new System.EventHandler(this.EMRequestDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReplacementParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAssetName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAssetSN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTechNote;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddtoList;
        private System.Windows.Forms.NumericUpDown nudAmt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbParts;
        private System.Windows.Forms.DataGridView dgvReplacementParts;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamePart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewLinkColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn partID;
    }
}