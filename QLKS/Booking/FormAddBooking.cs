using Guna.UI2.WinForms;
using QLKS.DAO;
using QLKS.DTO;
using QLKS.FormManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QLKS
{
    public partial class FormAddBooking : Form
    {
        private int Id;
        public FormAddBooking(int id)
        {
            this.Id = id;
            InitializeComponent();
            showRooms();
            ShowServices();
        }

        private BindingSource bs;

        #region methods
        public void load()
        {
            guna2TextBoxName.Text = "Full Name";
            guna2TextBoxCCCD.Text = "ID Number";
            guna2TextBoxPhone.Text = "Phone(+84)";
            guna2TextBoxEmail.Text = "Email Address";
            guna2TextBoxAddress.Text = "Address";
            tbPrices.Text = "0,00";
            showRooms();
            ShowServices();
        }

        public void showRooms()
        {
            gvRooms.Rows.Clear();
            gvAddedRooms.Rows.Clear();

            List<Phong> dsPhong = PhongDAO.Instance.GetAvailableRoom();

            foreach (Phong phong in dsPhong)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(gvRooms, phong.SoPhong, phong.TenLoaiPhong, phong.SucChua, phong.GiaMoiGio, phong.ID, phong.MoTa, phong.TrangThai);
                gvRooms.Rows.Add(row);
            }

        }

        public void ShowServices()
        {
            gvServices.Rows.Clear();
            gvAddedServices.Rows.Clear();

            List<DV> dsDV = DVDAO.Instance.GetAvailableServices();

            foreach (DV dv in dsDV)
            {
                DataGridViewRow row =new DataGridViewRow();
                row.CreateCells(gvServices, dv.ID, dv.TenDV, dv.LoaiDV, dv.GiaDV);
                gvServices.Rows.Add(row);
            }
        }

        List<SelectedServices> lstSelectedSV = new List<SelectedServices>();
        List<Phong> lstSelectedRoom = new List<Phong>();
        List<TotalPrices> lstTotalPrices = new List<TotalPrices>();
        List<KeyValuePair<int, int>> listSoP_SoG = new List<KeyValuePair<int, int>>();

        public int Id1 { get => Id; set => Id = value; }

        #endregion

        #region events
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
            if (gvAddedRooms.SelectedRows.Count != 0)
            {
                DataGridViewRow selectedRoom = gvAddedRooms.SelectedRows[0];
                int sophong = (int)selectedRoom.Cells["sophong2"].Value;
                int index = listSoP_SoG.FindIndex(x => x.Key == sophong);
                int number;
                bool check = int.TryParse(guna2tbTime.Text, out number);
                if (index != -1 && check)
                {
                    int oldtime = listSoP_SoG[index].Value;
                    listSoP_SoG[index] = new KeyValuePair<int, int>(sophong, int.Parse(guna2tbTime.Text));
                    TotalPrices prices = lstTotalPrices.Find(x => x.SoPhong == sophong);

                    prices.Price += (listSoP_SoG[index].Value - oldtime) * lstSelectedRoom.Find(x => x.SoPhong == sophong).GiaMoiGio;

                    tbPrices.Text = prices.Price.ToString("N2");

                }

            }
            UpdateDateTimePicker2Value();

        }

        private void guna2tbTime_Leave(object sender, EventArgs e)
        {

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

            if (gvAddedRooms.SelectedRows.Count != 0)
            {
                DataGridViewRow selectedRoom = gvAddedRooms.SelectedRows[0];
                int sophong = (int)selectedRoom.Cells["sophong2"].Value;
                int index = listSoP_SoG.FindIndex(x => x.Key == sophong);
                if (index != -1)
                {
                    listSoP_SoG[index] = new KeyValuePair<int, int>(sophong, int.Parse(guna2tbTime.Text));
                }
            }
        }

        private void guna2DateEnd_MouseEnter(object sender, EventArgs e)
        {
            var dtp = (Guna2DateTimePicker)sender;
            dtp.FillColor = Color.FromArgb(80, 80, 200);
            dtp.ForeColor = Color.White;
        }

        private void guna2DateEnd_MouseLeave(object sender, EventArgs e)
        {
            var dtp = (Guna2DateTimePicker)sender;
            dtp.FillColor = Color.FromArgb(60, 60, 100);
            dtp.ForeColor = Color.Black;
        }

        private void guna2ButtonDelete_MouseHover(object sender, EventArgs e)
        {
            var button = (Guna2Button)sender;
            button.FillColor = Color.Firebrick;
            button.ForeColor = Color.White;
        }

        private void guna2ButtonDelete_MouseLeave(object sender, EventArgs e)
        {
            var button = (Guna2Button)sender;
            button.FillColor = Color.FromArgb(50, 50, 90);
            button.ForeColor = Color.Firebrick;
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
            button.FillColor = Color.FromArgb(50,50,90);
            button.ForeColor = Color.ForestGreen;
        }

        private void guna2ButtonDelete_Click(object sender, EventArgs e)
        {
            FormMainMenu formmainmenu = Application.OpenForms.OfType<FormMainMenu>().FirstOrDefault();
            formmainmenu.OpenChildForm(new FormBooking(Id));
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

       


        private void gvRooms_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = gvRooms.Rows[e.RowIndex];

            // Tạo một dòng mới trong gvAddedRooms
            DataGridViewRow addedRow = new DataGridViewRow();
            addedRow.CreateCells(gvAddedRooms);
            Phong phong = new Phong();
            

            for (int i = 0; i < selectedRow.Cells.Count; i++)
            {
                // Gán giá trị của các ô từ gvRooms sang gvAddedRooms
                addedRow.Cells[i].Value = selectedRow.Cells[i].Value;
            }
            phong.ID = (int)selectedRow.Cells["id"].Value;
            phong.SoPhong = (int)selectedRow.Cells["sophong"].Value;
            phong.TenLoaiPhong = selectedRow.Cells["loaiphong"].Value.ToString();
            phong.SucChua = (int)selectedRow.Cells["succhua"].Value;
            phong.GiaMoiGio = (decimal)selectedRow.Cells["giamoigio"].Value;
            phong.MoTa = selectedRow.Cells["mota"].ToString();
            phong.TrangThai = selectedRow.Cells["trangthai"].Value.ToString();

            int sogio = int.Parse(guna2tbTime.Text);
            listSoP_SoG.Add(new KeyValuePair<int, int>(phong.SoPhong, sogio));

            TotalPrices totalPrices = new TotalPrices();
            totalPrices.SoPhong = phong.SoPhong;
            totalPrices.Price = phong.GiaMoiGio * listSoP_SoG.FirstOrDefault(x => x.Key == phong.SoPhong).Value;
            lstTotalPrices.Add(totalPrices);

            lstSelectedRoom.Add(phong);
            gvAddedRooms.Rows.Add(addedRow);

            tbPrices.Text = totalPrices.Price.ToString("N2");
            // Xóa dòng từ gvRooms
            gvRooms.Rows.RemoveAt(e.RowIndex);
        }

        private void gvAddedRooms_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = gvAddedRooms.Rows[e.RowIndex];
            int sophong = (int)selectedRow.Cells["sophong2"].Value;

            // Tạo một dòng mới trong gvAddedRooms
            DataGridViewRow addedRow = new DataGridViewRow();
            addedRow.CreateCells(gvRooms);

            for (int i = 0; i < selectedRow.Cells.Count; i++)
            {
                // Gán giá trị của các ô từ gvRooms sang gvAddedRooms
                addedRow.Cells[i].Value = selectedRow.Cells[i].Value;
            }
            // Thêm dòng vào gvAddedRooms
            gvRooms.Rows.Add(addedRow);

            // Xóa dòng từ gvRooms

            gvAddedRooms.Rows.RemoveAt(e.RowIndex);
            lstSelectedRoom.RemoveAll(item => item.SoPhong == sophong);
            lstSelectedSV.RemoveAll(item => item.SoPhong == sophong);
            lstTotalPrices.RemoveAll(item => item.SoPhong == sophong);
            listSoP_SoG.RemoveAll(item => item.Key == sophong);

        }

        private void gvAddedRooms_SelectionChanged(object sender, EventArgs e)
        {
            
            DataGridViewRow selectedRoom = new DataGridViewRow();
            //kiểm tra xem còn phòng nào trong added room không
            if (gvAddedRooms.SelectedRows.Count != 0)
            {
                selectedRoom = gvAddedRooms.SelectedRows[0];
            }
            else // nếu không thì clear hết
            {
                lstSelectedSV.Clear();
                lstSelectedRoom.Clear();
                lstTotalPrices.Clear();
                tbPrices.Text = "0";
                gvAddedServices.Rows.Clear();
                selectedRoom = null;
                return;
            }

            gvServices.Rows.Clear();
            gvAddedServices.Rows.Clear();
            int sophong = (int)selectedRoom.Cells["sophong2"].Value;
            foreach (SelectedServices item in lstSelectedSV)
            {
                if (item.SoPhong == sophong)
                {
                    // Thêm dòng vào d22 với các thông tin tương ứng
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(gvAddedServices, item.IdService,
                                                     item.SoPhong,
                                                     item.ServicesName,
                                                     item.ServicesType,
                                                     item.Count,
                                                     item.Prices
                        );
                    gvAddedServices.Rows.Add(row); ;
                }
            }


            // kiểm tra xem phòng đang chọn có đặt dv nào chưa
            bool exists = lstSelectedSV.Any(item => item.SoPhong == sophong);
            List<DV> dsDV = DVDAO.Instance.GetAvailableServices();
            
            if (exists)
            {
                // trong này sẽ lấy các dịch vụ mà phòng hiện tại chưa đặt để hiển thị ở gvServices
                gvServices.Rows.Clear();
                List<SelectedServices> RoomServices = lstSelectedSV.Where(item => item.SoPhong == sophong).ToList();
                List<DV> filteredDV = dsDV.Where(dv => !RoomServices.Any(rs => rs.IdService == dv.ID)).ToList();
                foreach(DV dv in filteredDV)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(gvServices, dv.ID, dv.TenDV, dv.LoaiDV, dv.GiaDV);
                    gvServices.Rows.Add(row);
                }
            }
            else 
            {
                gvServices.Rows.Clear();
                ShowServices();
            }

            guna2tbTime.Text = listSoP_SoG.FirstOrDefault(x => x.Key == sophong).Value.ToString();
            TotalPrices prices = lstTotalPrices.Find(x => x.SoPhong == sophong);
            tbPrices.Text = prices.Price.ToString("N2");
        }

        private void gvServices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvAddedRooms.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng order dịch vụ này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow selectedRoom = gvAddedRooms.SelectedRows[0];
            DataGridViewRow servicerow = gvServices.Rows[e.RowIndex];

            SelectedServices selectedServices = new SelectedServices();
            selectedServices.IdService = (int)servicerow.Cells["iddv"].Value;
            selectedServices.SoPhong = (int)selectedRoom.Cells["sophong2"].Value;
            //kiểm tra xem dịch vụ đó đã thêm vào addedServices chưa
            bool exists = lstSelectedSV.Any(item => item.SoPhong == selectedServices.SoPhong && 
                                                    item.IdService == selectedServices.IdService);

            //nếu chưa thì thêm vào
            if (!exists)
            {
                selectedServices.ServicesName = servicerow.Cells["tendv"].Value.ToString();
                selectedServices.ServicesType = servicerow.Cells["loaidv"].Value.ToString();
                selectedServices.Count = 1;
                selectedServices.Prices = (decimal)servicerow.Cells["giadv"].Value;
                selectedServices.TotalPrices = selectedServices.Prices * (decimal)selectedServices.Count;
                lstSelectedSV.Add(selectedServices);

                

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(gvAddedServices, selectedServices.IdService,
                                                selectedServices.SoPhong,
                                                selectedServices.ServicesName,
                                                selectedServices.ServicesType,
                                                selectedServices.Count,
                                                selectedServices.Prices
                    );

                gvAddedServices.Rows.Add(row);
                gvServices.Rows.RemoveAt(e.RowIndex);
                for (int i = 0; i < lstTotalPrices.Count; i++)
                {
                    if (lstTotalPrices[i].SoPhong == selectedServices.SoPhong)
                    {
                        lstTotalPrices[i].Price += (decimal)selectedServices.Prices * (decimal)selectedServices.Count;
                        tbPrices.Text = lstTotalPrices[i].Price.ToString("N2");
                        break; // Thoát vòng lặp sau khi cập nhật thành công
                    }
                }
                
            }
            else
            {
                selectedServices = null;
            }

        }

        private void gvAddedServices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(gvAddedRooms.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng order dịch vụ này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow selectedRoom = gvAddedRooms.SelectedRows[0];
            int sophong = (int)selectedRoom.Cells["sophong2"].Value;
            DataGridViewRow servicerow = gvAddedServices.Rows[e.RowIndex];

            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(gvServices,
                            servicerow.Cells["iddv2"].Value,
                            servicerow.Cells["tendv2"].Value,
                            servicerow.Cells["loaidv2"].Value,
                            servicerow.Cells["giadv2"].Value
                );
            gvServices.Rows.Add(row);
            lstSelectedSV.RemoveAll(item => item.IdService == (int)servicerow.Cells["iddv2"].Value &&
                                            item.SoPhong == sophong);
            //cập nhật giá 
            for (int i = 0; i < lstTotalPrices.Count; i++)
            {
                if (lstTotalPrices[i].SoPhong == sophong)
                {
                    lstTotalPrices[i].Price -= decimal.Parse(servicerow.Cells["giadv2"].Value.ToString()) 
                                               * decimal.Parse(servicerow.Cells["SL"].Value.ToString());
                    tbPrices.Text = lstTotalPrices[i].Price.ToString("N2");
                    break; // Thoát vòng lặp sau khi cập nhật thành công
                }
            }
            gvAddedServices.Rows.RemoveAt(e.RowIndex);
        }

        private void gvAddedServices_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        #endregion

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

        private void guna2TextBoxCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Hủy bỏ ký tự nhập vào
                e.Handled = true;
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
                bool isExists = KhachHangDAO.Instance.IsExistsByCCCD(idCard);
                KhachHang kh = new KhachHang();
                if (isExists)
                {
                    kh = KhachHangDAO.Instance.getKHfromCCCD(idCard);
                    DialogResult res = MessageBox.Show("CCCD đã tồn tại, Bạn có muốn thêm khách hàng nay?", "Confirm", MessageBoxButtons.OKCancel);
                    if(res == DialogResult.OK)
                    {
                        guna2TextBoxName.Text = kh.HoTen;
                        guna2TextBoxCCCD.Text = kh.CCCD;
                        guna2TextBoxPhone.Text = kh.DienThoai;
                        guna2TextBoxEmail.Text = kh.Email;
                        guna2TextBoxAddress.Text = kh.DiaChi;
                    }

                }
                // Ẩn thông báo lỗi nếu không có lỗi
                label2.Visible = false;
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
            else { 
                label3.Visible = false; 
            }
        }

        public int checkNotValidSoGio(List<KeyValuePair<int, int>> listSop_Sog)
        {
            foreach (KeyValuePair<int, int> pair in listSop_Sog)
            {
                if (pair.Value == 0)
                {
                    int key = pair.Key;
                    // Thực hiện các xử lý tương ứng với key có value = 0
                    // Ví dụ: In ra key
                    return key;
                }
            }
            return -1;
        }

        private void btMakeBill_Click(object sender, EventArgs e)
        {
            btMakeBill.Focus();
            KhachHang kh = new KhachHang();
            kh.HoTen = guna2TextBoxName.Text;
            kh.CCCD = guna2TextBoxCCCD.Text;
            kh.DienThoai = guna2TextBoxPhone.Text;
            kh.Email = guna2TextBoxEmail.Text;
            kh.DiaChi = guna2TextBoxAddress.Text;

            int Notvalid_sophong = checkNotValidSoGio(listSoP_SoG);
            if (Notvalid_sophong != -1)
            {
                MessageBox.Show("Số giờ của phòng "+ Notvalid_sophong.ToString() + " là 0.");
                return;
            }

            if (lstSelectedRoom.Count == 0)
            {
                MessageBox.Show("Chưa chọn phòng bạn ei!.");
                return;
            }

            bool isvalidkh = KhachHangDAO.Instance.isValidKH(kh);
            if (!isvalidkh)
            {
                MessageBox.Show("Thông tin khách hàng không hợp lệ.");
                return;
            }
            int added = KhachHangDAO.Instance.AddKhachHang(kh);
            if (added == -1)
            {
                MessageBox.Show("Sai Tên Khách Hàng hoặc CCCD.");
                return;
            }
            int makh = KhachHangDAO.Instance.getidbycccd(kh.CCCD);
            foreach (Phong phong in lstSelectedRoom)
            {
                int IdHD = -1;
                if (phong != null)
                {
                    Bill bill = new Bill();
                    bill.Makh = makh;
                    bill.Manv = this.Id;
                    bill.Maphong = phong.ID;
                    bill.Sophong = phong.SoPhong;
                    bill.Tenloaiphong = phong.TenLoaiPhong;
                    bill.Giamoigio = phong.GiaMoiGio;

                    DateTime checkinDateTime = guna2DateStart.Value;
                    DateTime checkoutDateTime = guna2DateEnd.Value;
                    checkinDateTime = new DateTime(checkinDateTime.Year, checkinDateTime.Month, checkinDateTime.Day, checkinDateTime.Hour, checkinDateTime.Minute, 0);
                    checkoutDateTime = new DateTime(checkoutDateTime.Year, checkoutDateTime.Month, checkoutDateTime.Day, checkoutDateTime.Hour, checkoutDateTime.Minute, 0);

                    bill.Checkin = checkinDateTime;
                    bill.Checkout = checkoutDateTime;
                    bill.Prices = lstTotalPrices.Find(x=> x.SoPhong == phong.SoPhong).Price;
                    bill.Trangthai = "Chưa thanh toán";
                    //cập nhật trạng thái phòng
                    PhongDAO.Instance.EmptyToRent(phong);

                    IdHD = BillDAO.Instance.AddHoaDon(bill);

                    foreach(SelectedServices selectedServices in lstSelectedSV)
                    {
                        if(selectedServices.SoPhong == phong.SoPhong)
                        {
                            SvBill svBill = new SvBill(); 
                            svBill.Mahd = IdHD;
                            svBill.Tendv = selectedServices.ServicesName;
                            svBill.Dongia = selectedServices.Prices;
                            svBill.Soluong = selectedServices.Count;
                            svBill.Prices = selectedServices.TotalPrices;

                            SvBillDAO.Instance.AddSvBill(svBill);

                        }
                    }
                }
            }
            DialogResult result = MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                FormMainMenu formmainmenu = Application.OpenForms.OfType<FormMainMenu>().FirstOrDefault();
                formmainmenu.OpenChildForm(new FormBooking(formmainmenu.Id1));
            }

        }

        private void FormAddBooking_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormBooking formbooking = Application.OpenForms.OfType<FormBooking>().FirstOrDefault();
            if(formbooking != null)
            {
                formbooking.ShowBills();
            }
        }

        private void gvAddedServices_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == SL.Index) // Kiểm tra chỉ khi kết thúc chỉnh sửa cột số lượng
            {
                DataGridViewCell cell = gvAddedServices.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if(cell.Value == null)
                {
                    gvAddedServices.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;
                }
                if (cell.Value != null)
                {
                    int quantity;
                    if (int.TryParse(cell.Value.ToString(), out quantity))
                    {
                        // Thực hiện các thay đổi trong giá trị prices dựa trên giá trị số lượng mới
                        int rowIndex = e.RowIndex; // Vị trí dòng được chỉnh sửa
                        DataGridViewRow editedRow = gvAddedServices.Rows[rowIndex];
                        int count = int.Parse(editedRow.Cells["SL"].Value.ToString());
                        int sophong = int.Parse(editedRow.Cells["sophong3"].Value.ToString());
                        int id = int.Parse(editedRow.Cells["iddv2"].Value.ToString());
                        int oldcount = 0;
                        // Cập nhật giá trị prices tương ứng
                        SelectedServices selectedServices = lstSelectedSV.Find(x => x.IdService == id && x.SoPhong == sophong);
                        if (selectedServices != null)
                        {
                            TotalPrices totalPrices = lstTotalPrices.Find(x => x.SoPhong == sophong);
                            if (selectedServices != null)
                            {
                                // Cập nhật giá trị của object
                                oldcount = selectedServices.Count;
                                selectedServices.Count = count;
                                selectedServices.TotalPrices = selectedServices.Prices * (decimal)count;
                            }
                            // Hiển thị giá trị prices lên TextBox hoặc nơi khác
                            totalPrices.Price += (selectedServices.Prices * (count - oldcount));
                            tbPrices.Text = totalPrices.Price.ToString("N2");
                        }
                    }
                    else
                    {
                        // Nếu giá trị không hợp lệ (không phải số nguyên), xử lý tại đây
                        // Ví dụ: Hiển thị thông báo lỗi cho người dùng
                        MessageBox.Show("Vui lòng nhập số nguyên vào ô số lượng.");
                        // Hoặc có thể thiết lập giá trị mặc định hoặc xử lý khác tùy theo yêu cầu
                    }
                }
            }
        }

        
    }
}
