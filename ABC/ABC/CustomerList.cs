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
        int user_id;
        public frmCustomerList()
        {
            InitializeComponent();
        }
        //method for Display Login Data for Manager User Form
        private void DisplayData(List<tbl_user_master> objlogin)
        {

            //List<string> userDetails = new List<string>();
            //userDetails = CustomerBLL.LoadUserData();

            List<LoginDTO> objloginlist = new List<LoginDTO>();

            for (int i = 0; i < objlogin.Count; i++)
            {
                LoginDTO objlogindto = new LoginDTO();

                objlogindto._user_id = objlogin[i].user_id;
                objlogindto._user_name = objlogin[i].user_name;
                objlogindto._f_name = objlogin[i].f_name;
                objlogindto._l_name = objlogin[i].l_name;
                objlogindto._password = objlogin[i].password;
                objlogindto._address = objlogin[i].address;
                objlogindto._nic_no = objlogin[i].nic_no;
                objlogindto._is_active = (bool)objlogin[i].is_active;
                objloginlist.Add(objlogindto);
            }            

            dataGridView1.DataSource = objloginlist;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //Boolean _stat = dataGridView1.CurrentRow.Cells[5].Value;
            //userRegister.chkBoxstat.Checked(CheckBox.IsCheckedProperty, true);





        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmUserRegister userRegister = new frmUserRegister();
            userRegister.txtUsrid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            userRegister.txtUname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            userRegister.txtFname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            userRegister.txtLname.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            userRegister.txtPword.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            userRegister.txtAddress.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            userRegister.txtNicno.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            Boolean chkstatcheck;
            chkstatcheck = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[7].Value.ToString());
            Boolean checkstat;
            if(chkstatcheck == true)
            {
                userRegister.chkBoxstat.CheckState = CheckState.Checked;
            }
            else
            {
                userRegister.chkBoxstat.CheckState = CheckState.Unchecked;
            }
            
           
            userRegister.Show();

        }
    }
}
