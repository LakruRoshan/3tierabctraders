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
    public partial class frmCustomerList : Form
    {
        public frmCustomerList()
        {
            InitializeComponent();
        }
        private void DisplayData(List<tbl_user_master> a)
        {

            //List<string> userDetails = new List<string>();
            //userDetails = CustomerBLL.LoadUserData();

            List<LoginDTO> c = new List<LoginDTO>();

            for (int i = 0; i < a.Count; i++)
            {
                LoginDTO b = new LoginDTO();

                b._user_id = a[i].user_id;
                b._user_name = a[i].user_name;

                c.Add(b);
            }            

            dataGridView1.DataSource = c;
        }
        private void CustomerList_Load(object sender, EventArgs e)
        {
            List<tbl_user_master> userDetails = new List<tbl_user_master>();
            userDetails = CustomerBLL.LoadUserData();

            DisplayData(userDetails);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
