namespace app_prakerin
{
    partial class FJurusan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FJurusan));
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
            this.DGVJurusan = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TXTKode = new Guna.UI2.WinForms.Guna2TextBox();
            this.TXTNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlPageHeader.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVJurusan)).BeginInit();
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
            this.lblPageTitle.Size = new System.Drawing.Size(130, 25);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Data Jurusan";
            // 
            // lblPageSub
            // 
            this.lblPageSub.AutoSize = true;
            this.lblPageSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPageSub.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblPageSub.Location = new System.Drawing.Point(20, 40);
            this.lblPageSub.Name = "lblPageSub";
            this.lblPageSub.Size = new System.Drawing.Size(200, 15);
            this.lblPageSub.TabIndex = 1;
            this.lblPageSub.Text = "Kelola data jurusan di sekolah.";
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
            this.TXTSearch.PlaceholderText = "Cari jurusan...";
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
            // DGVJurusan
            // 
            this.DGVJurusan.AllowUserToAddRows = false;
            this.DGVJurusan.AllowUserToDeleteRows = false;
            this.DGVJurusan.BackgroundColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.DGVJurusan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVJurusan.ColumnHeadersHeight = 40;
            this.DGVJurusan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.dataGridViewTextBoxColumn1,
                this.column2,
                this.dataGridViewTextBoxColumn2,
                this.dataGridViewTextBoxColumn3
            });
            this.DGVJurusan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVJurusan.EnableHeadersVisualStyles = false;
            this.DGVJurusan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DGVJurusan.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.DGVJurusan.Location = new System.Drawing.Point(0, 132);
            this.DGVJurusan.Name = "DGVJurusan";
            this.DGVJurusan.ReadOnly = true;
            this.DGVJurusan.RowHeadersVisible = false;
            this.DGVJurusan.RowTemplate.Height = 36;
            this.DGVJurusan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVJurusan.Size = new System.Drawing.Size(1080, 468);
            this.DGVJurusan.TabIndex = 3;
            // Header style
            this.DGVJurusan.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 58, 138);
            this.DGVJurusan.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.DGVJurusan.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.DGVJurusan.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(30, 58, 138);
            this.DGVJurusan.ColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            // Row style
            this.DGVJurusan.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.DGVJurusan.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.DGVJurusan.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            this.DGVJurusan.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            // Alternating row style
            this.DGVJurusan.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.DGVJurusan.AlternatingRowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            this.DGVJurusan.AlternatingRowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.DGVJurusan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVJurusan_CellClick);
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
            // column2 - ID_Jurusan (hidden) - lowercase name
            // 
            this.column2.HeaderText = "ID_Jurusan";
            this.column2.Name = "column2";
            this.column2.ReadOnly = true;
            this.column2.Visible = false;
            // 
            // dataGridViewTextBoxColumn2 - Kode Jurusan
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Kode Jurusan";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3 - Nama Jurusan
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Nama Jurusan";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // TXTKode (hidden, off-screen)
            // 
            this.TXTKode.Location = new System.Drawing.Point(-500, -500);
            this.TXTKode.Name = "TXTKode";
            this.TXTKode.Size = new System.Drawing.Size(1, 1);
            this.TXTKode.TabIndex = 10;
            this.TXTKode.Visible = false;
            // 
            // TXTNama (hidden, off-screen)
            // 
            this.TXTNama.Location = new System.Drawing.Point(-500, -480);
            this.TXTNama.Name = "TXTNama";
            this.TXTNama.Size = new System.Drawing.Size(1, 1);
            this.TXTNama.TabIndex = 11;
            this.TXTNama.Visible = false;
            // 
            // FJurusan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(1080, 600);
            this.Controls.Add(this.DGVJurusan);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.pnlSeparator);
            this.Controls.Add(this.pnlPageHeader);
            this.Controls.Add(this.TXTKode);
            this.Controls.Add(this.TXTNama);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FJurusan";
            this.Text = "Data Jurusan";
            this.Load += new System.EventHandler(this.FJurusan_Load);
            this.pnlPageHeader.ResumeLayout(false);
            this.pnlPageHeader.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVJurusan)).EndInit();
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
        private System.Windows.Forms.DataGridView DGVJurusan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Guna.UI2.WinForms.Guna2TextBox TXTKode;
        private Guna.UI2.WinForms.Guna2TextBox TXTNama;
    }
}
