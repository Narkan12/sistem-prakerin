
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
            System.Windows.Forms.DataGridViewCellStyle hdrStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle rowStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle altStyle = new System.Windows.Forms.DataGridViewCellStyle();

            this.pnlPageHeader  = new System.Windows.Forms.Panel();
            this.lblPageTitle   = new System.Windows.Forms.Label();
            this.lblPageSub     = new System.Windows.Forms.Label();
            this.pnlSeparator   = new System.Windows.Forms.Panel();
            this.panelTop       = new System.Windows.Forms.Panel();
            this.lblTitle       = new System.Windows.Forms.Label();
            this.TXTSearch      = new Guna.UI2.WinForms.Guna2TextBox();
            this.BTNTambah      = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit        = new Guna.UI2.WinForms.Guna2Button();
            this.btnHapus       = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh     = new Guna.UI2.WinForms.Guna2Button();
            this.DGVRole        = new System.Windows.Forms.DataGridView();
            // hidden helpers
            this.TXTNIS         = new Guna.UI2.WinForms.Guna2TextBox();
            this.TXTNama        = new Guna.UI2.WinForms.Guna2TextBox();
            this.TXTNoHP        = new Guna.UI2.WinForms.Guna2TextBox();
            this.TXTAlamat      = new Guna.UI2.WinForms.Guna2TextBox();
            this.CMBJK          = new Guna.UI2.WinForms.Guna2ComboBox();
            // columns
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2        = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3        = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4        = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5        = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6        = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1        = new System.Windows.Forms.DataGridViewImageColumn();

            this.pnlPageHeader.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRole)).BeginInit();
            this.SuspendLayout();

            // PAGE HEADER
            this.pnlPageHeader.BackColor = System.Drawing.Color.White; this.pnlPageHeader.Dock = System.Windows.Forms.DockStyle.Top; this.pnlPageHeader.Height = 70; this.pnlPageHeader.Name = "pnlPageHeader"; this.pnlPageHeader.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0); this.pnlPageHeader.TabIndex = 10; this.pnlPageHeader.Controls.Add(this.lblPageTitle); this.pnlPageHeader.Controls.Add(this.lblPageSub);
            this.lblPageTitle.Text = "Monitoring"; this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold); this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42); this.lblPageTitle.Location = new System.Drawing.Point(20, 12); this.lblPageTitle.AutoSize = true; this.lblPageTitle.TabIndex = 0;
            this.lblPageSub.Text = "Pantau kunjungan pembimbing ke lokasi Prakerin."; this.lblPageSub.Font = new System.Drawing.Font("Segoe UI", 9F); this.lblPageSub.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139); this.lblPageSub.Location = new System.Drawing.Point(20, 42); this.lblPageSub.AutoSize = true; this.lblPageSub.TabIndex = 1;
            this.pnlSeparator.BackColor = System.Drawing.Color.FromArgb(226, 232, 240); this.pnlSeparator.Dock = System.Windows.Forms.DockStyle.Top; this.pnlSeparator.Height = 1; this.pnlSeparator.Name = "pnlSeparator"; this.pnlSeparator.TabIndex = 11;

            // TOOLBAR
            this.panelTop.BackColor = System.Drawing.Color.White; this.panelTop.Dock = System.Windows.Forms.DockStyle.Top; this.panelTop.Height = 60; this.panelTop.Name = "panelTop"; this.panelTop.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0); this.panelTop.TabIndex = 5; this.panelTop.Controls.Add(this.TXTSearch); this.panelTop.Controls.Add(this.BTNTambah); this.panelTop.Controls.Add(this.btnEdit); this.panelTop.Controls.Add(this.btnHapus); this.panelTop.Controls.Add(this.btnRefresh); this.panelTop.Controls.Add(this.lblTitle);
            this.lblTitle.Text = "Monitoring"; this.lblTitle.Location = new System.Drawing.Point(-500, -500); this.lblTitle.Size = new System.Drawing.Size(1, 1); this.lblTitle.Name = "lblTitle"; this.lblTitle.TabIndex = 99;
            this.TXTSearch.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225); this.TXTSearch.BorderRadius = 8; this.TXTSearch.FillColor = System.Drawing.Color.FromArgb(248, 250, 252); this.TXTSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(59, 130, 246); this.TXTSearch.Font = new System.Drawing.Font("Segoe UI", 9F); this.TXTSearch.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85); this.TXTSearch.PlaceholderText = "Cari monitoring..."; this.TXTSearch.DefaultText = ""; this.TXTSearch.SelectedText = ""; this.TXTSearch.Cursor = System.Windows.Forms.Cursors.IBeam; this.TXTSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("TXTSearch.IconLeft"))); this.TXTSearch.Location = new System.Drawing.Point(20, 14); this.TXTSearch.Name = "TXTSearch"; this.TXTSearch.Size = new System.Drawing.Size(260, 32); this.TXTSearch.TabIndex = 0; this.TXTSearch.TextChanged += new System.EventHandler(this.TXTSearch_TextChanged);
            this.BTNTambah.FillColor = System.Drawing.Color.FromArgb(37, 99, 235); this.BTNTambah.HoverState.FillColor = System.Drawing.Color.FromArgb(29, 78, 216); this.BTNTambah.BorderRadius = 8; this.BTNTambah.Cursor = System.Windows.Forms.Cursors.Hand; this.BTNTambah.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold); this.BTNTambah.ForeColor = System.Drawing.Color.White; this.BTNTambah.Text = "+ Tambah"; this.BTNTambah.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)); this.BTNTambah.Location = new System.Drawing.Point(680, 14); this.BTNTambah.Name = "BTNTambah"; this.BTNTambah.Size = new System.Drawing.Size(100, 32); this.BTNTambah.TabIndex = 1; this.BTNTambah.Click += new System.EventHandler(this.BTNTambah_Click);
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(245, 158, 11); this.btnEdit.HoverState.FillColor = System.Drawing.Color.FromArgb(217, 119, 6); this.btnEdit.BorderRadius = 8; this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand; this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold); this.btnEdit.ForeColor = System.Drawing.Color.White; this.btnEdit.Text = "✎  Edit"; this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)); this.btnEdit.Location = new System.Drawing.Point(788, 14); this.btnEdit.Name = "btnEdit"; this.btnEdit.Size = new System.Drawing.Size(90, 32); this.btnEdit.TabIndex = 2; this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnHapus.FillColor = System.Drawing.Color.FromArgb(220, 38, 38); this.btnHapus.HoverState.FillColor = System.Drawing.Color.FromArgb(185, 28, 28); this.btnHapus.BorderRadius = 8; this.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand; this.btnHapus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold); this.btnHapus.ForeColor = System.Drawing.Color.White; this.btnHapus.Text = "🗑  Hapus"; this.btnHapus.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)); this.btnHapus.Location = new System.Drawing.Point(886, 14); this.btnHapus.Name = "btnHapus"; this.btnHapus.Size = new System.Drawing.Size(90, 32); this.btnHapus.TabIndex = 3; this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(248, 250, 252); this.btnRefresh.HoverState.FillColor = System.Drawing.Color.FromArgb(241, 245, 249); this.btnRefresh.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225); this.btnRefresh.BorderThickness = 1; this.btnRefresh.BorderRadius = 8; this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand; this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F); this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105); this.btnRefresh.Text = "↺  Refresh"; this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)); this.btnRefresh.Location = new System.Drawing.Point(984, 14); this.btnRefresh.Name = "btnRefresh"; this.btnRefresh.Size = new System.Drawing.Size(90, 32); this.btnRefresh.TabIndex = 4; this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // DGV
            hdrStyle.BackColor = System.Drawing.Color.FromArgb(30, 58, 138); hdrStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold); hdrStyle.ForeColor = System.Drawing.Color.White; hdrStyle.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0); hdrStyle.SelectionBackColor = System.Drawing.Color.FromArgb(30, 58, 138); hdrStyle.SelectionForeColor = System.Drawing.Color.White;
            rowStyle.BackColor = System.Drawing.Color.White; rowStyle.Font = new System.Drawing.Font("Segoe UI", 9F); rowStyle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59); rowStyle.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0); rowStyle.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254); rowStyle.SelectionForeColor = System.Drawing.Color.FromArgb(30, 58, 138); rowStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            altStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252); altStyle.Font = new System.Drawing.Font("Segoe UI", 9F); altStyle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59); altStyle.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0); altStyle.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254); altStyle.SelectionForeColor = System.Drawing.Color.FromArgb(30, 58, 138);

            this.DGVRole.AllowUserToAddRows = false; this.DGVRole.AllowUserToDeleteRows = false; this.DGVRole.AlternatingRowsDefaultCellStyle = altStyle; this.DGVRole.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill; this.DGVRole.BackgroundColor = System.Drawing.Color.White; this.DGVRole.BorderStyle = System.Windows.Forms.BorderStyle.None; this.DGVRole.ColumnHeadersDefaultCellStyle = hdrStyle; this.DGVRole.ColumnHeadersHeight = 40; this.DGVRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing; this.DGVRole.DefaultCellStyle = rowStyle; this.DGVRole.EnableHeadersVisualStyles = false; this.DGVRole.Font = new System.Drawing.Font("Segoe UI", 9F); this.DGVRole.GridColor = System.Drawing.Color.FromArgb(226, 232, 240); this.DGVRole.MultiSelect = false; this.DGVRole.Name = "DGVRole"; this.DGVRole.ReadOnly = true; this.DGVRole.RowHeadersVisible = false; this.DGVRole.RowTemplate.Height = 36; this.DGVRole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect; this.DGVRole.Dock = System.Windows.Forms.DockStyle.Fill; this.DGVRole.TabIndex = 7; this.DGVRole.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVRole_CellClick);

            this.dataGridViewTextBoxColumn1.HeaderText = "No"; this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1"; this.dataGridViewTextBoxColumn1.ReadOnly = true; this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None; this.dataGridViewTextBoxColumn1.Width = 50;
            this.Column2.HeaderText = "ID_Monitoring"; this.Column2.Name = "Column2"; this.Column2.ReadOnly = true; this.Column2.Visible = false;
            this.Column3.HeaderText = "ID_Prakerin"; this.Column3.Name = "Column3"; this.Column3.ReadOnly = true; this.Column3.Visible = false;
            this.Column4.HeaderText = "ID_Guru"; this.Column4.Name = "Column4"; this.Column4.ReadOnly = true; this.Column4.Visible = false;
            this.Column5.HeaderText = "Tanggal"; this.Column5.Name = "Column5"; this.Column5.ReadOnly = true; this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None; this.Column5.Width = 110;
            this.Column6.HeaderText = "Catatan"; this.Column6.Name = "Column6"; this.Column6.ReadOnly = true; this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Foto"; this.Column1.Name = "Column1"; this.Column1.ReadOnly = true; this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom; this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None; this.Column1.Width = 80;

            this.DGVRole.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.dataGridViewTextBoxColumn1, this.Column2, this.Column3, this.Column4,
                this.Column5, this.Column6, this.Column1
            });

            // hidden helpers
            this.TXTNIS.Location = new System.Drawing.Point(-500, 0); this.TXTNIS.Size = new System.Drawing.Size(10, 10); this.TXTNIS.Name = "TXTNIS"; this.TXTNIS.DefaultText = ""; this.TXTNIS.SelectedText = ""; this.TXTNIS.Font = new System.Drawing.Font("Segoe UI", 9F); this.TXTNIS.TabIndex = 91;
            this.TXTNama.Location = new System.Drawing.Point(-500, 20); this.TXTNama.Size = new System.Drawing.Size(10, 10); this.TXTNama.Name = "TXTNama"; this.TXTNama.DefaultText = ""; this.TXTNama.SelectedText = ""; this.TXTNama.Font = new System.Drawing.Font("Segoe UI", 9F); this.TXTNama.TabIndex = 92;
            this.TXTNoHP.Location = new System.Drawing.Point(-500, 40); this.TXTNoHP.Size = new System.Drawing.Size(10, 10); this.TXTNoHP.Name = "TXTNoHP"; this.TXTNoHP.DefaultText = ""; this.TXTNoHP.SelectedText = ""; this.TXTNoHP.Font = new System.Drawing.Font("Segoe UI", 9F); this.TXTNoHP.TabIndex = 93;
            this.TXTAlamat.Location = new System.Drawing.Point(-500, 60); this.TXTAlamat.Size = new System.Drawing.Size(10, 10); this.TXTAlamat.Name = "TXTAlamat"; this.TXTAlamat.DefaultText = ""; this.TXTAlamat.SelectedText = ""; this.TXTAlamat.Font = new System.Drawing.Font("Segoe UI", 9F); this.TXTAlamat.TabIndex = 94;
            this.CMBJK.Location = new System.Drawing.Point(-500, 80); this.CMBJK.Size = new System.Drawing.Size(10, 28); this.CMBJK.Name = "CMBJK"; this.CMBJK.BackColor = System.Drawing.Color.White; this.CMBJK.ForeColor = System.Drawing.Color.Black; this.CMBJK.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed; this.CMBJK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; this.CMBJK.ItemHeight = 22; this.CMBJK.TabIndex = 95;

            // FORM
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(1080, 600);
            this.Name = "FMonitoring";
            this.Text = "Monitoring";
            this.Controls.Add(this.DGVRole);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.pnlSeparator);
            this.Controls.Add(this.pnlPageHeader);
            this.Controls.Add(this.TXTNIS);
            this.Controls.Add(this.TXTNama);
            this.Controls.Add(this.TXTNoHP);
            this.Controls.Add(this.TXTAlamat);
            this.Controls.Add(this.CMBJK);
            this.Load += new System.EventHandler(this.FMonitoring_Load);

            this.pnlPageHeader.ResumeLayout(false);
            this.pnlPageHeader.PerformLayout();
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRole)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel         pnlPageHeader;
        private System.Windows.Forms.Label         lblPageTitle;
        private System.Windows.Forms.Label         lblPageSub;
        private System.Windows.Forms.Panel         pnlSeparator;
        private System.Windows.Forms.Panel         panelTop;
        private System.Windows.Forms.Label         lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox     TXTSearch;
        private Guna.UI2.WinForms.Guna2Button      BTNTambah;
        private Guna.UI2.WinForms.Guna2Button      btnEdit;
        private Guna.UI2.WinForms.Guna2Button      btnHapus;
        private Guna.UI2.WinForms.Guna2Button      btnRefresh;
        private System.Windows.Forms.DataGridView  DGVRole;
        private Guna.UI2.WinForms.Guna2TextBox     TXTNIS;
        private Guna.UI2.WinForms.Guna2TextBox     TXTNama;
        private Guna.UI2.WinForms.Guna2TextBox     TXTNoHP;
        private Guna.UI2.WinForms.Guna2TextBox     TXTAlamat;
        private Guna.UI2.WinForms.Guna2ComboBox    CMBJK;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewImageColumn   Column1;
    }
}
