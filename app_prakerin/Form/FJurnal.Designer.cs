namespace app_prakerin
{
    partial class FJurnal
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code 
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FJurnal));
            this.DGVRole = new System.Windows.Forms.DataGridView();
            this.btnHapus = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.BTNTambah = new Guna.UI2.WinForms.Guna2Button();
            this.TXTSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.TXTIDJurnal = new Guna.UI2.WinForms.Guna2TextBox();
            this.TXTIDPrakerin = new Guna.UI2.WinForms.Guna2TextBox();
            this.TXTTanggal = new Guna.UI2.WinForms.Guna2TextBox();
            this.TXTKegiatan = new Guna.UI2.WinForms.Guna2TextBox();
            this.TXTKendala = new Guna.UI2.WinForms.Guna2TextBox();
            this.TXTSolusi = new Guna.UI2.WinForms.Guna2TextBox();
            this.CMBStatusVerifikasi = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ColNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIDJurnal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIDPrakerin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColKegiatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColKendala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSolusi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStatusVerifikasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.ColNo,
            this.ColIDJurnal,
            this.ColIDPrakerin,
            this.Column1,
            this.ColTanggal,
            this.ColKegiatan,
            this.ColKendala,
            this.ColSolusi,
            this.ColStatusVerifikasi});
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
            this.TXTSearch.Location = new System.Drawing.Point(164, 16);
            this.TXTSearch.Name = "TXTSearch";
            this.TXTSearch.PlaceholderText = "Cari jurnal...";
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
            this.lblTitle.Text = "Data Jurnal Harian";
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
            // TXTIDJurnal
            // 
            this.TXTIDJurnal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTIDJurnal.DefaultText = "";
            this.TXTIDJurnal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTIDJurnal.Location = new System.Drawing.Point(-500, 0);
            this.TXTIDJurnal.Name = "TXTIDJurnal";
            this.TXTIDJurnal.PlaceholderText = "";
            this.TXTIDJurnal.SelectedText = "";
            this.TXTIDJurnal.Size = new System.Drawing.Size(10, 10);
            this.TXTIDJurnal.TabIndex = 97;
            // 
            // TXTIDPrakerin
            // 
            this.TXTIDPrakerin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTIDPrakerin.DefaultText = "";
            this.TXTIDPrakerin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTIDPrakerin.Location = new System.Drawing.Point(-500, 20);
            this.TXTIDPrakerin.Name = "TXTIDPrakerin";
            this.TXTIDPrakerin.PlaceholderText = "";
            this.TXTIDPrakerin.SelectedText = "";
            this.TXTIDPrakerin.Size = new System.Drawing.Size(10, 10);
            this.TXTIDPrakerin.TabIndex = 98;
            // 
            // TXTTanggal
            // 
            this.TXTTanggal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTTanggal.DefaultText = "";
            this.TXTTanggal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTTanggal.Location = new System.Drawing.Point(-500, 40);
            this.TXTTanggal.Name = "TXTTanggal";
            this.TXTTanggal.PlaceholderText = "";
            this.TXTTanggal.SelectedText = "";
            this.TXTTanggal.Size = new System.Drawing.Size(10, 10);
            this.TXTTanggal.TabIndex = 99;
            // 
            // TXTKegiatan
            // 
            this.TXTKegiatan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTKegiatan.DefaultText = "";
            this.TXTKegiatan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTKegiatan.Location = new System.Drawing.Point(-500, 60);
            this.TXTKegiatan.Name = "TXTKegiatan";
            this.TXTKegiatan.PlaceholderText = "";
            this.TXTKegiatan.SelectedText = "";
            this.TXTKegiatan.Size = new System.Drawing.Size(10, 10);
            this.TXTKegiatan.TabIndex = 100;
            // 
            // TXTKendala
            // 
            this.TXTKendala.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTKendala.DefaultText = "";
            this.TXTKendala.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTKendala.Location = new System.Drawing.Point(-500, 80);
            this.TXTKendala.Name = "TXTKendala";
            this.TXTKendala.PlaceholderText = "";
            this.TXTKendala.SelectedText = "";
            this.TXTKendala.Size = new System.Drawing.Size(10, 10);
            this.TXTKendala.TabIndex = 101;
            // 
            // TXTSolusi
            // 
            this.TXTSolusi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTSolusi.DefaultText = "";
            this.TXTSolusi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTSolusi.Location = new System.Drawing.Point(-500, 100);
            this.TXTSolusi.Name = "TXTSolusi";
            this.TXTSolusi.PlaceholderText = "";
            this.TXTSolusi.SelectedText = "";
            this.TXTSolusi.Size = new System.Drawing.Size(10, 10);
            this.TXTSolusi.TabIndex = 102;
            // 
            // CMBStatusVerifikasi
            // 
            this.CMBStatusVerifikasi.BackColor = System.Drawing.Color.White;
            this.CMBStatusVerifikasi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.CMBStatusVerifikasi.BorderRadius = 4;
            this.CMBStatusVerifikasi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CMBStatusVerifikasi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBStatusVerifikasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBStatusVerifikasi.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.CMBStatusVerifikasi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.CMBStatusVerifikasi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CMBStatusVerifikasi.ForeColor = System.Drawing.Color.Black;
            this.CMBStatusVerifikasi.ItemHeight = 22;
            this.CMBStatusVerifikasi.Location = new System.Drawing.Point(-500, 120);
            this.CMBStatusVerifikasi.Name = "CMBStatusVerifikasi";
            this.CMBStatusVerifikasi.Size = new System.Drawing.Size(10, 28);
            this.CMBStatusVerifikasi.TabIndex = 103;
            // 
            // ColNo
            // 
            this.ColNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColNo.HeaderText = "No";
            this.ColNo.Name = "ColNo";
            this.ColNo.ReadOnly = true;
            this.ColNo.Width = 45;
            // 
            // ColIDJurnal
            // 
            this.ColIDJurnal.HeaderText = "ID_Jurnal";
            this.ColIDJurnal.Name = "ColIDJurnal";
            this.ColIDJurnal.ReadOnly = true;
            // 
            // ColIDPrakerin
            // 
            this.ColIDPrakerin.HeaderText = "ID_Prakerin";
            this.ColIDPrakerin.Name = "ColIDPrakerin";
            this.ColIDPrakerin.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nama Siswa";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // ColTanggal
            // 
            this.ColTanggal.HeaderText = "Tanggal";
            this.ColTanggal.Name = "ColTanggal";
            this.ColTanggal.ReadOnly = true;
            // 
            // ColKegiatan
            // 
            this.ColKegiatan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColKegiatan.HeaderText = "Kegiatan";
            this.ColKegiatan.Name = "ColKegiatan";
            this.ColKegiatan.ReadOnly = true;
            // 
            // ColKendala
            // 
            this.ColKendala.HeaderText = "Kendala";
            this.ColKendala.Name = "ColKendala";
            this.ColKendala.ReadOnly = true;
            // 
            // ColSolusi
            // 
            this.ColSolusi.HeaderText = "Solusi";
            this.ColSolusi.Name = "ColSolusi";
            this.ColSolusi.ReadOnly = true;
            // 
            // ColStatusVerifikasi
            // 
            this.ColStatusVerifikasi.HeaderText = "Status_Verifikasi";
            this.ColStatusVerifikasi.Name = "ColStatusVerifikasi";
            this.ColStatusVerifikasi.ReadOnly = true;
            // 
            // FJurnal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGVRole);
            this.Controls.Add(this.TXTIDJurnal);
            this.Controls.Add(this.TXTIDPrakerin);
            this.Controls.Add(this.TXTTanggal);
            this.Controls.Add(this.TXTKegiatan);
            this.Controls.Add(this.TXTKendala);
            this.Controls.Add(this.TXTSolusi);
            this.Controls.Add(this.CMBStatusVerifikasi);
            this.Controls.Add(this.panelTop);
            this.Name = "FJurnal";
            this.Text = "FJurnal";
            this.Load += new System.EventHandler(this.FJurnal_Load);
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
        private Guna.UI2.WinForms.Guna2TextBox TXTIDJurnal;
        private Guna.UI2.WinForms.Guna2TextBox TXTIDPrakerin;
        private Guna.UI2.WinForms.Guna2TextBox TXTTanggal;
        private Guna.UI2.WinForms.Guna2TextBox TXTKegiatan;
        private Guna.UI2.WinForms.Guna2TextBox TXTKendala;
        private Guna.UI2.WinForms.Guna2TextBox TXTSolusi;
        private Guna.UI2.WinForms.Guna2ComboBox CMBStatusVerifikasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIDJurnal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIDPrakerin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKegiatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKendala;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSolusi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStatusVerifikasi;
    }
}
