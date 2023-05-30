using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DTO
{
    public class Bill
    {
        private int iD;
        private int makh;
        private int manv;
        private int maphong;
        private int sophong;
        private string tenloaiphong;
        private decimal giamoigio;
        private DateTime checkin;
        private DateTime checkout;
        private decimal prices;
        private string trangthai;

        public int ID { get => iD; set => iD = value; }
        public int Makh { get => makh; set => makh = value; }
        public int Maphong { get => maphong; set => maphong = value; }
        public int Sophong { get => sophong; set => sophong = value; }
        public string Tenloaiphong { get => tenloaiphong; set => tenloaiphong = value; }
        public decimal Giamoigio { get => giamoigio; set => giamoigio = value; }
        public DateTime Checkin { get => checkin; set => checkin = value; }
        public DateTime Checkout { get => checkout; set => checkout = value; }
        public decimal Prices { get => prices; set => prices = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
        public int Manv { get => manv; set => manv = value; }

        public Bill(int id, int makh, 
                    int maphong,int sophong, 
                    string tenloaiphong,decimal giamoigio,
                    DateTime checkin,DateTime checkout,
                    decimal prices, string trangthai)
        { 
            this.ID=id;
            this.Makh=makh;
            this.Maphong = maphong;
            this.Sophong = sophong;
            this.Tenloaiphong=tenloaiphong;
            this.Giamoigio=giamoigio;
            this.Checkin=checkin;
            this.Checkout=checkout;
            this.Prices=prices;
            this.Trangthai=trangthai;

        }

        public Bill(){}

        public Bill(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.Makh = (int)row["MaKH"];
            this.Manv = (int)row["MANV"];
            this.Maphong = (int)row["MaPhong"];
            this.Sophong = (int)row["SoPhong"];
            this.Tenloaiphong = row["TenLoaiPhong"].ToString();
            this.Giamoigio = (decimal)row["GiaMoiGio"];
            this.Checkin = Convert.ToDateTime(row["Checkin"]);
            this.Checkout = Convert.ToDateTime(row["Checkout"]);
            this.Prices = (decimal)row["Prices"];
            this.Trangthai = row["TrangThai"].ToString();
        }

    }
}
