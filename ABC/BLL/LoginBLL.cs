using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
//using DAL.DAO;

namespace BLL
{
    public class LoginBLL
    {
        public static List<string>UserValidate(string uname, string pword)
        {
            var userDetails = new List<string>();
            List<tbl_user_master> userList = new List<tbl_user_master>();
            userList = CustomerDAO.GetCustomers();
            foreach (tbl_customer customer in customerList)
            {
                if (un == customer.customer_username && pw == customer.customer_password)
                {
                    customerDetails.Add(customer.customer_id.ToString());
                    customerDetails.Add(customer.customer_first_name);
                    customerDetails.Add(customer.customer_last_name);

                }
            }
            return customerDetails;
        }
    }
    }
}
