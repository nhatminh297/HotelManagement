using Guna.UI2.WinForms;
using QLKS.FormAccount;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS.FormManager
{
    public partial class FormManageAccount : Form
    {
        public FormManageAccount()
        {
            InitializeComponent();
        }

        private void tbsearchacc_Enter(object sender, EventArgs e)
        {
            Guna2TextBox tb = (Guna2TextBox)sender;   
            if (tb.Text == "Tìm kiếm tài khoản")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }

        private void tbsearchacc_Leave(object sender, EventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Tìm kiếm tài khoản";
                textBox.ForeColor = Color.Gray;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FormEditAccount frm = new FormEditAccount();
            frm.ShowDialog();

        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            FormAddAccount frm = new FormAddAccount();
            frm.ShowDialog();
        }
    }
}
