using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.DAO;

namespace BLL
{
    public class LoginBLL
    {
        public static object lstUserData { get; set; }

        public static List<string>UserValidate(string uname, string pword)
        {
            var userDetails = new List<string>();
            List<tbl_user_master> userList = new List<tbl_user_master>();
            userList = LoginDAO.GetTbl_User_Masters();
            foreach (tbl_user_master user in userList)
            {
                if (uname == user.user_name && pword == user.password)
                {
                    userDetails.Add(user.user_id.ToString());
                    userDetails.Add(user.role_id.ToString());
                    userDetails.Add(user.f_name);
                    userDetails.Add(user.l_name);
                    

                }
            }
            return userDetails;
        }
    }
    
}
