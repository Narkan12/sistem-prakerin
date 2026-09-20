namespace app_prakerin
{
    partial class FJurnal
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FJurnal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlPageHeader = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblPageSub = new System.Windows.Forms.Label();
            this.pnlSeparator = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.TXTSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.BTNTambah = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnHapus = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.DGVRole = new System.Windows.Forms.DataGridView();
            this.ColNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIDJurnal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIDPrakerin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColKegiatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColKendala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSolusi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStatusVerifikasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TXTIDJurnal = new Guna.UI2.WinForms.Guna2TextBox();
            this.TXTIDPrakerin = new Guna.UI2.WinForms.Guna2TextBox();
            this.TXTTanggal = new Guna.UI2.WinForms.Guna2TextBox();
            this.TXTKegiatan = new Guna.UI2.WinForms.Guna2TextBox();
            this.TXTKendala = new Guna.UI2.WinForms.Guna2TextBox();
            this.TXTSolusi = new Guna.UI2.WinForms.Guna2TextBox();
            this.CMBStatusVerifikasi = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnlPageHeader.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRole)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPageHeader
            // 
            this.pnlPageHeader.BackColor = System.Drawing.Color.White;
            this.pnlPageHeader.Controls.Add(this.lblPageTitle);
            this.pnlPageHeader.Controls.Add(this.lblPageSub);
            this.pnlPageHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPageHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlPageHeader.Name = "pnlPageHeader";
            this.pnlPageHeader.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.pnlPageHeader.Size = new System.Drawing.Size(1080, 70);
            this.pnlPageHeader.TabIndex = 10;
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblPageTitle.Location = new System.Drawing.Point(20, 12);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(120, 25);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Jurnal Prakerin";
            // 
            // lblPageSub
            // 
            this.lblPageSub.AutoSize = true;
            this.lblPageSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPageSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblPageSub.Location = new System.Drawing.Point(20, 42);
            this.lblPageSub.Name = "lblPageSub";
            this.lblPageSub.Size = new System.Drawing.Size(300, 15);
            this.lblPageSub.TabIndex = 1;
            this.lblPageSub.Text = "Pantau catatan kegiatan harian siswa di industri.";
            // 
            // pnlSeparator
            // 
            this.pnlSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlSeparator.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSeparator.Location = new System.Drawing.Point(0, 70);
            this.pnlSeparator.Name = "pnlSeparator";
            this.pnlSeparator.Size = new System.Drawing.Size(1080, 1);
            this.pnlSeparator.TabIndex = 11;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.TXTSearch);
            this.panelTop.Controls.Add(this.BTNTambah);
            this.panelTop.Controls.Add(this.btnEdit);
            this.panelTop.Controls.Add(this.btnHapus);
            this.panelTop.Controls.Add(this.btnRefresh);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 71);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.panelTop.Size = new System.Drawing.Size(1080, 60);
            this.panelTop.TabIndex = 5;
            // 
            // TXTSearch
            // 
            this.TXTSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.TXTSearch.BorderRadius = 8;
            this.TXTSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTSearch.DefaultText = "";
            this.TXTSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.TXTSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.TXTSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.TXTSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("TXTSearch.IconLeft")));
            this.TXTSearch.Location = new System.Drawing.Point(20, 14);
            this.TXTSearch.Name = "TXTSearch";
            this.TXTSearch.PlaceholderText = "Cari jurnal...";
            this.TXTSearch.SelectedText = "";
            this.TXTSearch.Size = new System.Drawing.Size(260, 32);
            this.TXTSearch.TabIndex = 0;
            this.TXTSearch.TextChanged += new System.EventHandler(this.TXTSearch_TextChanged);
            // 
            // BTNTambah
            // 
            this.BTNTambah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNTambah.BorderRadius = 8;
            this.BTNTambah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNTambah.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.BTNTambah.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.BTNTambah.ForeColor = System.Drawing.Color.White;
            this.BTNTambah.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.BTNTambah.Location = new System.Drawing.Point(620, 14);
            this.BTNTambah.Name = "BTNTambah";
            this.BTNTambah.Size = new System.Drawing.Size(100, 32);
            this.BTNTambah.TabIndex = 1;
            this.BTNTambah.Text = "+ Tambah";
            this.BTNTambah.Click += new System.EventHandler(this.BTNTambah_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BorderRadius = 8;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnEdit.Location = new System.Drawing.Point(728, 14);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 32);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "\u270e  Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHapus.BorderRadius = 8;
            this.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnHapus.Location = new System.Drawing.Point(826, 14);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(90, 32);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnRefresh.BorderRadius = 8;
            this.btnRefresh.BorderThickness = 1;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnRefresh.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnRefresh.Location = new System.Drawing.Point(924, 14);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 32);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(-500, -500);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1, 1);
            this.lblTitle.TabIndex = 99;
            this.lblTitle.Text = "Data Jurnal Harian";
            // 
            // DGVRole
            // 
            this.DGVRole.AllowUserToAddRows = false;
            this.DGVRole.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.DGVRole.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVRole.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVRole.BackgroundColor = System.Drawing.Color.White;
            this.DGVRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.DGVRole.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVRole.ColumnHeadersHeight = 40;
            this.DGVRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
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
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVRole.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVRole.EnableHeadersVisualStyles = false;
            this.DGVRole.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DGVRole.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.DGVRole.Location = new System.Drawing.Point(0, 131);
            this.DGVRole.MultiSelect = false;
            this.DGVRole.Name = "DGVRole";
            this.DGVRole.ReadOnly = true;
            this.DGVRole.RowHeadersVisible = false;
            this.DGVRole.RowTemplate.Height = 36;
            this.DGVRole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVRole.Size = new System.Drawing.Size(1080, 469);
            this.DGVRole.TabIndex = 7;
            this.DGVRole.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVRole_CellClick);
            // 
            // ColNo
            // 
            this.ColNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColNo.HeaderText = "No";
            this.ColNo.Name = "ColNo";
            this.ColNo.ReadOnly = true;
            this.ColNo.Width = 50;
            // 
            // ColIDJurnal
            // 
            this.ColIDJurnal.HeaderText = "ID_Jurnal";
            this.ColIDJurnal.Name = "ColIDJurnal";
            this.ColIDJurnal.ReadOnly = true;
            this.ColIDJurnal.Visible = false;
            // 
            // ColIDPrakerin
            // 
            this.ColIDPrakerin.HeaderText = "ID_Prakerin";
            this.ColIDPrakerin.Name = "ColIDPrakerin";
            this.ColIDPrakerin.ReadOnly = true;
            this.ColIDPrakerin.Visible = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "Nama Siswa";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // ColTanggal
            // 
            this.ColTanggal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColTanggal.HeaderText = "Tanggal";
            this.ColTanggal.Name = "ColTanggal";
            this.ColTanggal.ReadOnly = true;
            this.ColTanggal.Width = 110;
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
            this.ColKendala.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColKendala.HeaderText = "Kendala";
            this.ColKendala.Name = "ColKendala";
            this.ColKendala.ReadOnly = true;
            this.ColKendala.Width = 150;
            // 
            // ColSolusi
            // 
            this.ColSolusi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColSolusi.HeaderText = "Solusi";
            this.ColSolusi.Name = "ColSolusi";
            this.ColSolusi.ReadOnly = true;
            this.ColSolusi.Width = 150;
            // 
            // ColStatusVerifikasi
            // 
            this.ColStatusVerifikasi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColStatusVerifikasi.HeaderText = "Status";
            this.ColStatusVerifikasi.Name = "ColStatusVerifikasi";
            this.ColStatusVerifikasi.ReadOnly = true;
            this.ColStatusVerifikasi.Width = 110;
            // 
            // TXTIDJurnal
            // 
            this.TXTIDJurnal.DefaultText = "";
            this.TXTIDJurnal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTIDJurnal.Location = new System.Drawing.Point(-500, 0);
            this.TXTIDJurnal.Name = "TXTIDJurnal";
            this.TXTIDJurnal.SelectedText = "";
            this.TXTIDJurnal.Size = new System.Drawing.Size(10, 10);
            this.TXTIDJurnal.TabIndex = 91;
            // 
            // TXTIDPrakerin
            // 
            this.TXTIDPrakerin.DefaultText = "";
            this.TXTIDPrakerin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTIDPrakerin.Location = new System.Drawing.Point(-500, 20);
            this.TXTIDPrakerin.Name = "TXTIDPrakerin";
            this.TXTIDPrakerin.SelectedText = "";
            this.TXTIDPrakerin.Size = new System.Drawing.Size(10, 10);
            this.TXTIDPrakerin.TabIndex = 92;
            // 
            // TXTTanggal
            // 
            this.TXTTanggal.DefaultText = "";
            this.TXTTanggal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTTanggal.Location = new System.Drawing.Point(-500, 40);
            this.TXTTanggal.Name = "TXTTanggal";
            this.TXTTanggal.SelectedText = "";
            this.TXTTanggal.Size = new System.Drawing.Size(10, 10);
            this.TXTTanggal.TabIndex = 93;
            // 
            // TXTKegiatan
            // 
            this.TXTKegiatan.DefaultText = "";
            this.TXTKegiatan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTKegiatan.Location = new System.Drawing.Point(-500, 60);
            this.TXTKegiatan.Name = "TXTKegiatan";
            this.TXTKegiatan.SelectedText = "";
            this.TXTKegiatan.Size = new System.Drawing.Size(10, 10);
            this.TXTKegiatan.TabIndex = 94;
            // 
            // TXTKendala
            // 
            this.TXTKendala.DefaultText = "";
            this.TXTKendala.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTKendala.Location = new System.Drawing.Point(-500, 80);
            this.TXTKendala.Name = "TXTKendala";
            this.TXTKendala.SelectedText = "";
            this.TXTKendala.Size = new System.Drawing.Size(10, 10);
            this.TXTKendala.TabIndex = 95;
            // 
            // TXTSolusi
            // 
            this.TXTSolusi.DefaultText = "";
            this.TXTSolusi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTSolusi.Location = new System.Drawing.Point(-500, 100);
            this.TXTSolusi.Name = "TXTSolusi";
            this.TXTSolusi.SelectedText = "";
            this.TXTSolusi.Size = new System.Drawing.Size(10, 10);
            this.TXTSolusi.TabIndex = 96;
            // 
            // CMBStatusVerifikasi
            // 
            this.CMBStatusVerifikasi.BackColor = System.Drawing.Color.White;
            this.CMBStatusVerifikasi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBStatusVerifikasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBStatusVerifikasi.ForeColor = System.Drawing.Color.Black;
            this.CMBStatusVerifikasi.ItemHeight = 22;
            this.CMBStatusVerifikasi.Location = new System.Drawing.Point(-500, 120);
            this.CMBStatusVerifikasi.Name = "CMBStatusVerifikasi";
            this.CMBStatusVerifikasi.Size = new System.Drawing.Size(10, 28);
            this.CMBStatusVerifikasi.TabIndex = 97;
            // 
            // FJurnal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1080, 600);
            this.Controls.Add(this.DGVRole);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.pnlSeparator);
            this.Controls.Add(this.pnlPageHeader);
            this.Controls.Add(this.TXTIDJurnal);
            this.Controls.Add(this.TXTIDPrakerin);
            this.Controls.Add(this.TXTTanggal);
            this.Controls.Add(this.TXTKegiatan);
            this.Controls.Add(this.TXTKendala);
            this.Controls.Add(this.TXTSolusi);
            this.Controls.Add(this.CMBStatusVerifikasi);
            this.Name = "FJurnal";
            this.Text = "Jurnal Prakerin";
            this.Load += new System.EventHandler(this.FJurnal_Load);
            this.pnlPageHeader.ResumeLayout(false);
            this.pnlPageHeader.PerformLayout();
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRole)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel pnlPageHeader;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblPageSub;
        private System.Windows.Forms.Panel pnlSeparator;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox TXTSearch;
        private Guna.UI2.WinForms.Guna2Button BTNTambah;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnHapus;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private System.Windows.Forms.DataGridView DGVRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIDJurnal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIDPrakerin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKegiatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKendala;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSolusi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStatusVerifikasi;
        private Guna.UI2.WinForms.Guna2TextBox TXTIDJurnal;
        private Guna.UI2.WinForms.Guna2TextBox TXTIDPrakerin;
        private Guna.UI2.WinForms.Guna2TextBox TXTTanggal;
        private Guna.UI2.WinForms.Guna2TextBox TXTKegiatan;
        private Guna.UI2.WinForms.Guna2TextBox TXTKendala;
        private Guna.UI2.WinForms.Guna2TextBox TXTSolusi;
        private Guna.UI2.WinForms.Guna2ComboBox CMBStatusVerifikasi;
    }
}
