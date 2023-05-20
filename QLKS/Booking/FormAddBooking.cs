using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class FormAddBooking : Form
    {
        public FormAddBooking()
        {
            InitializeComponent();
        }

        private BindingSource bs;

        private void FormAddBooking_Load(object sender, EventArgs e)
        {
            bs = new BindingSource();
            DateTime start = DateTime.Now;
            double hours = 0;

            bs.DataSource = new { StartDate = start, HoursToAdd = hours };
            guna2DateStart.DataBindings.Add("Value", bs, "StartDate", true, DataSourceUpdateMode.OnPropertyChanged);

            // Binding TextBox với BindingSource
            guna2tbTime.DataBindings.Add("Text", bs, "HoursToAdd", true, DataSourceUpdateMode.OnPropertyChanged);

            // Xử lý sự kiện ValueChanged của DateTimePicker1
            guna2DateStart.ValueChanged += guna2DateStart_ValueChanged;

            // Xử lý sự kiện TextChanged của TextBox
            guna2tbTime.TextChanged += guna2tbTime_TextChanged;

            //Xử lý sự kiện ValueChanged của guna2DateEnd
            guna2DateEnd.ValueChanged += Guna2DateEnd_ValueChanged;

            // Xử lý sự kiện TextChanged của TextBox
            guna2DateEnd.Value = start.AddHours(hours);

        }

        private void Guna2DateEnd_ValueChanged(object sender, EventArgs e)
        {
            UpdateTextBoxValue();
        }

        private void guna2DateStart_ValueChanged(object sender, EventArgs e)
        {
            UpdateDateTimePicker2Value();
        }

        private void guna2tbTime_TextChanged(object sender, EventArgs e)
        {
            UpdateDateTimePicker2Value();
        }

        private void UpdateDateTimePicker2Value()
        {
            DateTime startDate = guna2DateStart.Value;
            double hoursToAdd;
            if (double.TryParse(guna2tbTime.Text, out hoursToAdd))
            {
                DateTime newDate = startDate.AddHours(hoursToAdd);
                bs.DataSource = new { StartDate = startDate, HoursToAdd = hoursToAdd };
                guna2DateEnd.Value = newDate;
            }
        }

        private void UpdateTextBoxValue()
        {
            DateTime start = guna2DateStart.Value;
            DateTime end = guna2DateEnd.Value;

            TimeSpan diff = end.Subtract(start);
            guna2tbTime.Text = Math.Ceiling(diff.TotalHours).ToString();
        }

        private void guna2ButtonDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2TextBoxName_Enter(object sender, EventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;
            if (textBox.Text == "Full Name")
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        private void guna2TextBoxName_Leave(object sender, EventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Full Name";
                textBox.ForeColor = Color.Gray;
            }
        }

        private void guna2TextBoxCCCD_Enter(object sender, EventArgs e)
        {
            Guna2TextBox tb = (Guna2TextBox)sender;
            if (tb.Text =="ID Number")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }

        private void guna2TextBoxCCCD_Leave(object sender, EventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "ID Number";
                textBox.ForeColor = Color.Gray;
            }
        }

        private void guna2TextBoxPhone_Enter(object sender, EventArgs e)
        {
            Guna2TextBox tb = (Guna2TextBox)sender;
            if (tb.Text == "Phone(+84)")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }

        private void guna2TextBoxPhone_Leave(object sender, EventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Phone(+84)";
                textBox.ForeColor = Color.Gray;
            }
        }

        private void guna2TextBoxEmail_Enter(object sender, EventArgs e)
        {
            Guna2TextBox tb = (Guna2TextBox)sender;
            if (tb.Text == "Email Address")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }

        private void guna2TextBoxEmail_Leave(object sender, EventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Email Address";
                textBox.ForeColor = Color.Gray;
            }
        }

        private void guna2TextBoxAddress_Enter(object sender, EventArgs e)
        {
            Guna2TextBox tb = (Guna2TextBox)sender;
            if (tb.Text == "Address")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }

        private void guna2TextBoxAddress_Leave(object sender, EventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Address";
                textBox.ForeColor = Color.Gray;
            }
        }

        private void guna2tbTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void guna2tbTime_Leave(object sender, EventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "1";
            }
        }

        private DataGridViewRow selectedRow;

        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedCellValue = guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            // Thêm giá trị vào d2
            guna2DataGridView2.Rows.Add(selectedCellValue);

            // Xóa cell được double-click trong d1
            guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
        }

        private void guna2DataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedCellValue = guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            // Thêm giá trị vào d2
            guna2DataGridView2.Rows.Add(selectedCellValue);

            // Xóa cell được double-click trong d1
            guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
        }
    }
}
