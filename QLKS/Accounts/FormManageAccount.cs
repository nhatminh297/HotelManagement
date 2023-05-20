using Guna.UI2.WinForms;
using QLKS.FormAccount;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS.FormManager
{
    public partial class FormManageAccount : Form
    {
        string manv;
        string username;
        string password;
        string role;
        public FormManageAccount()
        {
            InitializeComponent();
        }

        private void tbsearchacc_Enter(object sender, EventArgs e)
        {
            Guna2TextBox tb = (Guna2TextBox)sender;   
            if (tb.Text == "Tìm kiếm tài khoản")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }

        private void tbsearchacc_Leave(object sender, EventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Tìm kiếm tài khoản";
                textBox.ForeColor = Color.Gray;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FormEditAccount frm = new FormEditAccount(manv,username,password,role);
            frm.ShowDialog();

        }
        
        private void Update()
        {
            guna2DataGridView1.DataSource = GetAccounts().Tables[0];
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            FormAddAccount frm = new FormAddAccount();
            frm.truyen = new FormAddAccount.truyendulieu(Update);
            frm.ShowDialog();
        }

        DataSet GetAccounts()
        {
            DataSet data= new DataSet();
            string query = "select MaNV,UserName,Password,Role from Accounts";
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlDataAdapter adapter=new SqlDataAdapter(query, sqlConnection);
                adapter.Fill(data);
                sqlConnection.Close();
            }
            return data;
        }
        private void FormManageAccount_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = GetAccounts().Tables[0];
            //guna2DataGridView1.DataMember = "Accounts";
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = GetAccounts().Tables[0];
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = guna2DataGridView1.CurrentRow.Index;
            if(i!=0 )
            {
                manv = guna2DataGridView1.Rows[i].Cells[0].Value.ToString();
                username = guna2DataGridView1.Rows[i].Cells[1].Value.ToString();
                password = guna2DataGridView1.Rows[i].Cells[2].Value.ToString();
                role = guna2DataGridView1.Rows[i].Cells[3].Value.ToString();
            }
        }

        Modify modify = new Modify();
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            int i = guna2DataGridView1.CurrentRow.Index;
            string manv= guna2DataGridView1.Rows[i].Cells[0].Value.ToString();
            if (manv.Trim()!="1")
            {
                string query = "delete from Accounts where manv='" + manv + "'";
                modify.Command(query);
            }
        }
    }
}
