using System;
using System.Collections.Generic;
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

        private static readonly List<string> _logAktivitas = new List<string>();

        public FMaster()
        {
            InitializeComponent();
        }

        public static void CatatAktivitas(string keterangan)
        {
            string waktu = DateTime.Now.ToString("HH:mm");
            _logAktivitas.Insert(0, $"[{waktu}]  {keterangan}");
            if (_logAktivitas.Count > 20)
                _logAktivitas.RemoveAt(_logAktivitas.Count - 1);
        }

        private void FDashboard_Load(object sender, EventArgs e)
        {
            try
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

                MuatStatistikDashboard();
                MuatInfoTambahan();

                if (Role == "Siswa")
                    BTNDM.Visible = false;

                if (!string.IsNullOrEmpty(Username))
                    CatatAktivitas($"Login sebagai {Username}");

                MuatAktivitas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Terjadi kesalahan saat memuat dashboard.\n\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MuatStatistikDashboard()
        {
            try
            {
                Koneksi.CRUD(
                    "SELECT COUNT(*) AS TotalSiswa FROM siswa;" +
                    "SELECT COUNT(*) AS TotalPembimbing FROM pembimbing;" +
                    "SELECT COUNT(*) AS TotalJurnal FROM jurnal_harian;" +
                    "SELECT COUNT(*) AS TotalDisetujui FROM jurnal_harian WHERE status_verifikasi = 'diterima';"
                );

                LBLTotSiswa.Text = Koneksi.ds.Tables.Count > 0 && Koneksi.ds.Tables[0].Rows.Count > 0
                    ? Koneksi.ds.Tables[0].Rows[0]["TotalSiswa"].ToString() : "0";

                LBLTotPembimbing.Text = Koneksi.ds.Tables.Count > 1 && Koneksi.ds.Tables[1].Rows.Count > 0
                    ? Koneksi.ds.Tables[1].Rows[0]["TotalPembimbing"].ToString() : "0";

                LBLTotJurnal.Text = Koneksi.ds.Tables.Count > 2 && Koneksi.ds.Tables[2].Rows.Count > 0
                    ? Koneksi.ds.Tables[2].Rows[0]["TotalJurnal"].ToString() : "0";

                LBLTotDisetujui.Text = Koneksi.ds.Tables.Count > 3 && Koneksi.ds.Tables[3].Rows.Count > 0
                    ? Koneksi.ds.Tables[3].Rows[0]["TotalDisetujui"].ToString() : "0";
            }
            catch
            {
                LBLTotSiswa.Text      = "0";
                LBLTotPembimbing.Text = "0";
                LBLTotJurnal.Text     = "0";
                LBLTotDisetujui.Text  = "0";
            }
        }

        private void MuatInfoTambahan()
        {
            string[] queryStat = {
                "SELECT COUNT(*) AS n FROM guru",
                "SELECT COUNT(*) AS n FROM kelas",
                "SELECT COUNT(*) AS n FROM jurusan",
                "SELECT COUNT(*) AS n FROM perusahaan",
                "SELECT COUNT(*) AS n FROM prakerin WHERE status='berlangsung'",
                $"SELECT COUNT(*) AS n FROM absensi WHERE tanggal='{DateTime.Now:yyyy-MM-dd}'",
                "SELECT COUNT(*) AS n FROM jurnal_harian WHERE status_verifikasi='menunggu'",
                "SELECT COUNT(*) AS n FROM jurnal_harian WHERE status_verifikasi='ditolak'"
            };

            Label[] labelsValue = {
                LBLStatValue0, LBLStatValue1, LBLStatValue2, LBLStatValue3,
                LBLStatValue4, LBLStatValue5, LBLStatValue6, LBLStatValue7
            };

            for (int i = 0; i < queryStat.Length; i++)
            {
                try
                {
                    Koneksi.CRUD(queryStat[i]);
                    labelsValue[i].Text = Koneksi.ds.Tables.Count > 0 && Koneksi.ds.Tables[0].Rows.Count > 0
                        ? Koneksi.ds.Tables[0].Rows[0]["n"].ToString()
                        : "0";
                }
                catch
                {
                    labelsValue[i].Text = "-";
                }
            }
        }

        private void MuatAktivitas()
        {
            Label[] lbls = {
                LBLActivity1, LBLActivity2, LBLActivity3, LBLActivity4, LBLActivity5,
                LBLActivity6, LBLActivity7, LBLActivity8, LBLActivity9, LBLActivity10
            };

            for (int i = 0; i < lbls.Length; i++)
            {
                lbls[i].Text = i < _logAktivitas.Count ? _logAktivitas[i] : "-";
            }
        }

        private void TampilForm(Form form)
        {
            for (int i = PNLContent.Controls.Count - 1; i >= 0; i--)
            {
                Control c = PNLContent.Controls[i];
                if (c is Form childForm)
                {
                    childForm.Hide();
                    PNLContent.Controls.RemoveAt(i);
                }
            }

            guna2Panel2.Visible = false;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            PNLContent.Controls.Add(form);
            form.Show();
        }

        private void TampilDashboard()
        {
            for (int i = PNLContent.Controls.Count - 1; i >= 0; i--)
            {
                Control c = PNLContent.Controls[i];
                if (c is Form childForm)
                {
                    childForm.Hide();
                    PNLContent.Controls.RemoveAt(i);
                }
            }

            guna2Panel2.Visible = true;
            MuatStatistikDashboard();
            MuatInfoTambahan();
            MuatAktivitas();
            label4.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                TampilDashboard();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal kembali ke dashboard.\n\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTNDM_Click(object sender, EventArgs e)
        {
            PNLDropdown.Visible = !PNLDropdown.Visible;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try
            {
                CatatAktivitas("Membuka halaman Pengguna");
                FPengguna FP = new FPengguna();
                TampilForm(FP);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman Pengguna.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            try
            {
                CatatAktivitas("Membuka halaman Role");
                FRole FR = new FRole();
                TampilForm(FR);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman Role.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                CatatAktivitas("Membuka halaman Kelas");
                FKelas FK = new FKelas();
                TampilForm(FK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman Kelas.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            try
            {
                CatatAktivitas("Membuka halaman Jurusan");
                FJurusan FJ = new FJurusan();
                TampilForm(FJ);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman Jurusan.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            try
            {
                CatatAktivitas("Membuka halaman Siswa");
                FSiswa FS = new FSiswa();
                TampilForm(FS);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman Siswa.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            try
            {
                CatatAktivitas("Membuka halaman Perusahaan");
                FPerusahaan FPrs = new FPerusahaan();
                TampilForm(FPrs);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman Perusahaan.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            try
            {
                CatatAktivitas("Membuka halaman Guru");
                FGuru FG = new FGuru();
                TampilForm(FG);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman Guru.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2Button10_Click_1(object sender, EventArgs e)
        {
            try
            {
                CatatAktivitas("Membuka halaman Prakerin");
                FPrakerin FP = new FPrakerin();
                TampilForm(FP);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman Prakerin.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            try
            {
                CatatAktivitas("Membuka halaman Pembimbing");
                FPembimbing Fpe = new FPembimbing();
                TampilForm(Fpe);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman Pembimbing.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            try
            {
                CatatAktivitas("Membuka halaman Jurnal");
                FJurnal FJ = new FJurnal();
                TampilForm(FJ);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman Jurnal.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            try
            {
                CatatAktivitas("Membuka halaman Absensi");
                FAbsensi FA = new FAbsensi();
                TampilForm(FA);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman Absensi.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult DS = MessageBox.Show("Apakah ingin logout?", "Logout",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (DS == DialogResult.Yes)
                {
                    _logAktivitas.Clear();
                    FLogin FL = new FLogin();
                    FL.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal melakukan logout.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PMenu_Click(object sender, EventArgs e)
        {
            PNLSidebar.Visible = !PNLSidebar.Visible;
        }

        private void LBLActivity1_Click(object sender, EventArgs e)
        {

        }
    }
}
