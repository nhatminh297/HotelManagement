using Guna.UI2.WinForms;
using QLKS.DAO;
using QLKS.DTO;
using QLKS.FormManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class FormBooking : Form
    {
        private int Id;
        public FormBooking(int id)
        {
            this.Id = id;
            InitializeComponent();
            ShowBills();
        }

        public void ShowBills()
        {
            guna2DataGridView2.Rows.Clear();
            List<Bill> uncheckedBill = BillDAO.Instance.GetUncheckedBills();

            foreach (Bill bill in uncheckedBill)
            {
                string name = KhachHangDAO.Instance.GetNameFromID(bill.Makh);

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(guna2DataGridView2,
                    bill.ID, name, bill.Sophong, 
                    bill.Checkin, bill.Checkout, bill.Prices, 
                    bill.Makh, bill.Manv, bill.Maphong, 
                    bill.Tenloaiphong, bill.Giamoigio, bill.Trangthai
                    );
                guna2DataGridView2.Rows.Add( row );

            }

        }
        

        private void btAddBooking_Click(object sender, EventArgs e)
        {
            //Bill bill = ConvertRowtoBill(guna2DataGridView2.CurrentRow);
            FormMainMenu formmainmenu = Application.OpenForms.OfType<FormMainMenu>().FirstOrDefault();
            formmainmenu.OpenChildForm(new FormAddBooking(Id));
        }

        private DataGridViewRow selectedRow;

        private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow clickedRow = guna2DataGridView2.Rows[e.RowIndex];
                if (selectedRow == clickedRow) 
                {
                    selectedRow.Selected = false;
                    selectedRow = null;
                }
                else
                {
                    if (selectedRow != null)
                    {
                        selectedRow.Selected = false;
                    }

                    // Lưu dòng được chọn
                    selectedRow = clickedRow;
                    selectedRow.Selected = true;
                }
            }
        }

        private void btMakeBill_Click(object sender, EventArgs e)
        {
            
            // Kiểm tra xem đã chọn dòng dữ liệu hay chưa
            if (guna2DataGridView2.SelectedRows.Count != 0) 
            {
                // Hiển thị form mới
                Bill hoadon = ConvertRowtoBill(guna2DataGridView2.CurrentRow);
                int sophong = hoadon.Sophong;
                string question = "Thanh toán hóa đơn cho phòng " + sophong.ToString();
                DialogResult result = MessageBox.Show(question, "Confirm!", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    BillDAO.Instance.PayBill(hoadon.ID, hoadon.Sophong);
                    guna2DataGridView2.Rows.Remove(guna2DataGridView2.CurrentRow);
                    FormBill newForm = new FormBill(hoadon.ID);
                    newForm.ShowDialog();
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }

            }
            else
            {
                // Hiển thị thông báo cho người dùng rằng phải chọn dòng dữ liệu trước khi bấm nút
                MessageBox.Show("Please choose the object to make bill!");
            }
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
            Guna2TextBox textBox = (Guna2TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Search Fullname";
                textBox.ForeColor = Color.Gray;
            }
        }

        public Bill ConvertRowtoBill(DataGridViewRow selectedRow)
        {
            Bill bill = new Bill();
            bill.ID = (int)selectedRow.Cells["id"].Value;
            bill.Makh = (int)selectedRow.Cells["makh"].Value;
            bill.Manv = (int)selectedRow.Cells["manv"].Value;
            bill.Maphong = (int)selectedRow.Cells["maphong"].Value;
            bill.Sophong = (int)selectedRow.Cells["sophong"].Value;
            bill.Tenloaiphong = selectedRow.Cells["tenloaiphong"].Value.ToString();
            bill.Giamoigio = (decimal)selectedRow.Cells["giamoigio"].Value;
            bill.Checkin = (DateTime)selectedRow.Cells["Checkin"].Value;
            bill.Checkout = (DateTime)selectedRow.Cells["checkout"].Value;
            bill.Prices = (decimal)selectedRow.Cells["prices"].Value;
            bill.Trangthai = selectedRow.Cells["trangthai"].Value.ToString();
            return bill;
        }

        private void guna2DataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Bill bill = ConvertRowtoBill(guna2DataGridView2.CurrentRow);
            FormMainMenu formmainmenu = Application.OpenForms.OfType<FormMainMenu>().FirstOrDefault();
            formmainmenu.OpenChildForm(new FormEditBooking(bill));
        }

        private void btMakeBill_MouseEnter(object sender, EventArgs e)
        {
            var button = (Guna2Button)sender;
            button.FillColor = Color.ForestGreen;
            button.ForeColor = Color.White;
        }

        private void btMakeBill_MouseLeave(object sender, EventArgs e)
        {
            var button = (Guna2Button)sender;
            button.FillColor = Color.FromArgb(40, 40, 80);
            button.ForeColor = Color.ForestGreen;
        }

        private void btEdit_MouseEnter(object sender, EventArgs e)
        {
            var button = (Guna2Button)sender;
            button.FillColor = Color.DarkGoldenrod;
            button.ForeColor = Color.White;
        }

        private void btEdit_MouseLeave(object sender, EventArgs e)
        {
            var button = (Guna2Button)sender;
            button.FillColor = Color.FromArgb(40, 40, 80);
            button.ForeColor = Color.DarkGoldenrod;
        }

        private void guna2ButtonDelete_MouseEnter(object sender, EventArgs e)
        {
            var button = (Guna2Button)sender;
            button.FillColor = Color.Firebrick;
            button.ForeColor = Color.White;
        }

        private void guna2ButtonDelete_MouseLeave(object sender, EventArgs e)
        {
            var button = (Guna2Button)sender;
            button.FillColor = Color.FromArgb(40, 40, 80);
            button.ForeColor = Color.Firebrick;
        }

        private void guna2ButtonDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn dòng dữ liệu hay chưa
            if (guna2DataGridView2.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Confirm!", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    
                    Bill bill = ConvertRowtoBill(selectedRow);
                    BillDAO.Instance.DeleteBill(bill);
                    guna2DataGridView2.Rows.Remove(guna2DataGridView2.CurrentRow);
                    ShowBills();

                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
            else
            {
                // Hiển thị thông báo cho người dùng rằng phải chọn dòng dữ liệu trước khi bấm nút
                MessageBox.Show("Please choose data!");
            }

            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView2.SelectedRows.Count > 0 )
            {
                
                Bill bill = ConvertRowtoBill(guna2DataGridView2.CurrentRow);

                FormMainMenu formmainmenu = Application.OpenForms.OfType<FormMainMenu>().FirstOrDefault();
                formmainmenu.OpenChildForm(new FormEditBooking(bill));
            }
            else
            {
                // Hiển thị thông báo cho người dùng rằng phải chọn dòng dữ liệu trước khi bấm nút
                MessageBox.Show("Please choose data!");
            }
        }

        private void tbSearchName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true; 
                e.SuppressKeyPress = true;

                string searchText = tbSearchName.Text.ToLower(); // Lấy giá trị trong TextBox và chuyển thành chữ thường
                int number;
                bool check = int.TryParse(searchText, out number);
                if (!check)
                    foreach (DataGridViewRow row in guna2DataGridView2.Rows)
                    {
                        // Kiểm tra giá trị trong cột tương ứng với dòng hiện tại
                        if (row.Cells["tenkh"].Value != null && row.Cells["tenkh"].Value.ToString().ToLower().Contains(searchText))
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
                    foreach (DataGridViewRow row in guna2DataGridView2.Rows)
                    {
                        // Kiểm tra giá trị trong cột tương ứng với dòng hiện tại
                        if (row.Cells["sophong"].Value != null && row.Cells["sophong"].Value.ToString().ToLower().Contains(searchText))
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
                guna2DataGridView2.Focus();
            }
        }
    }
}
