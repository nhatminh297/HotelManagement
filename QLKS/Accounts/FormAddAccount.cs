using Guna.UI2.WinForms;
using QLKS.DAO;
using QLKS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLKS.FormManager
{
    public partial class FormAddAccount : Form
    {
        public FormAddAccount()
        {
            InitializeComponent();
        }


        private void guna2TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void guna2TextBox1_Enter(object sender, EventArgs e)
        {
            Guna2TextBox tb = (Guna2TextBox)sender;
            if (tb.Text == "Họ và Tên")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }

        private void guna2TextBox1_Leave(object sender, EventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Họ và Tên";
                textBox.ForeColor = Color.Gray;
            }
        }

        private void guna2TextBox2_Enter(object sender, EventArgs e)
        {
            Guna2TextBox tb = (Guna2TextBox)sender;
            if (tb.Text == "Số điện thoại")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }

        private void guna2TextBox2_Leave(object sender, EventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Số điện thoại";
                textBox.ForeColor = Color.Gray;
            }
        }

        private void guna2TextBox3_Enter(object sender, EventArgs e)
        {
            Guna2TextBox tb = (Guna2TextBox)sender;
            if (tb.Text == "Địa chỉ")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }

        private void guna2TextBox3_Leave(object sender, EventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Địa chỉ";
                textBox.ForeColor = Color.Gray;
            }
        }

        private void guna2TextBox5_Enter(object sender, EventArgs e)
        {
            Guna2TextBox tb = (Guna2TextBox)sender;
            if (tb.Text == "Username")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }

        private void guna2TextBox5_Leave(object sender, EventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Username";
                textBox.ForeColor = Color.Gray;
            }
        }

        private void guna2TextBox6_Enter(object sender, EventArgs e)
        {
            Guna2TextBox tb = (Guna2TextBox)sender;
            if (tb.Text == "Password")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }

        private void guna2TextBox6_Leave(object sender, EventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Password";
                textBox.ForeColor = Color.Gray;
            }
        }


        private void btAddAccount_Click(object sender, EventArgs e)
        {

            Accounts acc = new Accounts();
            acc.Password = tbPassword.Text;
            if (!checkPassword(acc.Password))
            {
                MessageBox.Show("Kiểm tra lại mật khẩu");
                return;
            }
            acc.HoTen = tbName.Text;
            acc.DienThoai = tbPhone.Text;
            string ngaysinh = guna2DateTimePicker1.Text;
            acc.DiaChi = tbAddress.Text;
            acc.Role = cbRole.Text;
            acc.Username = tbUsername.Text;

            if(AccountsDAO.Instance.AddAccounts(acc) != 0)
            {
                MessageBox.Show("Thêm tài khoản thành công.");
                FormManageAccount form = Application.OpenForms.OfType<FormManageAccount>().FirstOrDefault();
                if(form != null)
                {
                    form.LoadAccount();
                }
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại.");
            }

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool checkPassword(string password)
        {
            bool containsDigit = password.Any(char.IsDigit);
            bool containsUpperCase = password.Any(char.IsUpper);
            bool containsLowerCase = password.Any(char.IsLower);
            bool containsSpecialCharacter = password.Any(c => !char.IsLetterOrDigit(c));

            if (containsDigit && containsUpperCase && containsLowerCase && containsSpecialCharacter)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            string password = tbPassword.Text;

            if (checkPassword(password))
            {
                guna2HtmlLabel2.Visible = false;
            }
            else
            {
                guna2HtmlLabel2.Visible = true;
            }
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
