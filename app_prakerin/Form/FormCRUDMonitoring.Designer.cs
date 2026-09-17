namespace app_prakerin
{
    partial class FormCRUDMonitoring
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
            this.CMBGuru = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DTTanggal = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTCatatan = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.PBFoto = new Guna.UI2.WinForms.Guna2PictureBox();
            this.BTNUpload = new Guna.UI2.WinForms.Guna2Button();
            this.TXTFoto = new Guna.UI2.WinForms.Guna2TextBox();
            this.BTNSimpan = new Guna.UI2.WinForms.Guna2Button();
            this.BTNBatal = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout(); ((System.ComponentModel.ISupportInitialize)(this.PBFoto)).BeginInit();
            this.SuspendLayout();

            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(30, 88, 187);
            this.guna2Panel1.Controls.Add(this.lblJudul);
            this.guna2Panel1.Controls.Add(this.lblSub);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(874, 70);
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
            this.lblJudul.Size = new System.Drawing.Size(228, 23);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Tambah Data Monitoring";

            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font(
                "Segoe UI Semibold",
                8.25F,
                System.Drawing.FontStyle.Bold
            );
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(200, 220, 255);
            this.lblSub.Location = new System.Drawing.Point(22, 46);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(254, 13);
            this.lblSub.TabIndex = 1;
            this.lblSub.Text = "Form untuk pengisian data monitoring prakerin.";

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
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Prakerin *";

            // 
            // CMBPrakerin
            // 
            this.CMBPrakerin.BackColor = System.Drawing.Color.White;
            this.CMBPrakerin.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.CMBPrakerin.BorderRadius = 4;
            this.CMBPrakerin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CMBPrakerin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBPrakerin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBPrakerin.FocusedColor = System.Drawing.Color.FromArgb(30, 88, 187);
            this.CMBPrakerin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(30, 88, 187);
            this.CMBPrakerin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CMBPrakerin.ForeColor = System.Drawing.Color.Black;
            this.CMBPrakerin.ItemHeight = 22;
            this.CMBPrakerin.Location = new System.Drawing.Point(25, 110);
            this.CMBPrakerin.Name = "CMBPrakerin";
            this.CMBPrakerin.Size = new System.Drawing.Size(530, 28);
            this.CMBPrakerin.TabIndex = 2;

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font(
                "Segoe UI",
                9.75F,
                System.Drawing.FontStyle.Bold
            );
            this.label2.Location = new System.Drawing.Point(22, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Guru Pembimbing *";

            // 
            // CMBGuru
            // 
            this.CMBGuru.BackColor = System.Drawing.Color.White;
            this.CMBGuru.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.CMBGuru.BorderRadius = 4;
            this.CMBGuru.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CMBGuru.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBGuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBGuru.FocusedColor = System.Drawing.Color.FromArgb(30, 88, 187);
            this.CMBGuru.FocusedState.BorderColor = System.Drawing.Color.FromArgb(30, 88, 187);
            this.CMBGuru.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CMBGuru.ForeColor = System.Drawing.Color.Black;
            this.CMBGuru.ItemHeight = 22;
            this.CMBGuru.Location = new System.Drawing.Point(25, 176);
            this.CMBGuru.Name = "CMBGuru";
            this.CMBGuru.Size = new System.Drawing.Size(530, 28);
            this.CMBGuru.TabIndex = 4;

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font(
                "Segoe UI",
                9.75F,
                System.Drawing.FontStyle.Bold
            );
            this.label3.Location = new System.Drawing.Point(22, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tanggal *";

            // 
            // DTTanggal
            // 
            this.DTTanggal.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.DTTanggal.BorderRadius = 4;
            this.DTTanggal.Checked = true;
            this.DTTanggal.FillColor = System.Drawing.Color.White;
            this.DTTanggal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DTTanggal.ForeColor = System.Drawing.Color.Black;
            this.DTTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTTanggal.CustomFormat = "dd MMMM yyyy";
            this.DTTanggal.Location = new System.Drawing.Point(25, 242);
            this.DTTanggal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DTTanggal.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DTTanggal.Name = "DTTanggal";
            this.DTTanggal.Size = new System.Drawing.Size(250, 30);
            this.DTTanggal.TabIndex = 6;
            this.DTTanggal.Value = new System.DateTime(2026, 9, 12, 0, 0, 0, 0);

            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font(
                "Segoe UI",
                9.75F,
                System.Drawing.FontStyle.Bold
            );
            this.label4.Location = new System.Drawing.Point(295, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Catatan";

            // 
            // TXTCatatan
            // 
            this.TXTCatatan.Animated = true;
            this.TXTCatatan.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.TXTCatatan.BorderRadius = 6;
            this.TXTCatatan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTCatatan.DefaultText = "";
            this.TXTCatatan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(30, 88, 187);
            this.TXTCatatan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTCatatan.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.TXTCatatan.Location = new System.Drawing.Point(298, 242);
            this.TXTCatatan.Multiline = true;
            this.TXTCatatan.PlaceholderText = "Masukan catatan hasil monitoring...";
            this.TXTCatatan.SelectedText = "";
            this.TXTCatatan.Size = new System.Drawing.Size(257, 80);
            this.TXTCatatan.TabIndex = 8;

            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font(
                "Segoe UI",
                9.75F,
                System.Drawing.FontStyle.Bold
            );
            this.label5.Location = new System.Drawing.Point(583, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Foto";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.PBFoto);
            this.guna2Panel2.Location = new System.Drawing.Point(583, 110);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(258, 190);
            this.guna2Panel2.TabIndex = 10;
            // 
            // PBFoto
            // 
            this.PBFoto.BackColor = System.Drawing.Color.Transparent;
            this.PBFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBFoto.ImageRotate = 0F;
            this.PBFoto.Location = new System.Drawing.Point(0, 0);
            this.PBFoto.Name = "PBFoto";
            this.PBFoto.Size = new System.Drawing.Size(256, 188);
            this.PBFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBFoto.TabIndex = 0;
            this.PBFoto.TabStop = false;
            this.PBFoto.UseTransparentBackground = true;
            // 
            // BTNUpload
            // 
            this.BTNUpload.BackColor = System.Drawing.Color.White;
            this.BTNUpload.BorderRadius = 5;
            this.BTNUpload.BorderThickness = 1;
            this.BTNUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNUpload.FillColor = System.Drawing.Color.FromArgb(235, 238, 245);
            this.BTNUpload.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.BTNUpload.ForeColor = System.Drawing.Color.Black;
            this.BTNUpload.Location = new System.Drawing.Point(583, 310);
            this.BTNUpload.Name = "BTNUpload";
            this.BTNUpload.Size = new System.Drawing.Size(258, 32);
            this.BTNUpload.TabIndex = 11;
            this.BTNUpload.Text = "Pilih Foto";
            this.BTNUpload.Click += new System.EventHandler(this.BTNUpload_Click);
            // 
            // TXTFoto
            // 
            this.TXTFoto.Animated = true;
            this.TXTFoto.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.TXTFoto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTFoto.DefaultText = "";
            this.TXTFoto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(30, 88, 187);
            this.TXTFoto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTFoto.ForeColor = System.Drawing.Color.Black;
            this.TXTFoto.Location = new System.Drawing.Point(583, 350);
            this.TXTFoto.Name = "TXTFoto";
            this.TXTFoto.PlaceholderText = "Nama file foto...";
            this.TXTFoto.SelectedText = "";
            this.TXTFoto.Size = new System.Drawing.Size(258, 20);
            this.TXTFoto.TabIndex = 12;
            this.TXTFoto.Visible = false;
            // 
            // BTNSimpan
            // 
            this.BTNSimpan.BorderRadius = 8;
            this.BTNSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNSimpan.FillColor = System.Drawing.Color.FromArgb(30, 88, 187);
            this.BTNSimpan.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.BTNSimpan.ForeColor = System.Drawing.Color.White;
            this.BTNSimpan.HoverState.FillColor = System.Drawing.Color.FromArgb(21, 74, 150);
            this.BTNSimpan.Location = new System.Drawing.Point(415, 350);
            this.BTNSimpan.Name = "BTNSimpan";
            this.BTNSimpan.Size = new System.Drawing.Size(140, 38);
            this.BTNSimpan.TabIndex = 13;
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
            this.BTNBatal.Location = new System.Drawing.Point(25, 350);
            this.BTNBatal.Name = "BTNBatal";
            this.BTNBatal.Size = new System.Drawing.Size(120, 38);
            this.BTNBatal.TabIndex = 14;
            this.BTNBatal.Text = "Batal";
            this.BTNBatal.Click += new System.EventHandler(this.BTNBatal_Click);
            // 
            // FormCRUDMonitoring
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(250, 251, 254);
            this.ClientSize = new System.Drawing.Size(874, 410);

            this.Controls.Add(this.TXTFoto);
            this.Controls.Add(this.BTNUpload);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTNBatal);
            this.Controls.Add(this.BTNSimpan);
            this.Controls.Add(this.TXTCatatan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DTTanggal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CMBGuru);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CMBPrakerin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel1);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None ;this.Name = "FormCRUDMonitoring";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; this.Text = "FormCRUDMonitoring";

            this.Load += new System.EventHandler(this.FormCRUDMonitoring_Load);

            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();

            this.guna2Panel2.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)(this.PBFoto)).EndInit();

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
        private Guna.UI2.WinForms.Guna2ComboBox CMBGuru;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTTanggal;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox TXTCatatan;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2PictureBox PBFoto;
        private Guna.UI2.WinForms.Guna2Button BTNUpload;
        private Guna.UI2.WinForms.Guna2TextBox TXTFoto;
        private Guna.UI2.WinForms.Guna2Button BTNSimpan;
        private Guna.UI2.WinForms.Guna2Button BTNBatal;
    }
}