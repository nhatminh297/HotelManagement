using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DTO
{
    public class SvBill
    {
        private int id;
        private int mahd;
        private string tendv;
        private decimal dongia;
        private int soluong;
        private decimal prices;

        public int Id { get => id; set => id = value; }
        public int Mahd { get => mahd; set => mahd = value; }
        public string Tendv { get => tendv; set => tendv = value; }
        public decimal Dongia { get => dongia; set => dongia = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public decimal Prices { get => prices; set => prices = value; }

        public SvBill() { }
        public SvBill(int id, int mahd, string tendv, decimal dongia, int soluong, decimal prices)
        {
            Id = id;
            Mahd = mahd;
            Tendv = tendv;
            Dongia = dongia;
            Soluong = soluong;
            Prices = prices;
        }
        public SvBill(DataRow row)
        {
            Id = (int)row["ID"];
            Mahd = (int)row["mahd"];
            Tendv = row["tendv"].ToString();
            Dongia = (decimal)row["dongia"];
            Soluong = (int)row["soluong"];
            Prices = (decimal)row["prices"];
        }
    }
}
