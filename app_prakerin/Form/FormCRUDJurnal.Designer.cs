namespace app_prakerin
{
    partial class FormCRUDJurnal
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
            this.DTPTanggal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTKegiatan = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTKendala = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTSolusi = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CMBStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.BTNSimpan = new Guna.UI2.WinForms.Guna2Button();
            this.BTNBatal = new Guna.UI2.WinForms.Guna2Button();
            this.CMBID = new Guna.UI2.WinForms.Guna2ComboBox();
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
            this.guna2Panel1.Size = new System.Drawing.Size(595, 70);
            this.guna2Panel1.TabIndex = 0;
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblJudul.ForeColor = System.Drawing.Color.White;
            this.lblJudul.Location = new System.Drawing.Point(20, 12);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(201, 23);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Tambah Data Jurnal";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(200, 220, 255);
            this.lblSub.Location = new System.Drawing.Point(22, 46);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(177, 13);
            this.lblSub.TabIndex = 1;
            this.lblSub.Text = "Form untuk pengisian data jurnal.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(22, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Prakerin *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(295, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tanggal *";
            // 
            // DTPTanggal
            // 
            this.DTPTanggal.CustomFormat = "dd-MM-yyyy";
            this.DTPTanggal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DTPTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPTanggal.Location = new System.Drawing.Point(298, 110);
            this.DTPTanggal.Name = "DTPTanggal";
            this.DTPTanggal.Size = new System.Drawing.Size(258, 23);
            this.DTPTanggal.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(22, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kegiatan *";
            // 
            // TXTKegiatan
            // 
            this.TXTKegiatan.Animated = true;
            this.TXTKegiatan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.TXTKegiatan.BorderRadius = 6;
            this.TXTKegiatan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTKegiatan.DefaultText = "";
            this.TXTKegiatan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(88)))), ((int)(((byte)(187)))));
            this.TXTKegiatan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTKegiatan.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.TXTKegiatan.Location = new System.Drawing.Point(25, 174);
            this.TXTKegiatan.Multiline = true;
            this.TXTKegiatan.Name = "TXTKegiatan";
            this.TXTKegiatan.PlaceholderText = "Masukan kegiatan...";
            this.TXTKegiatan.SelectedText = "";
            this.TXTKegiatan.Size = new System.Drawing.Size(250, 55);
            this.TXTKegiatan.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(295, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kendala";
            // 
            // TXTKendala
            // 
            this.TXTKendala.Animated = true;
            this.TXTKendala.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.TXTKendala.BorderRadius = 6;
            this.TXTKendala.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTKendala.DefaultText = "";
            this.TXTKendala.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(88)))), ((int)(((byte)(187)))));
            this.TXTKendala.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTKendala.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.TXTKendala.Location = new System.Drawing.Point(298, 174);
            this.TXTKendala.Multiline = true;
            this.TXTKendala.Name = "TXTKendala";
            this.TXTKendala.PlaceholderText = "Masukan kendala...";
            this.TXTKendala.SelectedText = "";
            this.TXTKendala.Size = new System.Drawing.Size(258, 55);
            this.TXTKendala.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(22, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Solusi";
            // 
            // TXTSolusi
            // 
            this.TXTSolusi.Animated = true;
            this.TXTSolusi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.TXTSolusi.BorderRadius = 6;
            this.TXTSolusi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTSolusi.DefaultText = "";
            this.TXTSolusi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(88)))), ((int)(((byte)(187)))));
            this.TXTSolusi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTSolusi.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.TXTSolusi.Location = new System.Drawing.Point(25, 266);
            this.TXTSolusi.Multiline = true;
            this.TXTSolusi.Name = "TXTSolusi";
            this.TXTSolusi.PlaceholderText = "Masukan solusi...";
            this.TXTSolusi.SelectedText = "";
            this.TXTSolusi.Size = new System.Drawing.Size(250, 55);
            this.TXTSolusi.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(295, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Status Verifikasi";
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
            this.CMBStatus.Location = new System.Drawing.Point(298, 266);
            this.CMBStatus.Name = "CMBStatus";
            this.CMBStatus.Size = new System.Drawing.Size(258, 28);
            this.CMBStatus.TabIndex = 12;
            // 
            // BTNSimpan
            // 
            this.BTNSimpan.BorderRadius = 8;
            this.BTNSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNSimpan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(88)))), ((int)(((byte)(187)))));
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
            this.BTNBatal.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
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
            // CMBID
            // 
            this.CMBID.BackColor = System.Drawing.Color.White;
            this.CMBID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.CMBID.BorderRadius = 4;
            this.CMBID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CMBID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(88)))), ((int)(((byte)(187)))));
            this.CMBID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(88)))), ((int)(((byte)(187)))));
            this.CMBID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CMBID.ForeColor = System.Drawing.Color.Black;
            this.CMBID.ItemHeight = 22;
            this.CMBID.Location = new System.Drawing.Point(25, 108);
            this.CMBID.Name = "CMBID";
            this.CMBID.Size = new System.Drawing.Size(250, 28);
            this.CMBID.TabIndex = 21;
            // 
            // FormCRUDJurnal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(595, 405);
            this.Controls.Add(this.CMBID);
            this.Controls.Add(this.BTNBatal);
            this.Controls.Add(this.BTNSimpan);
            this.Controls.Add(this.CMBStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TXTSolusi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXTKendala);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXTKegiatan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DTPTanggal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCRUDJurnal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCRUDJurnal";
            this.Load += new System.EventHandler(this.FormCRUDJurnal_Load);
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
        private System.Windows.Forms.DateTimePicker DTPTanggal;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox TXTKegiatan;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox TXTKendala;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox TXTSolusi;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox CMBStatus;
        private Guna.UI2.WinForms.Guna2Button BTNSimpan;
        private Guna.UI2.WinForms.Guna2Button BTNBatal;
        private Guna.UI2.WinForms.Guna2ComboBox CMBID;
    }
}