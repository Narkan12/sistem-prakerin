using System;
using System.Data;
using System.Windows.Forms;
using app_prakerin.Config;

namespace app_prakerin
{
    public partial class FLaporanPrakerin : Form
    {
        const string JUDUL_LAPORAN = "LAPORAN DATA PRAKERIN";

        public FLaporanPrakerin()
        {
            InitializeComponent();

            this.Dock = DockStyle.Fill;
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;

            this.Load += new EventHandler(FLaporanPrakerin_Load);
        }

        private void FLaporanPrakerin_Load(object sender, EventArgs e)
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
                    status = cmbStatus.Text.Trim().ToLower();
                }

                string tanggalMulai = dtpMulai.Value.ToString("yyyy-MM-dd");
                string tanggalSelesai = dtpSelesai.Value.ToString("yyyy-MM-dd");

                string query = @"SELECT p.id_prakerin, s.nis, s.nama AS nama_siswa, g.nama AS nama_guru, pe.nama AS nama_perusahaan, pb.nama AS nama_pembimbing, p.tanggal_mulai, p.tanggal_selesai, p.status
                    FROM prakerin p
                    INNER JOIN siswa s ON s.id_siswa = p.id_siswa
                    INNER JOIN guru g ON g.id_guru = p.id_guru
                    INNER JOIN perusahaan pe ON pe.id_perusahaan = p.id_perusahaan
                    INNER JOIN pembimbing pb ON pb.id_pembimbing = p.id_pembimbing
                    WHERE p.tanggal_mulai BETWEEN '" + tanggalMulai + "' AND '" + tanggalSelesai + "' ";

                if (!string.IsNullOrEmpty(search))
                {
                    query += "AND (s.nama LIKE '%" + search + "%' OR s.nis LIKE '%" + search + "%') ";
                }

                if (!string.IsNullOrEmpty(status))
                {
                    query += "AND p.status = '" + status + "' ";
                }

                query += "ORDER BY p.tanggal_mulai DESC, p.id_prakerin DESC";

                Koneksi.CRUD(query);

                DGVLaporan.Rows.Clear();

                int no = 1;

                foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
                {
                    string tanggalMulaiTampil = "";

                    if (row["tanggal_mulai"] != DBNull.Value)
                    {
                        tanggalMulaiTampil = Convert.ToDateTime(row["tanggal_mulai"]).ToString("dd-MM-yyyy");
                    }

                    string tanggalSelesaiTampil = "";

                    if (row["tanggal_selesai"] != DBNull.Value)
                    {
                        tanggalSelesaiTampil = Convert.ToDateTime(row["tanggal_selesai"]).ToString("dd-MM-yyyy");
                    }

                    DGVLaporan.Rows.Add(
                        no,
                        row["id_prakerin"].ToString(),
                        row["nis"].ToString(),
                        row["nama_siswa"].ToString(),
                        row["nama_guru"].ToString(),
                        row["nama_perusahaan"].ToString(),
                        row["nama_pembimbing"].ToString(),
                        tanggalMulaiTampil,
                        tanggalSelesaiTampil,
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
            int menunggu = 0;
            int berlangsung = 0;
            int selesai = 0;

            foreach (DataGridViewRow row in DGVLaporan.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }

                total++;

                string status = row.Cells["colStatus"].Value?.ToString().Trim().ToLower();

                if (status == "menunggu")
                {
                    menunggu++;
                }
                else if (status == "berlangsung")
                {
                    berlangsung++;
                }
                else if (status == "selesai")
                {
                    selesai++;
                }
            }

            lblTotalValue.Text = total.ToString();
            lblMenungguValue.Text = menunggu.ToString();
            lblBerlangsungValue.Text = berlangsung.ToString();
            lblSelesaiValue.Text = selesai.ToString();
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
                FileName = "Laporan_Praktek_Kerja_Lapangan.xlsx"
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
                FileName = "Laporan_Praktek_Kerja_Lapangan.csv"
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
                FileName = "Laporan_Praktek_Kerja_Lapangan.pdf"
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