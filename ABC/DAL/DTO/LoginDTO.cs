using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class LoginDTO
    {
		public int _user_id { get; set; }

		public string _user_name { get; set; }

		public string _password { get; set; }

		//public int _role_id { get; set; }

		public string _f_name { get; set; }

		public string _l_name { get; set; }

		public string _address { get; set; }
		public bool _is_active { get; set; }
		public string _nic_no { get; set; }


	}

}
