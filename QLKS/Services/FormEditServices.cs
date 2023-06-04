using QLKS.DAO;
using QLKS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class FormEditServices : Form
    {
        private DV dv;
        public FormEditServices(DV dv)
        {
            this.Dv = dv;
            InitializeComponent();
            loadSelectedDV();
        }

        public DV Dv { get => dv; set => dv = value; }

        private void guna2ButtonDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadSelectedDV()
        {
            tbSvName.Text = dv.TenDV;
            tbPrices.Text = ((int)dv.GiaDV).ToString();
            guna2ComboBoxtype.SelectedIndex = guna2ComboBoxtype.Items.IndexOf(dv.LoaiDV);
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            int number;
            bool check = int.TryParse(tbPrices.Text, out number);
            if (check)
            {
                DV dV = new DV();
                dV.TenDV = tbSvName.Text;
                dV.LoaiDV = guna2ComboBoxtype.Text;
                dV.GiaDV = decimal.Parse(tbPrices.Text);
                int rowaffected = DVDAO.Instance.UpdateDV(dV);
                if (rowaffected != 0)
                {
                    FormServices form = Application.OpenForms.OfType<FormServices>().FirstOrDefault();
                    if (form != null)
                    {
                        form.loadServices();
                    }
                    DialogResult result = MessageBox.Show("Thêm dịch vụ mới thành công!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    DialogResult result = MessageBox.Show("Tên dịch vụ đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                return;
            }
        }

        private void tbPrices_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
