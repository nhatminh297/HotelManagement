using Guna.UI2.WinForms;
using QLKS.DAO;
using QLKS.DTO;
using QLKS.FormAccount;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS.FormManager
{
    public partial class FormManageAccount : Form
    {
        private int IDThis;
        public FormManageAccount(int iDThis)
        {
            InitializeComponent();
            IDThis = iDThis;
            LoadAccount();
        }

        #region button ui

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

        #endregion


        public DataGridViewRow AccountToRow(Accounts acc)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(guna2DataGridView1, acc.ID, acc.HoTen, acc.DienThoai, acc.Username, acc.Password ,acc.DiaChi, acc.Role);
            return row;
        }

        public void LoadAccount()
        {
            guna2DataGridView1.Rows.Clear();
            List<Accounts> listAcc = AccountsDAO.Instance.GetAllAccount();
            foreach(Accounts acc in listAcc)
            {
                guna2DataGridView1.Rows.Add(AccountToRow(acc));
            }
        }
        

        private void btnAddAccount_Click(object sender, EventArgs e)
        { new FormAddAccount();
           
            FormAddAccount frm = new FormAddAccount();
            frm.ShowDialog();
        }
        public Accounts RowToAccounts(DataGridViewRow row)
        {
            Accounts accounts = new Accounts();
            accounts.ID = (int)row.Cells["colID"].Value;
            accounts.HoTen = row.Cells["colHoten"].Value.ToString();
            accounts.DienThoai = row.Cells["colDienthoai"].Value.ToString();
            accounts.Username = row.Cells["colUsername"].Value.ToString();
            accounts.Password = row.Cells["colPassword"].Value.ToString();
            accounts.DiaChi = row.Cells["colDiachi"].Value.ToString();
            accounts.Role = row.Cells["colRole"].Value.ToString();

            return accounts;
        }

        public DataGridViewRow AccountsToRow(Accounts acc)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(guna2DataGridView1, acc.ID, acc.HoTen, acc.DienThoai, acc.Username,
                acc.Password, acc.DiaChi, acc.Role);
            return row;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = guna2DataGridView1.CurrentRow;
                Accounts acc = RowToAccounts(row);
                FormEditAccount frm = new FormEditAccount(IDThis, acc.ID, acc.Role);
                frm.ShowDialog();
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = guna2DataGridView1.CurrentRow;
            if (row != null)
            {
                Accounts acc = RowToAccounts(row);
                if(IDThis != acc.ID)
                {
                    DialogResult res = MessageBox.Show("Bạn có chắc muốn xóa tài khoản này?", "Confirm dialog", MessageBoxButtons.OKCancel);
                    if(res == DialogResult.OK)
                    {
                        if (AccountsDAO.Instance.DeleteAccounts(acc.ID) != 0)
                        {
                            MessageBox.Show("Đã xóa tài khoản " + acc.Username);
                            guna2DataGridView1.Rows.Remove(row);
                        }
                        else
                        {
                            MessageBox.Show("Nhân viên này chưa thể xóa.");
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                else if(IDThis == acc.ID)
                {
                    MessageBox.Show("Không thể xóa tài khoản đang sử dụng.", "Ignore", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        public void Search()
        {
            string searchText = tbsearchacc.Text.ToLower(); // Lấy giá trị trong TextBox và chuyển thành chữ thường

            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                // Kiểm tra giá trị trong cột tương ứng với dòng hiện tại
                if (row.Cells["colHoten"].Value != null && row.Cells["colHoten"].Value.ToString().ToLower().Contains(searchText))
                {
                    row.Visible = true; // Hiển thị dòng nếu giá trị phù hợp
                }
                else
                {
                    row.Visible = false; // Ẩn dòng nếu giá trị không phù hợp
                }
            }

            // Thoát khỏi TextBox sau khi thực hiện tìm kiếm
            guna2DataGridView1.Focus();
        }

        private void tbsearchacc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                Search();
            }
        }
    }
}
