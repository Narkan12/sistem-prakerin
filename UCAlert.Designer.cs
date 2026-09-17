
namespace app_prakerin
{
    partial class UCAlert
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAlert));
            this.PNLBungkus = new Guna.UI2.WinForms.Guna2Panel();
            this.LBLDeskripsi = new System.Windows.Forms.Label();
            this.LBLJudul = new System.Windows.Forms.Label();
            this.PBIcon = new System.Windows.Forms.PictureBox();
            this.TAlert = new Guna.UI2.WinForms.Guna2Transition();
            this.TMRAlert = new System.Windows.Forms.Timer(this.components);
            this.PNLBungkus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // PNLBungkus
            // 
            this.PNLBungkus.BorderColor = System.Drawing.Color.Transparent;
            this.PNLBungkus.BorderRadius = 5;
            this.PNLBungkus.BorderThickness = 1;
            this.PNLBungkus.Controls.Add(this.LBLDeskripsi);
            this.PNLBungkus.Controls.Add(this.LBLJudul);
            this.PNLBungkus.Controls.Add(this.PBIcon);
            this.TAlert.SetDecoration(this.PNLBungkus, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PNLBungkus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.PNLBungkus.Location = new System.Drawing.Point(3, 3);
            this.PNLBungkus.Name = "PNLBungkus";
            this.PNLBungkus.Size = new System.Drawing.Size(314, 44);
            this.PNLBungkus.TabIndex = 0;
            // 
            // LBLDeskripsi
            // 
            this.LBLDeskripsi.AutoSize = true;
            this.LBLDeskripsi.BackColor = System.Drawing.Color.Transparent;
            this.TAlert.SetDecoration(this.LBLDeskripsi, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LBLDeskripsi.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLDeskripsi.ForeColor = System.Drawing.Color.Black;
            this.LBLDeskripsi.Location = new System.Drawing.Point(52, 24);
            this.LBLDeskripsi.Name = "LBLDeskripsi";
            this.LBLDeskripsi.Size = new System.Drawing.Size(101, 13);
            this.LBLDeskripsi.TabIndex = 32;
            this.LBLDeskripsi.Text = "masukan deskripsi";
            // 
            // LBLJudul
            // 
            this.LBLJudul.AutoSize = true;
            this.LBLJudul.BackColor = System.Drawing.Color.Transparent;
            this.TAlert.SetDecoration(this.LBLJudul, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LBLJudul.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLJudul.ForeColor = System.Drawing.Color.Black;
            this.LBLJudul.Location = new System.Drawing.Point(52, 7);
            this.LBLJudul.Name = "LBLJudul";
            this.LBLJudul.Size = new System.Drawing.Size(99, 17);
            this.LBLJudul.TabIndex = 31;
            this.LBLJudul.Text = "masukan judul";
            // 
            // PBIcon
            // 
            this.PBIcon.BackColor = System.Drawing.Color.Transparent;
            this.TAlert.SetDecoration(this.PBIcon, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PBIcon.Location = new System.Drawing.Point(12, 7);
            this.PBIcon.Name = "PBIcon";
            this.PBIcon.Size = new System.Drawing.Size(34, 30);
            this.PBIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBIcon.TabIndex = 30;
            this.PBIcon.TabStop = false;
            // 
            // TAlert
            // 
            this.TAlert.AnimationType = Guna.UI2.AnimatorNS.AnimationType.VertSlide;
            this.TAlert.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.TAlert.DefaultAnimation = animation1;
            // 
            // TMRAlert
            // 
            this.TMRAlert.Enabled = true;
            this.TMRAlert.Interval = 4000;
            this.TMRAlert.Tick += new System.EventHandler(this.TMRAlert_Tick);
            // 
            // UCAlert
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.PNLBungkus);
            this.TAlert.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Name = "UCAlert";
            this.Size = new System.Drawing.Size(320, 50);
            this.PNLBungkus.ResumeLayout(false);
            this.PNLBungkus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PNLBungkus;
        private System.Windows.Forms.Label LBLDeskripsi;
        private System.Windows.Forms.Label LBLJudul;
        private System.Windows.Forms.PictureBox PBIcon;
        private Guna.UI2.WinForms.Guna2Transition TAlert;
        private System.Windows.Forms.Timer TMRAlert;
    }
}
