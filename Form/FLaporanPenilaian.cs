using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using app_prakerin.Config;

namespace app_prakerin
{
    public partial class FLaporanPenilaian : Form
    {
        const string JUDUL_LAPORAN = "LAPORAN DATA PENILAIAN";

        public FLaporanPenilaian()
        {
            InitializeComponent();

            this.Dock = DockStyle.Fill;
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;

            this.Load += new EventHandler(FLaporanPenilaian_Load);
        }

        private void FLaporanPenilaian_Load(object sender, EventArgs e)
        {
            try
            {
                txtNilaiMin.Text = "0";
                txtNilaiMax.Text = "100";

                cmbPredikat.SelectedIndex = 0;

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

        private string GetPredikat(double nilai)
        {
            if (nilai >= 85) return "Sangat Baik";
            if (nilai >= 75) return "Baik";
            if (nilai >= 65) return "Cukup";
            return "Kurang";
        }

        private void TampilData()
        {
            try
            {
                string search = txtSearch.Text.Trim().Replace("'", "''");

                double nilaiMin = 0;
                double nilaiMax = 100;

                double.TryParse(txtNilaiMin.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out nilaiMin);
                double.TryParse(txtNilaiMax.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out nilaiMax);

                string predikat = "";

                if (cmbPredikat.SelectedIndex > 0)
                {
                    predikat = cmbPredikat.Text.Trim();
                }

                string query =
                    "SELECT pn.id_penilaian, pn.id_prakerin, " +
                    "s.nama AS nama_siswa, " +
                    "pr.nama AS nama_perusahaan, " +
                    "pb.nama AS pembimbing_perusahaan, " +
                    "pn.disiplin, pn.kerjasama, pn.tanggung_jawab, pn.inisiatif, pn.keahlian, " +
                    "pn.nilai_akhir, pn.status " +
                    "FROM penilaian pn " +
                    "LEFT JOIN prakerin pk ON pn.id_prakerin = pk.id_prakerin " +
                    "LEFT JOIN siswa s ON pk.id_siswa = s.id_siswa " +
                    "LEFT JOIN perusahaan pr ON pk.id_perusahaan = pr.id_perusahaan " +
                    "LEFT JOIN pembimbing pb ON pk.id_pembimbing = pb.id_pembimbing " +
                    "WHERE pn.nilai_akhir BETWEEN " + nilaiMin.ToString(CultureInfo.InvariantCulture) +
                    " AND " + nilaiMax.ToString(CultureInfo.InvariantCulture) + " ";

                if (!string.IsNullOrEmpty(search))
                {
                    query += "AND (pn.id_penilaian LIKE '%" + search + "%' " +
                             "OR pn.id_prakerin LIKE '%" + search + "%' " +
                             "OR s.nama LIKE '%" + search + "%' " +
                             "OR pr.nama LIKE '%" + search + "%' " +
                             "OR pb.nama LIKE '%" + search + "%' " +
                             "OR pn.nilai_akhir LIKE '%" + search + "%' " +
                             "OR pn.status LIKE '%" + search + "%') ";
                }

                query += "ORDER BY pn.id_penilaian DESC";

                Koneksi.CRUD(query);

                DGVLaporan.Rows.Clear();

                int no = 1;

                foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
                {
                    double nilaiAkhir = 0;
                    double.TryParse(row["nilai_akhir"].ToString(), NumberStyles.Any, CultureInfo.CurrentCulture, out nilaiAkhir);

                    string predikatBaris = GetPredikat(nilaiAkhir);

                    if (!string.IsNullOrEmpty(predikat) && predikatBaris != predikat)
                    {
                        continue;
                    }

                    DGVLaporan.Rows.Add(
                        no,
                        row["id_penilaian"].ToString(),
                        row["id_prakerin"].ToString(),
                        row["nama_siswa"].ToString(),
                        row["nama_perusahaan"].ToString(),
                        row["pembimbing_perusahaan"].ToString(),
                        row["disiplin"].ToString(),
                        row["kerjasama"].ToString(),
                        row["tanggung_jawab"].ToString(),
                        row["inisiatif"].ToString(),
                        row["keahlian"].ToString(),
                        row["nilai_akhir"].ToString(),
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
            double jumlah = 0;
            double tertinggi = double.MinValue;
            double terendah = double.MaxValue;

            foreach (DataGridViewRow row in DGVLaporan.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }

                double nilai = 0;

                double.TryParse(
                    row.Cells["colNilaiAkhir"].Value?.ToString(),
                    NumberStyles.Number,
                    CultureInfo.CurrentCulture,
                    out nilai
                );

                total++;
                jumlah += nilai;

                if (nilai > tertinggi) tertinggi = nilai;
                if (nilai < terendah) terendah = nilai;
            }

            double rataRata = total > 0 ? jumlah / total : 0;

            lblTotalValue.Text = total.ToString();
            lblRataRataValue.Text = rataRata.ToString("0.0", new CultureInfo("id-ID"));
            lblTertinggiValue.Text = total > 0 ? tertinggi.ToString("0.0", new CultureInfo("id-ID")) : "0";
            lblTerendahValue.Text = total > 0 ? terendah.ToString("0.0", new CultureInfo("id-ID")) : "0";
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            double nilaiMin = 0;
            double nilaiMax = 100;

            double.TryParse(txtNilaiMin.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out nilaiMin);
            double.TryParse(txtNilaiMax.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out nilaiMax);

            if (nilaiMin > nilaiMax)
            {
                MessageBox.Show(
                    "Nilai minimal tidak boleh lebih besar dari nilai maksimal.",
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

                txtNilaiMin.Text = "0";
                txtNilaiMax.Text = "100";

                cmbPredikat.SelectedIndex = 0;

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

            txtNilaiMin.Text = "0";
            txtNilaiMax.Text = "100";

            cmbPredikat.SelectedIndex = 0;

            TampilData();
        }

        /// <summary>
        /// Mengambil isi DGVLaporan (hanya kolom yang Visible, jadi ID Prakerin tidak ikut)
        /// menjadi DataTable, supaya bisa dipakai ulang oleh semua metode ekspor di Helper.
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
                FileName = "Laporan_Penilaian_Prakerin.xlsx"
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
                FileName = "Laporan_Penilaian_Prakerin.csv"
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
                FileName = "Laporan_Penilaian_Prakerin.pdf"
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