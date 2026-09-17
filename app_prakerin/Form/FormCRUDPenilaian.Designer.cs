namespace app_prakerin
{
    partial class FormCRUDPenilaian
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CMBPrakerin = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTDisiplin = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTKerjasama = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTTanggungJawab = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTInisiatif = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TXTKeahlian = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TXTNilaiAkhir = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TXTCatatan = new Guna.UI2.WinForms.Guna2TextBox();
            this.BTNSimpan = new Guna.UI2.WinForms.Guna2Button();
            this.BTNBatal = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(88)))), ((int)(((byte)(187)))));
            this.guna2Panel1.Controls.Add(this.lblJudul);
            this.guna2Panel1.Controls.Add(this.lblSub);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(540, 70);
            this.guna2Panel1.TabIndex = 0;
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblJudul.ForeColor = System.Drawing.Color.White;
            this.lblJudul.Location = new System.Drawing.Point(20, 12);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(229, 23);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Tambah Data Penilaian";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 8.25F); this.lblSub.ForeColor = System.Drawing.Color.FromArgb(200, 220, 255);
            this.lblSub.Location = new System.Drawing.Point(22, 46);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(240, 13);
            this.lblSub.TabIndex = 1;
            this.lblSub.Text = "Form untuk pengisian data penilaian prakerin.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(22, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Prakerin *";
            // 
            // CMBPrakerin
            // 
            this.CMBPrakerin.BackColor = System.Drawing.Color.White;
            this.CMBPrakerin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.CMBPrakerin.BorderRadius = 4;
            this.CMBPrakerin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CMBPrakerin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBPrakerin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBPrakerin.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(88)))), ((int)(((byte)(187)))));
            this.CMBPrakerin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(88)))), ((int)(((byte)(187)))));
            this.CMBPrakerin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CMBPrakerin.ForeColor = System.Drawing.Color.Black;
            this.CMBPrakerin.ItemHeight = 22;
            this.CMBPrakerin.Location = new System.Drawing.Point(25, 112);
            this.CMBPrakerin.Name = "CMBPrakerin";
            this.CMBPrakerin.Size = new System.Drawing.Size(490, 28);
            this.CMBPrakerin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(22, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Disiplin *";
            // 
            // TXTDisiplin
            // 
            this.TXTDisiplin.Animated = true;
            this.TXTDisiplin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.TXTDisiplin.BorderRadius = 6;
            this.TXTDisiplin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTDisiplin.DefaultText = "";
            this.TXTDisiplin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(88)))), ((int)(((byte)(187)))));
            this.TXTDisiplin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTDisiplin.ForeColor = System.Drawing.Color.Black;
            this.TXTDisiplin.Location = new System.Drawing.Point(25, 183);
            this.TXTDisiplin.Name = "TXTDisiplin";
            this.TXTDisiplin.PlaceholderText = "Masukan nilai disiplin...";
            this.TXTDisiplin.SelectedText = "";
            this.TXTDisiplin.Size = new System.Drawing.Size(230, 35);
            this.TXTDisiplin.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(280, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kerjasama *";
            // 
            // TXTKerjasama
            // 
            this.TXTKerjasama.Animated = true;
            this.TXTKerjasama.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.TXTKerjasama.BorderRadius = 6;
            this.TXTKerjasama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTKerjasama.DefaultText = "";
            this.TXTKerjasama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(88)))), ((int)(((byte)(187)))));
            this.TXTKerjasama.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTKerjasama.ForeColor = System.Drawing.Color.Black;
            this.TXTKerjasama.Location = new System.Drawing.Point(283, 183);
            this.TXTKerjasama.Name = "TXTKerjasama";
            this.TXTKerjasama.PlaceholderText = "Masukan nilai kerjasama...";
            this.TXTKerjasama.SelectedText = "";
            this.TXTKerjasama.Size = new System.Drawing.Size(230, 35);
            this.TXTKerjasama.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(22, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tanggung Jawab *";
            // 
            // TXTTanggungJawab
            // 
            this.TXTTanggungJawab.Animated = true;
            this.TXTTanggungJawab.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.TXTTanggungJawab.BorderRadius = 6;
            this.TXTTanggungJawab.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTTanggungJawab.DefaultText = "";
            this.TXTTanggungJawab.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(88)))), ((int)(((byte)(187)))));
            this.TXTTanggungJawab.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTTanggungJawab.ForeColor = System.Drawing.Color.Black;
            this.TXTTanggungJawab.Location = new System.Drawing.Point(25, 255);
            this.TXTTanggungJawab.Name = "TXTTanggungJawab";
            this.TXTTanggungJawab.PlaceholderText = "Masukan nilai tanggung jawab...";
            this.TXTTanggungJawab.SelectedText = "";
            this.TXTTanggungJawab.Size = new System.Drawing.Size(230, 35);
            this.TXTTanggungJawab.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(280, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Inisiatif *";
            // 
            // TXTInisiatif
            // 
            this.TXTInisiatif.Animated = true;
            this.TXTInisiatif.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.TXTInisiatif.BorderRadius = 6;
            this.TXTInisiatif.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTInisiatif.DefaultText = "";
            this.TXTInisiatif.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(88)))), ((int)(((byte)(187)))));
            this.TXTInisiatif.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTInisiatif.ForeColor = System.Drawing.Color.Black;
            this.TXTInisiatif.Location = new System.Drawing.Point(283, 255);
            this.TXTInisiatif.Name = "TXTInisiatif";
            this.TXTInisiatif.PlaceholderText = "Masukan nilai inisiatif...";
            this.TXTInisiatif.SelectedText = "";
            this.TXTInisiatif.Size = new System.Drawing.Size(230, 35);
            this.TXTInisiatif.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(22, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Keahlian *";
            // 
            // TXTKeahlian
            // 
            this.TXTKeahlian.Animated = true;
            this.TXTKeahlian.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.TXTKeahlian.BorderRadius = 6;
            this.TXTKeahlian.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTKeahlian.DefaultText = "";
            this.TXTKeahlian.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(88)))), ((int)(((byte)(187)))));
            this.TXTKeahlian.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTKeahlian.ForeColor = System.Drawing.Color.Black;
            this.TXTKeahlian.Location = new System.Drawing.Point(25, 327);
            this.TXTKeahlian.Name = "TXTKeahlian";
            this.TXTKeahlian.PlaceholderText = "Masukan nilai keahlian...";
            this.TXTKeahlian.SelectedText = "";
            this.TXTKeahlian.Size = new System.Drawing.Size(230, 35);
            this.TXTKeahlian.TabIndex = 12;
            this.TXTKeahlian.TextChanged += new System.EventHandler(this.TXTKeahlian_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(280, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nilai Akhir *";
            // 
            // TXTNilaiAkhir
            // 
            this.TXTNilaiAkhir.Animated = true;
            this.TXTNilaiAkhir.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.TXTNilaiAkhir.BorderRadius = 6;
            this.TXTNilaiAkhir.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTNilaiAkhir.DefaultText = "";
            this.TXTNilaiAkhir.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(88)))), ((int)(((byte)(187)))));
            this.TXTNilaiAkhir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTNilaiAkhir.ForeColor = System.Drawing.Color.Black;
            this.TXTNilaiAkhir.Location = new System.Drawing.Point(283, 327);
            this.TXTNilaiAkhir.Name = "TXTNilaiAkhir";
            this.TXTNilaiAkhir.PlaceholderText = "Masukan nilai akhir...";
            this.TXTNilaiAkhir.SelectedText = "";
            this.TXTNilaiAkhir.Size = new System.Drawing.Size(230, 35);
            this.TXTNilaiAkhir.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(22, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Catatan";
            // 
            // TXTCatatan
            // 
            this.TXTCatatan.Animated = true;
            this.TXTCatatan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.TXTCatatan.BorderRadius = 6;
            this.TXTCatatan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTCatatan.DefaultText = "";
            this.TXTCatatan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(88)))), ((int)(((byte)(187)))));
            this.TXTCatatan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTCatatan.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.TXTCatatan.Location = new System.Drawing.Point(25, 399);
            this.TXTCatatan.Multiline = true;
            this.TXTCatatan.Name = "TXTCatatan";
            this.TXTCatatan.PlaceholderText = "Masukan catatan penilaian...";
            this.TXTCatatan.SelectedText = "";
            this.TXTCatatan.Size = new System.Drawing.Size(488, 55);
            this.TXTCatatan.TabIndex = 16;
            // 
            // BTNSimpan
            // 
            this.BTNSimpan.BorderRadius = 8;
            this.BTNSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNSimpan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(88)))), ((int)(((byte)(187)))));
            this.BTNSimpan.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.BTNSimpan.ForeColor = System.Drawing.Color.White;
            this.BTNSimpan.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(74)))), ((int)(((byte)(150)))));
            this.BTNSimpan.Location = new System.Drawing.Point(368, 475);
            this.BTNSimpan.Name = "BTNSimpan";
            this.BTNSimpan.Size = new System.Drawing.Size(145, 38);
            this.BTNSimpan.TabIndex = 17;
            this.BTNSimpan.Text = "Simpan";
            this.BTNSimpan.Click += new System.EventHandler(this.BTNSimpan_Click);
            // 
            // BTNBatal
            // 
            this.BTNBatal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.BTNBatal.BorderRadius = 8;
            this.BTNBatal.BorderThickness = 1;
            this.BTNBatal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNBatal.FillColor = System.Drawing.Color.White;
            this.BTNBatal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTNBatal.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.BTNBatal.HoverState.FillColor = System.Drawing.Color.FromArgb(245, 247, 251);
            this.BTNBatal.Location = new System.Drawing.Point(25, 475);
            this.BTNBatal.Name = "BTNBatal";
            this.BTNBatal.Size = new System.Drawing.Size(120, 38);
            this.BTNBatal.TabIndex = 18;
            this.BTNBatal.Text = "Batal";
            this.BTNBatal.Click += new System.EventHandler(this.BTNBatal_Click);
            // 
            // FormCRUDPenilaian
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(540, 530);
            this.Controls.Add(this.BTNBatal);
            this.Controls.Add(this.BTNSimpan);
            this.Controls.Add(this.TXTCatatan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TXTNilaiAkhir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TXTKeahlian);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TXTInisiatif);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXTTanggungJawab);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXTKerjasama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTDisiplin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CMBPrakerin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCRUDPenilaian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCRUDPenilaian";
            this.Load += new System.EventHandler(this.FormCRUDPenilaian_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox CMBPrakerin;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TXTDisiplin;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox TXTKerjasama;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox TXTTanggungJawab;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox TXTInisiatif;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox TXTKeahlian;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox TXTNilaiAkhir;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox TXTCatatan;
        private Guna.UI2.WinForms.Guna2Button BTNSimpan;
        private Guna.UI2.WinForms.Guna2Button BTNBatal;
    }
}