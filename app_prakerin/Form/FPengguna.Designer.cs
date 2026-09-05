namespace app_prakerin
{
    partial class FPengguna
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPengguna));
            this.DGVPengguna = new System.Windows.Forms.DataGridView();
            this.btnHapus = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.BTNTambah = new Guna.UI2.WinForms.Guna2Button();
            this.TXTSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.TXTUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.TXTPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.CMBRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CMBStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPengguna)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVPengguna
            // 
            this.DGVPengguna.AllowUserToAddRows = false;
            this.DGVPengguna.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.DGVPengguna.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVPengguna.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPengguna.BackgroundColor = System.Drawing.Color.White;
            this.DGVPengguna.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(42)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVPengguna.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVPengguna.ColumnHeadersHeight = 32;
            this.DGVPengguna.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column2,
            this.colId,
            this.Column3,
            this.colNama,
            this.Column1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVPengguna.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVPengguna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVPengguna.EnableHeadersVisualStyles = false;
            this.DGVPengguna.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DGVPengguna.Location = new System.Drawing.Point(0, 58);
            this.DGVPengguna.MultiSelect = false;
            this.DGVPengguna.Name = "DGVPengguna";
            this.DGVPengguna.ReadOnly = true;
            this.DGVPengguna.RowHeadersVisible = false;
            this.DGVPengguna.RowTemplate.Height = 26;
            this.DGVPengguna.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPengguna.Size = new System.Drawing.Size(800, 392);
            this.DGVPengguna.TabIndex = 7;
            this.DGVPengguna.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPengguna_CellClick);
            // 
            // btnHapus
            // 
            this.btnHapus.BorderRadius = 5;
            this.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Location = new System.Drawing.Point(661, 15);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(70, 27);
            this.btnHapus.TabIndex = 1;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BorderRadius = 5;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(583, 15);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(70, 27);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // BTNTambah
            // 
            this.BTNTambah.BorderRadius = 5;
            this.BTNTambah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNTambah.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.BTNTambah.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.BTNTambah.ForeColor = System.Drawing.Color.White;
            this.BTNTambah.Location = new System.Drawing.Point(490, 15);
            this.BTNTambah.Name = "BTNTambah";
            this.BTNTambah.Size = new System.Drawing.Size(85, 27);
            this.BTNTambah.TabIndex = 3;
            this.BTNTambah.Text = "Tambah";
            this.BTNTambah.Click += new System.EventHandler(this.BTNTambah_Click);
            // 
            // TXTSearch
            // 
            this.TXTSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.TXTSearch.BorderRadius = 5;
            this.TXTSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTSearch.DefaultText = "";
            this.TXTSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.TXTSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTSearch.ForeColor = System.Drawing.Color.Black;
            this.TXTSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("TXTSearch.IconLeft")));
            this.TXTSearch.Location = new System.Drawing.Point(155, 14);
            this.TXTSearch.Name = "TXTSearch";
            this.TXTSearch.PlaceholderText = "Cari pengguna...";
            this.TXTSearch.SelectedText = "";
            this.TXTSearch.Size = new System.Drawing.Size(247, 28);
            this.TXTSearch.TabIndex = 5;
            this.TXTSearch.TextChanged += new System.EventHandler(this.TXTSearch_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(42)))), ((int)(((byte)(70)))));
            this.lblTitle.Location = new System.Drawing.Point(10, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(185, 26);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Data Pengguna";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.btnHapus);
            this.panelTop.Controls.Add(this.btnEdit);
            this.panelTop.Controls.Add(this.BTNTambah);
            this.panelTop.Controls.Add(this.TXTSearch);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 58);
            this.panelTop.TabIndex = 5;
            // 
            // TXTUsername
            // 
            this.TXTUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTUsername.DefaultText = "";
            this.TXTUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTUsername.Location = new System.Drawing.Point(-500, 0);
            this.TXTUsername.Name = "TXTUsername";
            this.TXTUsername.PlaceholderText = "";
            this.TXTUsername.SelectedText = "";
            this.TXTUsername.Size = new System.Drawing.Size(10, 10);
            this.TXTUsername.TabIndex = 97;
            this.TXTUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTUsername_KeyPress);
            // 
            // TXTPassword
            // 
            this.TXTPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTPassword.DefaultText = "";
            this.TXTPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTPassword.Location = new System.Drawing.Point(-500, 20);
            this.TXTPassword.Name = "TXTPassword";
            this.TXTPassword.PlaceholderText = "";
            this.TXTPassword.SelectedText = "";
            this.TXTPassword.Size = new System.Drawing.Size(10, 10);
            this.TXTPassword.TabIndex = 98;
            this.TXTPassword.UseSystemPasswordChar = true;
            // 
            // CMBRole
            // 
            this.CMBRole.BackColor = System.Drawing.Color.White;
            this.CMBRole.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.CMBRole.BorderRadius = 4;
            this.CMBRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CMBRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.CMBRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.CMBRole.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CMBRole.ForeColor = System.Drawing.Color.Black;
            this.CMBRole.ItemHeight = 22;
            this.CMBRole.Location = new System.Drawing.Point(-500, 40);
            this.CMBRole.Name = "CMBRole";
            this.CMBRole.Size = new System.Drawing.Size(10, 28);
            this.CMBRole.TabIndex = 99;
            this.CMBRole.DropDown += new System.EventHandler(this.CMBRole_DropDown);
            this.CMBRole.SelectedIndexChanged += new System.EventHandler(this.CMBRole_SelectedIndexChanged);
            // 
            // CMBStatus
            // 
            this.CMBStatus.BackColor = System.Drawing.Color.White;
            this.CMBStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.CMBStatus.BorderRadius = 4;
            this.CMBStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CMBStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.CMBStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.CMBStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CMBStatus.ForeColor = System.Drawing.Color.Black;
            this.CMBStatus.ItemHeight = 22;
            this.CMBStatus.Location = new System.Drawing.Point(-500, 60);
            this.CMBStatus.Name = "CMBStatus";
            this.CMBStatus.Size = new System.Drawing.Size(10, 28);
            this.CMBStatus.TabIndex = 100;
            this.CMBStatus.DropDown += new System.EventHandler(this.CMBStatus_DropDown);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 45;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "IDP";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colId.HeaderText = "Username";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Password";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // colNama
            // 
            this.colNama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNama.HeaderText = "Role";
            this.colNama.Name = "colNama";
            this.colNama.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Status";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // FPengguna
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGVPengguna);
            this.Controls.Add(this.TXTUsername);
            this.Controls.Add(this.TXTPassword);
            this.Controls.Add(this.CMBRole);
            this.Controls.Add(this.CMBStatus);
            this.Controls.Add(this.panelTop);
            this.Name = "FPengguna";
            this.Text = "FPengguna";
            this.Load += new System.EventHandler(this.FPengguna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPengguna)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.DataGridView DGVPengguna;
        private Guna.UI2.WinForms.Guna2Button btnHapus;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button BTNTambah;
        private Guna.UI2.WinForms.Guna2TextBox TXTSearch;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelTop;
        private Guna.UI2.WinForms.Guna2TextBox TXTUsername;
        private Guna.UI2.WinForms.Guna2TextBox TXTPassword;
        private Guna.UI2.WinForms.Guna2ComboBox CMBRole;
        private Guna.UI2.WinForms.Guna2ComboBox CMBStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}
