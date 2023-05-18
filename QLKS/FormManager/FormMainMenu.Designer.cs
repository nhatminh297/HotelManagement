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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btBooking = new FontAwesome.Sharp.IconButton();
            this.btCustomer = new FontAwesome.Sharp.IconButton();
            this.Room = new FontAwesome.Sharp.IconButton();
            this.btServices = new FontAwesome.Sharp.IconButton();
            this.btAccounts = new FontAwesome.Sharp.IconButton();
            this.btLogout = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btLogout);
            this.panelMenu.Controls.Add(this.btAccounts);
            this.panelMenu.Controls.Add(this.btServices);
            this.panelMenu.Controls.Add(this.Room);
            this.panelMenu.Controls.Add(this.btCustomer);
            this.panelMenu.Controls.Add(this.btBooking);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(174, 446);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(174, 96);
            this.panelLogo.TabIndex = 0;
            // 
            // btBooking
            // 
            this.btBooking.Dock = System.Windows.Forms.DockStyle.Top;
            this.btBooking.FlatAppearance.BorderSize = 0;
            this.btBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBooking.ForeColor = System.Drawing.Color.Gainsboro;
            this.btBooking.IconChar = FontAwesome.Sharp.IconChar.HouseMedicalFlag;
            this.btBooking.IconColor = System.Drawing.Color.Gainsboro;
            this.btBooking.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btBooking.IconSize = 32;
            this.btBooking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBooking.Location = new System.Drawing.Point(0, 96);
            this.btBooking.Name = "btBooking";
            this.btBooking.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btBooking.Size = new System.Drawing.Size(174, 34);
            this.btBooking.TabIndex = 1;
            this.btBooking.Text = "Booking";
            this.btBooking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBooking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btBooking.UseVisualStyleBackColor = true;
            this.btBooking.Click += new System.EventHandler(this.btBooking_Click);
            // 
            // btCustomer
            // 
            this.btCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCustomer.FlatAppearance.BorderSize = 0;
            this.btCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCustomer.ForeColor = System.Drawing.Color.Gainsboro;
            this.btCustomer.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btCustomer.IconColor = System.Drawing.Color.Gainsboro;
            this.btCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btCustomer.IconSize = 32;
            this.btCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCustomer.Location = new System.Drawing.Point(0, 130);
            this.btCustomer.Name = "btCustomer";
            this.btCustomer.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btCustomer.Size = new System.Drawing.Size(174, 34);
            this.btCustomer.TabIndex = 2;
            this.btCustomer.Text = "Customer";
            this.btCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCustomer.UseVisualStyleBackColor = true;
            this.btCustomer.Click += new System.EventHandler(this.btCustomer_Click);
            // 
            // Room
            // 
            this.Room.Dock = System.Windows.Forms.DockStyle.Top;
            this.Room.FlatAppearance.BorderSize = 0;
            this.Room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Room.ForeColor = System.Drawing.Color.Gainsboro;
            this.Room.IconChar = FontAwesome.Sharp.IconChar.Shop;
            this.Room.IconColor = System.Drawing.Color.Gainsboro;
            this.Room.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Room.IconSize = 32;
            this.Room.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Room.Location = new System.Drawing.Point(0, 164);
            this.Room.Name = "Room";
            this.Room.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Room.Size = new System.Drawing.Size(174, 34);
            this.Room.TabIndex = 3;
            this.Room.Text = "Rooms";
            this.Room.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Room.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Room.UseVisualStyleBackColor = true;
            this.Room.Click += new System.EventHandler(this.Room_Click);
            // 
            // btServices
            // 
            this.btServices.Dock = System.Windows.Forms.DockStyle.Top;
            this.btServices.FlatAppearance.BorderSize = 0;
            this.btServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btServices.ForeColor = System.Drawing.Color.Gainsboro;
            this.btServices.IconChar = FontAwesome.Sharp.IconChar.BellConcierge;
            this.btServices.IconColor = System.Drawing.Color.Gainsboro;
            this.btServices.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btServices.IconSize = 32;
            this.btServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btServices.Location = new System.Drawing.Point(0, 198);
            this.btServices.Name = "btServices";
            this.btServices.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btServices.Size = new System.Drawing.Size(174, 34);
            this.btServices.TabIndex = 4;
            this.btServices.Text = "Services";
            this.btServices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btServices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btServices.UseVisualStyleBackColor = true;
            this.btServices.Click += new System.EventHandler(this.btServices_Click);
            // 
            // btAccounts
            // 
            this.btAccounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btAccounts.FlatAppearance.BorderSize = 0;
            this.btAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAccounts.ForeColor = System.Drawing.Color.Gainsboro;
            this.btAccounts.IconChar = FontAwesome.Sharp.IconChar.PeopleLine;
            this.btAccounts.IconColor = System.Drawing.Color.Gainsboro;
            this.btAccounts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btAccounts.IconSize = 32;
            this.btAccounts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAccounts.Location = new System.Drawing.Point(0, 232);
            this.btAccounts.Name = "btAccounts";
            this.btAccounts.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btAccounts.Size = new System.Drawing.Size(174, 34);
            this.btAccounts.TabIndex = 5;
            this.btAccounts.Text = "Accounts";
            this.btAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAccounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAccounts.UseVisualStyleBackColor = true;
            this.btAccounts.Click += new System.EventHandler(this.btAccounts_Click);
            // 
            // btLogout
            // 
            this.btLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btLogout.FlatAppearance.BorderSize = 0;
            this.btLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btLogout.IconChar = FontAwesome.Sharp.IconChar.PersonWalkingDashedLineArrowRight;
            this.btLogout.IconColor = System.Drawing.Color.Gainsboro;
            this.btLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btLogout.IconSize = 32;
            this.btLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLogout.Location = new System.Drawing.Point(0, 412);
            this.btLogout.Name = "btLogout";
            this.btLogout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btLogout.Size = new System.Drawing.Size(174, 34);
            this.btLogout.TabIndex = 6;
            this.btLogout.Text = "Logout";
            this.btLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMainMenu";
            this.Text = "FormMainMenu";
            this.panelMenu.ResumeLayout(false);
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
    }
}