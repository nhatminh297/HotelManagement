using Guna.UI2.WinForms;
using QLKS.DAO;
using QLKS.DTO;
using QLKS.FormManager;
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
    //chinh ma nv khong the thay doi, co the dung label
    public partial class FormEditAccount : Form
    {
        private int manv;
        private string Role;
        private int thisId;

        public int Manv { get => manv; set => manv = value; }
        public string Role1 { get => Role; set => Role = value; }
        public int ThisId { get => thisId; set => thisId = value; }
        
        public FormEditAccount(int thisid, int Manv, string role)
        {
            InitializeComponent();
            this.Manv = Manv;
            this.Role1 = role;
            this.ThisId = thisid;
            FormEditAccount_Load();

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

        private void FormEditAccount_Load()
        {
            lbManv.Text = "Mã tài khoản: " + Manv;
            cbRole.SelectedIndex = cbRole.Items.IndexOf(Role);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string password = tbpassword.Text;
            if (!checkPassword(password))
            {
                MessageBox.Show("Kiểm tra lại mật khẩu");
                return;
            }

            if (thisId == Manv && cbRole.Text != "Admin")
            {
                Role = "Admin";
            }
            else
                Role = cbRole.Text;

            string username = tbusername.Text;


            if(AccountsDAO.Instance.UpdateUsername_password(Manv, username, password, Role) != 0)
            {
                MessageBox.Show("Cập nhật thành công!");
                FormManageAccount form = Application.OpenForms.OfType<FormManageAccount>().FirstOrDefault();
                if(form != null)
                {
                    form.LoadAccount();
                }
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
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

        private void tbpassword_TextChanged(object sender, EventArgs e)
        {
            string password = tbpassword.Text;

            if (checkPassword(password))
            {
                guna2HtmlLabel1.Visible = false;
            }
            else
            {
                // Mật khẩu không đáp ứng yêu cầu, cung cấp phản hồi người dùng tại đây
                // ...
                guna2HtmlLabel1.Visible=true;
            }
        }
    }
}
