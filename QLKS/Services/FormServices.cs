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
    public partial class FormServices : Form
    {
        public FormServices()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FormAddServices formAddServices = new FormAddServices();
            formAddServices.ShowDialog();
        }
        
        private DataGridViewRow selectedRow;

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow clickedRow = guna2DataGridView1.Rows[e.RowIndex];
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

        private void guna2ButtonEdit_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                // Hiển thị form edit
                FormEditServices a = new FormEditServices();
                a.ShowDialog();
            }
            else
            {
                // Hiển thị thông báo cho người dùng rằng phải chọn dòng dữ liệu trước khi bấm nút
                MessageBox.Show("Please choose data to edit!");
            }
        }

        private void guna2ButtonDelete_Click(object sender, EventArgs e)
        {
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

        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormEditServices formEditServices = new FormEditServices(); 
            formEditServices.ShowDialog();
        }
    }
}
