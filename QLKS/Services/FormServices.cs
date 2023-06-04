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
using System.Windows.Controls;
using System.Windows.Forms;

namespace QLKS
{
    public partial class FormServices : Form
    {
        public FormServices()
        {
            InitializeComponent();
            loadServices();
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
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = guna2DataGridView1.CurrentRow;
                DV dv = RowToDV(row);
                FormEditServices a = new FormEditServices(dv);
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
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Confirm!", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    DataGridViewRow row = guna2DataGridView1.CurrentRow;
                    DV dv = RowToDV(row);
                    DVDAO.Instance.DeleteDV(dv.ID);
                    guna2DataGridView1.Rows.Remove(row);
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
            DV dv = RowToDV(row);
            FormEditServices formEditServices = new FormEditServices(dv); 
            formEditServices.ShowDialog();
        }

        public DV RowToDV(DataGridViewRow row)
        {
            DV dv = new DV();
            dv.ID = (int)row.Cells["colID"].Value;
            dv.GiaDV = (decimal)row.Cells["colPrices"].Value;
            dv.TenDV = row.Cells["colName"].Value.ToString();
            dv.LoaiDV = row.Cells["colType"].Value.ToString();
            return dv;
        }

        public DataGridViewRow DVToRow(DV dv)
        {
            DataGridViewRow row = new DataGridViewRow();

            row.CreateCells(guna2DataGridView1,
                      dv.ID, dv.TenDV, dv.LoaiDV, dv.GiaDV );
            return row;
        }

        public void loadServices()
        {
            guna2DataGridView1.Rows.Clear();
            List<DV> lstDV = DVDAO.Instance.GetAllDV();

            foreach (DV dv in lstDV)
            {
                DataGridViewRow row = DVToRow(dv);
                guna2DataGridView1.Rows.Add(row);
            }
        }
    }
}
