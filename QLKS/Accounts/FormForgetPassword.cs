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
    public partial class FormForgetPassword : Form
    {
        public FormForgetPassword()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            this.Close();
        }
    }
}
