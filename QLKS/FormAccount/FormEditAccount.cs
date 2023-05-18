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

namespace QLKS.FormAccount
{
    public partial class FormEditAccount : Form
    {
        public FormEditAccount()
        {
            InitializeComponent();
        }

        private void tbMaNhanVien_Enter(object sender, EventArgs e)
        {
            Guna2TextBox tb = (Guna2TextBox)sender;
            if (tb.Text == "Mã nhân viên")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }

        private void tbMaNhanVien_Leave(object sender, EventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Mã nhân viên";
                textBox.ForeColor = Color.Gray;
            }
        }

        private void tbusername_Enter(object sender, EventArgs e)
        {
            Guna2TextBox tb = (Guna2TextBox)sender;
            if (tb.Text == "Username")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }

        private void tbusername_Leave(object sender, EventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Username";
                textBox.ForeColor = Color.Gray;
            }
        }

        private void tbpassword_Enter(object sender, EventArgs e)
        {
            Guna2TextBox tb = (Guna2TextBox)sender;
            if (tb.Text == "Password")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }

        private void tbpassword_Leave(object sender, EventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Password";
                textBox.ForeColor = Color.Gray;
            }
        }

        private void tbPhanQuyen_Enter(object sender, EventArgs e)
        {
            Guna2TextBox tb = (Guna2TextBox)sender;
            if (tb.Text == "Phân quyền")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }

        private void tbPhanQuyen_Leave(object sender, EventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Phân quyền";
                textBox.ForeColor = Color.Gray;
            }
        }
    }
}
