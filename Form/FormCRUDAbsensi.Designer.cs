namespace app_prakerin
{
    partial class FormCRUDAbsensi
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
            this.CMBID = new Guna.UI2.WinForms.Guna2ComboBox();

            this.label2 = new System.Windows.Forms.Label();
            this.DTPTanggal = new Guna.UI2.WinForms.Guna2DateTimePicker();

            this.label3 = new System.Windows.Forms.Label();
            this.DTPJamMasuk = new Guna.UI2.WinForms.Guna2DateTimePicker();

            this.label4 = new System.Windows.Forms.Label();
            this.DTPJamKeluar = new Guna.UI2.WinForms.Guna2DateTimePicker();

            this.label5 = new System.Windows.Forms.Label();
            this.CMBStatus = new Guna.UI2.WinForms.Guna2ComboBox();

            this.BTNSimpan = new Guna.UI2.WinForms.Guna2Button();
            this.BTNBatal = new Guna.UI2.WinForms.Guna2Button();

            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();

            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(68, 126, 225);
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
            this.lblJudul.Font = new System.Drawing.Font(
                "Tahoma",
                14.25F,
                System.Drawing.FontStyle.Bold
            );
            this.lblJudul.ForeColor = System.Drawing.Color.White;
            this.lblJudul.Location = new System.Drawing.Point(20, 12);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Tambah Data Absensi";

            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font(
                "Segoe UI Semibold",
                8.25F,
                System.Drawing.FontStyle.Bold
            );
            this.lblSub.ForeColor = System.Drawing.Color.White;
            this.lblSub.Location = new System.Drawing.Point(22, 46);
            this.lblSub.Name = "lblSub";
            this.lblSub.TabIndex = 1;
            this.lblSub.Text = "Form untuk pengisian data absensi.";

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font(
                "Segoe UI",
                9.75F,
                System.Drawing.FontStyle.Bold
            );
            this.label1.Location = new System.Drawing.Point(22, 88);
            this.label1.Name = "label1";
            this.label1.TabIndex = 1;
            this.label1.Text = "Prakerin *";

            // 
            // CMBID
            // 
            this.CMBID.BackColor = System.Drawing.Color.White;
            this.CMBID.BorderColor = System.Drawing.Color.FromArgb(180, 195, 215);
            this.CMBID.BorderRadius = 4;
            this.CMBID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CMBID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.CMBID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CMBID.ForeColor = System.Drawing.Color.Black;
            this.CMBID.ItemHeight = 22;
            this.CMBID.Location = new System.Drawing.Point(25, 112);
            this.CMBID.Name = "CMBID";
            this.CMBID.Size = new System.Drawing.Size(490, 30);
            this.CMBID.TabIndex = 2;

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font(
                "Segoe UI",
                9.75F,
                System.Drawing.FontStyle.Bold
            );
            this.label2.Location = new System.Drawing.Point(22, 160);
            this.label2.Name = "label2";
            this.label2.TabIndex = 3;
            this.label2.Text = "Tanggal *";

            // 
            // DTPTanggal
            // 
            this.DTPTanggal.BorderColor = System.Drawing.Color.FromArgb(180, 195, 215);
            this.DTPTanggal.BorderRadius = 4;
            this.DTPTanggal.Checked = true;
            this.DTPTanggal.FillColor = System.Drawing.Color.White;
            this.DTPTanggal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DTPTanggal.ForeColor = System.Drawing.Color.Black;
            this.DTPTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPTanggal.CustomFormat = "yyyy-MM-dd";
            this.DTPTanggal.Location = new System.Drawing.Point(25, 183);
            this.DTPTanggal.Name = "DTPTanggal";
            this.DTPTanggal.Size = new System.Drawing.Size(230, 35);
            this.DTPTanggal.TabIndex = 4;

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font(
                "Segoe UI",
                9.75F,
                System.Drawing.FontStyle.Bold
            );
            this.label3.Location = new System.Drawing.Point(280, 160);
            this.label3.Name = "label3";
            this.label3.TabIndex = 5;
            this.label3.Text = "Jam Masuk";

            // 
            // DTPJamMasuk
            // 
            this.DTPJamMasuk.BorderColor = System.Drawing.Color.FromArgb(180, 195, 215);
            this.DTPJamMasuk.BorderRadius = 4;
            this.DTPJamMasuk.Checked = true;
            this.DTPJamMasuk.FillColor = System.Drawing.Color.White;
            this.DTPJamMasuk.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DTPJamMasuk.ForeColor = System.Drawing.Color.Black;
            this.DTPJamMasuk.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPJamMasuk.CustomFormat = "HH:mm:ss";
            this.DTPJamMasuk.ShowUpDown = true;
            this.DTPJamMasuk.Location = new System.Drawing.Point(283, 183);
            this.DTPJamMasuk.Name = "DTPJamMasuk";
            this.DTPJamMasuk.Size = new System.Drawing.Size(230, 35);
            this.DTPJamMasuk.TabIndex = 6;

            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font(
                "Segoe UI",
                9.75F,
                System.Drawing.FontStyle.Bold
            );
            this.label4.Location = new System.Drawing.Point(22, 232);
            this.label4.Name = "label4";
            this.label4.TabIndex = 7;
            this.label4.Text = "Jam Keluar";

            // 
            // DTPJamKeluar
            // 
            this.DTPJamKeluar.BorderColor = System.Drawing.Color.FromArgb(180, 195, 215);
            this.DTPJamKeluar.BorderRadius = 4;
            this.DTPJamKeluar.Checked = true;
            this.DTPJamKeluar.FillColor = System.Drawing.Color.White;
            this.DTPJamKeluar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DTPJamKeluar.ForeColor = System.Drawing.Color.Black;
            this.DTPJamKeluar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPJamKeluar.CustomFormat = "HH:mm:ss";
            this.DTPJamKeluar.ShowUpDown = true;
            this.DTPJamKeluar.Location = new System.Drawing.Point(25, 255);
            this.DTPJamKeluar.Name = "DTPJamKeluar";
            this.DTPJamKeluar.Size = new System.Drawing.Size(230, 35);
            this.DTPJamKeluar.TabIndex = 8;

            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font(
                "Segoe UI",
                9.75F,
                System.Drawing.FontStyle.Bold
            );
            this.label5.Location = new System.Drawing.Point(280, 232);
            this.label5.Name = "label5";
            this.label5.TabIndex = 9;
            this.label5.Text = "Status *";

            // 
            // CMBStatus
            // 
            this.CMBStatus.BackColor = System.Drawing.Color.White;
            this.CMBStatus.BorderColor = System.Drawing.Color.FromArgb(180, 195, 215);
            this.CMBStatus.BorderRadius = 4;
            this.CMBStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CMBStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.CMBStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CMBStatus.ForeColor = System.Drawing.Color.Black;
            this.CMBStatus.ItemHeight = 22;
            this.CMBStatus.Location = new System.Drawing.Point(283, 255);
            this.CMBStatus.Name = "CMBStatus";
            this.CMBStatus.Size = new System.Drawing.Size(230, 30);
            this.CMBStatus.TabIndex = 10;

            // 
            // BTNSimpan
            // 
            this.BTNSimpan.BorderRadius = 5;
            this.BTNSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNSimpan.FillColor = System.Drawing.Color.FromArgb(24, 90, 212);
            this.BTNSimpan.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.BTNSimpan.ForeColor = System.Drawing.Color.White;
            this.BTNSimpan.Location = new System.Drawing.Point(368, 308);
            this.BTNSimpan.Name = "BTNSimpan";
            this.BTNSimpan.Size = new System.Drawing.Size(145, 38);
            this.BTNSimpan.TabIndex = 11;
            this.BTNSimpan.Text = "Simpan";
            this.BTNSimpan.Click += new System.EventHandler(this.BTNSimpan_Click);

            // 
            // BTNBatal
            // 
            this.BTNBatal.BorderRadius = 5;
            this.BTNBatal.BorderThickness = 1;
            this.BTNBatal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNBatal.FillColor = System.Drawing.Color.FromArgb(235, 238, 245);
            this.BTNBatal.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.BTNBatal.ForeColor = System.Drawing.Color.Black;
            this.BTNBatal.Location = new System.Drawing.Point(25, 308);
            this.BTNBatal.Name = "BTNBatal";
            this.BTNBatal.Size = new System.Drawing.Size(120, 38);
            this.BTNBatal.TabIndex = 12;
            this.BTNBatal.Text = "Batal";
            this.BTNBatal.Click += new System.EventHandler(this.BTNBatal_Click);

            // 
            // FormCRUDAbsensi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(250, 251, 254);
            this.ClientSize = new System.Drawing.Size(540, 362);

            this.Controls.Add(this.BTNBatal);
            this.Controls.Add(this.BTNSimpan);
            this.Controls.Add(this.CMBStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DTPJamKeluar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DTPJamMasuk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DTPTanggal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CMBID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel1);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCRUDAbsensi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCRUDAbsensi";
            this.Load += new System.EventHandler(this.FormCRUDAbsensi_Load);

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
        private Guna.UI2.WinForms.Guna2ComboBox CMBID;

        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTPTanggal;

        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTPJamMasuk;

        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTPJamKeluar;

        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox CMBStatus;

        private Guna.UI2.WinForms.Guna2Button BTNSimpan;
        private Guna.UI2.WinForms.Guna2Button BTNBatal;
    }
}