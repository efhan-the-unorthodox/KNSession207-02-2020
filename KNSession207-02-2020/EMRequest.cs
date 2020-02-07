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
    public partial class EMRequest : Form
    {
        long assetID;
        public EMRequest(long AID)
        {
            InitializeComponent();
            assetID = AID;
        }

        private void EMRequest_Load(object sender, EventArgs e)
        {
            //Method to load priority box
            loadPriority();
            //get details of the asset
            using(var db = new KNSession2Entities())
            {
                var assetInfo = db.Assets.Where(a => a.ID == assetID).FirstOrDefault();
                lblAssetSN.Text = assetInfo.AssetSN;
                lblAssetName.Text = assetInfo.AssetName;
                lblDept.Text = assetInfo.DepartmentLocation.Department.Name;
            }

        }
        private void loadPriority()
        {
            using(var db = new KNSession2Entities())
            {
                var priorities = db.Priorities.ToList();

                cbPriority.DataSource = new BindingSource(priorities, null);
                cbPriority.DisplayMember = "Name";
                cbPriority.ValueMember = "ID";
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //This is the method that will send the request when the request button is clicked
        private void btnSend_Click(object sender, EventArgs e)
        {
            var priorityID = ((Priority)cbPriority.SelectedItem).ID;
            var emDesc = tbEMDes.Text;
            var otherCon = tbOtherCons.Text;

            using(var db = new KNSession2Entities())
            {
                var newEMReq = new EmergencyMaintenance()
                {
                    AssetID = assetID,
                    PriorityID = priorityID,
                    DescriptionEmergency = emDesc,
                    OtherConsiderations = otherCon,
                    EMReportDate = DateTime.Now,
                    EMStartDate = DateTime.Now,
                    EMEndDate = null,
                    EMTechnicianNote = null
                };
                db.EmergencyMaintenances.Add(newEMReq);

                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Your request has been successfully made");
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Oops, an Error occured while sending the request");
                }

            }

        }
    }
}
