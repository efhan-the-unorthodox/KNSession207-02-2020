using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KNSession207_02_2020
{
 
    public partial class EMRequestDetails : Form
    {
        long emergencyMainID;
        List<replacementParts> repptList = new List<replacementParts>(); 
        public EMRequestDetails(long EMID)
        {
            InitializeComponent();
            emergencyMainID = EMID;
        }

        private void EMRequestDetails_Load(object sender, EventArgs e)
        {
            //get emergency maintenance request details 
            using(var db = new KNSession2Entities())
            {
                var requestDetails = db.EmergencyMaintenances.Where(a => a.ID == emergencyMainID).FirstOrDefault();
                lblAssetSN.Text = requestDetails.Asset.AssetSN;
                lblAssetName.Text = requestDetails.Asset.AssetName;
                lblDept.Text = requestDetails.Asset.DepartmentLocation.Department.Name;
                dtpStartDate.Value = (DateTime)requestDetails.EMStartDate;
            }
            loadReplacementParts();
        }

        //load the replacement parts for this asset
        private void loadReplacementParts()
        {
            using(var db = new KNSession2Entities())
            {
                var partsList = db.Parts.ToList();
                cbParts.DataSource = new BindingSource(partsList, null);
                cbParts.DisplayMember = "Name";
                cbParts.ValueMember = "ID";
            }
        }
        
        private void btnAddtoList_Click(object sender, EventArgs e)
        {
            var selectedPart = ((Part)cbParts.SelectedItem);
            var qty = nudAmt.Value;
            if(qty == 0)
            {
                MessageBox.Show("Quantity cannot be 0");
            }
            else
            {
                repptList.Add(new replacementParts
                {
                    Part = selectedPart,
                    Amount = qty
                });
                dgvreplacementparts();
            }
        }

        private void dgvreplacementparts()
        {
            dgvReplacementParts.Rows.Clear();
            foreach(var part in repptList)
            {
                object[] row = new object[]
                {
                    part.Part.Name,
                    part.Amount,
                    "Remove"
                };
                dgvReplacementParts.Rows.Add(row);
            }
        }

        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using(var db = new KNSession2Entities())
            {
                foreach (var replacement in repptList)
                {
                    var newChangePart = new ChangedPart()
                    {
                        EmergencyMaintenanceID = emergencyMainID,
                        PartID = replacement.Part.ID,
                        Amount = replacement.Amount
                    };
                    db.ChangedParts.Add(newChangePart);
                }
                var requestDetails = db.EmergencyMaintenances.Where(a => a.ID == emergencyMainID).FirstOrDefault();
                var endDate = dtpEndDate.Value;
                requestDetails.EMEndDate = endDate;
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Request submitted");
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Oops! an error occured during the submission process");
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        class replacementParts
        {
            public decimal Amount { get; set; }
            public virtual Part Part { get; set; }
        }

        private void dgvReplacementParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedPart = e.RowIndex;
            repptList.RemoveAt(selectedPart);
            dgvreplacementparts();
        }
    }
}
