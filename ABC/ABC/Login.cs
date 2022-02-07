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

    public partial class frmLogin : Form
    {
        int userId;
        int userRoleId;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            timer1.Start();
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
                List<string> uDetails = BLL.LoginBLL.UserValidate(uname, pword);
                foreach (var uDetail in uDetails)
                {
                    userId = Convert.ToInt32(uDetails[0]);
                    userRoleId = Convert.ToInt32(uDetails[1]);
                    usrDetails = string.Join(" ", uDetails[2], uDetails[3]);
                }
                if (userRoleId == 1)
                {
                    MessageBox.Show("Wellcome" +" "+ usrDetails);
                    frmAdminDashboard adminpanel = new frmAdminDashboard();
                    this.Hide();
                    adminpanel.Show();
                }
                else if(userRoleId == 2)
                {
                    MessageBox.Show("Wellcome" +"  "+ usrDetails);
                    frmCustomerDashboard customerpanel = new frmCustomerDashboard();
                    this.Hide();
                    customerpanel.Show();
                }
                else
                {
                    MessageBox.Show("You havent Registerd Yet..please Register" ,"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            frmCustomerRegister cusregisterfrm = new frmCustomerRegister();
            this.Hide();
            cusregisterfrm.Show();
;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            DateTime dateTime = DateTime.Now;
            lbldatetime.Text = dateTime.ToString();
            timer1.Start();
        }
    }
}


