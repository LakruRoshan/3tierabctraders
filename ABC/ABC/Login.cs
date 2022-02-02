using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lbldatetime.Text = dateTime.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string uname = txtUname.Text;
            string pword = txtPword.Text;
            string usrDetails = " ";

            if (uname.Trim() == "" && pword.Trim() == "")
            {
                MessageBox.Show("Please Enter Username and Password to Login...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
               List<string> usrDetails = BLL.LoginBLL.UserValidate(uname, pword);
                foreach (var usrDetails in usrDetails)
                {
                    userId = Convert.ToInt32(adminDetails[0]);
                    userDetails = string.Join(" ", adminDetails[1], adminDetails[2]);
                    //userDetails = string.Join(",", adminDetails.ToArray());
                }
                
                if(userDetails != " ")
                {
                    //MessageBox.Show(userDetails, "Output", MessageBoxButtons.OK);
                    this.Hide();
                    AdminMainMenuUI adminMainMenu = new AdminMainMenuUI(userId, userDetails);
                    adminMainMenu.ShowDialog();
                }
                else
                {
                    List<string> customerDetails = BLL.CustomerBLL.CheckCustomerLogin(username, password);
                    foreach (var customerDetail in customerDetails)
                    {
                        userId = Convert.ToInt32(customerDetails[0]);
                        userDetails = string.Join(" ", customerDetails[1], customerDetails[2]);
                    }

                    if (userDetails != " ")
                    {
                        //MessageBox.Show(userDetails, "Output", MessageBoxButtons.OK);
                        this.Hide();
                        CustomerMainMenuUI customerMainMenu = new CustomerMainMenuUI(userId, userDetails);
                        customerMainMenu.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Invaild Username or Password...", "Error", MessageBoxButtons.OK);
                        txtUname.Clear();
                        txtPword.Clear();
                        txtUname.Focus();
            }
        }
    }
}
