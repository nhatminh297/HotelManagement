using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DTO
{
    public class DV
    {
        private int iD;
        private string loaiDV;
        private string tenDV;
        private decimal giaDV;

        public int ID { get => iD; set => iD = value; }
        public string LoaiDV { get => loaiDV; set => loaiDV = value; }
        public string TenDV { get => tenDV; set => tenDV = value; }
        public decimal GiaDV { get => giaDV; set => giaDV = value; }

        public DV() { }
        public DV(int iD, string loaiDV, string tenDV, decimal giaDV)
        {
            ID = iD;
            LoaiDV = loaiDV;
            TenDV = tenDV;
            GiaDV = giaDV;
        }

        public DV(DataRow row)
        {
            ID = (int)row["ID"];
            LoaiDV = row["LoaiDV"].ToString();
            TenDV = row["TenDV"].ToString();
            GiaDV = (decimal)row["GiaDV"];
        }
    }
}
