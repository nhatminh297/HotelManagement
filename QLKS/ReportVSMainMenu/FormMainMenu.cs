using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using QLKS.FormAccount;

namespace QLKS.FormManager
{
    public partial class FormMainMenu : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public FormMainMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            panelMenu.Controls.Add(leftBorderBtn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(4, 186, 51);
            public static Color color7 = Color.FromArgb(239, 217, 33);
            public static Color color8 = Color.FromArgb(24, 161, 251);


        }
        //methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon current child form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
                lbTitleChildForm.ForeColor = color;
                lbTitleChildForm.Text = currentBtn.Text;

            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(30, 31, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btBooking_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormBooking());
        }

        private void btCustomer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new FormCustomers());
            
        }

        private void Room_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new FormRoom());

        }

        private void btServices_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new FormServices());

        }

        private void btAccounts_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new FormManageAccount());
            
        }

        private void btBill_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            
        }

        private void btReport_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8);

            DialogResult result = MessageBox.Show("Did you want to logout?", "Confirm!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                // Thực hiện 

            }
            else if (result == DialogResult.Cancel)
            {
                //
            }

        }

        private void btHome_Click(object sender, EventArgs e)
        {
            
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.HomeLg;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lbTitleChildForm.Text = "Home";
            lbTitleChildForm.ForeColor = Color.MediumPurple;
            OpenChildForm(new FormHome());
        }
        //drag form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMaximize_Click(object sender, EventArgs e)
        {
            if(WindowState != FormWindowState.Maximized)
                WindowState = FormWindowState.Maximized;
            else WindowState = FormWindowState.Normal;
        }

        private void iconMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            OpenChildForm(new FormHome());
        }
    }
}
