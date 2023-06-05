using QLKS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public string GetRole(string username, string password)
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

        public int GetID(string username, string password)
        {
            string query = "select id from nhanvien where UserName = '" + username + "' and Password = '" + password + "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            if (result.Rows.Count > 0)
            {
                int id = (int)result.Rows[0]["id"];
                return id;
            }

            return -1;
        }

        public string GetNameFromID(int ID)
        {
            string query = "select HoTen from nhanvien where ID = '"+ID+"'";
            DataTable res = DataProvider.Instance.ExecuteQuery(query);
            if(res.Rows.Count > 0)
            {
                string name = res.Rows[0]["hoten"].ToString();
                return name;
            }
            return "";
        }

        public List<Accounts> GetAllAccount()
        {
            List<Accounts> list = new List<Accounts>();
            string query = "select * from NhanVien";
            DataTable resTable = DataProvider.Instance.ExecuteQuery(query);
            if(resTable.Rows.Count > 0)
            {
                foreach(DataRow row in resTable.Rows)
                {
                    Accounts account = new Accounts(row);
                    list.Add(account);
                }
            }
            return list;
        }

        public int DeleteAccounts(int ID)
        {
            string query = "DELETE FROM Nhanvien WHERE ID = "+ID;
            int rowaffect = DataProvider.Instance.ExecuteNonQuery(query);
            return rowaffect;
        }

        public int AddAccounts(Accounts acc)
        {
            string query = "INSERT INTO NhanVien (HoTen, Username, Password, DienThoai, DiaChi, Role) " +
                "VALUES ( @HoTen , @Username , @Password , @DienThoai , @DiaChi , @Role )";
            int rowaffect = DataProvider.Instance.ExecuteNonQuery(query, 
                            new object[] { acc.HoTen, acc.Username, acc.Password, acc.DienThoai , acc.DiaChi, acc.Role});
            return rowaffect;
        }

       public int UpdateAccounts(Accounts acc)
        {
            string query = "UPDATE NhanVien SET HoTen = @HoTen , " +
                "Username = @Username , Password = @Password ," +
                "DienThoai = @DienThoai , DiaChi = @DiaChi ," +
                "Role = @Role WHERE ID = @ID ";

            int rowaffect = DataProvider.Instance.ExecuteNonQuery(query,
                        new object[] { acc.HoTen, acc.Username, acc.Password, acc.DienThoai, acc.DiaChi, acc.Role });
            return rowaffect;

        }

        public int UpdateUsername_password(int manv, string username, string password, string role)
        {
            string query = "UPDATE NhanVien SET " +
                                "Username = @NewUsername ," +
                                "Password = @NewPassword ," +
                                "role = @role " +
                            "WHERE ID = @ID ";
            int rowaffect = DataProvider.Instance.ExecuteNonQuery(query,
                       new object[] {username, password, role, manv});
            return rowaffect;
        }

        public bool IsExistsUsername(string username)
        {
            string query = "select * from nhanvien where username = '" + username+"'";
            int rowaffect = DataProvider.Instance.ExecuteNonQuery(query);
            if (rowaffect == 0)
            {
                return false;
            }
            return true;
        }

    }
}
