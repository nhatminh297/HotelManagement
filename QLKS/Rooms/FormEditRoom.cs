using Guna.UI2.WinForms;
using QLKS.DAO;
using QLKS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace QLKS
{
    public partial class FormEditRoom : Form
    {
        private Phong phong;
        public FormEditRoom(Phong phong)
        {
            this.phong = phong;
            InitializeComponent();
            loadPhong();
        }

        public Phong Phong { get => phong; set => phong = value; }

        private void guna2ButtonDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadPhong()
        {
            guna2TextBox3.Text = "Edit room " + phong.SoPhong.ToString();
            tbRoomNumber.Text = phong.SoPhong.ToString();
            guna2ComboBoxtype.SelectedIndex = guna2ComboBoxtype.Items.IndexOf(phong.TenLoaiPhong);
            tbCapacity.Text = phong.SucChua.ToString();
            tbPrices.Text = ((int)phong.GiaMoiGio).ToString();
            tbDescribe.Text = phong.MoTa;
        }

        private void guna2ButtonConfirm_Click(object sender, EventArgs e)
        {
            phong.SoPhong = int.Parse(tbRoomNumber.Text);
            phong.TenLoaiPhong = guna2ComboBoxtype.Text;
            phong.SucChua = int.Parse(tbCapacity.Text);
            phong.GiaMoiGio = decimal.Parse(tbPrices.Text);
            phong.MoTa = tbDescribe.Text;
            
            int rowaffect = PhongDAO.Instance.UpdateRoom(phong);
            if (rowaffect != 0)
            {
                MessageBox.Show("Update thành công!", "Thông báo", MessageBoxButtons.OK);
                FormRoom formroom = Application.OpenForms.OfType<FormRoom>().FirstOrDefault();
                if (formroom != null)
                {
                    formroom.loadRooms();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin!", "Thông báo", MessageBoxButtons.OK);
            }

        }

        private void tbRoomNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbRoomNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbRoomNumber.Text))
            {
                e.Cancel = true; // Ngăn người dùng di chuyển khỏi TextBox nếu trống
                tbRoomNumber.Focus(); // Đưa trỏ chuột vào TextBox
            }
        }
    }
}
