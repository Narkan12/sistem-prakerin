namespace app_prakerin
{
    partial class FMonitoring
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMonitoring));
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.TXTNIS = new Guna.UI2.WinForms.Guna2TextBox();
            this.TXTNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.TXTNoHP = new Guna.UI2.WinForms.Guna2TextBox();
            this.TXTAlamat = new Guna.UI2.WinForms.Guna2TextBox();
            this.CMBJK = new Guna.UI2.WinForms.Guna2ComboBox();
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
            this.lblPageTitle.Size = new System.Drawing.Size(100, 25);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Monitoring";
            // 
            // lblPageSub
            // 
            this.lblPageSub.AutoSize = true;
            this.lblPageSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPageSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblPageSub.Location = new System.Drawing.Point(20, 42);
            this.lblPageSub.Name = "lblPageSub";
            this.lblPageSub.Size = new System.Drawing.Size(280, 15);
            this.lblPageSub.TabIndex = 1;
            this.lblPageSub.Text = "Pantau kunjungan pembimbing ke lokasi Prakerin.";
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
            this.TXTSearch.PlaceholderText = "Cari monitoring...";
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
            this.lblTitle.Text = "Monitoring";
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
            this.dataGridViewTextBoxColumn1,
            this.Column2,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column3,
            this.Column4,
            this.Column1});
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID_Monitoring";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_Prakerin";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "ID_Guru";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.HeaderText = "Tanggal";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 110;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Catatan";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "Foto";
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // TXTNIS
            // 
            this.TXTNIS.DefaultText = "";
            this.TXTNIS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTNIS.Location = new System.Drawing.Point(-500, 0);
            this.TXTNIS.Name = "TXTNIS";
            this.TXTNIS.SelectedText = "";
            this.TXTNIS.Size = new System.Drawing.Size(10, 10);
            this.TXTNIS.TabIndex = 91;
            // 
            // TXTNama
            // 
            this.TXTNama.DefaultText = "";
            this.TXTNama.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTNama.Location = new System.Drawing.Point(-500, 20);
            this.TXTNama.Name = "TXTNama";
            this.TXTNama.SelectedText = "";
            this.TXTNama.Size = new System.Drawing.Size(10, 10);
            this.TXTNama.TabIndex = 92;
            // 
            // TXTNoHP
            // 
            this.TXTNoHP.DefaultText = "";
            this.TXTNoHP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTNoHP.Location = new System.Drawing.Point(-500, 40);
            this.TXTNoHP.Name = "TXTNoHP";
            this.TXTNoHP.SelectedText = "";
            this.TXTNoHP.Size = new System.Drawing.Size(10, 10);
            this.TXTNoHP.TabIndex = 93;
            // 
            // TXTAlamat
            // 
            this.TXTAlamat.DefaultText = "";
            this.TXTAlamat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTAlamat.Location = new System.Drawing.Point(-500, 60);
            this.TXTAlamat.Name = "TXTAlamat";
            this.TXTAlamat.SelectedText = "";
            this.TXTAlamat.Size = new System.Drawing.Size(10, 10);
            this.TXTAlamat.TabIndex = 94;
            // 
            // CMBJK
            // 
            this.CMBJK.BackColor = System.Drawing.Color.White;
            this.CMBJK.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBJK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBJK.ForeColor = System.Drawing.Color.Black;
            this.CMBJK.ItemHeight = 22;
            this.CMBJK.Location = new System.Drawing.Point(-500, 80);
            this.CMBJK.Name = "CMBJK";
            this.CMBJK.Size = new System.Drawing.Size(10, 28);
            this.CMBJK.TabIndex = 95;
            // 
            // FMonitoring
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1080, 600);
            this.Controls.Add(this.DGVRole);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.pnlSeparator);
            this.Controls.Add(this.pnlPageHeader);
            this.Controls.Add(this.TXTNIS);
            this.Controls.Add(this.TXTNama);
            this.Controls.Add(this.TXTNoHP);
            this.Controls.Add(this.TXTAlamat);
            this.Controls.Add(this.CMBJK);
            this.Name = "FMonitoring";
            this.Text = "Monitoring";
            this.Load += new System.EventHandler(this.FMonitoring_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private Guna.UI2.WinForms.Guna2TextBox TXTNIS;
        private Guna.UI2.WinForms.Guna2TextBox TXTNama;
        private Guna.UI2.WinForms.Guna2TextBox TXTNoHP;
        private Guna.UI2.WinForms.Guna2TextBox TXTAlamat;
        private Guna.UI2.WinForms.Guna2ComboBox CMBJK;
    }
}
