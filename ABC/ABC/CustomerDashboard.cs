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
    public partial class frmCustomerDashboard : Form
    {
        public frmCustomerDashboard()
        {
            InitializeComponent();
        }

        private void frmCustomerDashboard_Load(object sender, EventArgs e)
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
    }
}
