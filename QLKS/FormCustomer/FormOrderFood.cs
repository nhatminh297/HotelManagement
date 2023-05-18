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
    public partial class FormOrderFood : Form
    {
        public FormOrderFood()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormLogin a = new FormLogin();
            a.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FormRoom a = new FormRoom();
            a.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FormBooking a = new FormBooking();
            a.Show();
            this.Close();
        }
    }
}
