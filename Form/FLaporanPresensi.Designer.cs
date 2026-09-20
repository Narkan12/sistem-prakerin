namespace app_prakerin
{
    partial class FLaporan
    {
        private System.ComponentModel.IContainer components = null;

        /* Header */
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;

        /* Filter */
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label lblFilterTitle;
        private System.Windows.Forms.Label lblCari;
        private System.Windows.Forms.Label lblTanggalMulai;
        private System.Windows.Forms.Label lblTanggalSelesai;
        private System.Windows.Forms.Label lblStatus;

        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpMulai;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpSelesai;
        private Guna.UI2.WinForms.Guna2ComboBox cmbStatus;

        private Guna.UI2.WinForms.Guna2Button btnTampilkan;
        private Guna.UI2.WinForms.Guna2Button btnReset;

        /* Statistik */
        private System.Windows.Forms.Panel cardTotal;
        private System.Windows.Forms.Panel cardHadir;
        private System.Windows.Forms.Panel cardIzin;
        private System.Windows.Forms.Panel cardSakit;
        private System.Windows.Forms.Panel cardAlfa;

        private System.Windows.Forms.Label lblTotalTitle;
        private System.Windows.Forms.Label lblTotalValue;

        private System.Windows.Forms.Label lblHadirTitle;
        private System.Windows.Forms.Label lblHadirValue;

        private System.Windows.Forms.Label lblIzinTitle;
        private System.Windows.Forms.Label lblIzinValue;

        private System.Windows.Forms.Label lblSakitTitle;
        private System.Windows.Forms.Label lblSakitValue;

        private System.Windows.Forms.Label lblAlfaTitle;
        private System.Windows.Forms.Label lblAlfaValue;

        /* Data */
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Label lblDataTitle;
        private System.Windows.Forms.Label lblDataSubtitle;
        private Guna.UI2.WinForms.Guna2Button btnCetak;

        private System.Windows.Forms.DataGridView DGVLaporan;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.btnTampilkan = new Guna.UI2.WinForms.Guna2Button();
            this.cmbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpSelesai = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpMulai = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTanggalSelesai = new System.Windows.Forms.Label();
            this.lblTanggalMulai = new System.Windows.Forms.Label();
            this.lblCari = new System.Windows.Forms.Label();
            this.lblFilterTitle = new System.Windows.Forms.Label();
            this.cardTotal = new System.Windows.Forms.Panel();
            this.lblTotalTitle = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.cardHadir = new System.Windows.Forms.Panel();
            this.lblHadirTitle = new System.Windows.Forms.Label();
            this.lblHadirValue = new System.Windows.Forms.Label();
            this.cardIzin = new System.Windows.Forms.Panel();
            this.lblIzinTitle = new System.Windows.Forms.Label();
            this.lblIzinValue = new System.Windows.Forms.Label();
            this.cardSakit = new System.Windows.Forms.Panel();
            this.lblSakitTitle = new System.Windows.Forms.Label();
            this.lblSakitValue = new System.Windows.Forms.Label();
            this.cardAlfa = new System.Windows.Forms.Panel();
            this.lblAlfaTitle = new System.Windows.Forms.Label();
            this.lblAlfaValue = new System.Windows.Forms.Label();
            this.panelData = new System.Windows.Forms.Panel();
            this.DGVLaporan = new System.Windows.Forms.DataGridView();
            this.btnCetak = new Guna.UI2.WinForms.Guna2Button();
            this.lblDataSubtitle = new System.Windows.Forms.Label();
            this.lblDataTitle = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdAbsensi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdPrakerin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJamMasuk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJamKeluar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelHeader.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.cardTotal.SuspendLayout();
            this.cardHadir.SuspendLayout();
            this.cardIzin.SuspendLayout();
            this.cardSakit.SuspendLayout();
            this.cardAlfa.SuspendLayout();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLaporan)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.btnRefresh);
            this.panelHeader.Controls.Add(this.lblSubtitle);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1119, 80);
            this.panelHeader.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BorderRadius = 6;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(88)))), ((int)(((byte)(187)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(980, 20);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(95, 38);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(115)))), ((int)(((byte)(125)))));
            this.lblSubtitle.Location = new System.Drawing.Point(28, 45);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(367, 15);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Rekapitulasi kehadiran siswa selama kegiatan Praktik Kerja Lapangan";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(88)))), ((int)(((byte)(187)))));
            this.lblTitle.Location = new System.Drawing.Point(25, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(195, 31);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Laporan Presensi";
            // 
            // panelFilter
            // 
            this.panelFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFilter.BackColor = System.Drawing.Color.White;
            this.panelFilter.Controls.Add(this.btnReset);
            this.panelFilter.Controls.Add(this.btnTampilkan);
            this.panelFilter.Controls.Add(this.cmbStatus);
            this.panelFilter.Controls.Add(this.dtpSelesai);
            this.panelFilter.Controls.Add(this.dtpMulai);
            this.panelFilter.Controls.Add(this.txtSearch);
            this.panelFilter.Controls.Add(this.lblStatus);
            this.panelFilter.Controls.Add(this.lblTanggalSelesai);
            this.panelFilter.Controls.Add(this.lblTanggalMulai);
            this.panelFilter.Controls.Add(this.lblCari);
            this.panelFilter.Controls.Add(this.lblFilterTitle);
            this.panelFilter.Location = new System.Drawing.Point(20, 95);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(1060, 125);
            this.panelFilter.TabIndex = 1;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BorderRadius = 5;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.btnReset.Location = new System.Drawing.Point(940, 62);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 35);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTampilkan.BorderRadius = 5;
            this.btnTampilkan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTampilkan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(88)))), ((int)(((byte)(187)))));
            this.btnTampilkan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTampilkan.ForeColor = System.Drawing.Color.White;
            this.btnTampilkan.Location = new System.Drawing.Point(809, 62);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(125, 35);
            this.btnTampilkan.TabIndex = 5;
            this.btnTampilkan.Text = "Tampilkan";
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmbStatus.BorderRadius = 5;
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(88)))), ((int)(((byte)(187)))));
            this.cmbStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(88)))), ((int)(((byte)(187)))));
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbStatus.ItemHeight = 30;
            this.cmbStatus.Items.AddRange(new object[] {
            "Semua Status",
            "Hadir",
            "Izin",
            "Sakit",
            "Alfa"});
            this.cmbStatus.Location = new System.Drawing.Point(564, 62);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(145, 36);
            this.cmbStatus.TabIndex = 4;
            // 
            // dtpSelesai
            // 
            this.dtpSelesai.BorderRadius = 5;
            this.dtpSelesai.Checked = true;
            this.dtpSelesai.FillColor = System.Drawing.Color.White;
            this.dtpSelesai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpSelesai.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSelesai.Location = new System.Drawing.Point(407, 62);
            this.dtpSelesai.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpSelesai.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpSelesai.Name = "dtpSelesai";
            this.dtpSelesai.Size = new System.Drawing.Size(145, 35);
            this.dtpSelesai.TabIndex = 3;
            this.dtpSelesai.Value = new System.DateTime(2026, 9, 18, 12, 42, 19, 547);
            // 
            // dtpMulai
            // 
            this.dtpMulai.BorderRadius = 5;
            this.dtpMulai.Checked = true;
            this.dtpMulai.FillColor = System.Drawing.Color.White;
            this.dtpMulai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpMulai.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMulai.Location = new System.Drawing.Point(252, 62);
            this.dtpMulai.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpMulai.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpMulai.Name = "dtpMulai";
            this.dtpMulai.Size = new System.Drawing.Size(145, 35);
            this.dtpMulai.TabIndex = 2;
            this.dtpMulai.Value = new System.DateTime(2026, 9, 18, 12, 42, 19, 562);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(213)))), ((int)(((byte)(222)))));
            this.txtSearch.BorderRadius = 5;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(88)))), ((int)(((byte)(187)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(20, 62);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Nama siswa / NIS...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(220, 35);
            this.txtSearch.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.lblStatus.Location = new System.Drawing.Point(567, 42);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 15);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status";
            // 
            // lblTanggalSelesai
            // 
            this.lblTanggalSelesai.AutoSize = true;
            this.lblTanggalSelesai.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTanggalSelesai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.lblTanggalSelesai.Location = new System.Drawing.Point(410, 42);
            this.lblTanggalSelesai.Name = "lblTanggalSelesai";
            this.lblTanggalSelesai.Size = new System.Drawing.Size(86, 15);
            this.lblTanggalSelesai.TabIndex = 8;
            this.lblTanggalSelesai.Text = "Tanggal Selesai";
            // 
            // lblTanggalMulai
            // 
            this.lblTanggalMulai.AutoSize = true;
            this.lblTanggalMulai.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTanggalMulai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.lblTanggalMulai.Location = new System.Drawing.Point(255, 42);
            this.lblTanggalMulai.Name = "lblTanggalMulai";
            this.lblTanggalMulai.Size = new System.Drawing.Size(81, 15);
            this.lblTanggalMulai.TabIndex = 9;
            this.lblTanggalMulai.Text = "Tanggal Mulai";
            // 
            // lblCari
            // 
            this.lblCari.AutoSize = true;
            this.lblCari.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.lblCari.Location = new System.Drawing.Point(20, 42);
            this.lblCari.Name = "lblCari";
            this.lblCari.Size = new System.Drawing.Size(60, 15);
            this.lblCari.TabIndex = 10;
            this.lblCari.Text = "Cari Siswa";
            // 
            // lblFilterTitle
            // 
            this.lblFilterTitle.AutoSize = true;
            this.lblFilterTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFilterTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.lblFilterTitle.Location = new System.Drawing.Point(18, 12);
            this.lblFilterTitle.Name = "lblFilterTitle";
            this.lblFilterTitle.Size = new System.Drawing.Size(102, 19);
            this.lblFilterTitle.TabIndex = 11;
            this.lblFilterTitle.Text = "Filter Laporan";
            // 
            // cardTotal
            // 
            this.cardTotal.BackColor = System.Drawing.Color.White;
            this.cardTotal.Controls.Add(this.lblTotalTitle);
            this.cardTotal.Controls.Add(this.lblTotalValue);
            this.cardTotal.Location = new System.Drawing.Point(20, 235);
            this.cardTotal.Name = "cardTotal";
            this.cardTotal.Size = new System.Drawing.Size(200, 80);
            this.cardTotal.TabIndex = 12;
            // 
            // lblTotalTitle
            // 
            this.lblTotalTitle.AutoSize = true;
            this.lblTotalTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTotalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(110)))), ((int)(((byte)(120)))));
            this.lblTotalTitle.Location = new System.Drawing.Point(15, 12);
            this.lblTotalTitle.Name = "lblTotalTitle";
            this.lblTotalTitle.Size = new System.Drawing.Size(76, 15);
            this.lblTotalTitle.TabIndex = 0;
            this.lblTotalTitle.Text = "Total Absensi";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold);
            this.lblTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(88)))), ((int)(((byte)(187)))));
            this.lblTotalValue.Location = new System.Drawing.Point(14, 32);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(33, 38);
            this.lblTotalValue.TabIndex = 1;
            this.lblTotalValue.Text = "0";
            // 
            // cardHadir
            // 
            this.cardHadir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardHadir.BackColor = System.Drawing.Color.White;
            this.cardHadir.Controls.Add(this.lblHadirTitle);
            this.cardHadir.Controls.Add(this.lblHadirValue);
            this.cardHadir.Location = new System.Drawing.Point(235, 235);
            this.cardHadir.Name = "cardHadir";
            this.cardHadir.Size = new System.Drawing.Size(200, 80);
            this.cardHadir.TabIndex = 11;
            // 
            // lblHadirTitle
            // 
            this.lblHadirTitle.AutoSize = true;
            this.lblHadirTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblHadirTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(110)))), ((int)(((byte)(120)))));
            this.lblHadirTitle.Location = new System.Drawing.Point(15, 12);
            this.lblHadirTitle.Name = "lblHadirTitle";
            this.lblHadirTitle.Size = new System.Drawing.Size(36, 15);
            this.lblHadirTitle.TabIndex = 0;
            this.lblHadirTitle.Text = "Hadir";
            // 
            // lblHadirValue
            // 
            this.lblHadirValue.AutoSize = true;
            this.lblHadirValue.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold);
            this.lblHadirValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblHadirValue.Location = new System.Drawing.Point(14, 32);
            this.lblHadirValue.Name = "lblHadirValue";
            this.lblHadirValue.Size = new System.Drawing.Size(33, 38);
            this.lblHadirValue.TabIndex = 1;
            this.lblHadirValue.Text = "0";
            // 
            // cardIzin
            // 
            this.cardIzin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardIzin.BackColor = System.Drawing.Color.White;
            this.cardIzin.Controls.Add(this.lblIzinTitle);
            this.cardIzin.Controls.Add(this.lblIzinValue);
            this.cardIzin.Location = new System.Drawing.Point(450, 235);
            this.cardIzin.Name = "cardIzin";
            this.cardIzin.Size = new System.Drawing.Size(200, 80);
            this.cardIzin.TabIndex = 10;
            // 
            // lblIzinTitle
            // 
            this.lblIzinTitle.AutoSize = true;
            this.lblIzinTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblIzinTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(110)))), ((int)(((byte)(120)))));
            this.lblIzinTitle.Location = new System.Drawing.Point(15, 12);
            this.lblIzinTitle.Name = "lblIzinTitle";
            this.lblIzinTitle.Size = new System.Drawing.Size(25, 15);
            this.lblIzinTitle.TabIndex = 0;
            this.lblIzinTitle.Text = "Izin";
            // 
            // lblIzinValue
            // 
            this.lblIzinValue.AutoSize = true;
            this.lblIzinValue.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold);
            this.lblIzinValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.lblIzinValue.Location = new System.Drawing.Point(14, 32);
            this.lblIzinValue.Name = "lblIzinValue";
            this.lblIzinValue.Size = new System.Drawing.Size(33, 38);
            this.lblIzinValue.TabIndex = 1;
            this.lblIzinValue.Text = "0";
            // 
            // cardSakit
            // 
            this.cardSakit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardSakit.BackColor = System.Drawing.Color.White;
            this.cardSakit.Controls.Add(this.lblSakitTitle);
            this.cardSakit.Controls.Add(this.lblSakitValue);
            this.cardSakit.Location = new System.Drawing.Point(665, 235);
            this.cardSakit.Name = "cardSakit";
            this.cardSakit.Size = new System.Drawing.Size(200, 80);
            this.cardSakit.TabIndex = 9;
            // 
            // lblSakitTitle
            // 
            this.lblSakitTitle.AutoSize = true;
            this.lblSakitTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSakitTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(110)))), ((int)(((byte)(120)))));
            this.lblSakitTitle.Location = new System.Drawing.Point(15, 12);
            this.lblSakitTitle.Name = "lblSakitTitle";
            this.lblSakitTitle.Size = new System.Drawing.Size(32, 15);
            this.lblSakitTitle.TabIndex = 0;
            this.lblSakitTitle.Text = "Sakit";
            // 
            // lblSakitValue
            // 
            this.lblSakitValue.AutoSize = true;
            this.lblSakitValue.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold);
            this.lblSakitValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.lblSakitValue.Location = new System.Drawing.Point(14, 32);
            this.lblSakitValue.Name = "lblSakitValue";
            this.lblSakitValue.Size = new System.Drawing.Size(33, 38);
            this.lblSakitValue.TabIndex = 1;
            this.lblSakitValue.Text = "0";
            // 
            // cardAlfa
            // 
            this.cardAlfa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cardAlfa.BackColor = System.Drawing.Color.White;
            this.cardAlfa.Controls.Add(this.lblAlfaTitle);
            this.cardAlfa.Controls.Add(this.lblAlfaValue);
            this.cardAlfa.Location = new System.Drawing.Point(880, 235);
            this.cardAlfa.Name = "cardAlfa";
            this.cardAlfa.Size = new System.Drawing.Size(200, 80);
            this.cardAlfa.TabIndex = 8;
            // 
            // lblAlfaTitle
            // 
            this.lblAlfaTitle.AutoSize = true;
            this.lblAlfaTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblAlfaTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(110)))), ((int)(((byte)(120)))));
            this.lblAlfaTitle.Location = new System.Drawing.Point(15, 12);
            this.lblAlfaTitle.Name = "lblAlfaTitle";
            this.lblAlfaTitle.Size = new System.Drawing.Size(28, 15);
            this.lblAlfaTitle.TabIndex = 0;
            this.lblAlfaTitle.Text = "Alfa";
            // 
            // lblAlfaValue
            // 
            this.lblAlfaValue.AutoSize = true;
            this.lblAlfaValue.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold);
            this.lblAlfaValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.lblAlfaValue.Location = new System.Drawing.Point(14, 32);
            this.lblAlfaValue.Name = "lblAlfaValue";
            this.lblAlfaValue.Size = new System.Drawing.Size(33, 38);
            this.lblAlfaValue.TabIndex = 1;
            this.lblAlfaValue.Text = "0";
            // 
            // panelData
            // 
            this.panelData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelData.BackColor = System.Drawing.Color.White;
            this.panelData.Controls.Add(this.DGVLaporan);
            this.panelData.Controls.Add(this.btnCetak);
            this.panelData.Controls.Add(this.lblDataSubtitle);
            this.panelData.Controls.Add(this.lblDataTitle);
            this.panelData.Location = new System.Drawing.Point(20, 335);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(1060, 365);
            this.panelData.TabIndex = 7;
            // 
            // DGVLaporan
            // 
            this.DGVLaporan.AllowUserToAddRows = false;
            this.DGVLaporan.AllowUserToDeleteRows = false;
            this.DGVLaporan.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.DGVLaporan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVLaporan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVLaporan.BackgroundColor = System.Drawing.Color.White;
            this.DGVLaporan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVLaporan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVLaporan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(88)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(88)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.DGVLaporan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVLaporan.ColumnHeadersHeight = 38;
            this.DGVLaporan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colIdAbsensi,
            this.colIdPrakerin,
            this.colNIS,
            this.colNama,
            this.colTanggal,
            this.colJamMasuk,
            this.colJamKeluar,
            this.colStatus});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(235)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(88)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVLaporan.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVLaporan.EnableHeadersVisualStyles = false;
            this.DGVLaporan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.DGVLaporan.Location = new System.Drawing.Point(18, 65);
            this.DGVLaporan.MultiSelect = false;
            this.DGVLaporan.Name = "DGVLaporan";
            this.DGVLaporan.ReadOnly = true;
            this.DGVLaporan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DGVLaporan.RowHeadersVisible = false;
            this.DGVLaporan.RowTemplate.Height = 35;
            this.DGVLaporan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVLaporan.Size = new System.Drawing.Size(1022, 280);
            this.DGVLaporan.TabIndex = 9;
            // 
            // btnCetak
            // 
            this.btnCetak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCetak.BorderRadius = 5;
            this.btnCetak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCetak.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(88)))), ((int)(((byte)(187)))));
            this.btnCetak.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCetak.ForeColor = System.Drawing.Color.White;
            this.btnCetak.Location = new System.Drawing.Point(955, 12);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(85, 35);
            this.btnCetak.TabIndex = 8;
            this.btnCetak.Text = "Cetak";
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
            // 
            // lblDataSubtitle
            // 
            this.lblDataSubtitle.AutoSize = true;
            this.lblDataSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDataSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(115)))), ((int)(((byte)(125)))));
            this.lblDataSubtitle.Location = new System.Drawing.Point(20, 39);
            this.lblDataSubtitle.Name = "lblDataSubtitle";
            this.lblDataSubtitle.Size = new System.Drawing.Size(234, 15);
            this.lblDataSubtitle.TabIndex = 10;
            this.lblDataSubtitle.Text = "Daftar rekapitulasi kehadiran siswa Prakerin";
            // 
            // lblDataTitle
            // 
            this.lblDataTitle.AutoSize = true;
            this.lblDataTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDataTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.lblDataTitle.Location = new System.Drawing.Point(18, 12);
            this.lblDataTitle.Name = "lblDataTitle";
            this.lblDataTitle.Size = new System.Drawing.Size(103, 20);
            this.lblDataTitle.TabIndex = 11;
            this.lblDataTitle.Text = "Data Laporan";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1119, 720);
            this.guna2Panel1.TabIndex = 13;
            // 
            // colNo
            // 
            this.colNo.HeaderText = "No";
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            this.colNo.Width = 45;
            // 
            // colIdAbsensi
            // 
            this.colIdAbsensi.HeaderText = "ID Absensi";
            this.colIdAbsensi.Name = "colIdAbsensi";
            this.colIdAbsensi.ReadOnly = true;
            this.colIdAbsensi.Visible = false;
            this.colIdAbsensi.Width = 150;
            // 
            // colIdPrakerin
            // 
            this.colIdPrakerin.HeaderText = "ID Prakerin";
            this.colIdPrakerin.Name = "colIdPrakerin";
            this.colIdPrakerin.ReadOnly = true;
            this.colIdPrakerin.Visible = false;
            this.colIdPrakerin.Width = 150;
            // 
            // colNIS
            // 
            this.colNIS.HeaderText = "NIS";
            this.colNIS.Name = "colNIS";
            this.colNIS.ReadOnly = true;
            this.colNIS.Width = 90;
            // 
            // colNama
            // 
            this.colNama.HeaderText = "Nama Siswa";
            this.colNama.Name = "colNama";
            this.colNama.ReadOnly = true;
            this.colNama.Width = 180;
            // 
            // colTanggal
            // 
            this.colTanggal.HeaderText = "Tanggal";
            this.colTanggal.Name = "colTanggal";
            this.colTanggal.ReadOnly = true;
            this.colTanggal.Width = 150;
            // 
            // colJamMasuk
            // 
            this.colJamMasuk.HeaderText = "Jam Masuk";
            this.colJamMasuk.Name = "colJamMasuk";
            this.colJamMasuk.ReadOnly = true;
            this.colJamMasuk.Width = 150;
            // 
            // colJamKeluar
            // 
            this.colJamKeluar.HeaderText = "Jam Keluar";
            this.colJamKeluar.Name = "colJamKeluar";
            this.colJamKeluar.ReadOnly = true;
            this.colJamKeluar.Width = 150;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 150;
            // 
            // FLaporan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1119, 720);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.cardAlfa);
            this.Controls.Add(this.cardSakit);
            this.Controls.Add(this.cardIzin);
            this.Controls.Add(this.cardHadir);
            this.Controls.Add(this.cardTotal);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FLaporan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laporan Prakerin";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.cardTotal.ResumeLayout(false);
            this.cardTotal.PerformLayout();
            this.cardHadir.ResumeLayout(false);
            this.cardHadir.PerformLayout();
            this.cardIzin.ResumeLayout(false);
            this.cardIzin.PerformLayout();
            this.cardSakit.ResumeLayout(false);
            this.cardSakit.PerformLayout();
            this.cardAlfa.ResumeLayout(false);
            this.cardAlfa.PerformLayout();
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLaporan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdAbsensi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdPrakerin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNIS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJamMasuk;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJamKeluar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}