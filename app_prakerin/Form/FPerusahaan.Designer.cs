namespace app_prakerin
{
    partial class FPerusahaan
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPerusahaan));
            this.pnlPageHeader = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblPageSub = new System.Windows.Forms.Label();
            this.pnlSeparator = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.TXTSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.BTNTambah = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnHapus = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.DGVRole = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TXTNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.TXTAlamat = new Guna.UI2.WinForms.Guna2TextBox();
            this.TXTNoTelp = new Guna.UI2.WinForms.Guna2TextBox();
            this.TXTEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.TXTBidang = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.pnlPageHeader.Height = 70;
            this.pnlPageHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlPageHeader.Name = "pnlPageHeader";
            this.pnlPageHeader.Padding = new System.Windows.Forms.Padding(20);
            this.pnlPageHeader.Size = new System.Drawing.Size(1080, 70);
            this.pnlPageHeader.TabIndex = 0;
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblPageTitle.Location = new System.Drawing.Point(20, 10);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(160, 25);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Data Perusahaan";
            // 
            // lblPageSub
            // 
            this.lblPageSub.AutoSize = true;
            this.lblPageSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPageSub.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblPageSub.Location = new System.Drawing.Point(20, 40);
            this.lblPageSub.Name = "lblPageSub";
            this.lblPageSub.Size = new System.Drawing.Size(220, 15);
            this.lblPageSub.TabIndex = 1;
            this.lblPageSub.Text = "Kelola data perusahaan tempat Prakerin.";
            // 
            // pnlSeparator
            // 
            this.pnlSeparator.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.pnlSeparator.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSeparator.Height = 1;
            this.pnlSeparator.Location = new System.Drawing.Point(0, 70);
            this.pnlSeparator.Name = "pnlSeparator";
            this.pnlSeparator.Size = new System.Drawing.Size(1080, 1);
            this.pnlSeparator.TabIndex = 1;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.TXTSearch);
            this.panelTop.Controls.Add(this.BTNTambah);
            this.panelTop.Controls.Add(this.btnEdit);
            this.panelTop.Controls.Add(this.btnHapus);
            this.panelTop.Controls.Add(this.btnRefresh);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 60;
            this.panelTop.Location = new System.Drawing.Point(0, 71);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(20);
            this.panelTop.Size = new System.Drawing.Size(1080, 60);
            this.panelTop.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(-500, -500);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1, 1);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "";
            // 
            // TXTSearch
            // 
            this.TXTSearch.BorderRadius = 8;
            this.TXTSearch.FillColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.TXTSearch.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.TXTSearch.FocusedBorderColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.TXTSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("TXTSearch.IconLeft")));
            this.TXTSearch.Location = new System.Drawing.Point(20, 14);
            this.TXTSearch.Name = "TXTSearch";
            this.TXTSearch.PlaceholderText = "Cari perusahaan...";
            this.TXTSearch.Size = new System.Drawing.Size(260, 32);
            this.TXTSearch.TabIndex = 1;
            this.TXTSearch.TextChanged += new System.EventHandler(this.TXTSearch_TextChanged);
            // 
            // BTNTambah
            // 
            this.BTNTambah.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.BTNTambah.BorderRadius = 8;
            this.BTNTambah.FillColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.BTNTambah.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BTNTambah.ForeColor = System.Drawing.Color.White;
            this.BTNTambah.Location = new System.Drawing.Point(680, 14);
            this.BTNTambah.Name = "BTNTambah";
            this.BTNTambah.Size = new System.Drawing.Size(100, 32);
            this.BTNTambah.TabIndex = 2;
            this.BTNTambah.Text = "+ Tambah";
            this.BTNTambah.Click += new System.EventHandler(this.BTNTambah_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnEdit.BorderRadius = 8;
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(245, 158, 11);
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(788, 14);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 32);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "✎  Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnHapus.BorderRadius = 8;
            this.btnHapus.FillColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Location = new System.Drawing.Point(886, 14);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(90, 32);
            this.btnHapus.TabIndex = 4;
            this.btnHapus.Text = "🗑  Hapus";
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnRefresh.BorderRadius = 8;
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.btnRefresh.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnRefresh.BorderThickness = 1;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.btnRefresh.Location = new System.Drawing.Point(984, 14);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 32);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "↺  Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // DGVRole
            // 
            this.DGVRole.AllowUserToAddRows = false;
            this.DGVRole.AllowUserToDeleteRows = false;
            this.DGVRole.BackgroundColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.DGVRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVRole.ColumnHeadersHeight = 40;
            this.DGVRole.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.dataGridViewTextBoxColumn1,
                this.Column2,
                this.dataGridViewTextBoxColumn2,
                this.dataGridViewTextBoxColumn3,
                this.Column3,
                this.Column4,
                this.Column5
            });
            this.DGVRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVRole.EnableHeadersVisualStyles = false;
            this.DGVRole.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DGVRole.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.DGVRole.Location = new System.Drawing.Point(0, 132);
            this.DGVRole.Name = "DGVRole";
            this.DGVRole.ReadOnly = true;
            this.DGVRole.RowHeadersVisible = false;
            this.DGVRole.RowTemplate.Height = 36;
            this.DGVRole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVRole.Size = new System.Drawing.Size(1080, 468);
            this.DGVRole.TabIndex = 3;
            // Header style
            this.DGVRole.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 58, 138);
            this.DGVRole.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.DGVRole.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.DGVRole.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(30, 58, 138);
            this.DGVRole.ColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            // Row style
            this.DGVRole.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.DGVRole.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.DGVRole.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            this.DGVRole.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            // Alternating row style
            this.DGVRole.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.DGVRole.AlternatingRowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            this.DGVRole.AlternatingRowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.DGVRole.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVRole_CellClick);
            // 
            // dataGridViewTextBoxColumn1 - No
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            this.dataGridViewTextBoxColumn1.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            // 
            // Column2 - ID_Perusahaan (hidden)
            // 
            this.Column2.HeaderText = "ID_Perusahaan";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // dataGridViewTextBoxColumn2 - Nama Perusahaan
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nama Perusahaan";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3 - Alamat
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Alamat";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // Column3 - No. Telp
            // 
            this.Column3.HeaderText = "No. Telp";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 120;
            // 
            // Column4 - Email
            // 
            this.Column4.HeaderText = "Email";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 160;
            // 
            // Column5 - Bidang Usaha
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Bidang Usaha";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // TXTNama (hidden, off-screen)
            // 
            this.TXTNama.Location = new System.Drawing.Point(-500, -500);
            this.TXTNama.Name = "TXTNama";
            this.TXTNama.Size = new System.Drawing.Size(1, 1);
            this.TXTNama.TabIndex = 10;
            this.TXTNama.Visible = false;
            // 
            // TXTAlamat (hidden, off-screen)
            // 
            this.TXTAlamat.Location = new System.Drawing.Point(-500, -480);
            this.TXTAlamat.Name = "TXTAlamat";
            this.TXTAlamat.Size = new System.Drawing.Size(1, 1);
            this.TXTAlamat.TabIndex = 11;
            this.TXTAlamat.Visible = false;
            // 
            // TXTNoTelp (hidden, off-screen)
            // 
            this.TXTNoTelp.Location = new System.Drawing.Point(-500, -460);
            this.TXTNoTelp.Name = "TXTNoTelp";
            this.TXTNoTelp.Size = new System.Drawing.Size(1, 1);
            this.TXTNoTelp.TabIndex = 12;
            this.TXTNoTelp.Visible = false;
            // 
            // TXTEmail (hidden, off-screen)
            // 
            this.TXTEmail.Location = new System.Drawing.Point(-500, -440);
            this.TXTEmail.Name = "TXTEmail";
            this.TXTEmail.Size = new System.Drawing.Size(1, 1);
            this.TXTEmail.TabIndex = 13;
            this.TXTEmail.Visible = false;
            // 
            // TXTBidang (hidden, off-screen)
            // 
            this.TXTBidang.Location = new System.Drawing.Point(-500, -420);
            this.TXTBidang.Name = "TXTBidang";
            this.TXTBidang.Size = new System.Drawing.Size(1, 1);
            this.TXTBidang.TabIndex = 14;
            this.TXTBidang.Visible = false;
            // 
            // FPerusahaan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(1080, 600);
            this.Controls.Add(this.DGVRole);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.pnlSeparator);
            this.Controls.Add(this.pnlPageHeader);
            this.Controls.Add(this.TXTNama);
            this.Controls.Add(this.TXTAlamat);
            this.Controls.Add(this.TXTNoTelp);
            this.Controls.Add(this.TXTEmail);
            this.Controls.Add(this.TXTBidang);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FPerusahaan";
            this.Text = "Data Perusahaan";
            this.Load += new System.EventHandler(this.FPerusahaan_Load);
            this.pnlPageHeader.ResumeLayout(false);
            this.pnlPageHeader.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private Guna.UI2.WinForms.Guna2TextBox TXTNama;
        private Guna.UI2.WinForms.Guna2TextBox TXTAlamat;
        private Guna.UI2.WinForms.Guna2TextBox TXTNoTelp;
        private Guna.UI2.WinForms.Guna2TextBox TXTEmail;
        private Guna.UI2.WinForms.Guna2TextBox TXTBidang;
    }
}
