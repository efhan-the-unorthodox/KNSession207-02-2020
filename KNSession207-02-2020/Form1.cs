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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //login into EM management
            var username = tbUsername.Text;
            var password = tbPassword.Text;

            using(var db = new KNSession2Entities())
            {
                if(username.Length == 0 || password.Length == 0)
                {
                    MessageBox.Show("Please Type in valid Credentials");
                }

                else
                {
                    //user authentication, check if user exists in the database first
                    var userDetails = db.Employees.Where(a => a.Username == username).FirstOrDefault();
                    if (userDetails != null)
                    {
                        if(userDetails.Password == password)
                        {
                            GlobalVariables.empID = userDetails.ID;
                            GlobalVariables.username = userDetails.Username;
                            if(userDetails.isAdmin == true)
                            {
                                var launchAdmin = new MMRequestManagement();
                                this.Hide();
                                launchAdmin.ShowDialog();
                                this.Show();
                            }
                            else
                            {
                                var launchAP = new EMManagement();
                                this.Hide();
                                launchAP.ShowDialog();
                                this.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username");
                    }
                }

                

            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
