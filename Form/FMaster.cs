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

        private static readonly List<string[]> _logAktivitas = new List<string[]>();
        private static string _userAktif = "Sistem";

        private int[] jumlahStat = new int[8];
        private readonly ToolTip _tipStat = new ToolTip();

        private static readonly string[] NamaStat =
        {
            "Total Guru",
            "Total Kelas",
            "Total Jurusan",
            "Total Perusahaan",
            "Prakerin Berlangsung",
            "Absensi Hari Ini",
            "Jurnal Menunggu Verifikasi",
            "Jurnal Ditolak"
        };

        // =====================================================================
        // HAK AKSES MENU PER ROLE
        // Kunci role = nama role (tidak peka huruf besar/kecil).
        // Dashboard selalu bisa diakses semua role yang dikenali.
        // Role yang tidak dikenal / kosong => hanya Dashboard (aman secara default).
        //
        // Admin      : semua menu.
        // Guru       : guru pembimbing sekolah -> kelola penempatan prakerin siswa
        //              bimbingannya, pantau jurnal & absensi, monitoring kunjungan,
        //              penilaian, dan seluruh laporan. Tanpa Data Master.
        // Pembimbing : pembimbing lapangan DU/DI -> verifikasi jurnal, cek absensi,
        //              memberi penilaian, serta laporan jurnal/absensi/penilaian.
        // Siswa      : mengisi jurnal harian dan absensi miliknya.
        // =====================================================================
        private static readonly Dictionary<string, string[]> AksesRole =
            new Dictionary<string, string[]>(StringComparer.OrdinalIgnoreCase)
        {
            { "admin", new[] {
                "pengguna", "role", "siswa", "guru", "kelas", "jurusan", "perusahaan", "pembimbing",
                "prakerin", "jurnal", "absensi", "monitoring", "penilaian",
                "lap_absensi", "lap_monitoring", "lap_prakerin", "lap_jurnal", "lap_penilaian" } },

            { "guru", new[] {
                "prakerin", "jurnal", "absensi", "monitoring", "penilaian",
                "lap_absensi", "lap_monitoring", "lap_prakerin", "lap_jurnal", "lap_penilaian" } },

            { "pembimbing", new[] {
                "jurnal", "absensi", "penilaian",
                "lap_absensi", "lap_jurnal", "lap_penilaian" } },

            { "siswa", new[] {
                "jurnal", "absensi" } }
        };

        public FMaster()
        {
            InitializeComponent();
        }

        public static void CatatAktivitas(string keterangan)
        {
            string waktu = DateTime.Now.ToString("HH:mm");
            _logAktivitas.Insert(0, new string[] { keterangan, "Oleh " + _userAktif, waktu });
            if (_logAktivitas.Count > 20)
                _logAktivitas.RemoveAt(_logAktivitas.Count - 1);
        }

        // -------------------------------------------------------------------
        // Pengecekan & penerapan hak akses
        // -------------------------------------------------------------------
        private string KunciRole()
        {
            string r = (Role ?? "").Trim();
            if (r.Equals("administrator", StringComparison.OrdinalIgnoreCase))
                r = "admin";
            return r;
        }

        private bool PunyaAkses(string menu)
        {
            string[] daftar;
            return AksesRole.TryGetValue(KunciRole(), out daftar)
                   && Array.IndexOf(daftar, menu) >= 0;
        }

        // Atur satu tombol menu; mengembalikan 1 jika ditampilkan (untuk menghitung isi dropdown)
        private int AturMenu(string menu, Control tombol)
        {
            bool boleh = PunyaAkses(menu);
            tombol.Visible = boleh;
            return boleh ? 1 : 0;
        }

        private void TerapkanAksesRole()
        {
            // Menu utama
            AturMenu("prakerin", guna2Button10);
            AturMenu("jurnal", guna2Button12);
            AturMenu("absensi", guna2Button13);
            AturMenu("monitoring", guna2Button14);
            AturMenu("penilaian", guna2Button15);

            // Dropdown Data Master
            int jumlahMaster = 0;
            jumlahMaster += AturMenu("pengguna", guna2Button3);
            jumlahMaster += AturMenu("role", guna2Button4);
            jumlahMaster += AturMenu("siswa", guna2Button7);
            jumlahMaster += AturMenu("guru", guna2Button9);
            jumlahMaster += AturMenu("kelas", guna2Button2);
            jumlahMaster += AturMenu("jurusan", guna2Button5);
            jumlahMaster += AturMenu("perusahaan", guna2Button8);
            jumlahMaster += AturMenu("pembimbing", guna2Button11);

            BTNDM.Visible = jumlahMaster > 0;
            if (jumlahMaster == 0)
                PNLDropdown.Visible = false;
            else
                PNLDropdown.Height = 6 + jumlahMaster * 38;   // padding 3+3, tiap item 34 + margin 4

            // Dropdown Laporan
            int jumlahLaporan = 0;
            jumlahLaporan += AturMenu("lap_absensi", guna2Button16);
            jumlahLaporan += AturMenu("lap_monitoring", guna2Button17);
            jumlahLaporan += AturMenu("lap_prakerin", guna2Button18);
            jumlahLaporan += AturMenu("lap_jurnal", guna2Button19);
            jumlahLaporan += AturMenu("lap_penilaian", guna2Button20);

            BTNL.Visible = jumlahLaporan > 0;
            if (jumlahLaporan == 0)
                PNLDropdown2.Visible = false;
            else
                PNLDropdown2.Height = 9 + jumlahLaporan * 46;  // padding 3+3, tiap item 42 + margin 4

            // Tombol panah pada kartu dashboard mengikuti akses menu tujuannya
            BTNPanahSiswa.Visible = PunyaAkses("siswa");
            BTNPanahPembimbing.Visible = PunyaAkses("pembimbing");
            BTNPanahJurnal.Visible = PunyaAkses("jurnal");
            BTNPanahSetujui.Visible = PunyaAkses("jurnal");
        }

        private string KunciMenu(Form form)
        {
            if (form is FPengguna) return "pengguna";
            if (form is FRole) return "role";
            if (form is FSiswa) return "siswa";
            if (form is FGuru) return "guru";
            if (form is FKelas) return "kelas";
            if (form is FJurusan) return "jurusan";
            if (form is FPerusahaan) return "perusahaan";
            if (form is FPembimbing) return "pembimbing";
            if (form is FPrakerin) return "prakerin";
            if (form is FJurnal) return "jurnal";
            if (form is FAbsensi) return "absensi";
            if (form is FMonitoring) return "monitoring";
            if (form is FPenilaian) return "penilaian";
            if (form is FlaporanPresensi) return "lap_absensi";
            if (form is FLaporanMonitoring) return "lap_monitoring";
            if (form is FLaporanPrakerin) return "lap_prakerin";
            if (form is FLaporanJurnal) return "lap_jurnal";
            if (form is FLaporanPenilaian) return "lap_penilaian";
            return null;
        }

        // Penjaga tambahan: menutup jalur lain menuju form (mis. tombol panah di kartu dashboard)
        private bool CekAkses(Form form)
        {
            string kunci = KunciMenu(form);
            if (kunci == null || PunyaAkses(kunci))
                return true;

            CatatAktivitas("Akses ditolak: " + kunci);
            MessageBox.Show(
                "Role Anda tidak memiliki akses ke halaman ini.",
                "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        private void FDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Username))
                {
                    _userAktif = "Guest";
                }
                else
                {
                    _userAktif = Username[0].ToString().ToUpper() + Username.Substring(1).ToLower();
                }

                label1.Text = _userAktif;
                label5.Text = "Selamat Datang!";
                label4.Text = _userAktif;
                LBLTanggal.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");

                TerapkanAksesRole();

                MuatDataDashboard();

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

        private void MuatDataDashboard()
        {
            MuatStatistikDashboard();
            MuatInfoTambahan();
            MuatRingkasan();
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
                LBLTotSiswa.Text = "0";
                LBLTotPembimbing.Text = "0";
                LBLTotJurnal.Text = "0";
                LBLTotDisetujui.Text = "0";
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

            Label[] labelsNama = {
                LBLStatLabel0, LBLStatLabel1, LBLStatLabel2, LBLStatLabel3,
                LBLStatLabel4, LBLStatLabel5, LBLStatLabel6, LBLStatLabel7
            };

            Label[] labelsValue = {
                LBLStatValue0, LBLStatValue1, LBLStatValue2, LBLStatValue3,
                LBLStatValue4, LBLStatValue5, LBLStatValue6, LBLStatValue7
            };

            Guna.UI2.WinForms.Guna2ProgressBar[] bars = {
                PBStat0, PBStat1, PBStat2, PBStat3,
                PBStat4, PBStat5, PBStat6, PBStat7
            };

            for (int i = 0; i < queryStat.Length; i++)
            {
                labelsNama[i].Text = NamaStat[i];
                _tipStat.SetToolTip(labelsNama[i], NamaStat[i]);

                try
                {
                    Koneksi.CRUD(queryStat[i]);
                    labelsValue[i].Text = Koneksi.ds.Tables.Count > 0 && Koneksi.ds.Tables[0].Rows.Count > 0
                        ? Koneksi.ds.Tables[0].Rows[0]["n"].ToString()
                        : "0";
                    jumlahStat[i] = AmbilAngka(labelsValue[i].Text);
                }
                catch
                {
                    labelsValue[i].Text = "-";
                    jumlahStat[i] = 0;
                }

                _tipStat.SetToolTip(labelsValue[i], NamaStat[i] + ": " + labelsValue[i].Text);
            }

            int terbesar = 0;
            for (int i = 0; i < jumlahStat.Length; i++)
            {
                if (jumlahStat[i] > terbesar)
                    terbesar = jumlahStat[i];
            }

            for (int i = 0; i < bars.Length; i++)
            {
                bars[i].Value = terbesar == 0 ? 0 : jumlahStat[i] * 100 / terbesar;
            }
        }

        private void MuatRingkasan()
        {
            int siswa = AmbilAngka(LBLTotSiswa.Text);
            int pembimbing = AmbilAngka(LBLTotPembimbing.Text);
            int jurnal = AmbilAngka(LBLTotJurnal.Text);
            int disetujui = AmbilAngka(LBLTotDisetujui.Text);
            int lainnya = jumlahStat[0] + jumlahStat[1] + jumlahStat[2] + jumlahStat[3] + jumlahStat[4];
            int total = siswa + pembimbing + jurnal + disetujui + lainnya;

            LBLTrendSiswa.Text = jumlahStat[4] + " prakerin berlangsung";
            LBLTrendPembimbing.Text = jumlahStat[0] + " guru terdaftar";
            LBLTrendJurnal.Text = jumlahStat[6] + " menunggu verifikasi";
            LBLTrendSetujui.Text = jumlahStat[7] + " jurnal ditolak";

            LBLDonutTotal.Text = total.ToString();

            LBLLegendJumlah1.Text = siswa.ToString();
            LBLLegendPersen1.Text = HitungPersen(siswa, total);

            LBLLegendJumlah2.Text = pembimbing.ToString();
            LBLLegendPersen2.Text = HitungPersen(pembimbing, total);

            LBLLegendJumlah3.Text = jurnal.ToString();
            LBLLegendPersen3.Text = HitungPersen(jurnal, total);

            LBLLegendJumlah4.Text = disetujui.ToString();
            LBLLegendPersen4.Text = HitungPersen(disetujui, total);

            LBLLegendJumlah5.Text = lainnya.ToString();
            LBLLegendPersen5.Text = HitungPersen(lainnya, total);
        }

        private int AmbilAngka(string teks)
        {
            int angka;
            if (int.TryParse(teks, out angka))
                return angka;
            return 0;
        }

        private string HitungPersen(int nilai, int total)
        {
            if (total == 0 || nilai == 0)
                return "0%";
            double persen = nilai * 100.0 / total;
            return persen.ToString("0.0") + "%";
        }

        private string AmbilIkon(string keterangan)
        {
            string teks = keterangan.ToLower();
            if (teks.Contains("login"))
                return "\U0001F511";
            if (teks.Contains("laporan"))
                return "\U0001F4CA";
            if (teks.Contains("jurnal"))
                return "\U0001F4C4";
            if (teks.Contains("absensi"))
                return "\U0001F4C6";
            return "\u270E";
        }

        private void MuatAktivitas()
        {
            Panel[] baris = {
                PNLActivityRow1, PNLActivityRow2, PNLActivityRow3, PNLActivityRow4,
                PNLActivityRow5, PNLActivityRow6, PNLActivityRow7
            };

            Label[] judul = {
                LBLActivity1, LBLActivity2, LBLActivity3, LBLActivity4,
                LBLActivity5, LBLActivity6, LBLActivity7
            };

            Label[] deskripsi = {
                LBLActDesc1, LBLActDesc2, LBLActDesc3, LBLActDesc4,
                LBLActDesc5, LBLActDesc6, LBLActDesc7
            };

            Label[] waktu = {
                LBLActWaktu1, LBLActWaktu2, LBLActWaktu3, LBLActWaktu4,
                LBLActWaktu5, LBLActWaktu6, LBLActWaktu7
            };

            Guna.UI2.WinForms.Guna2Button[] ikon = {
                ICNAct1, ICNAct2, ICNAct3, ICNAct4, ICNAct5, ICNAct6, ICNAct7
            };

            int jumlahBaris = Math.Min(Math.Max(_logAktivitas.Count, 1), baris.Length);
            PNLActivityList.Height = jumlahBaris * 46 - 1;

            for (int i = 0; i < baris.Length; i++)
            {
                baris[i].Visible = i < jumlahBaris;
            }

            if (_logAktivitas.Count == 0)
            {
                judul[0].Text = "Belum ada aktivitas";
                deskripsi[0].Text = "-";
                waktu[0].Text = "";
                ikon[0].Text = "\u270E";
                return;
            }

            for (int i = 0; i < jumlahBaris; i++)
            {
                string[] data = _logAktivitas[i];
                judul[i].Text = data[0];
                deskripsi[i].Text = data[1];
                waktu[i].Text = data[2];
                ikon[i].Text = AmbilIkon(data[0]);
            }
        }

        private void TampilForm(Form form)
        {
            if (!CekAkses(form))
            {
                form.Dispose();
                return;
            }

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
            MuatDataDashboard();
            MuatAktivitas();
            LBLTanggal.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
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

        private void BTNFilterHari_Click(object sender, EventArgs e)
        {
            try
            {
                TampilDashboard();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat ulang dashboard.\n\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTNLihatSemua_Click(object sender, EventArgs e)
        {
            if (_logAktivitas.Count == 0)
            {
                MessageBox.Show("Belum ada aktivitas.", "Aktivitas Terbaru",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string daftar = "";
            foreach (string[] data in _logAktivitas)
            {
                daftar += "[" + data[2] + "]  " + data[0] + "\n";
            }

            MessageBox.Show(daftar, "Semua Aktivitas",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BTNDM_Click(object sender, EventArgs e)
        {
            PNLDropdown.Visible = !PNLDropdown.Visible;
        }

        private void BTNL_Click(object sender, EventArgs e)
        {
            PNLDropdown2.Visible = !PNLDropdown2.Visible;
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

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            try
            {
                CatatAktivitas("Membuka halaman monitoring");
                FMonitoring FM = new FMonitoring();
                TampilForm(FM);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman Monitoring.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            try
            {
                CatatAktivitas("Membuka halaman penilaian");
                FPenilaian Fpen = new FPenilaian();
                TampilForm(Fpen);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman Penilaian.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            try
            {
                CatatAktivitas("Membuka halaman laporan absensi");
                FlaporanPresensi Flappre = new FlaporanPresensi();
                TampilForm(Flappre);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman Laporan Absensi.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {
            try
            {
                CatatAktivitas("Membuka halaman laporan monitoring");
                FLaporanMonitoring Flapmon = new FLaporanMonitoring();
                TampilForm(Flapmon);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman Laporan Monitoring.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {
            try
            {
                CatatAktivitas("Membuka halaman laporan prakerin");
                FLaporanPrakerin Flapra = new FLaporanPrakerin();
                TampilForm(Flapra);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman Laporan Prakerin.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2Button19_Click(object sender, EventArgs e)
        {
            try
            {
                CatatAktivitas("Membuka halaman laporan jurnal");
                FLaporanJurnal Flapjur = new FLaporanJurnal();
                TampilForm(Flapjur);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman Laporan Jurnal.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2Button20_Click(object sender, EventArgs e)
        {
            try
            {
                CatatAktivitas("Membuka halaman laporan penilaian");
                FLaporanPenilaian Flappen = new FLaporanPenilaian();
                TampilForm(Flappen);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman Laporan Penilaian.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}