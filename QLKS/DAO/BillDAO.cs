using QLKS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillDAO();
                return BillDAO.instance;
            }
            private set
            {
                BillDAO.instance = value;
            }
        }
        private BillDAO() { }

        public List<Bill> GetUncheckedBills()
        {
            List<Bill> list = new List<Bill>();

            DataTable dataTable = DataProvider.Instance.ExecuteQuery("select * from hoadon where trangthai = N'Chưa thanh toán'");
            foreach (DataRow row in dataTable.Rows)
            {
                Bill bill = new Bill(row);
                list.Add(bill);
            }

            return list;
        }

        public int AddHoaDon(Bill bill)
        {
            string query = "INSERT INTO HoaDon (MaKH, MANV, MaPhong, SoPhong, TenLoaiPhong, GiaMoiGio, Checkin, Checkout, Prices, TrangThai) " +
               "OUTPUT INSERTED.ID " +
               "VALUES ( @MaKH , @MANV , @MaPhong , @SoPhong , @TenLoaiPhong , @GiaMoiGio , @Checkin , @Checkout , @Prices , @TrangThai );";


            int hoaDonId = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query, new object[] {
                                                bill.Makh, bill.Manv, bill.Maphong, bill.Sophong, bill.Tenloaiphong, 
                                                bill.Giamoigio, bill.Checkin, bill.Checkout, bill.Prices, bill.Trangthai
                                           }));
            return hoaDonId;
        }

        public void UpdateHoadon(Bill bill)
        {
            string query = "UPDATE HoaDon SET MaKH = @MaKH ," +
                                    "MANV = @MANV ," +
                                    "MaPhong = @MaPhong ," +
                                    "SoPhong = @SoPhong ," +
                                    "TenLoaiPhong = @TenLoaiPhong ," +
                                    "GiaMoiGio = @GiaMoiGio ," +
                                    "Checkin = @Checkin ," +
                                    "Checkout = @Checkout ," +
                                    "Prices = @Prices ," +
                                    "TrangThai = @TrangThai " +
                                "WHERE ID = @ID ;";
            DataProvider.Instance.ExecuteQuery(query, new object[] {bill.Makh, bill.Manv, bill.Maphong, bill.Sophong,
                                bill.Tenloaiphong, bill.Giamoigio, bill.Checkin, bill.Checkout, bill.Prices, bill.Trangthai, bill.ID});
        }

        public void DeleteBill(Bill bill)
        {
            PhongDAO.Instance.RentToEmpty(bill.Sophong);
            SvBillDAO.Instance.deleteSvBill(bill.ID);
            string query = "Delete from hoadon where id = " + bill.ID;
            DataProvider.Instance.ExecuteQuery(query);
        }

        public void PayBill(int idbill, int sophong)
        {
            PhongDAO.Instance.RentToEmpty(sophong);
            string query = "UPDATE HoaDon SET TrangThai = N'Đã thanh toán' WHERE ID = '" + idbill + "'";
            DataProvider.Instance.ExecuteQuery(query);
        }

        public Bill GetHoaDonByID(int mahd)
        {
            string query = "select * from HoaDon where id = '" + mahd + "'";
            DataTable res = DataProvider.Instance.ExecuteQuery(query);
            Bill bill = null;
            if (res.Rows.Count > 0)
            {
                bill = new Bill(res.Rows[0]);
            }
            return bill;
        }

    }
}
