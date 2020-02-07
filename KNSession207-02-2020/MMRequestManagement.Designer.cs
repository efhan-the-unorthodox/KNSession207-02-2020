namespace KNSession207_02_2020
{
    partial class MMRequestManagement
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
            this.btnManageReq = new System.Windows.Forms.Button();
            this.dgvEMRequests = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ASN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameAsset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRequest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaintenanceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEMRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // btnManageReq
            // 
            this.btnManageReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageReq.Location = new System.Drawing.Point(12, 408);
            this.btnManageReq.Name = "btnManageReq";
            this.btnManageReq.Size = new System.Drawing.Size(309, 24);
            this.btnManageReq.TabIndex = 5;
            this.btnManageReq.Text = "Manage Request";
            this.btnManageReq.UseVisualStyleBackColor = true;
            this.btnManageReq.Click += new System.EventHandler(this.btnManageReq_Click);
            // 
            // dgvEMRequests
            // 
            this.dgvEMRequests.AllowUserToAddRows = false;
            this.dgvEMRequests.AllowUserToDeleteRows = false;
            this.dgvEMRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEMRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEMRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ASN,
            this.NameAsset,
            this.DateRequest,
            this.EmpName,
            this.Dept,
            this.MaintenanceID});
            this.dgvEMRequests.Location = new System.Drawing.Point(12, 51);
            this.dgvEMRequests.Name = "dgvEMRequests";
            this.dgvEMRequests.ReadOnly = true;
            this.dgvEMRequests.RowHeadersVisible = false;
            this.dgvEMRequests.RowHeadersWidth = 51;
            this.dgvEMRequests.RowTemplate.Height = 24;
            this.dgvEMRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEMRequests.Size = new System.Drawing.Size(776, 339);
            this.dgvEMRequests.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "List of Assets Requesting EM:";
            // 
            // ASN
            // 
            this.ASN.HeaderText = "Asset SN";
            this.ASN.MinimumWidth = 6;
            this.ASN.Name = "ASN";
            this.ASN.ReadOnly = true;
            // 
            // NameAsset
            // 
            this.NameAsset.HeaderText = "Asset Name`";
            this.NameAsset.MinimumWidth = 6;
            this.NameAsset.Name = "NameAsset";
            this.NameAsset.ReadOnly = true;
            // 
            // DateRequest
            // 
            this.DateRequest.HeaderText = "Request Date";
            this.DateRequest.MinimumWidth = 6;
            this.DateRequest.Name = "DateRequest";
            this.DateRequest.ReadOnly = true;
            // 
            // EmpName
            // 
            this.EmpName.HeaderText = "Employee Full Name";
            this.EmpName.MinimumWidth = 6;
            this.EmpName.Name = "EmpName";
            this.EmpName.ReadOnly = true;
            // 
            // Dept
            // 
            this.Dept.HeaderText = "Department";
            this.Dept.MinimumWidth = 6;
            this.Dept.Name = "Dept";
            this.Dept.ReadOnly = true;
            // 
            // MaintenanceID
            // 
            this.MaintenanceID.HeaderText = "EmergencyMaintenanceID";
            this.MaintenanceID.MinimumWidth = 6;
            this.MaintenanceID.Name = "MaintenanceID";
            this.MaintenanceID.ReadOnly = true;
            this.MaintenanceID.Visible = false;
            // 
            // MMRequestManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnManageReq);
            this.Controls.Add(this.dgvEMRequests);
            this.Controls.Add(this.label1);
            this.Name = "MMRequestManagement";
            this.Text = "MMRequestManagement";
            this.Load += new System.EventHandler(this.MMRequestManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEMRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManageReq;
        private System.Windows.Forms.DataGridView dgvEMRequests;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameAsset;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaintenanceID;
    }
}