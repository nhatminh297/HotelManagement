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

        private void tbSearchRoom_Enter(object sender, EventArgs e)
        {
            Guna2TextBox tb = (Guna2TextBox)sender;
            if (tb.Text == "Room number")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }

        private void tbSearchRoom_Leave(object sender, EventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Room number";
                textBox.ForeColor = Color.Gray;
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
    }
}
