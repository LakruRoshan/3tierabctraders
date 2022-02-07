using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.DAO;

namespace BLL
{
    public class CustomerBLL
    {
        public static List<string> nicValidate(string nicno)
        {
            var userDetails = new List<string>();
            List<tbl_user_master> userList = new List<tbl_user_master>();
            userList = LoginDAO.searchUsersBYNIC(nicno);
            foreach (tbl_user_master user in userList)
            {
                userDetails.Add(user.nic_no.ToString());
               
            }
            return userDetails;
        }
        public static List<tbl_user_master> GetCustomers()
        {
            return LoginDAO.GetTbl_User_Masters();
        }
        public static List<tbl_user_master> LoadUserData()
        {
            var userDetails = new List<string>();
            List<tbl_user_master> userList = new List<tbl_user_master>();
            userList = LoginDAO.LoadUserData();
            //foreach (tbl_user_master user in userList)
            //{
            //    userDetails.Add(user.user_id.ToString());
            //    userDetails.Add(user.user_name.ToString());
            //    userDetails.Add(user.password.ToString());
            //    userDetails.Add(user.f_name.ToString());
            //    userDetails.Add(user.l_name.ToString());
            //    userDetails.Add(user.address.ToString());
            //    userDetails.Add(user.nic_no.ToString());
            //    userDetails.Add(user.is_active.ToString());
            //    userDetails.Add(user.role_id.ToString());

            //}
            
            return userList;
        }
        public static void Addcustomer(tbl_user_master customer)
        {
            LoginDAO.AddCustomer(customer);
        }

    }
}
