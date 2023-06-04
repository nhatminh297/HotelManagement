using QLKS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DAO
{
    public class PhongDAO
    {
        private static PhongDAO instance;

        public static PhongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhongDAO();
                return PhongDAO.instance;
            }
            private set
            {
                PhongDAO.instance = value;
            }
        }
        private PhongDAO() { }

        public List<Phong> GetAvailableRoom()
        {
            List<Phong> dsPhong = new List<Phong>();

            string query = "select * from phong where Trangthai = N'Trống'";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            
            foreach (DataRow row in dataTable.Rows)
            {
                Phong phong = new Phong(row);
                dsPhong.Add(phong);
            }

            return dsPhong;
        }

        public void EmptyToRent(Phong phong)
        {

            string query = "update Phong set TrangThai='Đã thuê' where SoPhong = "+phong.SoPhong;
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
        }

        public void RentToEmpty(int sophong)
        {
            if (IsExistsSoPhong(sophong))
            {
                string query = "update Phong set TrangThai= N'Trống' where SoPhong = " + sophong;
                DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            }
        }

        public List<Phong> GetAllPhong()
        {
            List<Phong> lstPhong = new List<Phong>();

            string query = "select * from Phong";
            DataTable res = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in res.Rows)
            {
                Phong phong = new Phong(row);
                lstPhong.Add(phong);
            }
            return lstPhong;
        }

        public bool IsExistsSoPhong(int sophong)
        {
            string query = "SELECT * FROM Phong WHERE SoPhong = '" + sophong + "'";
            DataTable res = DataProvider.Instance.ExecuteQuery(query);
            if (res.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public int AddRoom(Phong phong)
        {
            string query = "INSERT INTO Phong (SoPhong, TenLoaiPhong, GiaMoiGio, SucChua, MoTa, TrangThai) " +
               "VALUES ( @SoPhong , @TenLoaiPhong , @GiaMoiGio , @SucChua , @MoTa , @TrangThai )";
            if (!IsExistsSoPhong(phong.SoPhong))
            {
                int rowAffect = DataProvider.Instance.ExecuteNonQuery(query, new object[] {phong.SoPhong, phong.TenLoaiPhong,
                                phong.GiaMoiGio, phong.SucChua, phong.MoTa, phong.TrangThai});

                return rowAffect;
            }
            return 0;
        }

        public int UpdateRoom(Phong phong)
        {
            string query = "UPDATE Phong SET SoPhong = @SoPhong , " +
                "TenLoaiPhong = @TenLoaiPhong , GiaMoiGio = @GiaMoiGio , " +
                "SucChua = @SucChua , MoTa = @MoTa , TrangThai = @TrangThai WHERE ID = @ID ";
            int row = DataProvider.Instance.ExecuteNonQuery(query, new object[] {phong.SoPhong, phong.TenLoaiPhong, phong.GiaMoiGio, phong.SucChua, phong.MoTa,
                phong.TrangThai, phong.ID });
            return row;
        }

        public void DeleteRoom(int maphong)
        {
            string query = "DELETE FROM Phong WHERE ID = @ID ";
            DataProvider.Instance.ExecuteQuery(query, new object[] {maphong});

        }
    }
}
