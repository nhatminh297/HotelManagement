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
                        }
                        guna2DataGridView1.Rows.Remove(row);
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
    }
}
