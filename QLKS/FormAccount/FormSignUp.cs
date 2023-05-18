using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security.Permissions;

namespace QLKS
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
            guna2CircleButton1.Visible = false;
            guna2CircleButton2.Visible = false; 
            guna2CircleButton3.Visible = false;
            guna2CircleButton4.Visible = false;
            guna2CircleButton5.Visible = false;
            guna2CircleButton6.Visible = false;
            guna2CircleButton7.Visible = false;
            guna2CustomRadioButton3.Checked = true;
            //guna2CircleButton8.Visible = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            this.Close();
        }

        public bool CheckAccount(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");//chi duoc dung chu cai, 6-24 ky tu
        }

        public bool CheckEmail(string em)
        {
            return Regex.IsMatch(em, @"[a-zA-Z0-9_.]{3,20}@gmail.com$");
        }

        public bool CheckMobileNumber(string mn)
        {
            return Regex.IsMatch(mn,@"^[0-9]{10,12}$");
        }
        public bool CheckName(string n)
        {
            return Regex.IsMatch(n, @"^[a-zA-Z]");
        }

        //public bool CheckBirthday(string birthday) 
        //{

        //}

        Modify modify = new Modify();

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string FirstName= guna2TextBox1.Text.Trim();
            string Surname= guna2TextBox2.Text.Trim();
            string MobileNumber= guna2TextBox3.Text.Trim();
            string EmailAddress=guna2TextBox4.Text.Trim();
            string UserName=guna2TextBox5.Text.Trim();
            string Password=guna2TextBox6.Text.Trim(); //Trim la khong tinh dau cach
            string Role="Customer";
            string DateOfBirth="a";
            DateOfBirth = guna2ComboBox1.Text+"/"+ guna2ComboBox3.Text+"/"+guna2ComboBox2.Text;
            if(guna2CustomRadioButton1.Checked)
            {
                Role = "Receiptionist";
            }
            if (guna2CustomRadioButton3.Checked)
            {
                Role = "Customer";
            }
            if (guna2CustomRadioButton4.Checked)
            {
                Role = "Staff";
            }
            if (!CheckName(FirstName))
            {
                guna2CircleButton1.Visible= true;
                return;
            }
            if (!CheckName(Surname))
            {
                guna2CircleButton2.Visible = true;
                return;
            }
            if(!CheckMobileNumber(MobileNumber))
            {
                guna2CircleButton3.Visible = true;
                return;
            }
            if(!CheckEmail(EmailAddress)||modify.accounts("select * from Account where EmailAddress = '"+EmailAddress+"'").Count!=0)
            {
                guna2CircleButton4.Visible = true;
                return;
            }
            if(!CheckAccount(UserName))
            {
                guna2CircleButton5.Visible = true;
                return;
            }
            if (!CheckAccount(Password))
            {
                guna2CircleButton6.Visible = true;
                return;
            }
            try
            {
                string query="insert into Account values('"+UserName+"', '"+FirstName+"','"+Surname+"','"+MobileNumber+"','"+EmailAddress+"','"+Password+"','"+DateOfBirth+"','"+Role+"')";
                modify.Command(query);
                MessageBox.Show("DK Thanh Cong");
            }
            catch
            {
                MessageBox.Show("Username da dc dk");
            }
            
        }

        private void FormSignUp_Load(object sender, EventArgs e)
        {
            for(int i=1900;i<2101;i++)
            {
                guna2ComboBox2.Items.Add(i.ToString());
                guna2ComboBox2.Text = "2000";
                guna2ComboBox1.Text = "1";
                guna2ComboBox3.Text = "1";
                guna2TextBox10.Enabled=false;
                guna2TextBox8.Enabled = false;
                guna2TextBox9.Enabled = false;
            }
        }
    }
}
