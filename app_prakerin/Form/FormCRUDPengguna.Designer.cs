
namespace app_prakerin
{
    partial class FormCRUDPengguna
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
            this.TXTUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CMBRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CMBStatus = new Guna.UI2.WinForms.Guna2ComboBox();
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
            this.guna2Panel1.Size = new System.Drawing.Size(540, 70);
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
            this.lblJudul.Text = "Tambah Data Pengguna";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblSub.ForeColor = System.Drawing.Color.White;
            this.lblSub.Location = new System.Drawing.Point(22, 46);
            this.lblSub.Name = "lblSub";
            this.lblSub.TabIndex = 1;
            this.lblSub.Text = "Form untuk pengisian data pengguna.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(22, 88);
            this.label1.Name = "label1";
            this.label1.TabIndex = 1;
            this.label1.Text = "Username *";
            // 
            // TXTUsername
            // 
            this.TXTUsername.Animated = true;
            this.TXTUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.TXTUsername.BorderRadius = 4;
            this.TXTUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTUsername.DefaultText = "";
            this.TXTUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.TXTUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTUsername.ForeColor = System.Drawing.Color.Black;
            this.TXTUsername.Location = new System.Drawing.Point(25, 112);
            this.TXTUsername.Name = "TXTUsername";
            this.TXTUsername.PlaceholderText = "Masukan username...";
            this.TXTUsername.SelectedText = "";
            this.TXTUsername.Size = new System.Drawing.Size(230, 35);
            this.TXTUsername.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(280, 88);
            this.label2.Name = "label2";
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // TXTPassword
            // 
            this.TXTPassword.Animated = true;
            this.TXTPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.TXTPassword.BorderRadius = 4;
            this.TXTPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTPassword.DefaultText = "";
            this.TXTPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.TXTPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTPassword.ForeColor = System.Drawing.Color.Black;
            this.TXTPassword.Location = new System.Drawing.Point(283, 112);
            this.TXTPassword.Name = "TXTPassword";
            this.TXTPassword.PlaceholderText = "Masukan password...";
            this.TXTPassword.SelectedText = "";
            this.TXTPassword.Size = new System.Drawing.Size(230, 35);
            this.TXTPassword.TabIndex = 4;
            this.TXTPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(22, 160);
            this.label3.Name = "label3";
            this.label3.TabIndex = 5;
            this.label3.Text = "Role *";
            // 
            // CMBRole
            // 
            this.CMBRole.BackColor = System.Drawing.Color.White;
            this.CMBRole.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.CMBRole.BorderRadius = 4;
            this.CMBRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CMBRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.CMBRole.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CMBRole.ForeColor = System.Drawing.Color.Black;
            this.CMBRole.ItemHeight = 22;
            this.CMBRole.Location = new System.Drawing.Point(25, 183);
            this.CMBRole.Name = "CMBRole";
            this.CMBRole.Size = new System.Drawing.Size(230, 30);
            this.CMBRole.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(280, 160);
            this.label4.Name = "label4";
            this.label4.TabIndex = 7;
            this.label4.Text = "Status *";
            // 
            // CMBStatus
            // 
            this.CMBStatus.BackColor = System.Drawing.Color.White;
            this.CMBStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.CMBStatus.BorderRadius = 4;
            this.CMBStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CMBStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.CMBStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CMBStatus.ForeColor = System.Drawing.Color.Black;
            this.CMBStatus.ItemHeight = 22;
            this.CMBStatus.Location = new System.Drawing.Point(283, 183);
            this.CMBStatus.Name = "CMBStatus";
            this.CMBStatus.Size = new System.Drawing.Size(230, 30);
            this.CMBStatus.TabIndex = 8;
            // 
            // BTNSimpan
            // 
            this.BTNSimpan.BorderRadius = 5;
            this.BTNSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNSimpan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(212)))));
            this.BTNSimpan.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.BTNSimpan.ForeColor = System.Drawing.Color.White;
            this.BTNSimpan.Location = new System.Drawing.Point(368, 240);
            this.BTNSimpan.Name = "BTNSimpan";
            this.BTNSimpan.Size = new System.Drawing.Size(145, 38);
            this.BTNSimpan.TabIndex = 9;
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
            this.BTNBatal.Location = new System.Drawing.Point(25, 240);
            this.BTNBatal.Name = "BTNBatal";
            this.BTNBatal.Size = new System.Drawing.Size(120, 38);
            this.BTNBatal.TabIndex = 10;
            this.BTNBatal.Text = "Batal";
            this.BTNBatal.Click += new System.EventHandler(this.BTNBatal_Click);
            // 
            // FormCRUDPengguna
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(540, 295);
            this.Controls.Add(this.BTNBatal);
            this.Controls.Add(this.BTNSimpan);
            this.Controls.Add(this.CMBStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CMBRole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCRUDPengguna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCRUDPengguna";
            this.Load += new System.EventHandler(this.FormCRUDPengguna_Load);
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
        private Guna.UI2.WinForms.Guna2TextBox TXTUsername;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TXTPassword;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox CMBRole;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox CMBStatus;
        private Guna.UI2.WinForms.Guna2Button BTNSimpan;
        private Guna.UI2.WinForms.Guna2Button BTNBatal;
    }
}
