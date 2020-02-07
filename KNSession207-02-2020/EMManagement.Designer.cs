namespace KNSession207_02_2020
{
    partial class EMManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAssets = new System.Windows.Forms.DataGridView();
            this.btnSendMaintenanceRequest = new System.Windows.Forms.Button();
            this.ASN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameAsset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LCEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssets)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available Assets";
            // 
            // dgvAssets
            // 
            this.dgvAssets.AllowUserToAddRows = false;
            this.dgvAssets.AllowUserToDeleteRows = false;
            this.dgvAssets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ASN,
            this.NameAsset,
            this.LCEM,
            this.EMNumber,
            this.AID});
            this.dgvAssets.Location = new System.Drawing.Point(12, 58);
            this.dgvAssets.Name = "dgvAssets";
            this.dgvAssets.ReadOnly = true;
            this.dgvAssets.RowHeadersVisible = false;
            this.dgvAssets.RowHeadersWidth = 51;
            this.dgvAssets.RowTemplate.Height = 24;
            this.dgvAssets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssets.Size = new System.Drawing.Size(776, 339);
            this.dgvAssets.TabIndex = 1;
            // 
            // btnSendMaintenanceRequest
            // 
            this.btnSendMaintenanceRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMaintenanceRequest.Location = new System.Drawing.Point(12, 414);
            this.btnSendMaintenanceRequest.Name = "btnSendMaintenanceRequest";
            this.btnSendMaintenanceRequest.Size = new System.Drawing.Size(309, 24);
            this.btnSendMaintenanceRequest.TabIndex = 2;
            this.btnSendMaintenanceRequest.Text = "Send Emergency Maintenance Request";
            this.btnSendMaintenanceRequest.UseVisualStyleBackColor = true;
            this.btnSendMaintenanceRequest.Click += new System.EventHandler(this.btnSendMaintenanceRequest_Click);
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
            this.NameAsset.HeaderText = "Asset Name";
            this.NameAsset.MinimumWidth = 6;
            this.NameAsset.Name = "NameAsset";
            this.NameAsset.ReadOnly = true;
            // 
            // LCEM
            // 
            this.LCEM.HeaderText = "Last Closed EM";
            this.LCEM.MinimumWidth = 6;
            this.LCEM.Name = "LCEM";
            this.LCEM.ReadOnly = true;
            // 
            // EMNumber
            // 
            this.EMNumber.HeaderText = "Number of EMs";
            this.EMNumber.MinimumWidth = 6;
            this.EMNumber.Name = "EMNumber";
            this.EMNumber.ReadOnly = true;
            // 
            // AID
            // 
            this.AID.HeaderText = "AssetID";
            this.AID.MinimumWidth = 6;
            this.AID.Name = "AID";
            this.AID.ReadOnly = true;
            this.AID.Visible = false;
            // 
            // EMManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSendMaintenanceRequest);
            this.Controls.Add(this.dgvAssets);
            this.Controls.Add(this.label1);
            this.Name = "EMManagement";
            this.Text = "EMManagement";
            this.Load += new System.EventHandler(this.EMManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAssets;
        private System.Windows.Forms.Button btnSendMaintenanceRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameAsset;
        private System.Windows.Forms.DataGridViewTextBoxColumn LCEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn AID;
    }
}