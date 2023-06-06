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
    public partial class FormRoom : Form
    {
        public FormRoom()
        {
            InitializeComponent();
            loadRooms();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FormAddRoom a = new FormAddRoom();
            a.ShowDialog();
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
            button.FillColor = Color.FromArgb(50, 50, 90);
            button.ForeColor = Color.FromArgb(94, 148, 255);
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
            button.FillColor = Color.FromArgb(50, 50, 90);
            button.ForeColor = Color.ForestGreen;
        }

        private void btEdit_MouseEnter(object sender, EventArgs e)
        {
            var button = (Guna2Button)sender;
            button.FillColor = Color.Orange;
            button.ForeColor = Color.White;
        }

        private void btEdit_MouseLeave(object sender, EventArgs e)
        {
            var button = (Guna2Button)sender;
            button.FillColor = Color.FromArgb(50, 50, 90);
            button.ForeColor = Color.Orange;
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
            button.FillColor = Color.FromArgb(50, 50, 90);
            button.ForeColor = Color.Firebrick;
        }



        private void guna2ButtonEdit_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = guna2DataGridView1.CurrentRow;
                Phong phong = RowToPhong(row);
                FormEditRoom a = new FormEditRoom(phong);
                a.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose data to edit!");
            }
            
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

        private void guna2ButtonDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn dòng dữ liệu hay chưa
            if (selectedRow != null)
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Confirm!", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    DataGridViewRow row = guna2DataGridView1.CurrentRow;
                    Phong phong = RowToPhong(row);
                    PhongDAO.Instance.DeleteRoom(phong.ID);
                    loadRooms();

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
            DataGridViewRow row = guna2DataGridView1.CurrentRow;
            Phong phong = RowToPhong(row);
            FormEditRoom formEditRoom = new FormEditRoom(phong);
            formEditRoom.ShowDialog();
        }

        public Phong RowToPhong(DataGridViewRow row)
        {
            Phong phong = new Phong();
            phong.ID = (int)row.Cells["colID"].Value;
            phong.SoPhong = (int)row.Cells["colRoom_number"].Value;
            phong.SucChua = (int)row.Cells["colCapacity"].Value;
            phong.GiaMoiGio = (decimal)row.Cells["colPrices"].Value;
            phong.TrangThai = row.Cells["colStatus"].Value.ToString();
            phong.TenLoaiPhong = row.Cells["colType"].Value.ToString();
            phong.MoTa = row.Cells["colMota"].Value.ToString();
            return phong;
        }

        public DataGridViewRow PhongToRow(Phong phong)
        {
            DataGridViewRow row = new DataGridViewRow();

            row.CreateCells(guna2DataGridView1,
                       phong.ID, phong.SoPhong, phong.TenLoaiPhong, phong.SucChua,
                       phong.GiaMoiGio, phong.TrangThai, phong.MoTa
                    );
            return row;
        }

        public void loadRooms()
        {
            guna2DataGridView1.Rows.Clear();
            List<Phong> lstPhong = PhongDAO.Instance.GetAllPhong();

            foreach (Phong p in lstPhong)
            {
                DataGridViewRow row = PhongToRow(p);
                guna2DataGridView1.Rows.Add(row);
            }
        }

        public void Search()
        {
            string searchText = tbSearchRoom.Text.ToLower(); // Lấy giá trị trong TextBox và chuyển thành chữ thường
            int number;
            bool check = int.TryParse(searchText, out number);
            if (!check)
                foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                {
                    // Kiểm tra giá trị trong cột tương ứng với dòng hiện tại
                    if (row.Cells["colType"].Value != null && row.Cells["colType"].Value.ToString().ToLower().Contains(searchText))
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
                    if (row.Cells["colRoom_number"].Value != null && row.Cells["colRoom_number"].Value.ToString().ToLower().Contains(searchText))
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

        private void tbSearchRoom_KeyDown(object sender, KeyEventArgs e)
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
    }
}
