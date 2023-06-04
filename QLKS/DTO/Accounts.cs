using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DTO
{
    public class Accounts // nhanvien
    {
        public Accounts() { }

        private int iD;
        private string hoTen;
        private string username;
        private string password;
        private string dienThoai;
        private string diaChi;
        private string role;

        public int ID { get => iD; set => iD = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Role { get => role; set => role = value; }

        public Accounts(int iD, string hoTen, string username, string password, string dienThoai, string diaChi, string role)
        {
            ID = iD;
            HoTen = hoTen;
            Username = username;
            Password = password;
            DienThoai = dienThoai;
            DiaChi = diaChi;
            Role = role;
        }

        public Accounts(DataRow row)
        {
            ID = (int)row["id"];
            HoTen = row["hoten"].ToString();
            Username = row["username"].ToString();
            Password = row["password"].ToString();
            DienThoai = row["dienThoai"].ToString();
            DiaChi = row["DiaChi"].ToString();
            Role = row["role"].ToString();
        }
        
    }
}
