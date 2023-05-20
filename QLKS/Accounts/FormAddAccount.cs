using Guna.UI2.WinForms;
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
        public delegate void truyendulieu();
        public truyendulieu truyen;
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
        }
        
        Modify modify=new Modify();
        int i = 103;
        private void btAddAccount_Click_1(object sender, EventArgs e)
        {
            string manv=i.ToString();
            string hoten = guna2TextBox1.Text;
            int sdt = int.Parse(guna2TextBox2.Text);
            string ngaysinh = guna2DateTimePicker1.Text;
            string diachi = guna2TextBox3.Text;
            string role = guna2ComboBox1.Text;
            string username = guna2TextBox5.Text;
            string password = guna2TextBox6.Text;
            try
            { 
                string query = "insert into Accounts values( '"+manv+"' ,'" + hoten + "', '" + ngaysinh + "','" + diachi + "','" + sdt + "','" + role + "','" + username + "','" + password + "')";
                modify.Command(query);
                MessageBox.Show("DK Thanh Cong");
                i++;
                FormAddAccount formAddAccount = new FormAddAccount();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
