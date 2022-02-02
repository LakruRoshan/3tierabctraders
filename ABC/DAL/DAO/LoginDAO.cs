using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class LoginDAO : ABCDataConnectionContext
    {
        public static List<tbl_user_master> GetTbl_User_Masters()
        {
            return db.tbl_user_masters.ToList();
        }

        public static void AddCustomer(tbl_user_master user)
        {
            try
            {
                db.tbl_user_masters.InsertOnSubmit(user);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void UpdateCustomer(tbl_user_master users)
        {
            try
            {
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static tbl_user_master GetOneCustomer(int user_id)
        {
            return db.tbl_user_masters.Single(users => users.user_id == user_id);
        }

        public static void DeleteCustomer(tbl_user_master customer)
        {
            try
            {
                db.tbl_user_masters.DeleteOnSubmit(customer);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<tbl_user_master> searchUsers(string keyWord)
        {
            var searchResult = (from usr in db.tbl_user_masters where usr.f_name.Contains(keyWord) || usr.l_name.Contains(keyWord) select usr).ToList();
            return searchResult;
        }
    }
}

