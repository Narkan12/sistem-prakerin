
namespace app_prakerin
{
    partial class FormCRUDPrakerin
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CMBPerusahaan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CMBPembimbing = new Guna.UI2.WinForms.Guna2ComboBox();
            this.BTNSimpan = new Guna.UI2.WinForms.Guna2Button();
            this.BTNBatal = new Guna.UI2.WinForms.Guna2Button();
            this.DTMulai = new System.Windows.Forms.DateTimePicker();
            this.DTSelesai = new System.Windows.Forms.DateTimePicker();
            this.CMBStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CMBSiswa = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CMBGuru = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.guna2Panel1.Size = new System.Drawing.Size(580, 70);
            this.guna2Panel1.TabIndex = 0;
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblJudul.ForeColor = System.Drawing.Color.White;
            this.lblJudul.Location = new System.Drawing.Point(20, 12);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(221, 23);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Tambah Data Prakerin";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(200, 220, 255);
            this.lblSub.Location = new System.Drawing.Point(22, 46);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(191, 13);
            this.lblSub.TabIndex = 1;
            this.lblSub.Text = "Form untuk pengisian data prakerin.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(22, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Siswa *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(295, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Guru Pembimbing *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(26, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Perusahaan *";
            // 
            // CMBPerusahaan
            // 
            this.CMBPerusahaan.BackColor = System.Drawing.Color.White;
            this.CMBPerusahaan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.CMBPerusahaan.BorderRadius = 4;
            this.CMBPerusahaan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CMBPerusahaan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBPerusahaan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBPerusahaan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(88)))), ((int)(((byte)(187)))));
            this.CMBPerusahaan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(88)))), ((int)(((byte)(187)))));
            this.CMBPerusahaan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CMBPerusahaan.ForeColor = System.Drawing.Color.Black;
            this.CMBPerusahaan.ItemHeight = 22;
            this.CMBPerusahaan.Location = new System.Drawing.Point(26, 183);
            this.CMBPerusahaan.Name = "CMBPerusahaan";
            this.CMBPerusahaan.Size = new System.Drawing.Size(250, 28);
            this.CMBPerusahaan.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(295, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pembimbing Perusahaan *";
            // 
            // CMBPembimbing
            // 
            this.CMBPembimbing.BackColor = System.Drawing.Color.White;
            this.CMBPembimbing.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.CMBPembimbing.BorderRadius = 4;
            this.CMBPembimbing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CMBPembimbing.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBPembimbing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBPembimbing.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(88)))), ((int)(((byte)(187)))));
            this.CMBPembimbing.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(88)))), ((int)(((byte)(187)))));
            this.CMBPembimbing.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CMBPembimbing.ForeColor = System.Drawing.Color.Black;
            this.CMBPembimbing.ItemHeight = 22;
            this.CMBPembimbing.Location = new System.Drawing.Point(299, 185);
            this.CMBPembimbing.Name = "CMBPembimbing";
            this.CMBPembimbing.Size = new System.Drawing.Size(250, 28);
            this.CMBPembimbing.TabIndex = 10;
            // 
            // BTNSimpan
            // 
            this.BTNSimpan.BorderRadius = 8;
            this.BTNSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNSimpan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(88)))), ((int)(((byte)(187)))));
            this.BTNSimpan.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.BTNSimpan.ForeColor = System.Drawing.Color.White;
            this.BTNSimpan.HoverState.FillColor = System.Drawing.Color.FromArgb(21, 74, 150);
            this.BTNSimpan.Location = new System.Drawing.Point(415, 323);
            this.BTNSimpan.Name = "BTNSimpan";
            this.BTNSimpan.Size = new System.Drawing.Size(140, 38);
            this.BTNSimpan.TabIndex = 15;
            this.BTNSimpan.Text = "Simpan";
            this.BTNSimpan.Click += new System.EventHandler(this.BTNSimpan_Click);
            // 
            // BTNBatal
            // 
            this.BTNBatal.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.BTNBatal.BorderRadius = 8;
            this.BTNBatal.BorderThickness = 1;
            this.BTNBatal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNBatal.FillColor = System.Drawing.Color.White;
            this.BTNBatal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTNBatal.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.BTNBatal.HoverState.FillColor = System.Drawing.Color.FromArgb(245, 247, 251);
            this.BTNBatal.Location = new System.Drawing.Point(25, 323);
            this.BTNBatal.Name = "BTNBatal";
            this.BTNBatal.Size = new System.Drawing.Size(120, 38);
            this.BTNBatal.TabIndex = 16;
            this.BTNBatal.Text = "Batal";
            this.BTNBatal.Click += new System.EventHandler(this.BTNBatal_Click);
            // 
            // DTMulai
            // 
            this.DTMulai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DTMulai.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTMulai.Location = new System.Drawing.Point(25, 257);
            this.DTMulai.Name = "DTMulai";
            this.DTMulai.Size = new System.Drawing.Size(145, 23);
            this.DTMulai.TabIndex = 17;
            // 
            // DTSelesai
            // 
            this.DTSelesai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DTSelesai.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTSelesai.Location = new System.Drawing.Point(220, 257);
            this.DTSelesai.Name = "DTSelesai";
            this.DTSelesai.Size = new System.Drawing.Size(145, 23);
            this.DTSelesai.TabIndex = 18;
            // 
            // CMBStatus
            // 
            this.CMBStatus.BackColor = System.Drawing.Color.White;
            this.CMBStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.CMBStatus.BorderRadius = 4;
            this.CMBStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CMBStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(88)))), ((int)(((byte)(187)))));
            this.CMBStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(88)))), ((int)(((byte)(187)))));
            this.CMBStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CMBStatus.ForeColor = System.Drawing.Color.Black;
            this.CMBStatus.ItemHeight = 22;
            this.CMBStatus.Location = new System.Drawing.Point(419, 256);
            this.CMBStatus.Name = "CMBStatus";
            this.CMBStatus.Size = new System.Drawing.Size(130, 28);
            this.CMBStatus.TabIndex = 19;
            // 
            // CMBSiswa
            // 
            this.CMBSiswa.BackColor = System.Drawing.Color.White;
            this.CMBSiswa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.CMBSiswa.BorderRadius = 4;
            this.CMBSiswa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CMBSiswa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBSiswa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBSiswa.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(88)))), ((int)(((byte)(187)))));
            this.CMBSiswa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(88)))), ((int)(((byte)(187)))));
            this.CMBSiswa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CMBSiswa.ForeColor = System.Drawing.Color.Black;
            this.CMBSiswa.ItemHeight = 22;
            this.CMBSiswa.Location = new System.Drawing.Point(26, 120);
            this.CMBSiswa.Name = "CMBSiswa";
            this.CMBSiswa.Size = new System.Drawing.Size(250, 28);
            this.CMBSiswa.TabIndex = 20;
            // 
            // CMBGuru
            // 
            this.CMBGuru.BackColor = System.Drawing.Color.White;
            this.CMBGuru.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.CMBGuru.BorderRadius = 4;
            this.CMBGuru.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CMBGuru.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBGuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBGuru.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(88)))), ((int)(((byte)(187)))));
            this.CMBGuru.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(88)))), ((int)(((byte)(187)))));
            this.CMBGuru.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CMBGuru.ForeColor = System.Drawing.Color.Black;
            this.CMBGuru.ItemHeight = 22;
            this.CMBGuru.Location = new System.Drawing.Point(298, 120);
            this.CMBGuru.Name = "CMBGuru";
            this.CMBGuru.Size = new System.Drawing.Size(250, 28);
            this.CMBGuru.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(20, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Tanggal Mulai *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(216, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Tanggal Selesai *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(415, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Status *";
            // 
            // FormCRUDPrakerin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(580, 390);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CMBGuru);
            this.Controls.Add(this.CMBSiswa);
            this.Controls.Add(this.CMBStatus);
            this.Controls.Add(this.DTSelesai);
            this.Controls.Add(this.DTMulai);
            this.Controls.Add(this.BTNBatal);
            this.Controls.Add(this.BTNSimpan);
            this.Controls.Add(this.CMBPembimbing);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CMBPerusahaan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCRUDPrakerin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCRUDSiswa";
            this.Load += new System.EventHandler(this.FormCRUDPrakerin_Load_1);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox CMBPerusahaan;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox CMBPembimbing;
        private Guna.UI2.WinForms.Guna2Button BTNSimpan;
        private Guna.UI2.WinForms.Guna2Button BTNBatal;
        private System.Windows.Forms.DateTimePicker DTMulai;
        private System.Windows.Forms.DateTimePicker DTSelesai;
        private Guna.UI2.WinForms.Guna2ComboBox CMBStatus;
        private Guna.UI2.WinForms.Guna2ComboBox CMBSiswa;
        private Guna.UI2.WinForms.Guna2ComboBox CMBGuru;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
