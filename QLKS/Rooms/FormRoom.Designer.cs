namespace QLKS
{
    partial class FormRoom
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRoom));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ButtonDelete = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btAdd = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btSearch = new Guna.UI2.WinForms.Guna2Button();
            this.tbSearchRoom = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Controls.Add(this.guna2ButtonDelete);
            this.guna2Panel1.Controls.Add(this.guna2ButtonEdit);
            this.guna2Panel1.Controls.Add(this.btAdd);
            this.guna2Panel1.Controls.Add(this.guna2DataGridView1);
            this.guna2Panel1.Controls.Add(this.btSearch);
            this.guna2Panel1.Controls.Add(this.tbSearchRoom);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(904, 489);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Baskerville Old Face", 20F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Turquoise;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(53, 47);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(235, 33);
            this.guna2HtmlLabel1.TabIndex = 14;
            this.guna2HtmlLabel1.Text = "Room Informations";
            // 
            // guna2ButtonDelete
            // 
            this.guna2ButtonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2ButtonDelete.BorderRadius = 5;
            this.guna2ButtonDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonDelete.FillColor = System.Drawing.Color.Firebrick;
            this.guna2ButtonDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonDelete.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonDelete.Location = new System.Drawing.Point(778, 402);
            this.guna2ButtonDelete.Name = "guna2ButtonDelete";
            this.guna2ButtonDelete.Size = new System.Drawing.Size(87, 38);
            this.guna2ButtonDelete.TabIndex = 12;
            this.guna2ButtonDelete.Text = "DELETE";
            this.guna2ButtonDelete.Click += new System.EventHandler(this.guna2ButtonDelete_Click);
            // 
            // guna2ButtonEdit
            // 
            this.guna2ButtonEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2ButtonEdit.BorderRadius = 5;
            this.guna2ButtonEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonEdit.FillColor = System.Drawing.Color.Orange;
            this.guna2ButtonEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonEdit.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonEdit.Location = new System.Drawing.Point(652, 402);
            this.guna2ButtonEdit.Name = "guna2ButtonEdit";
            this.guna2ButtonEdit.Size = new System.Drawing.Size(87, 38);
            this.guna2ButtonEdit.TabIndex = 11;
            this.guna2ButtonEdit.Text = "EDIT";
            this.guna2ButtonEdit.Click += new System.EventHandler(this.guna2ButtonEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAdd.BorderRadius = 5;
            this.btAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btAdd.FillColor = System.Drawing.Color.ForestGreen;
            this.btAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.Color.White;
            this.btAdd.Location = new System.Drawing.Point(526, 402);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(87, 38);
            this.btAdd.TabIndex = 10;
            this.btAdd.Text = "ADD";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 17;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNumber,
            this.colType,
            this.colCapacity,
            this.colPrices,
            this.colStatus});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(80, 109);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.Size = new System.Drawing.Size(747, 263);
            this.guna2DataGridView1.TabIndex = 8;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 17;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellClick);
            this.guna2DataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellDoubleClick);
            // 
            // colID
            // 
            this.colID.FillWeight = 20F;
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colNumber
            // 
            this.colNumber.FillWeight = 80F;
            this.colNumber.HeaderText = "Room number";
            this.colNumber.Name = "colNumber";
            this.colNumber.ReadOnly = true;
            // 
            // colType
            // 
            this.colType.FillWeight = 90F;
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // colCapacity
            // 
            this.colCapacity.FillWeight = 60F;
            this.colCapacity.HeaderText = "Capacity";
            this.colCapacity.Name = "colCapacity";
            this.colCapacity.ReadOnly = true;
            // 
            // colPrices
            // 
            this.colPrices.HeaderText = "Prices/hour";
            this.colPrices.Name = "colPrices";
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            // 
            // btSearch
            // 
            this.btSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSearch.BorderRadius = 5;
            this.btSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.ForeColor = System.Drawing.Color.White;
            this.btSearch.Location = new System.Drawing.Point(740, 44);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(103, 36);
            this.btSearch.TabIndex = 7;
            this.btSearch.Text = "Search";
            // 
            // tbSearchRoom
            // 
            this.tbSearchRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSearchRoom.BorderRadius = 5;
            this.tbSearchRoom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchRoom.DefaultText = "Room number";
            this.tbSearchRoom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearchRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearchRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchRoom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchRoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearchRoom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchRoom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearchRoom.IconLeft = ((System.Drawing.Image)(resources.GetObject("tbSearchRoom.IconLeft")));
            this.tbSearchRoom.Location = new System.Drawing.Point(420, 44);
            this.tbSearchRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSearchRoom.Name = "tbSearchRoom";
            this.tbSearchRoom.PasswordChar = '\0';
            this.tbSearchRoom.PlaceholderText = "";
            this.tbSearchRoom.SelectedText = "";
            this.tbSearchRoom.Size = new System.Drawing.Size(312, 36);
            this.tbSearchRoom.TabIndex = 6;
            this.tbSearchRoom.Enter += new System.EventHandler(this.tbSearchRoom_Enter);
            this.tbSearchRoom.Leave += new System.EventHandler(this.tbSearchRoom_Leave);
            // 
            // FormRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 489);
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRoom";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btSearch;
        private Guna.UI2.WinForms.Guna2TextBox tbSearchRoom;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonDelete;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonEdit;
        private Guna.UI2.WinForms.Guna2Button btAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrices;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}