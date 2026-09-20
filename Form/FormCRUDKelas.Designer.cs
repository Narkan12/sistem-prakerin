namespace app_prakerin
{
    partial class FormCRUDKelas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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
            this.TXTTingkat = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CMBJurusan = new Guna.UI2.WinForms.Guna2ComboBox();
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
            this.guna2Panel1.Size = new System.Drawing.Size(520, 88);
            this.guna2Panel1.TabIndex = 0;
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.ForeColor = System.Drawing.Color.White;
            this.lblJudul.Location = new System.Drawing.Point(28, 20);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(200, 28);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Tambah Data Kelas";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.lblSub.Location = new System.Drawing.Point(30, 54);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(176, 15);
            this.lblSub.TabIndex = 1;
            this.lblSub.Text = "Form untuk pengisian data kelas.";
            // 
            // pnlHeaderDot1
            // 
            this.pnlHeaderDot1.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeaderDot1.BorderRadius = 40;
            this.pnlHeaderDot1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.pnlHeaderDot1.Location = new System.Drawing.Point(392, 4);
            this.pnlHeaderDot1.Name = "pnlHeaderDot1";
            this.pnlHeaderDot1.Size = new System.Drawing.Size(80, 80);
            this.pnlHeaderDot1.TabIndex = 2;
            // 
            // pnlHeaderDot2
            // 
            this.pnlHeaderDot2.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeaderDot2.BorderRadius = 20;
            this.pnlHeaderDot2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.pnlHeaderDot2.Location = new System.Drawing.Point(352, 44);
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
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama Kelas *";
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
            this.TXTNama.PlaceholderText = "Masukan nama kelas...";
            this.TXTNama.SelectedText = "";
            this.TXTNama.Size = new System.Drawing.Size(300, 42);
            this.TXTNama.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(344, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tingkat *";
            // 
            // TXTTingkat
            // 
            this.TXTTingkat.Animated = true;
            this.TXTTingkat.BackColor = System.Drawing.Color.White;
            this.TXTTingkat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.TXTTingkat.BorderRadius = 10;
            this.TXTTingkat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTTingkat.DefaultText = "";
            this.TXTTingkat.FillColor = System.Drawing.Color.White;
            this.TXTTingkat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.TXTTingkat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TXTTingkat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.TXTTingkat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.TXTTingkat.Location = new System.Drawing.Point(344, 134);
            this.TXTTingkat.Name = "TXTTingkat";
            this.TXTTingkat.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.TXTTingkat.PlaceholderText = "Contoh: 10";
            this.TXTTingkat.SelectedText = "";
            this.TXTTingkat.Size = new System.Drawing.Size(148, 42);
            this.TXTTingkat.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(28, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Jurusan *";
            // 
            // CMBJurusan
            // 
            this.CMBJurusan.BackColor = System.Drawing.Color.White;
            this.CMBJurusan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.CMBJurusan.BorderRadius = 10;
            this.CMBJurusan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CMBJurusan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBJurusan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBJurusan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.CMBJurusan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.CMBJurusan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CMBJurusan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.CMBJurusan.ItemHeight = 34;
            this.CMBJurusan.Location = new System.Drawing.Point(28, 220);
            this.CMBJurusan.Name = "CMBJurusan";
            this.CMBJurusan.Size = new System.Drawing.Size(464, 42);
            this.CMBJurusan.TabIndex = 6;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlFooter.Controls.Add(this.BTNBatal);
            this.pnlFooter.Controls.Add(this.BTNSimpan);
            this.pnlFooter.Controls.Add(this.pnlFooterLine);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 292);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(520, 72);
            this.pnlFooter.TabIndex = 9;
            // 
            // pnlFooterLine
            // 
            this.pnlFooterLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlFooterLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFooterLine.Location = new System.Drawing.Point(0, 0);
            this.pnlFooterLine.Name = "pnlFooterLine";
            this.pnlFooterLine.Size = new System.Drawing.Size(520, 1);
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
            this.BTNSimpan.Location = new System.Drawing.Point(352, 15);
            this.BTNSimpan.Name = "BTNSimpan";
            this.BTNSimpan.Size = new System.Drawing.Size(140, 42);
            this.BTNSimpan.TabIndex = 7;
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
            this.BTNBatal.Location = new System.Drawing.Point(232, 15);
            this.BTNBatal.Name = "BTNBatal";
            this.BTNBatal.Size = new System.Drawing.Size(110, 42);
            this.BTNBatal.TabIndex = 8;
            this.BTNBatal.Text = "Batal";
            this.BTNBatal.Click += new System.EventHandler(this.BTNBatal_Click);
            // 
            // FormCRUDKelas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 364);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.CMBJurusan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTTingkat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTNama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCRUDKelas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCRUDKelas";
            this.Load += new System.EventHandler(this.FormCRUDKelas_Load);
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
        private Guna.UI2.WinForms.Guna2TextBox TXTTingkat;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox CMBJurusan;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlFooterLine;
        private Guna.UI2.WinForms.Guna2Button BTNSimpan;
        private Guna.UI2.WinForms.Guna2Button BTNBatal;
    }
}