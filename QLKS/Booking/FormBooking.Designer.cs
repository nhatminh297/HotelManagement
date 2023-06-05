namespace QLKS
{
    partial class FormBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBooking));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btMakeBill = new Guna.UI2.WinForms.Guna2Button();
            this.btAddBooking = new Guna.UI2.WinForms.Guna2Button();
            this.tbSearchName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DataGridView2 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sophong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Checkin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenloaiphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giamoigio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.guna2ButtonDelete);
            this.panel1.Controls.Add(this.btMakeBill);
            this.panel1.Controls.Add(this.btAddBooking);
            this.panel1.Controls.Add(this.tbSearchName);
            this.panel1.Controls.Add(this.guna2DataGridView2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 539);
            this.panel1.TabIndex = 2;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.guna2Button1.Location = new System.Drawing.Point(664, 471);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(87, 38);
            this.guna2Button1.TabIndex = 10;
            this.guna2Button1.Text = "EDIT";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            this.guna2Button1.MouseEnter += new System.EventHandler(this.btEdit_MouseEnter);
            this.guna2Button1.MouseLeave += new System.EventHandler(this.btEdit_MouseLeave);
            // 
            // guna2ButtonDelete
            // 
            this.guna2ButtonDelete.BorderColor = System.Drawing.Color.Firebrick;
            this.guna2ButtonDelete.BorderRadius = 5;
            this.guna2ButtonDelete.BorderThickness = 2;
            this.guna2ButtonDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.guna2ButtonDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonDelete.ForeColor = System.Drawing.Color.Firebrick;
            this.guna2ButtonDelete.Location = new System.Drawing.Point(775, 471);
            this.guna2ButtonDelete.Name = "guna2ButtonDelete";
            this.guna2ButtonDelete.Size = new System.Drawing.Size(87, 38);
            this.guna2ButtonDelete.TabIndex = 9;
            this.guna2ButtonDelete.Text = "DELETE";
            this.guna2ButtonDelete.Click += new System.EventHandler(this.guna2ButtonDelete_Click);
            this.guna2ButtonDelete.MouseEnter += new System.EventHandler(this.guna2ButtonDelete_MouseEnter);
            this.guna2ButtonDelete.MouseLeave += new System.EventHandler(this.guna2ButtonDelete_MouseLeave);
            // 
            // btMakeBill
            // 
            this.btMakeBill.BorderColor = System.Drawing.Color.ForestGreen;
            this.btMakeBill.BorderRadius = 5;
            this.btMakeBill.BorderThickness = 2;
            this.btMakeBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btMakeBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btMakeBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btMakeBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btMakeBill.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.btMakeBill.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMakeBill.ForeColor = System.Drawing.Color.ForestGreen;
            this.btMakeBill.Location = new System.Drawing.Point(552, 471);
            this.btMakeBill.Name = "btMakeBill";
            this.btMakeBill.Size = new System.Drawing.Size(87, 38);
            this.btMakeBill.TabIndex = 7;
            this.btMakeBill.Text = "MAKE BILL";
            this.btMakeBill.Click += new System.EventHandler(this.btMakeBill_Click);
            this.btMakeBill.MouseEnter += new System.EventHandler(this.btMakeBill_MouseEnter);
            this.btMakeBill.MouseLeave += new System.EventHandler(this.btMakeBill_MouseLeave);
            // 
            // btAddBooking
            // 
            this.btAddBooking.BorderColor = System.Drawing.Color.ForestGreen;
            this.btAddBooking.BorderRadius = 5;
            this.btAddBooking.BorderThickness = 2;
            this.btAddBooking.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btAddBooking.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btAddBooking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btAddBooking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btAddBooking.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.btAddBooking.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddBooking.ForeColor = System.Drawing.Color.ForestGreen;
            this.btAddBooking.Location = new System.Drawing.Point(743, 58);
            this.btAddBooking.Name = "btAddBooking";
            this.btAddBooking.Size = new System.Drawing.Size(132, 38);
            this.btAddBooking.TabIndex = 6;
            this.btAddBooking.Text = "MAKE BOOKING";
            this.btAddBooking.Click += new System.EventHandler(this.btAddBooking_Click);
            this.btAddBooking.MouseEnter += new System.EventHandler(this.btMakeBill_MouseEnter);
            this.btAddBooking.MouseLeave += new System.EventHandler(this.btMakeBill_MouseLeave);
            // 
            // tbSearchName
            // 
            this.tbSearchName.BorderRadius = 5;
            this.tbSearchName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchName.DefaultText = "Search Fullname";
            this.tbSearchName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearchName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearchName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearchName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearchName.IconLeft = ((System.Drawing.Image)(resources.GetObject("tbSearchName.IconLeft")));
            this.tbSearchName.Location = new System.Drawing.Point(69, 58);
            this.tbSearchName.Name = "tbSearchName";
            this.tbSearchName.PasswordChar = '\0';
            this.tbSearchName.PlaceholderText = "";
            this.tbSearchName.SelectedText = "";
            this.tbSearchName.Size = new System.Drawing.Size(369, 36);
            this.tbSearchName.TabIndex = 3;
            this.tbSearchName.Enter += new System.EventHandler(this.tbSearchName_Enter);
            this.tbSearchName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearchName_KeyDown);
            this.tbSearchName.Leave += new System.EventHandler(this.tbSearchName_Leave);
            // 
            // guna2DataGridView2
            // 
            this.guna2DataGridView2.AllowUserToAddRows = false;
            this.guna2DataGridView2.AllowUserToDeleteRows = false;
            this.guna2DataGridView2.AllowUserToOrderColumns = true;
            this.guna2DataGridView2.AllowUserToResizeColumns = false;
            this.guna2DataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.guna2DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guna2DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView2.ColumnHeadersHeight = 30;
            this.guna2DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.tenkh,
            this.sophong,
            this.Checkin,
            this.checkout,
            this.prices,
            this.makh,
            this.manv,
            this.maphong,
            this.tenloaiphong,
            this.giamoigio,
            this.trangthai});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.Location = new System.Drawing.Point(70, 120);
            this.guna2DataGridView2.MultiSelect = false;
            this.guna2DataGridView2.Name = "guna2DataGridView2";
            this.guna2DataGridView2.ReadOnly = true;
            this.guna2DataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.guna2DataGridView2.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridView2.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView2.RowTemplate.Height = 40;
            this.guna2DataGridView2.Size = new System.Drawing.Size(822, 330);
            this.guna2DataGridView2.TabIndex = 1;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.guna2DataGridView2.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.Height = 30;
            this.guna2DataGridView2.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView2.ThemeStyle.RowsStyle.Height = 40;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView2_CellClick);
            this.guna2DataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView2_CellDoubleClick);
            // 
            // id
            // 
            this.id.FillWeight = 40F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // tenkh
            // 
            this.tenkh.FillWeight = 107.8173F;
            this.tenkh.HeaderText = "Name";
            this.tenkh.Name = "tenkh";
            this.tenkh.ReadOnly = true;
            // 
            // sophong
            // 
            this.sophong.FillWeight = 107.8173F;
            this.sophong.HeaderText = "Room";
            this.sophong.Name = "sophong";
            this.sophong.ReadOnly = true;
            // 
            // Checkin
            // 
            this.Checkin.FillWeight = 107.8173F;
            this.Checkin.HeaderText = "Check In";
            this.Checkin.Name = "Checkin";
            this.Checkin.ReadOnly = true;
            // 
            // checkout
            // 
            this.checkout.FillWeight = 107.8173F;
            this.checkout.HeaderText = "Check Out";
            this.checkout.Name = "checkout";
            this.checkout.ReadOnly = true;
            // 
            // prices
            // 
            this.prices.HeaderText = "Prices";
            this.prices.Name = "prices";
            this.prices.ReadOnly = true;
            // 
            // makh
            // 
            this.makh.HeaderText = "makh";
            this.makh.Name = "makh";
            this.makh.ReadOnly = true;
            this.makh.Visible = false;
            // 
            // manv
            // 
            this.manv.HeaderText = "manv";
            this.manv.Name = "manv";
            this.manv.ReadOnly = true;
            this.manv.Visible = false;
            // 
            // maphong
            // 
            this.maphong.HeaderText = "maphong";
            this.maphong.Name = "maphong";
            this.maphong.ReadOnly = true;
            this.maphong.Visible = false;
            // 
            // tenloaiphong
            // 
            this.tenloaiphong.HeaderText = "tenloaiphong";
            this.tenloaiphong.Name = "tenloaiphong";
            this.tenloaiphong.ReadOnly = true;
            this.tenloaiphong.Visible = false;
            // 
            // giamoigio
            // 
            this.giamoigio.HeaderText = "giamoigio";
            this.giamoigio.Name = "giamoigio";
            this.giamoigio.ReadOnly = true;
            this.giamoigio.Visible = false;
            // 
            // trangthai
            // 
            this.trangthai.HeaderText = "trangthai";
            this.trangthai.Name = "trangthai";
            this.trangthai.ReadOnly = true;
            this.trangthai.Visible = false;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.AllowDrop = true;
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FormBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 539);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBooking";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonDelete;
        private Guna.UI2.WinForms.Guna2Button btMakeBill;
        private Guna.UI2.WinForms.Guna2Button btAddBooking;
        private Guna.UI2.WinForms.Guna2TextBox tbSearchName;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sophong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Checkin;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkout;
        private System.Windows.Forms.DataGridViewTextBoxColumn prices;
        private System.Windows.Forms.DataGridViewTextBoxColumn makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenloaiphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamoigio;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
    }
}