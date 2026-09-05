using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app_prakerin.Config;

namespace app_prakerin
{
    public partial class FMaster : Form
    {
        public string ID;
        public string Username;
        public string Role;
        public string Status;

        public FMaster()
        {
            InitializeComponent();
        }

        private void FDashboard_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Username))
            {

                label1.Text = "Guest";
                label5.Text = "Selamat Datang!";
                
            }
            else
            {
               string namaUser = Username[0].ToString().ToUpper() + Username.Substring(1).ToLower();
                label1.Text = namaUser;
                label5.Text = $"Selamat Datang, {namaUser}!";
            }

            label4.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");

            //data jumlah siswa, pembimbing, jurnal, dan jurnal disetujui
            Koneksi.CRUD("SELECT COUNT(*) AS TotalSiswa FROM Siswa;" +
                "SELECT COUNT(*) AS TotalPembimbing FROM pembimbing;" +
                "SELECT COUNT(*) AS TotalJurnal FROM jurnal_harian;" +
                "SELECT COUNT(*) AS TotalDisetujui FROM jurnal_harian WHERE status_verifikasi = 'diterima';");
            
            DataRow row = Koneksi.ds.Tables[0].Rows[0];

            LBLTotSiswa.Text =
            Koneksi.ds.Tables[0].Rows[0]["TotalSiswa"].ToString();

            LBLTotPembimbing.Text =
            Koneksi.ds.Tables[1].Rows[0]["TotalPembimbing"].ToString();

            LBLTotJurnal.Text =
            Koneksi.ds.Tables[2].Rows[0]["TotalJurnal"].ToString();

            LBLTotDisetujui.Text =
            Koneksi.ds.Tables[3].Rows[0]["TotalDisetujui"].ToString();




            //untuk control content
            PNLHeader.Location = new Point(240, -10);

            //pembagian role
            if (Role == "Super Admin")
            {

            }

            else if (Role == "Siswa")
            {
                BTNDM.Visible = false;

            }



        }

        private void BTNDM_Click(object sender, EventArgs e)
        {
            if (PNLDropdown.Visible == true)
            {
                PNLDropdown.Visible = false;
            }
            else
            {
                PNLDropdown.Visible = true;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            FPengguna FP = new FPengguna();
            Helper.UntukForm(FP, PNLContent);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            FRole FR = new FRole();
            Helper.UntukForm(FR, PNLContent);
        }

       

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           FMaster FM = new FMaster();
            FM.Visible = true;
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FKelas FK = new FKelas();
            Helper.UntukForm(FK, PNLContent);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            FJurusan FJ = new FJurusan();
            Helper.UntukForm(FJ, PNLContent);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            FSiswa FS = new FSiswa();
            Helper.UntukForm(FS, PNLContent);
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            FPerusahaan FPrs = new FPerusahaan();
            Helper.UntukForm(FPrs, PNLContent);
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            FGuru FG = new FGuru();
            Helper.UntukForm(FG, PNLContent);
        }


        private void guna2Button10_Click_1(object sender, EventArgs e)
        {
            FPrakerin FP = new FPrakerin();
            Helper.UntukForm(FP, PNLContent);
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            FPembimbing Fpe = new FPembimbing();
            Helper.UntukForm(Fpe, PNLContent);
        }
        private void guna2Button12_Click(object sender, EventArgs e)
        {
            FJurnal FJ = new FJurnal();
            Helper.UntukForm(FJ, PNLContent);
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            FAbsensi FA = new FAbsensi();
            Helper.UntukForm(FA, PNLContent);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

            DialogResult DS = MessageBox.Show("Apakah ingin logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (DS == DialogResult.Yes )
            {
                FLogin FL = new FLogin();
                FL.Show();
                this.Hide();
            }
            
        }

        private void PMenu_Click(object sender, EventArgs e)
        {
            if (PNLSidebar.Visible == true)
            {
                PNLSidebar.Visible = false;
            }

            else
            {
                PNLSidebar.Visible = true;
            }
        }

        
    }
      
}
