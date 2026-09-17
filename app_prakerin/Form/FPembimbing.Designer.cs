namespace app_prakerin
{
    partial class FPembimbing
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPembimbing));
            this.DGVRole = new System.Windows.Forms.DataGridView();
            this.btnHapus = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.BTNTambah = new Guna.UI2.WinForms.Guna2Button();
            this.TXTSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.TXTNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.TXTJabatan = new Guna.UI2.WinForms.Guna2TextBox();
            this.TXTNoHP = new Guna.UI2.WinForms.Guna2TextBox();
            this.TXTEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRole)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVRole
            // 
            this.DGVRole.AllowUserToAddRows = false;
            this.DGVRole.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.DGVRole.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVRole.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVRole.BackgroundColor = System.Drawing.Color.White;
            this.DGVRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(42)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVRole.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVRole.ColumnHeadersHeight = 32;
            this.DGVRole.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column2,
            this.Column3,
            this.Column3a,
            this.dataGridViewTextBoxColumn3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVRole.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVRole.EnableHeadersVisualStyles = false;
            this.DGVRole.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DGVRole.Location = new System.Drawing.Point(0, 58);
            this.DGVRole.MultiSelect = false;
            this.DGVRole.Name = "DGVRole";
            this.DGVRole.ReadOnly = true;
            this.DGVRole.RowHeadersVisible = false;
            this.DGVRole.RowTemplate.Height = 26;
            this.DGVRole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVRole.Size = new System.Drawing.Size(800, 392);
            this.DGVRole.TabIndex = 7;
            this.DGVRole.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVRole_CellClick);
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
            this.btnHapus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.BTNTambah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.TXTSearch.Location = new System.Drawing.Point(176, 12);
            this.TXTSearch.Name = "TXTSearch";
            this.TXTSearch.PlaceholderText = "Cari pembimbing...";
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
            this.lblTitle.Size = new System.Drawing.Size(160, 26);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Data Pembimbing";
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
            // TXTNama
            // 
            this.TXTNama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTNama.DefaultText = "";
            this.TXTNama.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTNama.Location = new System.Drawing.Point(-500, 0);
            this.TXTNama.Name = "TXTNama";
            this.TXTNama.PlaceholderText = "";
            this.TXTNama.SelectedText = "";
            this.TXTNama.Size = new System.Drawing.Size(10, 10);
            this.TXTNama.TabIndex = 97;
            // 
            // TXTKeterangan
            // 
            this.TXTJabatan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTJabatan.DefaultText = "";
            this.TXTJabatan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTJabatan.Location = new System.Drawing.Point(-500, 20);
            this.TXTJabatan.Name = "TXTKeterangan";
            this.TXTJabatan.PlaceholderText = "";
            this.TXTJabatan.SelectedText = "";
            this.TXTJabatan.Size = new System.Drawing.Size(10, 10);
            this.TXTJabatan.TabIndex = 98;
            // 
            // TXTNoHP
            // 
            this.TXTNoHP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTNoHP.DefaultText = "";
            this.TXTNoHP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTNoHP.Location = new System.Drawing.Point(-500, 40);
            this.TXTNoHP.Name = "TXTNoHP";
            this.TXTNoHP.PlaceholderText = "";
            this.TXTNoHP.SelectedText = "";
            this.TXTNoHP.Size = new System.Drawing.Size(10, 10);
            this.TXTNoHP.TabIndex = 99;
            // 
            // TXTEmail
            // 
            this.TXTEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTEmail.DefaultText = "";
            this.TXTEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTEmail.Location = new System.Drawing.Point(-500, 60);
            this.TXTEmail.Name = "TXTEmail";
            this.TXTEmail.PlaceholderText = "";
            this.TXTEmail.SelectedText = "";
            this.TXTEmail.Size = new System.Drawing.Size(10, 10);
            this.TXTEmail.TabIndex = 100;
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
            this.Column2.HeaderText = "ID_Pembimbing";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ID_Pengguna";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column3a
            // 
            this.Column3a.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3a.HeaderText = "ID_Perusahaan";
            this.Column3a.Name = "Column3a";
            this.Column3a.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Nama";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Jabatan";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "No HP";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Email";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // FPembimbing
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGVRole);
            this.Controls.Add(this.TXTNama);
            this.Controls.Add(this.TXTJabatan);
            this.Controls.Add(this.TXTNoHP);
            this.Controls.Add(this.TXTEmail);
            this.Controls.Add(this.panelTop);
            this.Name = "FPembimbing";
            this.Text = "FPembimbing";
            this.Load += new System.EventHandler(this.FPembimbing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRole)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.DataGridView DGVRole;
        private Guna.UI2.WinForms.Guna2Button btnHapus;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button BTNTambah;
        private Guna.UI2.WinForms.Guna2TextBox TXTSearch;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelTop;
        private Guna.UI2.WinForms.Guna2TextBox TXTNama;
        private Guna.UI2.WinForms.Guna2TextBox TXTJabatan;
        private Guna.UI2.WinForms.Guna2TextBox TXTNoHP;
        private Guna.UI2.WinForms.Guna2TextBox TXTEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3a;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
