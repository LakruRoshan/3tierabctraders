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
        int userId;
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

            //MessageBox.Show("1");

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
                    usrDetails = string.Join(" ", uDetails[1], uDetails[2]);
                    MessageBox.Show("success");
                    //userDetails = string.Join(",", adminDetails.ToArray());
                }

            }
        }
    }
}


