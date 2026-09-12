
namespace app_prakerin
{
    partial class FormCRUDJurusan
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
            this.TXTKode = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.BTNSimpan = new Guna.UI2.WinForms.Guna2Button();
            this.BTNBatal = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(126)))), ((int)(((byte)(225)))));
            this.guna2Panel1.Controls.Add(this.lblJudul);
            this.guna2Panel1.Controls.Add(this.lblSub);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(480, 70);
            this.guna2Panel1.TabIndex = 0;
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblJudul.ForeColor = System.Drawing.Color.White;
            this.lblJudul.Location = new System.Drawing.Point(20, 12);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Tambah Data Jurusan";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblSub.ForeColor = System.Drawing.Color.White;
            this.lblSub.Location = new System.Drawing.Point(22, 46);
            this.lblSub.Name = "lblSub";
            this.lblSub.TabIndex = 1;
            this.lblSub.Text = "Form untuk pengisian data jurusan.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(22, 90);
            this.label1.Name = "label1";
            this.label1.TabIndex = 1;
            this.label1.Text = "Kode Jurusan *";
            // 
            // TXTKode
            // 
            this.TXTKode.Animated = true;
            this.TXTKode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.TXTKode.BorderRadius = 4;
            this.TXTKode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTKode.DefaultText = "";
            this.TXTKode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.TXTKode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTKode.ForeColor = System.Drawing.Color.Black;
            this.TXTKode.Location = new System.Drawing.Point(25, 115);
            this.TXTKode.Name = "TXTKode";
            this.TXTKode.PlaceholderText = "Contoh: RPL";
            this.TXTKode.SelectedText = "";
            this.TXTKode.Size = new System.Drawing.Size(430, 35);
            this.TXTKode.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(22, 162);
            this.label2.Name = "label2";
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama Jurusan *";
            // 
            // TXTNama
            // 
            this.TXTNama.Animated = true;
            this.TXTNama.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.TXTNama.BorderRadius = 4;
            this.TXTNama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTNama.DefaultText = "";
            this.TXTNama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.TXTNama.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTNama.ForeColor = System.Drawing.Color.Black;
            this.TXTNama.Location = new System.Drawing.Point(25, 187);
            this.TXTNama.Name = "TXTNama";
            this.TXTNama.PlaceholderText = "Masukan nama jurusan...";
            this.TXTNama.SelectedText = "";
            this.TXTNama.Size = new System.Drawing.Size(430, 35);
            this.TXTNama.TabIndex = 4;
            // 
            // BTNSimpan
            // 
            this.BTNSimpan.BorderRadius = 5;
            this.BTNSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNSimpan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(212)))));
            this.BTNSimpan.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.BTNSimpan.ForeColor = System.Drawing.Color.White;
            this.BTNSimpan.Location = new System.Drawing.Point(310, 245);
            this.BTNSimpan.Name = "BTNSimpan";
            this.BTNSimpan.Size = new System.Drawing.Size(145, 38);
            this.BTNSimpan.TabIndex = 5;
            this.BTNSimpan.Text = "Simpan";
            this.BTNSimpan.Click += new System.EventHandler(this.BTNSimpan_Click);
            // 
            // BTNBatal
            // 
            this.BTNBatal.BorderRadius = 5;
            this.BTNBatal.BorderThickness = 1;
            this.BTNBatal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNBatal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.BTNBatal.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.BTNBatal.ForeColor = System.Drawing.Color.Black;
            this.BTNBatal.Location = new System.Drawing.Point(25, 245);
            this.BTNBatal.Name = "BTNBatal";
            this.BTNBatal.Size = new System.Drawing.Size(120, 38);
            this.BTNBatal.TabIndex = 6;
            this.BTNBatal.Text = "Batal";
            this.BTNBatal.Click += new System.EventHandler(this.BTNBatal_Click);
            // 
            // FormCRUDJurusan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(480, 300);
            this.Controls.Add(this.BTNBatal);
            this.Controls.Add(this.BTNSimpan);
            this.Controls.Add(this.TXTNama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTKode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCRUDJurusan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCRUDJurusan";
            this.Load += new System.EventHandler(this.FormCRUDJurusan_Load);
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
        private Guna.UI2.WinForms.Guna2TextBox TXTKode;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TXTNama;
        private Guna.UI2.WinForms.Guna2Button BTNSimpan;
        private Guna.UI2.WinForms.Guna2Button BTNBatal;
    }
}
