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
    public partial class frmAdminDashboard : Form
    {
        public frmAdminDashboard()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            DateTime dateTime = DateTime.Now;
            lbldatetime.Text = dateTime.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lbldatetime.Text = dateTime.ToString();
            timer1.Start();
        }

        private void btnAdminManageCustomers_Click(object sender, EventArgs e)
        {
            frmCustomerList custfrm = new frmCustomerList();
            custfrm.Show();

        }
    }
}
