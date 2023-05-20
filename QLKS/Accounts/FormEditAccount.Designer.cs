namespace QLKS.FormAccount
{
    partial class FormEditAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditAccount));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.tbPhanQuyen = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbMaNhanVien = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbusername = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Controls.Add(this.guna2Button2);
            this.guna2Panel1.Controls.Add(this.btnUpdate);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Location = new System.Drawing.Point(20, 20);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(483, 546);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(142, 18);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(207, 47);
            this.guna2HtmlLabel1.TabIndex = 3;
            this.guna2HtmlLabel1.Text = "Sửa tài khoản";
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 10;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Gray;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(310, 449);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(129, 57);
            this.guna2Button2.TabIndex = 2;
            this.guna2Button2.Text = "Thoát";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 10;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.Green;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(148, 449);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(129, 57);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.tbPhanQuyen);
            this.guna2Panel2.Controls.Add(this.tbMaNhanVien);
            this.guna2Panel2.Controls.Add(this.tbpassword);
            this.guna2Panel2.Controls.Add(this.tbusername);
            this.guna2Panel2.Location = new System.Drawing.Point(38, 77);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(402, 363);
            this.guna2Panel2.TabIndex = 0;
            // 
            // tbPhanQuyen
            // 
            this.tbPhanQuyen.BorderRadius = 10;
            this.tbPhanQuyen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhanQuyen.DefaultText = "Phân quyền";
            this.tbPhanQuyen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPhanQuyen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPhanQuyen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPhanQuyen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPhanQuyen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPhanQuyen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPhanQuyen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPhanQuyen.IconLeft = ((System.Drawing.Image)(resources.GetObject("tbPhanQuyen.IconLeft")));
            this.tbPhanQuyen.Location = new System.Drawing.Point(22, 254);
            this.tbPhanQuyen.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbPhanQuyen.Name = "tbPhanQuyen";
            this.tbPhanQuyen.PasswordChar = '\0';
            this.tbPhanQuyen.PlaceholderText = "";
            this.tbPhanQuyen.SelectedText = "";
            this.tbPhanQuyen.Size = new System.Drawing.Size(357, 55);
            this.tbPhanQuyen.TabIndex = 3;
            this.tbPhanQuyen.Enter += new System.EventHandler(this.tbPhanQuyen_Enter);
            this.tbPhanQuyen.Leave += new System.EventHandler(this.tbPhanQuyen_Leave);
            // 
            // tbMaNhanVien
            // 
            this.tbMaNhanVien.BorderRadius = 10;
            this.tbMaNhanVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMaNhanVien.DefaultText = "Mã nhân viên";
            this.tbMaNhanVien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbMaNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbMaNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMaNhanVien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMaNhanVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMaNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbMaNhanVien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMaNhanVien.IconLeft = ((System.Drawing.Image)(resources.GetObject("tbMaNhanVien.IconLeft")));
            this.tbMaNhanVien.Location = new System.Drawing.Point(24, 60);
            this.tbMaNhanVien.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbMaNhanVien.Name = "tbMaNhanVien";
            this.tbMaNhanVien.PasswordChar = '\0';
            this.tbMaNhanVien.PlaceholderText = "";
            this.tbMaNhanVien.ReadOnly = true;
            this.tbMaNhanVien.SelectedText = "";
            this.tbMaNhanVien.Size = new System.Drawing.Size(357, 55);
            this.tbMaNhanVien.TabIndex = 99;
            this.tbMaNhanVien.Enter += new System.EventHandler(this.tbMaNhanVien_Enter);
            this.tbMaNhanVien.Leave += new System.EventHandler(this.tbMaNhanVien_Leave);
            // 
            // tbpassword
            // 
            this.tbpassword.BorderRadius = 10;
            this.tbpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbpassword.DefaultText = "Password";
            this.tbpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbpassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbpassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("tbpassword.IconLeft")));
            this.tbpassword.Location = new System.Drawing.Point(24, 189);
            this.tbpassword.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.PasswordChar = '\0';
            this.tbpassword.PlaceholderText = "";
            this.tbpassword.SelectedText = "";
            this.tbpassword.Size = new System.Drawing.Size(357, 55);
            this.tbpassword.TabIndex = 2;
            this.tbpassword.Enter += new System.EventHandler(this.tbpassword_Enter);
            this.tbpassword.Leave += new System.EventHandler(this.tbpassword_Leave);
            // 
            // tbusername
            // 
            this.tbusername.BorderRadius = 10;
            this.tbusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbusername.DefaultText = "Username";
            this.tbusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbusername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbusername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbusername.IconLeft = ((System.Drawing.Image)(resources.GetObject("tbusername.IconLeft")));
            this.tbusername.Location = new System.Drawing.Point(22, 125);
            this.tbusername.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbusername.Name = "tbusername";
            this.tbusername.PasswordChar = '\0';
            this.tbusername.PlaceholderText = "";
            this.tbusername.SelectedText = "";
            this.tbusername.Size = new System.Drawing.Size(357, 55);
            this.tbusername.TabIndex = 1;
            this.tbusername.Enter += new System.EventHandler(this.tbusername_Enter);
            this.tbusername.Leave += new System.EventHandler(this.tbusername_Leave);
            // 
            // FormEditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 585);
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormEditAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormEditAccount";
            this.Load += new System.EventHandler(this.FormEditAccount_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox tbPhanQuyen;
        private Guna.UI2.WinForms.Guna2TextBox tbMaNhanVien;
        private Guna.UI2.WinForms.Guna2TextBox tbpassword;
        private Guna.UI2.WinForms.Guna2TextBox tbusername;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}