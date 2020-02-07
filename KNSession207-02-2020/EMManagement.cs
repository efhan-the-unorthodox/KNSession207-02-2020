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
    public partial class EMManagement : Form
    {
        public EMManagement()
        {
            InitializeComponent();
        }

        private void EMManagement_Load(object sender, EventArgs e)
        {
            //get the assets for the Accountable party user
            loadAssets();
           
        }

        private void btnSendMaintenanceRequest_Click(object sender, EventArgs e)
        {
            //get the ID of the selected Asset
            var selectedAssetID = Convert.ToInt64(dgvAssets.CurrentRow.Cells[4].Value);

            var newRequest = new EMRequest(selectedAssetID);
            this.Hide();
            newRequest.ShowDialog();
            this.Show();
            loadAssets();
        }
        private void loadAssets()
        {
            using (var db = new KNSession2Entities())
            {
                var assetList = db.Assets.Where(a => a.EmployeeID == GlobalVariables.empID).ToList();

                dgvAssets.Rows.Clear();
                foreach (var asset in assetList)
                {
                    //get the last completed task finishing date if any
                    var lastClosedEM1 = db.EmergencyMaintenances.OrderByDescending(a => a.EMEndDate).Where(b => b.EMEndDate != null && b.AssetID == asset.ID).Select(a => a.EMEndDate).FirstOrDefault();
                    var emCount = db.EmergencyMaintenances.Where(a => a.AssetID == asset.ID && a.EMEndDate != null).Count();
                    var lcem = "--";
                    if (lastClosedEM1 != null)
                    {
                        lcem = lastClosedEM1.ToString();
                    }
                    object[] assetRow = new object[]
                    {
                        asset.AssetSN,
                        asset.AssetName,
                        lcem,
                        emCount,
                        asset.ID
                    };
                    dgvAssets.Rows.Add(assetRow);
                }
            }
        }
    }
}
