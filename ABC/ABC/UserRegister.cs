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
using DAL.DTO;

namespace ABC
{
    public partial class frmUserRegister : Form
    {
        string usr_id;
        public frmUserRegister()
        {
            InitializeComponent();
        }
       
        private void frmUserRegister_Load(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool chkstat;
            tbl_user_master customer = new tbl_user_master();
            customer.user_id = Convert.ToInt32(txtUsrid.Text);
            customer.user_name = txtUname.Text;
            customer.password = txtPword.Text;
            customer.f_name = txtFname.Text;
            customer.l_name = txtLname.Text;
            customer.address = txtAddress.Text;
            customer.nic_no = txtNicno.Text;
            if (chkBoxstat.CheckState == CheckState.Checked)
            {
                chkstat = true;
            }
            else
            {
                chkstat = false;
            }
            customer.is_active = chkstat;
            CustomerBLL.UpdateCustomer(customer);
            MessageBox.Show("Customer Record Updated Successful...", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
            //DisplayData();
           
        }
        private void DisplayData()
        {

            List<tbl_user_master> customerDetails = new List<tbl_user_master>();
            customerDetails = CustomerBLL.GetCustomers();
            frmUserRegister userRegister = new frmUserRegister();

            userRegister.Show();
        }
    }
}
