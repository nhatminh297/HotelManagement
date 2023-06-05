using QLKS.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.Models
{
    public struct RevenueByDate
    {
        public string Date { get; set; }
        public decimal TotalAmount { get; set; }
    }

    public class Dashboard
    {
        //Fields & Properties
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;
        public int NumCustomers { get; private set; }
        public int NumRooms { get; private set; } // suppliers
        public int NumServices { get; private set; } //products
        public List<KeyValuePair<string, int>> TopServicesList { get; private set; }
        public List<KeyValuePair<string, int>> LowServiceslist { get; private set; }

        public List<KeyValuePair<string, int>> TopRoomTypeList { get; private set; }
        public List<RevenueByDate> GrossRevenueList { get; private set; }
        public int NumHoadon { get; set; } // Order
        public int NumSvBill { get; set; }  
        public decimal TotalRevenue { get; set; }
        public decimal TotalProfit { get; set; }
        //Constructor
        public Dashboard()
        {

        }

        // private methods

        private void GetNumberItems()
        {
            var command = new SqlCommand();
            string query = "select count(id) from khachhang";
            NumCustomers = (int)DataProvider.Instance.ExecuteScalar(query);
            //Get Total Number of Rooms
            query = "select count(id) from Phong";
            NumRooms = (int)DataProvider.Instance.ExecuteScalar(query);
            //Get Total Number of Services
            query = "select count(id) from DV";
            NumServices = (int)DataProvider.Instance.ExecuteScalar(query);
            //Get Total Number of Bills
            query = "select count(id) from [hoadon]" +
                                    "where Checkout between  @fromDate and @toDate ";
            NumHoadon = (int)DataProvider.Instance.ExecuteScalar(query, new object[] {startDate, endDate});
            query = "select id from [hoadon] where Checkout between  @fromDate and @toDate ";
            DataTable restable = DataProvider.Instance.ExecuteQuery(query, new object[] { startDate, endDate });
            NumSvBill = 0;
            foreach (DataRow row in restable.Rows)
            {
                NumSvBill += (int)row["ID"];
            }
        }

        private void GetBillsAnalisys()
        {
            GrossRevenueList = new List<RevenueByDate>();
            TotalProfit = 0;
            TotalRevenue = 0;
            string query = "select checkin , sum(prices) as total from HoaDon " +
                                "where Checkout between  @fromDate and @toDate " +
                                "group by checkin";
            DataTable datatable = DataProvider.Instance.ExecuteQuery( query, new object[] { startDate, endDate });
            var resultTable = new List<KeyValuePair<DateTime, decimal>>();
            foreach(DataRow row in datatable.Rows)
            {
                resultTable.Add(
                    new KeyValuePair<DateTime, decimal>((DateTime)row[0], (decimal)row[1])
                    );
                TotalRevenue += (decimal)row[1];
            }
            TotalProfit = TotalRevenue * 0.2m;//20%

            //Group by Hours
            if (numberDays <= 1)
            {
                GrossRevenueList = (from orderList in resultTable
                                    group orderList by orderList.Key.ToString("hh tt")
                                    into order
                                    select new RevenueByDate
                                    {
                                        Date = order.Key,
                                        TotalAmount = order.Sum(amount => amount.Value)
                                    }).ToList();
            }
            //Group by Days
            else if (numberDays <= 30)
            {
                GrossRevenueList = (from orderList in resultTable
                                    group orderList by orderList.Key.ToString("dd MMM")
                                    into order
                                    select new RevenueByDate
                                    {
                                        Date = order.Key,
                                        TotalAmount = order.Sum(amount => amount.Value)
                                    }).ToList();
            }
            //Group by Weeks
            else if (numberDays <= 92)
            {
                GrossRevenueList = (from orderList in resultTable
                                    group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                        orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                    into order
                                    select new RevenueByDate
                                    {
                                        Date = "Week " + order.Key.ToString(),
                                        TotalAmount = order.Sum(amount => amount.Value)
                                    }).ToList();
            }
            //Group by Months
            else if (numberDays <= (365 * 2))
            {
                bool isYear = numberDays <= 365 ? true : false;
                GrossRevenueList = (from orderList in resultTable
                                    group orderList by orderList.Key.ToString("MMM yyyy")
                                    into order
                                    select new RevenueByDate
                                    {
                                        Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                        TotalAmount = order.Sum(amount => amount.Value)
                                    }).ToList();
            }
            //Group by Years
            else
            {
                GrossRevenueList = (from orderList in resultTable
                                    group orderList by orderList.Key.ToString("yyyy")
                                    into order
                                    select new RevenueByDate
                                    {
                                        Date = order.Key,
                                        TotalAmount = order.Sum(amount => amount.Value)
                                    }).ToList();
            }
        }

        private void GetServicesAnalisys()
        {
            TopServicesList = new List<KeyValuePair<string, int>>();
            LowServiceslist = new List<KeyValuePair<string, int>>();

            //Get Top 5 products
            int count = 7;
            string query = "select top ( @top_count ) tendv, sum(SoLuong) as sl " +
                                        " from BillServices svbill, HoaDon hd " +
                                    " where hd.ID = svbill.mahd " +
                                    " and Checkout between  @fromDate and @toDate " +
                                    " group by TenDV " +
                                    " order by sl desc";
            DataTable datatable = DataProvider.Instance.ExecuteQuery(query, new object[] {count, startDate, endDate });
            foreach(DataRow row in datatable.Rows)
            {
                TopServicesList.Add(
                    new KeyValuePair<string, int>(row[0].ToString(), (int)row[1]));
            }

            //Get LowServiceslist
            query = "select top ( @top_count ) tendv, sum(SoLuong) as sl " +
                    " from BillServices svbill, HoaDon hd" +
                    " where hd.ID = svbill.mahd" +
                    " group by TenDV " +
                    " order by sl asc";
            count = 5;
            DataTable datatable2 = DataProvider.Instance.ExecuteQuery(query, new object[] {count});
            foreach (DataRow row in datatable2.Rows)
            {
                LowServiceslist.Add(
                    new KeyValuePair<string, int>(row[0].ToString(), (int)row[1]));
            }
        }
        
        private void GetRoomsAnalisys()
        {
            TopRoomTypeList = new List<KeyValuePair<string, int>>();

            string query = "select tenloaiphong, count(*) from hoadon " +
                " where Checkout between @fromDate and @toDate " +
                " group by TenLoaiPhong";
            DataTable datatable = DataProvider.Instance.ExecuteQuery(query, new object[] { startDate, endDate });
            int total = 0;
            foreach (DataRow row in datatable.Rows)
            {
                TopRoomTypeList.Add(
                    new KeyValuePair<string, int>(row[0].ToString(), (int)row[1]));
                total += (int)row[1];

            }

        }

        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day,
                endDate.Hour, endDate.Minute, 59);
            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;
                GetNumberItems();
                GetBillsAnalisys();
                GetServicesAnalisys();
                GetRoomsAnalisys();
                Console.WriteLine("Refreshed data: {0} - {1}", startDate.ToString(), endDate.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Data not refreshed, same query: {0} - {1}", startDate.ToString(), endDate.ToString());
                return false;
            }
        }
    }
}
