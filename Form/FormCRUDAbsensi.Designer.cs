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
            this.pnlHeaderDot1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlHeaderDot2 = new Guna.UI2.WinForms.Guna2Panel();

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

            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlFooterLine = new System.Windows.Forms.Panel();
            this.BTNSimpan = new Guna.UI2.WinForms.Guna2Button();
            this.BTNBatal = new Guna.UI2.WinForms.Guna2Button();

            this.guna2Panel1.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();

            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.guna2Panel1.Controls.Add(this.lblJudul);
            this.guna2Panel1.Controls.Add(this.lblSub);
            this.guna2Panel1.Controls.Add(this.pnlHeaderDot1);
            this.guna2Panel1.Controls.Add(this.pnlHeaderDot2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(560, 88);
            this.guna2Panel1.TabIndex = 0;

            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.ForeColor = System.Drawing.Color.White;
            this.lblJudul.Location = new System.Drawing.Point(28, 20);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(233, 28);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Tambah Data Absensi";

            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.lblSub.Location = new System.Drawing.Point(30, 54);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(190, 15);
            this.lblSub.TabIndex = 1;
            this.lblSub.Text = "Form untuk pengisian data absensi.";

            // 
            // pnlHeaderDot1
            // 
            this.pnlHeaderDot1.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeaderDot1.BorderRadius = 40;
            this.pnlHeaderDot1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.pnlHeaderDot1.Location = new System.Drawing.Point(432, 4);
            this.pnlHeaderDot1.Name = "pnlHeaderDot1";
            this.pnlHeaderDot1.Size = new System.Drawing.Size(80, 80);
            this.pnlHeaderDot1.TabIndex = 2;

            // 
            // pnlHeaderDot2
            // 
            this.pnlHeaderDot2.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeaderDot2.BorderRadius = 20;
            this.pnlHeaderDot2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.pnlHeaderDot2.Location = new System.Drawing.Point(392, 44);
            this.pnlHeaderDot2.Name = "pnlHeaderDot2";
            this.pnlHeaderDot2.Size = new System.Drawing.Size(40, 40);
            this.pnlHeaderDot2.TabIndex = 3;

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(28, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prakerin *";

            // 
            // CMBID
            // 
            this.CMBID.BackColor = System.Drawing.Color.White;
            this.CMBID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.CMBID.BorderRadius = 10;
            this.CMBID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CMBID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.CMBID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.CMBID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CMBID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.CMBID.ItemHeight = 34;
            this.CMBID.Location = new System.Drawing.Point(28, 134);
            this.CMBID.Name = "CMBID";
            this.CMBID.Size = new System.Drawing.Size(504, 42);
            this.CMBID.TabIndex = 2;

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(28, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tanggal *";

            // 
            // DTPTanggal
            // 
            this.DTPTanggal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.DTPTanggal.BorderRadius = 10;
            this.DTPTanggal.Checked = true;
            this.DTPTanggal.FillColor = System.Drawing.Color.White;
            this.DTPTanggal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DTPTanggal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.DTPTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPTanggal.CustomFormat = "yyyy-MM-dd";
            this.DTPTanggal.Location = new System.Drawing.Point(28, 220);
            this.DTPTanggal.Name = "DTPTanggal";
            this.DTPTanggal.Size = new System.Drawing.Size(244, 42);
            this.DTPTanggal.TabIndex = 4;

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(288, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Jam Masuk";

            // 
            // DTPJamMasuk
            // 
            this.DTPJamMasuk.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.DTPJamMasuk.BorderRadius = 10;
            this.DTPJamMasuk.Checked = true;
            this.DTPJamMasuk.FillColor = System.Drawing.Color.White;
            this.DTPJamMasuk.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DTPJamMasuk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.DTPJamMasuk.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPJamMasuk.CustomFormat = "HH:mm:ss";
            this.DTPJamMasuk.ShowUpDown = true;
            this.DTPJamMasuk.Location = new System.Drawing.Point(288, 220);
            this.DTPJamMasuk.Name = "DTPJamMasuk";
            this.DTPJamMasuk.Size = new System.Drawing.Size(244, 42);
            this.DTPJamMasuk.TabIndex = 6;

            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(28, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Jam Keluar";

            // 
            // DTPJamKeluar
            // 
            this.DTPJamKeluar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.DTPJamKeluar.BorderRadius = 10;
            this.DTPJamKeluar.Checked = true;
            this.DTPJamKeluar.FillColor = System.Drawing.Color.White;
            this.DTPJamKeluar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DTPJamKeluar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.DTPJamKeluar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPJamKeluar.CustomFormat = "HH:mm:ss";
            this.DTPJamKeluar.ShowUpDown = true;
            this.DTPJamKeluar.Location = new System.Drawing.Point(28, 306);
            this.DTPJamKeluar.Name = "DTPJamKeluar";
            this.DTPJamKeluar.Size = new System.Drawing.Size(244, 42);
            this.DTPJamKeluar.TabIndex = 8;

            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.label5.Location = new System.Drawing.Point(288, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Status *";

            // 
            // CMBStatus
            // 
            this.CMBStatus.BackColor = System.Drawing.Color.White;
            this.CMBStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.CMBStatus.BorderRadius = 10;
            this.CMBStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CMBStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.CMBStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.CMBStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CMBStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.CMBStatus.ItemHeight = 34;
            this.CMBStatus.Location = new System.Drawing.Point(288, 306);
            this.CMBStatus.Name = "CMBStatus";
            this.CMBStatus.Size = new System.Drawing.Size(244, 42);
            this.CMBStatus.TabIndex = 10;

            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlFooter.Controls.Add(this.BTNBatal);
            this.pnlFooter.Controls.Add(this.BTNSimpan);
            this.pnlFooter.Controls.Add(this.pnlFooterLine);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 378);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(560, 72);
            this.pnlFooter.TabIndex = 13;

            // 
            // pnlFooterLine
            // 
            this.pnlFooterLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlFooterLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFooterLine.Location = new System.Drawing.Point(0, 0);
            this.pnlFooterLine.Name = "pnlFooterLine";
            this.pnlFooterLine.Size = new System.Drawing.Size(560, 1);
            this.pnlFooterLine.TabIndex = 2;

            // 
            // BTNSimpan
            // 
            this.BTNSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.BTNSimpan.BorderRadius = 10;
            this.BTNSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNSimpan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.BTNSimpan.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSimpan.ForeColor = System.Drawing.Color.White;
            this.BTNSimpan.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.BTNSimpan.Location = new System.Drawing.Point(392, 15);
            this.BTNSimpan.Name = "BTNSimpan";
            this.BTNSimpan.Size = new System.Drawing.Size(140, 42);
            this.BTNSimpan.TabIndex = 11;
            this.BTNSimpan.Text = "Simpan";
            this.BTNSimpan.Click += new System.EventHandler(this.BTNSimpan_Click);

            // 
            // BTNBatal
            // 
            this.BTNBatal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.BTNBatal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.BTNBatal.BorderRadius = 10;
            this.BTNBatal.BorderThickness = 1;
            this.BTNBatal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNBatal.FillColor = System.Drawing.Color.White;
            this.BTNBatal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNBatal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.BTNBatal.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.BTNBatal.Location = new System.Drawing.Point(272, 15);
            this.BTNBatal.Name = "BTNBatal";
            this.BTNBatal.Size = new System.Drawing.Size(110, 42);
            this.BTNBatal.TabIndex = 12;
            this.BTNBatal.Text = "Batal";
            this.BTNBatal.Click += new System.EventHandler(this.BTNBatal_Click);

            // 
            // FormCRUDAbsensi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(560, 450);

            this.Controls.Add(this.pnlFooter);
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
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblSub;
        private Guna.UI2.WinForms.Guna2Panel pnlHeaderDot1;
        private Guna.UI2.WinForms.Guna2Panel pnlHeaderDot2;

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

        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlFooterLine;
        private Guna.UI2.WinForms.Guna2Button BTNSimpan;
        private Guna.UI2.WinForms.Guna2Button BTNBatal;
    }
}
