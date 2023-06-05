using QLKS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Management.Instrumentation;
using System.Security.RightsManagement;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Globalization;

namespace QLKS.DAO
{
    public class KhachHangDAO
    {
        private static KhachHangDAO instance;
        public static KhachHangDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachHangDAO();
                return KhachHangDAO.instance;
            }
            private set
            {
                KhachHangDAO.instance = value;
            }
        }
        private KhachHangDAO() { }

        public string GetNameFromID(int id)
        {
            DataTable Hoten = DataProvider.Instance.ExecuteQuery("select hoten from KhachHang where id="+id);
            DataRow name = Hoten.Rows[0];
            return name["hoten"].ToString();
        }

        public KhachHang getKHfromCCCD(string cccd)
        {
            string query = "select * from KhachHang where cccd = '" + cccd + "'";
            DataTable res = DataProvider.Instance.ExecuteQuery(query);
            if (res.Rows.Count > 0)
            {
                DataRow row = res.Rows[0];
                KhachHang kh = new KhachHang(row);
                return kh;
            }
            return null;
        }

        public int getidbycccd(string cccd)
        {
            string query = "select id from KhachHang where cccd = '" + cccd + "'";
            DataTable res = DataProvider.Instance.ExecuteQuery(query);
            if (res.Rows.Count > 0)
            {
                DataRow row = res.Rows[0];
                int id = (int)row["ID"];
                return id;
            }
            return -1;
        }

        
        public KhachHang GetKhachHangByID(int id)
        {
            string query = "select * from KhachHang where id = '" + id.ToString() + "'";
            DataTable res = DataProvider.Instance.ExecuteQuery(query);
            if(res.Rows.Count > 0)
            {
                DataRow row = res.Rows[0];
                KhachHang kh = new KhachHang(row);
                return kh;
            }
            return null;
        }

        public bool isValidKH(KhachHang kh)
        {
            if (kh.HoTen.Length >= 6 && kh.CCCD.Length == 12 && kh.DienThoai.Length == 11 && kh.DienThoai.StartsWith("84"))
            {
                string emailPattern = @"^[a-zA-Z0-9]+@gmail\.com$";
                if (!Regex.IsMatch(kh.Email, emailPattern))
                {
                    return false;
                }

                return true;
            }
            return false;
            
        }

        public string ResetFullName(string name)
        {
            TextInfo textInfo = new CultureInfo("vi-VN", false).TextInfo;
            string properCase = textInfo.ToTitleCase(name.ToLower());
            string[] words = properCase.Split(' ');
            string firstName = words[0];
            string lastName = string.Join(" ", words.Skip(1));
            firstName = char.ToUpper(firstName[0]) + firstName.Substring(1).ToLower();
            TextInfo nameInfo = new CultureInfo("en-US", false).TextInfo;
            lastName = nameInfo.ToTitleCase(lastName);
            string fullName = firstName + " " + lastName;
            return fullName;
        }

        public int IsExists(KhachHang kh)
        {
            string cccd = kh.CCCD;
            string getname = "select hoten from KhachHang where cccd = '" + cccd + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(getname);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                if(ResetFullName(kh.HoTen) == row["hoten"].ToString())
                {
                    return 1; // trùng cccd, trùng tên
                }
                else
                {
                    return -1;// cùng cccd mà khác tên
                }
            }
            return 0;// chưa có trong database

        }

        public bool IsExistsByCCCD(string cccd)
        {
            string getkh = "select * from KhachHang where cccd = '" + cccd + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(getkh);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;// chưa có trong database

        }


        public int AddKhachHang(KhachHang kh)
        {
            if (isValidKH(kh))
            {
                if(IsExists(kh) == 0)// chưa tồn tại
                {
                    string query = "INSERT INTO KhachHang (HoTen, CCCD, DienThoai, Email, DiaChi) VALUES ( @hoTen , @cccd , @dienThoai , @email , @diaChi )";
                    DataProvider.Instance.ExecuteQuery(query, new object[] { ResetFullName(kh.HoTen), kh.CCCD, kh.DienThoai, kh.Email, kh.DiaChi });
                    return 1;
                }else if (IsExists(kh) == -1)
                {
                    return -1;
                }
            }
            return 0;
        }

        public bool UpdateKH(KhachHang kh)
        {
            if (isValidKH(kh))
            {
                int check = IsExists(kh);
                if (check == 1 || check == -1)
                {
                    string query = "UPDATE KhachHang SET HoTen = @hoTen , DienThoai = @dienThoai , DiaChi = @diaChi , email = @email , CCCD = @cccd WHERE ID = @ID ";
                    DataProvider.Instance.ExecuteQuery(query, new object[] { ResetFullName(kh.HoTen), kh.DienThoai, kh.DiaChi, kh.Email, kh.CCCD, kh.ID });
                }
                else
                {
                    string query = "INSERT INTO KhachHang (HoTen, CCCD, DienThoai, Email, DiaChi) VALUES ( @hoTen , @cccd , @dienThoai , @email , @diaChi )";
                    DataProvider.Instance.ExecuteQuery(query, new object[] { ResetFullName(kh.HoTen), kh.CCCD, kh.DienThoai, kh.Email, kh.DiaChi });
                }
                return true;
            }
            return false;
        }

        public List<KhachHang> GetAllkhachHang()
        {
            List<KhachHang> lstkhachhang = new List<KhachHang>();

            string query = "select * from KhachHang";
            DataTable res = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in res.Rows)
            {
                KhachHang kh = new KhachHang(row);
                lstkhachhang.Add(kh);
            }
            return lstkhachhang;
        }
    }
}
