using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using app_prakerin.Config;

namespace app_prakerin
{
    public partial class FlaporanPresensi : Form
    {
        const string JUDUL_LAPORAN = "LAPORAN DATA PRESENSI PRAKERIN";

        public FlaporanPresensi()
        {
            InitializeComponent();

            this.Dock = DockStyle.Fill;
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;

            this.Load += new EventHandler(FLaporan_Load);
        }

        private void FLaporan_Load(object sender, EventArgs e)
        {
            try
            {
                dtpMulai.Value = DateTime.Now.AddDays(-30);
                dtpSelesai.Value = DateTime.Now;

                cmbStatus.SelectedIndex = 0;

                TampilData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat laporan.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void TampilData()
        {
            try
            {
                string search = txtSearch.Text.Trim();
                string status = "";

                if (cmbStatus.SelectedIndex > 0)
                {
                    status = cmbStatus.Text.Trim();
                }

                string tanggalMulai = dtpMulai.Value.ToString("yyyy-MM-dd");
                string tanggalSelesai = dtpSelesai.Value.ToString("yyyy-MM-dd");

                string query = "SELECT absensi.id_absensi, absensi.id_prakerin, siswa.nis, siswa.nama AS nama_siswa, perusahaan.nama AS nama_perusahaan, absensi.tanggal, absensi.jam_masuk, absensi.jam_keluar, absensi.status FROM absensi INNER JOIN prakerin ON absensi.id_prakerin = prakerin.id_prakerin INNER JOIN siswa ON prakerin.id_siswa = siswa.id_siswa INNER JOIN perusahaan on perusahaan.id_perusahaan = prakerin.id_perusahaan WHERE absensi.tanggal BETWEEN '" + tanggalMulai + "' AND '" + tanggalSelesai + "' ";

                if (!string.IsNullOrEmpty(search))
                {
                    query += "AND (siswa.nama LIKE '%" + search + "%' OR siswa.nis LIKE '%" + search + "%') AND (perusahaan.nama LIKE '%" + search + "%')";
                }

                if (!string.IsNullOrEmpty(status))
                {
                    query += "AND absensi.status = '" + status + "' ";
                }

                query += "ORDER BY absensi.tanggal DESC, absensi.id_absensi DESC";

                Koneksi.CRUD(query);

                DGVLaporan.Rows.Clear();

                int no = 1;

                foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
                {
                    string tanggal = "";

                    if (row["tanggal"] != DBNull.Value)
                    {
                        tanggal = Convert.ToDateTime(row["tanggal"]).ToString("dd-MM-yyyy");
                    }

                    string jamMasuk = "";

                    if (row["jam_masuk"] != DBNull.Value)
                    {
                        jamMasuk = row["jam_masuk"].ToString();
                    }

                    string jamKeluar = "";

                    if (row["jam_keluar"] != DBNull.Value)
                    {
                        jamKeluar = row["jam_keluar"].ToString();
                    }

                    DGVLaporan.Rows.Add(
                        no,
                        row["id_absensi"].ToString(),
                        row["id_prakerin"].ToString(),
                        row["nis"].ToString(),
                        row["nama_siswa"].ToString(),
                        row["nama_perusahaan"].ToString(),
                        tanggal,
                        jamMasuk,
                        jamKeluar,
                        row["status"].ToString()
                    );

                    no++;
                }

                HitungStatistik();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menampilkan laporan.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void HitungStatistik()
        {
            int total = 0;
            int hadir = 0;
            int izin = 0;
            int sakit = 0;
            int alfa = 0;

            foreach (DataGridViewRow row in DGVLaporan.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }

                total++;

                string status = row.Cells["colStatus"].Value?.ToString().Trim().ToLower();

                if (status == "hadir")
                {
                    hadir++;
                }
                else if (status == "izin")
                {
                    izin++;
                }
                else if (status == "sakit")
                {
                    sakit++;
                }
                else if (status == "alfa")
                {
                    alfa++;
                }
            }

            lblTotalValue.Text = total.ToString();
            lblHadirValue.Text = hadir.ToString();
            lblIzinValue.Text = izin.ToString();
            lblSakitValue.Text = sakit.ToString();
            lblAlfaValue.Text = alfa.ToString();
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            if (dtpMulai.Value.Date > dtpSelesai.Value.Date)
            {
                MessageBox.Show(
                    "Tanggal mulai tidak boleh lebih besar dari tanggal selesai.",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            TampilData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                txtSearch.Clear();

                dtpMulai.Value = DateTime.Now.AddDays(-30);
                dtpSelesai.Value = DateTime.Now;

                cmbStatus.SelectedIndex = 0;

                TampilData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal melakukan refresh.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();

            dtpMulai.Value = DateTime.Now.AddDays(-30);
            dtpSelesai.Value = DateTime.Now;

            cmbStatus.SelectedIndex = 0;

            TampilData();
        }

        /// <summary>
        /// Mengambil isi DGVLaporan (hanya kolom yang Visible) menjadi DataTable,
        /// supaya bisa dipakai ulang oleh semua metode ekspor di Helper (CSV/Excel/PDF/Print/Preview).
        /// </summary>
        private DataTable AmbilDataTabel()
        {
            DataTable dt = new DataTable();

            foreach (DataGridViewColumn kolom in DGVLaporan.Columns)
            {
                if (kolom.Visible)
                {
                    dt.Columns.Add(kolom.HeaderText);
                }
            }

            foreach (DataGridViewRow row in DGVLaporan.Rows)
            {
                if (row.IsNewRow) continue;

                DataRow dr = dt.NewRow();
                int kolomKe = 0;

                foreach (DataGridViewColumn kolom in DGVLaporan.Columns)
                {
                    if (kolom.Visible)
                    {
                        dr[kolomKe] = row.Cells[kolom.Index].Value?.ToString() ?? "";
                        kolomKe++;
                    }
                }

                dt.Rows.Add(dr);
            }

            return dt;
        }

        /// <summary>
        /// Dipanggil oleh semua tombol ekspor/cetak: memastikan ada data di tabel.
        /// </summary>
        private bool AdaData()
        {
            if (DGVLaporan.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Tidak ada data yang dapat diekspor.",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return false;
            }

            return true;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (!AdaData()) return;

            SaveFileDialog saveFile = new SaveFileDialog
            {
                Filter = "Excel Files|*.xlsx",
                Title = "Simpan Laporan Excel",
                FileName = "Laporan_Presensi_Prakerin.xlsx"
            };

            if (saveFile.ShowDialog() != DialogResult.OK) return;

            try
            {
                Helper.Excel(AmbilDataTabel(), saveFile.FileName, JUDUL_LAPORAN);

                MessageBox.Show(
                    "Laporan berhasil diekspor ke Excel.",
                    "Berhasil",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal mengekspor ke Excel.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnCsv_Click(object sender, EventArgs e)
        {
            if (!AdaData()) return;

            SaveFileDialog saveFile = new SaveFileDialog
            {
                Filter = "CSV Files|*.csv",
                Title = "Simpan Laporan CSV",
                FileName = "Laporan_Presensi_Prakerin.csv"
            };

            if (saveFile.ShowDialog() != DialogResult.OK) return;

            try
            {
                Helper.CSV(AmbilDataTabel(), saveFile.FileName);

                MessageBox.Show(
                    "Laporan berhasil diekspor ke CSV.",
                    "Berhasil",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal mengekspor ke CSV.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            if (!AdaData()) return;

            SaveFileDialog saveFile = new SaveFileDialog
            {
                Filter = "PDF Files|*.pdf",
                Title = "Simpan Laporan PDF",
                FileName = "Laporan_Presensi_Prakerin.pdf"
            };

            if (saveFile.ShowDialog() != DialogResult.OK) return;

            try
            {
                Helper.PDF(AmbilDataTabel(), saveFile.FileName, JUDUL_LAPORAN);

                MessageBox.Show(
                    "Laporan berhasil diekspor ke PDF.",
                    "Berhasil",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal mengekspor ke PDF.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (!AdaData()) return;

            try
            {
                Helper.Print(AmbilDataTabel(), JUDUL_LAPORAN);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal mencetak laporan.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (!AdaData()) return;

            try
            {
                Helper.Preview(AmbilDataTabel(), JUDUL_LAPORAN, this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal membuka pratinjau cetak.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void panelFilter_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}