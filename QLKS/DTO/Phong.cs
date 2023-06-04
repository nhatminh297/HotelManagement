using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DTO
{
    public class Phong
    {
        private int iD;
        private int soPhong;
        private string tenLoaiPhong;
        private decimal giaMoiGio;
        private int sucChua;
        private string moTa;
        private string trangThai;

        public int ID { get => iD; set => iD = value; }
        public int SoPhong { get => soPhong; set => soPhong = value; }
        public string TenLoaiPhong { get => tenLoaiPhong; set => tenLoaiPhong = value; }
        public decimal GiaMoiGio { get => giaMoiGio; set => giaMoiGio = value; }
        public int SucChua { get => sucChua; set => sucChua = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }

        public Phong() { }

        public Phong(int iD, int soPhong, string tenLoaiPhong, decimal giaMoiGio, int sucChua, string moTa, string trangThai)
        {
            this.ID = iD;
            this.SoPhong = soPhong;
            this.TenLoaiPhong = tenLoaiPhong;
            this.GiaMoiGio = giaMoiGio;
            this.SucChua = sucChua;
            this.MoTa = moTa;
            this.TrangThai = trangThai;
        }

        public Phong(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.SoPhong = (int)row["SoPhong"];
            this.TenLoaiPhong = row["TenLoaiPhong"].ToString();
            this.GiaMoiGio = (decimal)row["GiaMoiGio"];
            this.MoTa = row["Mota"].ToString();
            this.TrangThai = row["TrangThai"].ToString();
            this.SucChua = (int)row["SucChua"];
        }
    }
}
