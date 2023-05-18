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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
        
        Modify modify=new Modify();

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string username = guna2TextBox1.Text;
            string password = guna2TextBox2.Text;
            string query ="select * from Account where UserName = '"+username+"' and Password = '"+password+"'";
            string query2 = "select role from Account where UserName = '" + username + "' and Password = '" + password + "'";
            if (modify.accounts(query).Count != 0 && modify.role(query2).Trim() == "Customer")
            {
                FormRoom room = new FormRoom();
                room.Show();
                Hide();
            }
            else if (modify.accounts(query).Count != 0 && modify.role(query2).Trim() == "Receiptionist")
            {
                FormManageFood food = new FormManageFood();
                food.Show();
                Hide();
            }
            else
            {
                label3.Visible = true;
                label2.Visible = true;
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            FormSignUp signup = new FormSignUp();
            signup.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FormForgetPassword formForgetPassword = new FormForgetPassword();
            formForgetPassword.Show();
            this.Hide();
        }
    }
}
