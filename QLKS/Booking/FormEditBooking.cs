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
    public partial class FormEditBooking : Form
    {
        public FormEditBooking()
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

        private void guna2tbTime_TextChanged(object sender, EventArgs e)
        {
            UpdateDateTimePicker2Value();
        }

        

        private void guna2DateStart_ValueChanged(object sender, EventArgs e)
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

        private void Guna2DateEnd_ValueChanged(object sender, EventArgs e)
        {
            UpdateTextBoxValue();

        }

        private void UpdateTextBoxValue()
        {
            DateTime start = guna2DateStart.Value;
            DateTime end = guna2DateEnd.Value;

            TimeSpan diff = end.Subtract(start);
            guna2tbTime.Text = Math.Ceiling(diff.TotalHours).ToString();
        }

        

        private void btMakeBill_Click(object sender, EventArgs e)
        {
            FormBill bill = new FormBill();
            bill.ShowDialog(); 
        }

        private void guna2ButtonDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
