using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace QLKS
{
    internal class Modify
    {
        public Modify() { }
        SqlCommand sqlCommand;//dung truy van CRUD
        SqlDataReader reader;//doc du lieu trong database
        public List<Account> accounts(string query)//lay danh sach  account
        {
            List<Account> accounts = new List<Account>();
            using(SqlConnection sqlConnection=Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                reader=sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    accounts.Add(new Account(reader.GetString(0), reader.GetString(5)));
                }
                sqlConnection.Close();
            }
            return accounts;
        }

        public string role(string query)//lay role tk
        {
            string role;
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand=new SqlCommand(query, sqlConnection);
                {
                    role = sqlCommand.ExecuteScalar().ToString();//
                }
                return role;
            }
                
        }
        public void Command(string query)//dung tao account
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();//truy van
                sqlConnection.Close();
            }
        }
    }
}
