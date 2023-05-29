using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DAO
{
    public class AccountsDAO
    {
        private static AccountsDAO instance;
        public static AccountsDAO Instance
        {
            get { if (instance == null) instance = new AccountsDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountsDAO() { }

        public string Login(string username, string password)
        {
            string query = "select role from nhanvien where UserName = '"+username+"' and Password = '"+password+"'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            if (result.Rows.Count > 0)
            {
                string role = result.Rows[0]["Role"].ToString();
                return role;
            }

            return null;
        }
    }
}
