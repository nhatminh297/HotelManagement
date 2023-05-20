using Guna.UI2.WinForms;
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
    public partial class FormBooking : Form
    {
        public FormBooking()
        {
            InitializeComponent();
        }

      

        


        private void btAddBooking_Click(object sender, EventArgs e)
        {
            FormAddBooking formAddBooking = new FormAddBooking();
            formAddBooking.ShowDialog();
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
            if (selectedRow != null)
            {
                // Hiển thị form mới
                FormBill newForm = new FormBill();
                newForm.ShowDialog();
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

        private void guna2DataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormEditBooking formAddBooking = new FormEditBooking();
            formAddBooking.ShowDialog();
        }

        private void guna2ButtonDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn dòng dữ liệu hay chưa
            if (selectedRow != null)
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Confirm!", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    // Thực hiện xóa dữ liệu

                }
                else if (result == DialogResult.Cancel)
                {
                    // Hủy bỏ thao tác xóa
                }

            }
            else
            {
                // Hiển thị thông báo cho người dùng rằng phải chọn dòng dữ liệu trước khi bấm nút
                MessageBox.Show("Please choose data!");
            }

            
        }
    }
}
