using Guna.UI2.WinForms;
using QLKS.DAO;
using QLKS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class FormCustomers : Form
    {
        public FormCustomers()
        {
            InitializeComponent();
            loadCusTomers();
        }

        private void tbSearchName_Enter(object sender, EventArgs e)
        {
            Guna2TextBox tb = (Guna2TextBox)sender;
            if (tb.Text == "Search Fullname")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }

        private void tbSearchName_Leave(object sender, EventArgs e)
        {
            Guna2TextBox tb = (Guna2TextBox)sender;

            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                tb.Text = "Search Fullname";
                tb.ForeColor = Color.Gray;
            }
        }

        public KhachHang RowToKhachHang(DataGridViewRow row)
        {
            KhachHang kh = new KhachHang();
            kh.ID = (int)row.Cells["colID"].Value;
            kh.CCCD = row.Cells["colCCCD"].Value.ToString();
            kh.HoTen = row.Cells["colName"].Value.ToString();
            kh.DienThoai = row.Cells["colPhone"].ToString();
            kh.DiaChi = row.Cells["colAddress"].Value.ToString();
            kh.Email = row.Cells["colEmail"].Value.ToString();
            return kh;
        }

        public DataGridViewRow KhachHangToRow(KhachHang khachHang)
        {
            DataGridViewRow row = new DataGridViewRow();

            row.CreateCells(guna2DataGridView1, 
                        khachHang.ID, khachHang.CCCD, khachHang.HoTen, 
                        khachHang.DienThoai, khachHang.Email, khachHang.DiaChi
                    ); 
            return row;
        }


        public void loadCusTomers()
        {
            guna2DataGridView1.Rows.Clear();
            List<KhachHang> lstKH = KhachHangDAO.Instance.GetAllkhachHang();

            foreach (KhachHang kh in lstKH)
            {
                DataGridViewRow row = KhachHangToRow(kh);
                guna2DataGridView1.Rows.Add(row);
            }

        }
    }
}
