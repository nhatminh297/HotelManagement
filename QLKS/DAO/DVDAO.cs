using QLKS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DAO
{
    public class DVDAO
    {
        private static DVDAO instance;

        public static DVDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DVDAO();
                return DVDAO.instance;
            }
            private set
            {
                DVDAO.instance = value;
            }
        }
        private DVDAO() { }

        public List<DV> GetAvailableServices()
        {
            List<DV> dsDV = new List<DV>();

            string query = "select * from DV";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                DV phong = new DV(row);
                dsDV.Add(phong);
            }

            return dsDV;
        }

        public List<DV> GetAllDV()
        {
            List<DV> lstDV = new List<DV>();

            string query = "select * from DV";
            DataTable res = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in res.Rows)
            {
                DV dv = new DV(row);
                lstDV.Add(dv);
            }
            return lstDV;
        }

        public int AddDV(DV dv)
        {
            string query = "INSERT INTO DV (LoaiDV, TenDV, GiaDV) VALUES ( @LoaiDV , @TenDV , @GiaDV )";
            int rowAffect = DataProvider.Instance.ExecuteNonQuery(query, new object[] {dv.LoaiDV, dv.TenDV, dv.GiaDV});
            return rowAffect;
        }

        public int UpdateDV(DV dv)
        {
            string query = "UPDATE DV SET TenDV = @TenDV , GiaDV = @GiaDV , LoaiDV = @LoaiDV WHERE ID = @ID ";
            int row = DataProvider.Instance.ExecuteNonQuery(query, new object[] {dv.TenDV, dv.GiaDV, dv.LoaiDV, dv.ID});
            return row;
        }

        public void DeleteDV(int maDV)
        {
            string query = "DELETE FROM DV WHERE ID = @ID ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { maDV });

        }
    }
}
