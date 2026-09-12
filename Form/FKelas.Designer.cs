namespace app_prakerin
{
    partial class FKelas
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FKelas));
            this.DGVRole = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHapus = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.BTNTambah = new Guna.UI2.WinForms.Guna2Button();
            this.TXTSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.TXTNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.TXTKeterangan = new Guna.UI2.WinForms.Guna2TextBox();
            this.CMBJurusan = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRole)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // DGVRole
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(240, 244, 248);
            this.DGVRole.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVRole.AllowUserToAddRows = false;
            this.DGVRole.AllowUserToDeleteRows = false;
            this.DGVRole.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVRole.BackgroundColor = System.Drawing.Color.White;
            this.DGVRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(22, 42, 70);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVRole.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVRole.ColumnHeadersHeight = 32;
            this.DGVRole.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.dataGridViewTextBoxColumn1, this.Column2,
                this.dataGridViewTextBoxColumn2, this.dataGridViewTextBoxColumn3, this.Column3 });
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DGVRole.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVRole.EnableHeadersVisualStyles = false;
            this.DGVRole.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DGVRole.MultiSelect = false;
            this.DGVRole.Name = "DGVRole";
            this.DGVRole.ReadOnly = true;
            this.DGVRole.RowHeadersVisible = false;
            this.DGVRole.RowTemplate.Height = 26;
            this.DGVRole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVRole.TabIndex = 7;
            this.DGVRole.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVRole_CellClick);
            // Columns
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 45;
            this.Column2.HeaderText = "ID_Kelas";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nama Kelas";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Tingkat";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.Column3.HeaderText = "Jurusan";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // Buttons
            this.btnHapus.BorderRadius = 5;
            this.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapus.FillColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Location = new System.Drawing.Point(661, 15);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(70, 27);
            this.btnHapus.TabIndex = 1;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            this.btnEdit.BorderRadius = 5;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(583, 15);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(70, 27);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.BTNTambah.BorderRadius = 5;
            this.BTNTambah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNTambah.FillColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.BTNTambah.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.BTNTambah.ForeColor = System.Drawing.Color.White;
            this.BTNTambah.Location = new System.Drawing.Point(490, 15);
            this.BTNTambah.Name = "BTNTambah";
            this.BTNTambah.Size = new System.Drawing.Size(85, 27);
            this.BTNTambah.TabIndex = 3;
            this.BTNTambah.Text = "Tambah";
            this.BTNTambah.Click += new System.EventHandler(this.BTNTambah_Click);
            // TXTSearch
            this.TXTSearch.BorderColor = System.Drawing.Color.FromArgb(180, 195, 215);
            this.TXTSearch.BorderRadius = 5;
            this.TXTSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTSearch.DefaultText = "";
            this.TXTSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.TXTSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTSearch.ForeColor = System.Drawing.Color.Black;
            this.TXTSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("TXTSearch.IconLeft")));
            this.TXTSearch.Location = new System.Drawing.Point(135, 14);
            this.TXTSearch.Name = "TXTSearch";
            this.TXTSearch.PlaceholderText = "Cari kelas...";
            this.TXTSearch.SelectedText = "";
            this.TXTSearch.Size = new System.Drawing.Size(247, 28);
            this.TXTSearch.TabIndex = 5;
            this.TXTSearch.TextChanged += new System.EventHandler(this.TXTSearch_TextChanged);
            // lblTitle
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(22, 42, 70);
            this.lblTitle.Location = new System.Drawing.Point(10, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(160, 26);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Data Kelas";
            // panelTop
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
            // Hidden off-screen fields for AmbilData storage
            this.TXTNama.Location = new System.Drawing.Point(-500, 0);
            this.TXTNama.Name = "TXTNama";
            this.TXTNama.Size = new System.Drawing.Size(10, 10);
            this.TXTNama.DefaultText = "";
            this.TXTNama.SelectedText = "";
            this.TXTNama.TabIndex = 98;
            this.TXTKeterangan.Location = new System.Drawing.Point(-500, 20);
            this.TXTKeterangan.Name = "TXTKeterangan";
            this.TXTKeterangan.Size = new System.Drawing.Size(10, 10);
            this.TXTKeterangan.DefaultText = "";
            this.TXTKeterangan.SelectedText = "";
            this.TXTKeterangan.TabIndex = 99;
            this.CMBJurusan.BackColor = System.Drawing.Color.White;
            this.CMBJurusan.BorderColor = System.Drawing.Color.FromArgb(180, 195, 215);
            this.CMBJurusan.BorderRadius = 4;
            this.CMBJurusan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CMBJurusan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBJurusan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBJurusan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.CMBJurusan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CMBJurusan.ForeColor = System.Drawing.Color.Black;
            this.CMBJurusan.ItemHeight = 22;
            this.CMBJurusan.Location = new System.Drawing.Point(-500, 40);
            this.CMBJurusan.Name = "CMBJurusan";
            this.CMBJurusan.Size = new System.Drawing.Size(10, 28);
            this.CMBJurusan.TabIndex = 100;
            this.CMBJurusan.DropDown += new System.EventHandler(this.CMBJurusan_DropDown);
            // Form
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGVRole);
            this.Controls.Add(this.TXTNama);
            this.Controls.Add(this.TXTKeterangan);
            this.Controls.Add(this.CMBJurusan);
            this.Controls.Add(this.panelTop);
            this.Name = "FKelas";
            this.Text = "FKelas";
            this.Load += new System.EventHandler(this.FRole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRole)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.DataGridView DGVRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private Guna.UI2.WinForms.Guna2Button btnHapus;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button BTNTambah;
        private Guna.UI2.WinForms.Guna2TextBox TXTSearch;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelTop;
        private Guna.UI2.WinForms.Guna2TextBox TXTNama;
        private Guna.UI2.WinForms.Guna2TextBox TXTKeterangan;
        private Guna.UI2.WinForms.Guna2ComboBox CMBJurusan;
    }
}
