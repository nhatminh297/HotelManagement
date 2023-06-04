using QLKS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DAO
{
    public class SvBillDAO
    {
        private static SvBillDAO instance;

        public static SvBillDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new SvBillDAO();
                return SvBillDAO.instance;
            }
            private set
            {
                SvBillDAO.instance = value;
            }
        }
        private SvBillDAO() { }

        public void AddSvBill(SvBill svBill)
        {
            string query = "INSERT INTO BillServices (MAHD, TenDV, DonGia, SoLuong, Prices) " +
                   "VALUES ( @MAHD , @TenDV , @DonGia , @SoLuong , @Prices );";

            DataProvider.Instance.ExecuteQuery(query, new object[] { svBill.Mahd, svBill.Tendv, svBill.Dongia, svBill.Soluong, svBill.Prices});
        }

        public List<SvBill> GetSelectedSvBills(int idhd)
        {
            List<SvBill> svBillList = new List<SvBill>();

            string query = "select * from BillServices where mahd = " + idhd;
            DataTable res = DataProvider.Instance.ExecuteQuery(query);
            
            foreach (DataRow row in res.Rows)
            {
                SvBill svBill = new SvBill(row);
                svBillList.Add(svBill);
            }
            return svBillList;
        }

        public void deleteSvBill(int idhd)
        {
            string query = "DELETE FROM BillServices WHERE mahd = " + idhd;
            DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
