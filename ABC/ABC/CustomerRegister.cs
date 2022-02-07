using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace ABC
{
    public partial class frmCustomerRegister : Form
    {
        string nicNo;
        public frmCustomerRegister()
        {
            InitializeComponent();
        }

     
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin login = new frmLogin();
            login.Show();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUname.Clear();
            txtPword.Clear();
            txtFname.Clear();
            txtLname.Clear();
            txtAddress.Clear();
            txtNicno.Clear();

                
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

           string uname =txtUname.Text;
            string pword =txtPword.Text;
            string fname =txtFname.Text;
            string lname =txtLname.Text;
            string address =txtAddress.Text;
            string nicno =txtNicno.Text;
            bool stat = true;

            if (uname.Trim() == "" && pword.Trim() == "" && fname.Trim() == "" && lname.Trim() == "" && address.Trim() == "" && nicno.Trim() == "")
            {
                MessageBox.Show("Please Fill all to register...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                List<string> userDetails = BLL.CustomerBLL.nicValidate(nicno);
                foreach (var userDetail in userDetails)
                {
                    nicNo = Convert.ToString(userDetails[0]);
                }

                if(nicNo == nicno)
                {
                    MessageBox.Show("This user Already Registed please contact Administrator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    
                    tbl_user_master customer = new tbl_user_master();
                    customer.user_name = uname;
                    customer.password = pword;
                    customer.f_name = fname;
                    customer.l_name = lname;
                    customer.address = address;
                    customer.nic_no = nicno;
                    customer.is_active = stat;
                    customer.role_id = 2;
                    CustomerBLL.Addcustomer(customer);
                    
                    MessageBox.Show("New Account Created...", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtUname.Clear();
                    txtPword.Clear();
                    txtFname.Clear();
                    txtLname.Clear();
                    txtAddress.Clear();
                    txtNicno.Clear();
                    txtUname.Focus();

                }

            }



            }
    }
}
