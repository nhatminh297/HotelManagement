using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QLKS.DTO
{
    public class KhachHang
    {
        public KhachHang() { }

        private int iD;
        private string cCCD;
        private string hoTen;
        private string dienThoai;
        private string diaChi;
        private string email;

        public int ID { get => iD; set => iD = value; }
        public string CCCD { get => cCCD; set => cCCD = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Email { get => email; set => email = value; }

        public KhachHang(int iD, string cCCD, string hoTen, string dienThoai, string diaChi, string email)
        {
            ID = iD;
            CCCD = cCCD;
            HoTen = hoTen;
            DienThoai = dienThoai;
            DiaChi = diaChi;
            Email = email;
        }

        public KhachHang(DataRow row)
        {
            ID = (int)row["ID"];
            CCCD = row["CCCD"].ToString();
            HoTen = row["HoTen"].ToString();
            DienThoai = row["DienThoai"].ToString();
            DiaChi = row["DiaChi"].ToString();
            Email = row["Email"].ToString();
        }
    }
}
