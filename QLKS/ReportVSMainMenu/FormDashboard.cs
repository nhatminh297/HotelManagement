using QLKS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS.ReportVSMainMenu
{
    public partial class FormDashboard : Form
    {
        private Dashboard model;
        private Button currentButton;
        //Constructor
        public FormDashboard()
        {
            InitializeComponent();
            //Default - Last 7 days
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            btLast7Days.Select();
            SetDateMenuButtonUI(btLast7Days);
            model = new Dashboard();
            LoadData();
        }
        //Private methods
        private void LoadData()
        {
            var refreshData = model.LoadData(dtpStartDate.Value, dtpEndDate.Value);
            if (refreshData == true)
            {
                lbNumberBooking.Text = model.NumHoadon.ToString();
                lbTotalRevenue.Text = model.TotalRevenue.ToString("N2")+ "₫";
                lbTotalProfit.Text = model.TotalProfit.ToString("N2")+ "₫";
                lbNumberCustomers.Text = model.NumCustomers.ToString();
                lbNumberRooms.Text = model.NumRooms.ToString();
                lbNumberServices.Text = model.NumServices.ToString();
                chartGrossRevenue.DataSource = model.GrossRevenueList;
                chartGrossRevenue.Series[0].XValueMember = "Date";
                chartGrossRevenue.Series[0].YValueMembers = "TotalAmount";
                chartGrossRevenue.DataBind();

                chartTopServices.DataSource = model.TopServicesList;
                chartTopServices.Series[0].XValueMember = "Key";
                chartTopServices.Series[0].YValueMembers = "Value";
                chartTopServices.DataBind();

                chartRoomtype.DataSource = model.TopRoomTypeList;
                chartRoomtype.Series[0].XValueMember = "Key";
                chartRoomtype.Series[0].YValueMembers = "Value";
                chartRoomtype.DataBind();

                dgvLowServices.DataSource = model.LowServiceslist;
                dgvLowServices.Columns[0].HeaderText = "Item";
                dgvLowServices.Columns[1].HeaderText = "Units";
                Console.WriteLine("Loaded view :)");
            }
            else Console.WriteLine("View not loaded, same query");
        }

        private void SetDateMenuButtonUI(object button)
        {
            var btn = (Button)button;
            if (button != btCustomDate)
            {
                btOkCustomDate.Visible = false;
            }
            btn.BackColor = btLast30Days.FlatAppearance.BorderColor;
            btn.ForeColor = Color.White;

            if(currentButton != null && currentButton != btn)
            {
                currentButton.BackColor = guna2Panel1.BackColor; 
                currentButton.ForeColor = Color.DarkGray;
            }
            currentButton = btn;

            //dtpStartDate.Enabled = false;
            //dtpEndDate.Enabled = false;
            //btOkCustomDate.Visible = false;
        }
        //Event 
        private void btThisMonth_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEndDate.Value = DateTime.Now;
            label1.Text = "-3%";
            label7.Text = "+9%";
            label9.Text = "-6%";
            LoadData();
            SetDateMenuButtonUI(sender);
        }

        private void btLast30Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;
            label1.Text = "+7%";
            label7.Text = "+19%";
            label9.Text = "+18%";
            LoadData();
            SetDateMenuButtonUI(sender);
        }

        private void btLast7Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            label1.Text = "+5%";
            label7.Text = "-12%";
            label9.Text = "+7%";
            LoadData();
            SetDateMenuButtonUI(sender);
        }

        private void btTodays_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Now;
            label1.Text = "-6%";
            label7.Text = "+12%";
            label9.Text = "+15%";
            LoadData();
            SetDateMenuButtonUI(sender);
        }

        private void btOkCustomDate_Click(object sender, EventArgs e)
        {
            label1.Text = "+5%";
            label7.Text = "+13%";
            label9.Text = "+19%";
            LoadData();
        }

        private void btCustomDate_Click(object sender, EventArgs e)
        {
            dtpStartDate.Enabled = true;
            dtpEndDate.Enabled = true;
            btOkCustomDate.Visible = true;
            SetDateMenuButtonUI(sender);
        }

        private void lbStartDate_Click(object sender, EventArgs e)
        {
            if(currentButton == btCustomDate)
            {
                dtpStartDate.Select();
                SendKeys.Send("%{Down}");
            }
        }

        private void lbEndDate_Click(object sender, EventArgs e)
        {
            if (currentButton == btCustomDate)
            {
                dtpEndDate.Select();
                SendKeys.Send("%{Down}");
            }
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            lbStartDate.Text = dtpStartDate.Text;
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            lbEndDate.Text = dtpEndDate.Text;
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            lbStartDate.Text = dtpStartDate.Text;
            lbEndDate.Text = dtpEndDate.Text;
            dgvLowServices.Columns[1].Width  = 50;
        }
    }
}
