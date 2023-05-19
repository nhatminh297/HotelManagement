using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLKS
{
    internal class Connection
    {
        private static string _connectionString= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CNPM\QLKS\Database1.mdf;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
