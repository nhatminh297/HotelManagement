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
using System.Windows.Forms;

namespace QLKS
{
    public partial class FormAddRoom : Form
    {
        public FormAddRoom()
        {
            InitializeComponent();
        }

        private void guna2ButtonDelete_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btMakeBill_Click(object sender, EventArgs e)
        {
            Phong phong = new Phong();
            phong.SoPhong = int.Parse(tbRoomNumber.Text);
            phong.SucChua = int.Parse(tbCapacity.Text);
            phong.MoTa = tbDescribe.Text;
            phong.TrangThai = "Trống";
            phong.GiaMoiGio = decimal.Parse(tbPrices.Text);
            phong.TenLoaiPhong = guna2ComboBoxtype.Text;

            if(PhongDAO.Instance.AddRoom(phong) != 0)
            {
                FormRoom formroom = Application.OpenForms.OfType<FormRoom>().FirstOrDefault();
                if (formroom != null)
                {
                    formroom.loadRooms();
                }
                DialogResult result = MessageBox.Show("Thêm phòng mới thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult result = MessageBox.Show("Số phòng bị trùng", "Thông báo", MessageBoxButtons.OK);
                return;
            }

        }
    }
}
