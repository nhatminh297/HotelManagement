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

        public void Search()
        {
            string searchText = tbSearchName.Text.ToLower(); // Lấy giá trị trong TextBox và chuyển thành chữ thường
            int number;
            bool check = int.TryParse(searchText, out number);
            if (!check)
                foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                {
                    // Kiểm tra giá trị trong cột tương ứng với dòng hiện tại
                    if (row.Cells["colName"].Value != null && row.Cells["colName"].Value.ToString().ToLower().Contains(searchText))
                    {
                        row.Visible = true; // Hiển thị dòng nếu giá trị phù hợp
                    }
                    else
                    {
                        row.Visible = false; // Ẩn dòng nếu giá trị không phù hợp
                    }
                }
            else
            {
                foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                {
                    // Kiểm tra giá trị trong cột tương ứng với dòng hiện tại
                    if (row.Cells["colCCCD"].Value != null && row.Cells["colCCCD"].Value.ToString().ToLower().Contains(searchText))
                    {
                        row.Visible = true; // Hiển thị dòng nếu giá trị phù hợp
                    }
                    else
                    {
                        row.Visible = false; // Ẩn dòng nếu giá trị không phù hợp
                    }
                }
            }

            // Thoát khỏi TextBox sau khi thực hiện tìm kiếm
            guna2DataGridView1.Focus();
        }

        private void tbSearchName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                Search();
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btSearch_MouseEnter(object sender, EventArgs e)
        {
            var button = (Guna2Button)sender;
            button.FillColor = Color.FromArgb(94, 148, 255);
            button.ForeColor = Color.White;
        }

        private void btSearch_MouseLeave(object sender, EventArgs e)
        {
            var button = (Guna2Button)sender;
            button.FillColor = Color.FromArgb(40, 40, 80);
            button.ForeColor = Color.FromArgb(94, 148, 255);
        }

        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }
    }
}
