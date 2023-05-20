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

namespace QLKS
{
    public partial class FormCustomers : Form
    {
        public FormCustomers()
        {
            InitializeComponent();
        }

        private void tbSearchName_Enter(object sender, EventArgs e)
        {
            Guna2TextBox tb = (Guna2TextBox)sender;
            if (tb.Text == "Search Fullname")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }

        private void tbSearchName_Leave(object sender, EventArgs e)
        {
            Guna2TextBox tb = (Guna2TextBox)sender;

            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                tb.Text = "Search Fullname";
                tb.ForeColor = Color.Gray;
            }
        }
    }
}
