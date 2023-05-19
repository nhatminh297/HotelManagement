namespace QLKS.FormManager
{
    partial class FormMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FontAwesome.Sharp.IconPictureBox iconExit;
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btReport = new FontAwesome.Sharp.IconButton();
            this.btAccounts = new FontAwesome.Sharp.IconButton();
            this.btBill = new FontAwesome.Sharp.IconButton();
            this.btLogout = new FontAwesome.Sharp.IconButton();
            this.btServices = new FontAwesome.Sharp.IconButton();
            this.Room = new FontAwesome.Sharp.IconButton();
            this.btCustomer = new FontAwesome.Sharp.IconButton();
            this.btBooking = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btHome = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.iconMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.guna2pnShadow = new Guna.UI2.WinForms.Guna2GradientPanel();
            iconExit = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(iconExit)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btHome)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximize)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // iconExit
            // 
            iconExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            iconExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            iconExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            iconExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            iconExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            iconExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconExit.IconSize = 20;
            iconExit.Location = new System.Drawing.Point(871, 3);
            iconExit.Name = "iconExit";
            iconExit.Size = new System.Drawing.Size(30, 20);
            iconExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            iconExit.TabIndex = 3;
            iconExit.TabStop = false;
            iconExit.Click += new System.EventHandler(this.iconExit_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btReport);
            this.panelMenu.Controls.Add(this.btAccounts);
            this.panelMenu.Controls.Add(this.btBill);
            this.panelMenu.Controls.Add(this.btLogout);
            this.panelMenu.Controls.Add(this.btServices);
            this.panelMenu.Controls.Add(this.Room);
            this.panelMenu.Controls.Add(this.btCustomer);
            this.panelMenu.Controls.Add(this.btBooking);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(180, 561);
            this.panelMenu.TabIndex = 0;
            // 
            // btReport
            // 
            this.btReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btReport.FlatAppearance.BorderSize = 0;
            this.btReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReport.ForeColor = System.Drawing.Color.Gainsboro;
            this.btReport.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTrendUp;
            this.btReport.IconColor = System.Drawing.Color.Gainsboro;
            this.btReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btReport.IconSize = 32;
            this.btReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btReport.Location = new System.Drawing.Point(0, 415);
            this.btReport.Name = "btReport";
            this.btReport.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btReport.Size = new System.Drawing.Size(180, 50);
            this.btReport.TabIndex = 8;
            this.btReport.Text = "Report";
            this.btReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btReport.UseVisualStyleBackColor = true;
            this.btReport.Click += new System.EventHandler(this.btReport_Click);
            // 
            // btAccounts
            // 
            this.btAccounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btAccounts.FlatAppearance.BorderSize = 0;
            this.btAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAccounts.ForeColor = System.Drawing.Color.Gainsboro;
            this.btAccounts.IconChar = FontAwesome.Sharp.IconChar.PeopleLine;
            this.btAccounts.IconColor = System.Drawing.Color.Gainsboro;
            this.btAccounts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btAccounts.IconSize = 32;
            this.btAccounts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAccounts.Location = new System.Drawing.Point(0, 365);
            this.btAccounts.Name = "btAccounts";
            this.btAccounts.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btAccounts.Size = new System.Drawing.Size(180, 50);
            this.btAccounts.TabIndex = 5;
            this.btAccounts.Text = "Accounts";
            this.btAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAccounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAccounts.UseVisualStyleBackColor = true;
            this.btAccounts.Click += new System.EventHandler(this.btAccounts_Click);
            // 
            // btBill
            // 
            this.btBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.btBill.FlatAppearance.BorderSize = 0;
            this.btBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBill.ForeColor = System.Drawing.Color.Gainsboro;
            this.btBill.IconChar = FontAwesome.Sharp.IconChar.MoneyBillWave;
            this.btBill.IconColor = System.Drawing.Color.Gainsboro;
            this.btBill.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btBill.IconSize = 32;
            this.btBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBill.Location = new System.Drawing.Point(0, 315);
            this.btBill.Name = "btBill";
            this.btBill.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btBill.Size = new System.Drawing.Size(180, 50);
            this.btBill.TabIndex = 6;
            this.btBill.Text = "Bill";
            this.btBill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btBill.UseVisualStyleBackColor = true;
            this.btBill.Click += new System.EventHandler(this.btBill_Click);
            // 
            // btLogout
            // 
            this.btLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btLogout.FlatAppearance.BorderSize = 0;
            this.btLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btLogout.IconChar = FontAwesome.Sharp.IconChar.PersonWalkingDashedLineArrowRight;
            this.btLogout.IconColor = System.Drawing.Color.Gainsboro;
            this.btLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btLogout.IconSize = 32;
            this.btLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLogout.Location = new System.Drawing.Point(0, 511);
            this.btLogout.Name = "btLogout";
            this.btLogout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btLogout.Size = new System.Drawing.Size(180, 50);
            this.btLogout.TabIndex = 7;
            this.btLogout.Text = "Logout";
            this.btLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btServices
            // 
            this.btServices.Dock = System.Windows.Forms.DockStyle.Top;
            this.btServices.FlatAppearance.BorderSize = 0;
            this.btServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btServices.ForeColor = System.Drawing.Color.Gainsboro;
            this.btServices.IconChar = FontAwesome.Sharp.IconChar.BellConcierge;
            this.btServices.IconColor = System.Drawing.Color.Gainsboro;
            this.btServices.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btServices.IconSize = 32;
            this.btServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btServices.Location = new System.Drawing.Point(0, 265);
            this.btServices.Name = "btServices";
            this.btServices.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btServices.Size = new System.Drawing.Size(180, 50);
            this.btServices.TabIndex = 4;
            this.btServices.Text = "Services";
            this.btServices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btServices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btServices.UseVisualStyleBackColor = true;
            this.btServices.Click += new System.EventHandler(this.btServices_Click);
            // 
            // Room
            // 
            this.Room.Dock = System.Windows.Forms.DockStyle.Top;
            this.Room.FlatAppearance.BorderSize = 0;
            this.Room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Room.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Room.ForeColor = System.Drawing.Color.Gainsboro;
            this.Room.IconChar = FontAwesome.Sharp.IconChar.Shop;
            this.Room.IconColor = System.Drawing.Color.Gainsboro;
            this.Room.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Room.IconSize = 32;
            this.Room.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Room.Location = new System.Drawing.Point(0, 215);
            this.Room.Name = "Room";
            this.Room.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Room.Size = new System.Drawing.Size(180, 50);
            this.Room.TabIndex = 3;
            this.Room.Text = "Rooms";
            this.Room.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Room.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Room.UseVisualStyleBackColor = true;
            this.Room.Click += new System.EventHandler(this.Room_Click);
            // 
            // btCustomer
            // 
            this.btCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCustomer.FlatAppearance.BorderSize = 0;
            this.btCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCustomer.ForeColor = System.Drawing.Color.Gainsboro;
            this.btCustomer.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btCustomer.IconColor = System.Drawing.Color.Gainsboro;
            this.btCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btCustomer.IconSize = 32;
            this.btCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCustomer.Location = new System.Drawing.Point(0, 165);
            this.btCustomer.Name = "btCustomer";
            this.btCustomer.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btCustomer.Size = new System.Drawing.Size(180, 50);
            this.btCustomer.TabIndex = 2;
            this.btCustomer.Text = "Customer";
            this.btCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCustomer.UseVisualStyleBackColor = true;
            this.btCustomer.Click += new System.EventHandler(this.btCustomer_Click);
            // 
            // btBooking
            // 
            this.btBooking.Dock = System.Windows.Forms.DockStyle.Top;
            this.btBooking.FlatAppearance.BorderSize = 0;
            this.btBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBooking.ForeColor = System.Drawing.Color.Gainsboro;
            this.btBooking.IconChar = FontAwesome.Sharp.IconChar.HouseMedicalFlag;
            this.btBooking.IconColor = System.Drawing.Color.Gainsboro;
            this.btBooking.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btBooking.IconSize = 32;
            this.btBooking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBooking.Location = new System.Drawing.Point(0, 115);
            this.btBooking.Name = "btBooking";
            this.btBooking.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btBooking.Size = new System.Drawing.Size(180, 50);
            this.btBooking.TabIndex = 1;
            this.btBooking.Text = "Booking";
            this.btBooking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBooking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btBooking.UseVisualStyleBackColor = true;
            this.btBooking.Click += new System.EventHandler(this.btBooking_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(180, 115);
            this.panelLogo.TabIndex = 0;
            // 
            // btHome
            // 
            this.btHome.BackColor = System.Drawing.Color.Transparent;
            this.btHome.Image = global::QLKS.Properties.Resources.logoo_removebg_preview;
            this.btHome.Location = new System.Drawing.Point(12, 12);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(155, 88);
            this.btHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btHome.TabIndex = 0;
            this.btHome.TabStop = false;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.iconMinimize);
            this.panel1.Controls.Add(this.iconMaximize);
            this.panel1.Controls.Add(iconExit);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(180, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 65);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // iconMinimize
            // 
            this.iconMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.iconMinimize.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.iconMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMinimize.IconSize = 20;
            this.iconMinimize.Location = new System.Drawing.Point(799, 3);
            this.iconMinimize.Name = "iconMinimize";
            this.iconMinimize.Size = new System.Drawing.Size(30, 20);
            this.iconMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMinimize.TabIndex = 5;
            this.iconMinimize.TabStop = false;
            this.iconMinimize.Click += new System.EventHandler(this.iconMinimize_Click);
            // 
            // iconMaximize
            // 
            this.iconMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.iconMaximize.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconMaximize.IconChar = FontAwesome.Sharp.IconChar.Maximize;
            this.iconMaximize.IconColor = System.Drawing.Color.Gainsboro;
            this.iconMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMaximize.IconSize = 20;
            this.iconMaximize.Location = new System.Drawing.Point(835, 3);
            this.iconMaximize.Name = "iconMaximize";
            this.iconMaximize.Size = new System.Drawing.Size(30, 20);
            this.iconMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMaximize.TabIndex = 4;
            this.iconMaximize.TabStop = false;
            this.iconMaximize.Click += new System.EventHandler(this.iconMaximize_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbTitleChildForm);
            this.panel2.Controls.Add(this.iconCurrentChildForm);
            this.panel2.Location = new System.Drawing.Point(6, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 63);
            this.panel2.TabIndex = 1;
            // 
            // lbTitleChildForm
            // 
            this.lbTitleChildForm.AutoSize = true;
            this.lbTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.lbTitleChildForm.Location = new System.Drawing.Point(64, 29);
            this.lbTitleChildForm.Name = "lbTitleChildForm";
            this.lbTitleChildForm.Size = new System.Drawing.Size(66, 24);
            this.lbTitleChildForm.TabIndex = 1;
            this.lbTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 53;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(15, 7);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(53, 53);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelDesktop.Location = new System.Drawing.Point(180, 65);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(904, 496);
            this.panelDesktop.TabIndex = 3;
            // 
            // guna2pnShadow
            // 
            this.guna2pnShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2pnShadow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.guna2pnShadow.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.guna2pnShadow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2pnShadow.Location = new System.Drawing.Point(180, 65);
            this.guna2pnShadow.Name = "guna2pnShadow";
            this.guna2pnShadow.Size = new System.Drawing.Size(904, 7);
            this.guna2pnShadow.TabIndex = 0;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.guna2pnShadow);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMainMenu";
            this.Text = "FormMainMenu";
            ((System.ComponentModel.ISupportInitialize)(iconExit)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btHome)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximize)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btLogout;
        private FontAwesome.Sharp.IconButton btAccounts;
        private FontAwesome.Sharp.IconButton btServices;
        private FontAwesome.Sharp.IconButton Room;
        private FontAwesome.Sharp.IconButton btCustomer;
        private FontAwesome.Sharp.IconButton btBooking;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btBill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.PictureBox btHome;
        private System.Windows.Forms.Panel panelDesktop;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2pnShadow;
        private FontAwesome.Sharp.IconPictureBox iconMinimize;
        private FontAwesome.Sharp.IconPictureBox iconMaximize;
        private FontAwesome.Sharp.IconButton btReport;
    }
}