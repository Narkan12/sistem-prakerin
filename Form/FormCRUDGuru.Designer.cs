namespace app_prakerin
{
    partial class FormCRUDGuru
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
            this.TXTNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTNIP = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTNoHP = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CMBPengguna = new Guna.UI2.WinForms.Guna2ComboBox();

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
            this.lblJudul.Size = new System.Drawing.Size(199, 28);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Tambah Data Guru";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.lblSub.Location = new System.Drawing.Point(30, 54);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(170, 15);
            this.lblSub.TabIndex = 1;
            this.lblSub.Text = "Form untuk pengisian data guru.";
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
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama *";
            // 
            // TXTNama
            // 
            this.TXTNama.Animated = true;
            this.TXTNama.BackColor = System.Drawing.Color.White;
            this.TXTNama.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.TXTNama.BorderRadius = 10;
            this.TXTNama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTNama.DefaultText = "";
            this.TXTNama.FillColor = System.Drawing.Color.White;
            this.TXTNama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.TXTNama.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TXTNama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.TXTNama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.TXTNama.Location = new System.Drawing.Point(28, 134);
            this.TXTNama.Name = "TXTNama";
            this.TXTNama.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.TXTNama.PlaceholderText = "Masukan nama guru...";
            this.TXTNama.SelectedText = "";
            this.TXTNama.Size = new System.Drawing.Size(244, 42);
            this.TXTNama.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(288, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "NIP";
            // 
            // TXTNIP
            // 
            this.TXTNIP.Animated = true;
            this.TXTNIP.BackColor = System.Drawing.Color.White;
            this.TXTNIP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.TXTNIP.BorderRadius = 10;
            this.TXTNIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTNIP.DefaultText = "";
            this.TXTNIP.FillColor = System.Drawing.Color.White;
            this.TXTNIP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.TXTNIP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TXTNIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.TXTNIP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.TXTNIP.Location = new System.Drawing.Point(288, 134);
            this.TXTNIP.Name = "TXTNIP";
            this.TXTNIP.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.TXTNIP.PlaceholderText = "Masukan NIP...";
            this.TXTNIP.SelectedText = "";
            this.TXTNIP.Size = new System.Drawing.Size(244, 42);
            this.TXTNIP.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(28, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "No HP";
            // 
            // TXTNoHP
            // 
            this.TXTNoHP.Animated = true;
            this.TXTNoHP.BackColor = System.Drawing.Color.White;
            this.TXTNoHP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.TXTNoHP.BorderRadius = 10;
            this.TXTNoHP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTNoHP.DefaultText = "";
            this.TXTNoHP.FillColor = System.Drawing.Color.White;
            this.TXTNoHP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.TXTNoHP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TXTNoHP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.TXTNoHP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.TXTNoHP.Location = new System.Drawing.Point(28, 220);
            this.TXTNoHP.Name = "TXTNoHP";
            this.TXTNoHP.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.TXTNoHP.PlaceholderText = "Masukan no HP...";
            this.TXTNoHP.SelectedText = "";
            this.TXTNoHP.Size = new System.Drawing.Size(244, 42);
            this.TXTNoHP.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(288, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // TXTEmail
            // 
            this.TXTEmail.Animated = true;
            this.TXTEmail.BackColor = System.Drawing.Color.White;
            this.TXTEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.TXTEmail.BorderRadius = 10;
            this.TXTEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTEmail.DefaultText = "";
            this.TXTEmail.FillColor = System.Drawing.Color.White;
            this.TXTEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.TXTEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TXTEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.TXTEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.TXTEmail.Location = new System.Drawing.Point(288, 220);
            this.TXTEmail.Name = "TXTEmail";
            this.TXTEmail.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.TXTEmail.PlaceholderText = "Masukan email...";
            this.TXTEmail.SelectedText = "";
            this.TXTEmail.Size = new System.Drawing.Size(244, 42);
            this.TXTEmail.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.label5.Location = new System.Drawing.Point(28, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Akun Pengguna *";
            // 
            // CMBPengguna
            // 
            this.CMBPengguna.BackColor = System.Drawing.Color.White;
            this.CMBPengguna.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.CMBPengguna.BorderRadius = 10;
            this.CMBPengguna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CMBPengguna.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBPengguna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBPengguna.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.CMBPengguna.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.CMBPengguna.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CMBPengguna.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.CMBPengguna.ItemHeight = 34;
            this.CMBPengguna.Location = new System.Drawing.Point(28, 306);
            this.CMBPengguna.Name = "CMBPengguna";
            this.CMBPengguna.Size = new System.Drawing.Size(504, 42);
            this.CMBPengguna.TabIndex = 10;
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
            // FormCRUDGuru
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.CMBPengguna);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXTEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXTNoHP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTNIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTNama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCRUDGuru";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCRUDGuru";
            this.Load += new System.EventHandler(this.FormCRUDGuru_Load);
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
        private Guna.UI2.WinForms.Guna2TextBox TXTNama;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TXTNIP;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox TXTNoHP;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox TXTEmail;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox CMBPengguna;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlFooterLine;
        private Guna.UI2.WinForms.Guna2Button BTNSimpan;
        private Guna.UI2.WinForms.Guna2Button BTNBatal;
    }
}
