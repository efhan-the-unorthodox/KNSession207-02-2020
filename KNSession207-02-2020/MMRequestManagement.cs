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
    public partial class MMRequestManagement : Form
    {
        public MMRequestManagement()
        {
            InitializeComponent();
        }

        private void MMRequestManagement_Load(object sender, EventArgs e)
        {
            //get all emergency maintenance reqeusts
            using (var db = new KNSession2Entities())
            {
                var emrequestList = (from a in db.EmergencyMaintenances
                                     where a.EMEndDate == null
                                     orderby a.PriorityID descending
                                     orderby a.EMReportDate ascending
                                     select new { a }).ToList();

                dgvEMRequests.Rows.Clear();
                foreach (var req in emrequestList)
                {
                    var fullName = req.a.Asset.Employee.FirstName + " " + req.a.Asset.Employee.LastName;
                    object[] reqrow = new object[]
                    {
                        req.a.Asset.AssetSN,
                        req.a.Asset.AssetName,
                        req.a.EMReportDate.ToString("dd/MM/yyyy"),
                        fullName,
                        req.a.Asset.DepartmentLocation.Department.Name,
                        req.a.ID
                    };
                    dgvEMRequests.Rows.Add(reqrow);
                }
            }
        }

        private void btnManageReq_Click(object sender, EventArgs e)
        {
            //get the maintainence request number
            var emRequestID = Convert.ToInt64(dgvEMRequests.CurrentRow.Cells[5].Value);

            var manageRequest = new EMRequestDetails(emRequestID);
            this.Hide();
            manageRequest.ShowDialog();
            this.Show();
            MMRequestManagement_Load(sender, e);
        }
    }
}
