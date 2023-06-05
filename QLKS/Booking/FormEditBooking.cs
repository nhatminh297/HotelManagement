using Guna.UI2.WinForms;
using QLKS.DAO;
using QLKS.DTO;
using QLKS.FormManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Windows.Input;
using System.Xml.Linq;

namespace QLKS
{
    public partial class FormEditBooking : Form
    {
        private static Bill hoadon;
        public decimal totalSvBill;
        public FormEditBooking(Bill hoadon)
        {
            this.Hoadon = hoadon;
            InitializeComponent();
        }

        #region smallevents
        private BindingSource bs;

        public Bill Hoadon { get => hoadon; set => hoadon = value; }

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

            showInfo(hoadon);
        }

        private void guna2tbTime_TextChanged(object sender, EventArgs e)
        {
            int number;
            bool check = int.TryParse(guna2tbTime.Text, out number);
            if (check)
            {
                int sogio = int.Parse(guna2tbTime.Text.ToString());
                decimal delta = hoadon.Giamoigio * sogio;
                hoadon.Prices = delta + totalSvBill;
                tbPrices.Text = hoadon.Prices.ToString("N2");
            }
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
            btEdit_Click(null, null);
            int sophong = hoadon.Sophong;
            string question = "Thanh toán hóa đơn cho phòng " + sophong.ToString();
            DialogResult result = MessageBox.Show(question, "Confirm!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                BillDAO.Instance.PayBill(hoadon.ID, hoadon.Sophong);
                FormMainMenu formmainmenu = Application.OpenForms.OfType<FormMainMenu>().FirstOrDefault();
                formmainmenu.OpenChildForm(new FormBooking(formmainmenu.Id1));

                FormBill newForm = new FormBill(hoadon.ID);
                newForm.ShowDialog();
            }
            else if (result == DialogResult.Cancel)
            {
                return;
            } 

        }

        private void guna2ButtonDelete_Click(object sender, EventArgs e)
        {
            FormMainMenu fmainmenu = Application.OpenForms.OfType<FormMainMenu>().FirstOrDefault();
            fmainmenu.OpenChildForm(new FormBooking(fmainmenu.Id1));
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion

        public void showInfo(Bill hoadon)
        {
            showKH(hoadon.Makh);
            showAddedServices(hoadon.ID);
            tbFormName.Text = "Oders of Room " + hoadon.Sophong.ToString();
            tbPrices.Text = hoadon.Prices.ToString("N2");
            guna2DateStart.Value = hoadon.Checkin;
            guna2DateEnd.Value = hoadon.Checkout;
        }


        KhachHang kh = new KhachHang();
        List<DV> dsDV = DVDAO.Instance.GetAvailableServices();
        List<SvBill> lstsvBills = new List<SvBill>();
        List<DV> filteredDV = new List<DV>();

        public void showKH(int id)
        {
            kh = KhachHangDAO.Instance.GetKhachHangByID(id);
            if (kh != null)
            {
                guna2TextBoxName.Text = kh.HoTen;
                guna2TextBoxCCCD.Text = kh.CCCD;
                guna2TextBoxPhone.Text = kh.DienThoai;
                guna2TextBoxEmail.Text = kh.Email;
                guna2TextBoxAddress.Text = kh.DiaChi;
            }
        }

        public void showAddedServices(int idhd)
        {
            gvAddedServices.Rows.Clear();
            lstsvBills = SvBillDAO.Instance.GetSelectedSvBills(idhd);

            foreach (SvBill svBill in lstsvBills)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(gvAddedServices,
                   svBill.Tendv, svBill.Dongia, svBill.Soluong, svBill.Prices
                    );
                gvAddedServices.Rows.Add(row);
                totalSvBill += svBill.Prices;
            }
            ShowServices(lstsvBills);
        }

        public void ShowServices(List<SvBill> svBills)
        {
            gvServices.Rows.Clear();

            filteredDV = dsDV.Where(dv => !svBills.Any(rs => rs.Tendv == dv.TenDV)).ToList();
            foreach (DV dv in filteredDV)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(gvServices, dv.TenDV, dv.LoaiDV, dv.GiaDV, dv.ID);
                gvServices.Rows.Add(row);
            }
        }

        public DataGridViewRow SvBillToRow(SvBill svbill)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (svbill != null)
            {
                row.CreateCells(gvAddedServices,
                   svbill.Tendv, svbill.Dongia, svbill.Soluong, svbill.Prices
                    );
                return row;
            }
            return null;
        }

        public SvBill AddedSvToSvBill(DataGridViewRow row)
        {
            SvBill svbill = new SvBill();
            svbill.Mahd = hoadon.ID;
            svbill.Tendv = row.Cells["tendv2"].Value.ToString();
            svbill.Dongia = (decimal)row.Cells["giadv2"].Value;
            svbill.Soluong = int.Parse(row.Cells["SL"].Value.ToString());
            svbill.Prices = svbill.Dongia * svbill.Soluong;
            return svbill;
        }

        public DataGridViewRow SVToRow(DV dv)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (dv != null)
            {
                row.CreateCells(gvServices,
                   dv.TenDV, dv.LoaiDV, dv.GiaDV.ToString("N1"), dv.ID
                    );
                return row;
            }
            return null;
        }

        public DV ServicesRowToDV(DataGridViewRow row)
        {
            DV dv = new DV();
            dv.ID = (int)row.Cells["iddv"].Value;
            dv.GiaDV = (decimal)row.Cells["giadv"].Value;
            dv.LoaiDV = row.Cells["loaidv"].Value.ToString();
            dv.TenDV = row.Cells["tendv"].Value.ToString();
            return dv;
        }


        private void gvServices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = gvServices.CurrentRow;
            DV dv = ServicesRowToDV(selectedRow);
            SvBill svBill = new SvBill();

            svBill.Mahd = this.Hoadon.ID;
            svBill.Tendv = dv.TenDV;
            svBill.Dongia = dv.GiaDV;
            svBill.Soluong = 1;
            svBill.Prices = svBill.Dongia*svBill.Soluong;
            lstsvBills.Add(svBill);

            totalSvBill += svBill.Prices;
            hoadon.Prices += svBill.Prices;
            tbPrices.Text = hoadon.Prices.ToString("N2");

            gvAddedServices.Rows.Add(SvBillToRow(svBill));
            gvServices.Rows.RemoveAt(e.RowIndex);

        }

        private void gvAddedServices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!isCellEmpty)
            {
                DataGridViewRow selectedRow = gvAddedServices.CurrentRow;
                SvBill svBill = AddedSvToSvBill(selectedRow);
                totalSvBill -= svBill.Prices;
                hoadon.Prices -= svBill.Prices;
                tbPrices.Text = hoadon.Prices.ToString("N2");
                //lstSelectedSV.RemoveAll(item => item.IdService == (int)servicerow.Cells["iddv2"].Value &&
                //item.SoPhong == sophong);
                lstsvBills.RemoveAll(item => item.Tendv == svBill.Tendv);
                filteredDV = dsDV.Where(dv => !lstsvBills.Any(rs => rs.Tendv == dv.TenDV)).ToList();
                gvServices.Rows.Clear();
                gvAddedServices.Rows.RemoveAt(e.RowIndex);


                foreach (DV dv in filteredDV)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(gvServices, dv.TenDV, dv.LoaiDV, dv.GiaDV, dv.ID);
                    gvServices.Rows.Add(row);
                }
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            int mahd = this.Hoadon.ID;
            //update khachhang
            KhachHang kh = new KhachHang();
            kh.ID = hoadon.Makh;
            kh.CCCD = guna2TextBoxCCCD.Text;
            kh.HoTen = guna2TextBoxName.Text; 
            kh.DienThoai = guna2TextBoxPhone.Text;
            kh.DiaChi = guna2TextBoxAddress.Text;
            kh.Email = guna2TextBoxEmail.Text;

            if (!KhachHangDAO.Instance.UpdateKH(kh))
            {
                MessageBox.Show("Kiểm tra lại thông tin khách hàng");
                return;
            }
            int makh = KhachHangDAO.Instance.getidbycccd(kh.CCCD);
            
            //update hoadon
            hoadon.Makh = makh;
            hoadon.Checkin = guna2DateStart.Value;
            hoadon.Checkout = guna2DateEnd.Value;
            BillDAO.Instance.UpdateHoadon(hoadon);

            //updatebill với mahd
            SvBillDAO.Instance.deleteSvBill(mahd);
            foreach(SvBill svBill in lstsvBills)
            {
                SvBillDAO.Instance.AddSvBill(svBill);
            }

        }

        private void gvAddedServices_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void gvAddedServices_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gvAddedServices.CurrentCell.ColumnIndex == SL.Index)
            {
                TextBox textBox = e.Control as TextBox;
                if (textBox != null)
                {
                    textBox.KeyPress += TextBox_KeyPress;
                }
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FormEditBooking_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormBooking formbooking = Application.OpenForms.OfType<FormBooking>().FirstOrDefault();
            if (formbooking != null)
            {
                formbooking.ShowBills();
            }
        }

        private bool isCellEmpty = true;

        private void gvAddedServices_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridViewRow row = gvAddedServices.Rows[e.RowIndex];
            DataGridViewCell cell = row.Cells[e.ColumnIndex];
            string cellValue = e.FormattedValue?.ToString();

            if (string.IsNullOrWhiteSpace(cellValue))
            {
                // Ô không có giá trị, hủy bỏ việc di chuyển đến ô khác
                gvAddedServices.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;
                gvAddedServices.CurrentCell = cell;
                gvAddedServices.BeginEdit(false);
                //gvAddedServices.EndEdit(false);
                e.Cancel = true;
            }
            else
            {
                isCellEmpty = false;
            }
        }

        private void guna2TextBoxCCCD_TextChanged(object sender, EventArgs e)
        {
            string idCard = guna2TextBoxCCCD.Text;

            // Kiểm tra độ dài của chuỗi và xác minh rằng nó chứa toàn số và đúng 12 ký tự
            if (idCard.Length != 12 || !idCard.All(char.IsDigit))
            {
                // Hiển thị thông báo lỗi bằng Label
                label2.Text = "ID Card phải chứa đúng 12 số.";
                label2.Visible = true;
            }
            else
            {
                // Ẩn thông báo lỗi nếu không có lỗi
                label2.Visible = false;
            }
        }

        private void guna2TextBoxCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Hủy bỏ ký tự nhập vào
                e.Handled = true;
            }
        }

        private void guna2TextBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Hủy bỏ ký tự nhập vào
                e.Handled = true;
            }
        }

        private void guna2TextBoxPhone_TextChanged(object sender, EventArgs e)
        {
            string phone = guna2TextBoxPhone.Text;

            // Kiểm tra độ dài của chuỗi và xác minh rằng nó có định dạng đúng
            if (phone.Length != 11 || !phone.StartsWith("84") || !phone.All(char.IsDigit))
            {
                label4.Visible = true;
            }
            else
            {
                label4.Visible = false;
            }
        }

        private void guna2TextBoxEmail_TextChanged(object sender, EventArgs e)
        {
            string email = guna2TextBoxEmail.Text;

            // Kiểm tra định dạng email
            string pattern = @"^[a-zA-Z0-9]+@gmail\.com$";
            bool isValid = Regex.IsMatch(email, pattern);

            if (!isValid)
            {
                // Hiển thị thông báo lỗi
                label3.Visible = true;
            }
            else
            {
                label3.Visible = false;
            }
        }

        private void gvAddedServices_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (!isCellEmpty)
            {
                DataGridViewRow row = gvAddedServices.Rows[e.RowIndex];
                //if (row.Cells["SL"].Value)
                SvBill svBill = AddedSvToSvBill(row);
                SvBill Item = lstsvBills.FirstOrDefault(item => item.Tendv == svBill.Tendv);
                int old = Item.Soluong;
                Item.Soluong = svBill.Soluong;
                Item.Prices = Item.Dongia * Item.Soluong;
                gvAddedServices.Rows[e.RowIndex].Cells["total"].Value = Item.Prices;
                decimal delta = Item.Dongia * (Item.Soluong - old);
                totalSvBill += delta;
                hoadon.Prices += delta;
                tbPrices.Text = hoadon.Prices.ToString("N2");
            }
        }

        private void btMakeBill_MouseEnter(object sender, EventArgs e)
        {
            var button = (Guna2Button)sender;
            button.FillColor = Color.ForestGreen;
            button.ForeColor = Color.White;
        }

        private void btMakeBill_MouseLeave(object sender, EventArgs e)
        {
            var button = (Guna2Button)sender;
            button.FillColor = Color.FromArgb(40, 40, 80);
            button.ForeColor = Color.ForestGreen;
        }

        private void btEdit_MouseEnter(object sender, EventArgs e)
        {
            var button = (Guna2Button)sender;
            button.FillColor = Color.DarkGoldenrod;
            button.ForeColor = Color.White;
        }

        private void btEdit_MouseLeave(object sender, EventArgs e)
        {
            var button = (Guna2Button)sender;
            button.FillColor = Color.FromArgb(40, 40, 80);
            button.ForeColor = Color.DarkGoldenrod;
        }

        private void guna2ButtonDelete_MouseEnter(object sender, EventArgs e)
        {
            var button = (Guna2Button)sender;
            button.FillColor = Color.Firebrick;
            button.ForeColor = Color.White;
        }

        private void guna2ButtonDelete_MouseLeave(object sender, EventArgs e)
        {
            var button = (Guna2Button)sender;
            button.FillColor = Color.FromArgb(40, 40, 80);
            button.ForeColor = Color.Firebrick;
        }

        private void guna2DateStart_MouseEnter(object sender, EventArgs e)
        {
            var dtp = (Guna2DateTimePicker)sender;
            dtp.FillColor = Color.FromArgb(80, 80, 200);
            dtp.ForeColor = Color.White;
        }

        private void guna2DateStart_MouseLeave(object sender, EventArgs e)
        {
            var dtp = (Guna2DateTimePicker)sender;
            dtp.FillColor = Color.FromArgb(60, 60, 100);
            dtp.ForeColor = Color.Black;
        }
    }
}
