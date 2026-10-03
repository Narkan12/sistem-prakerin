using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using app_prakerin.Config;

namespace app_prakerin
{
    public partial class FLaporanMonitoring : Form
    {
        const string JUDUL_LAPORAN = "LAPORAN MONITORING PRAKERIN";

        public FLaporanMonitoring()
        {
            InitializeComponent();

            this.Dock = DockStyle.Fill;
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;

            this.Load += new EventHandler(FLaporanMonitoring_Load);
        }

        private void FLaporanMonitoring_Load(object sender, EventArgs e)
        {
            try
            {
                dtpTanggal.Value = DateTime.Now;

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

                string tanggalFilter = dtpTanggal.Value.ToString("yyyy-MM-dd");

                // Catatan: query berasumsi tabel "guru" memiliki kolom id_guru & nama,
                // sesuai pola penamaan pada tabel siswa (id_siswa, nis, nama).
                // Sesuaikan nama kolom jika struktur tabel guru berbeda.
                string query = "SELECT monitoring.id_monitoring, monitoring.id_prakerin, monitoring.id_guru, siswa.nis, siswa.nama AS nama_siswa, guru.nama AS nama_guru, monitoring.tanggal, monitoring.catatan, monitoring.foto FROM monitoring INNER JOIN prakerin ON monitoring.id_prakerin = prakerin.id_prakerin INNER JOIN siswa ON prakerin.id_siswa = siswa.id_siswa INNER JOIN guru ON monitoring.id_guru = guru.id_guru WHERE monitoring.tanggal = '" + tanggalFilter + "' ";

                if (!string.IsNullOrEmpty(search))
                {
                    query += "AND (siswa.nama LIKE '%" + search + "%' OR siswa.nis LIKE '%" + search + "%' OR guru.nama LIKE '%" + search + "%' OR monitoring.catatan LIKE '%" + search + "%') ";
                }

                query += "ORDER BY monitoring.tanggal DESC, monitoring.id_monitoring DESC";

                Koneksi.CRUD(query);

                DGVLaporanMonitoring.Rows.Clear();

                int no = 1;

                foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
                {
                    string tanggal = "";

                    if (row["tanggal"] != DBNull.Value)
                    {
                        tanggal = Convert.ToDateTime(row["tanggal"]).ToString("dd-MM-yyyy");
                    }

                    string foto = row["foto"] != DBNull.Value ? row["foto"].ToString() : "";
                    string statusFoto = string.IsNullOrEmpty(foto) ? "Tidak Ada" : "Ada";

                    DGVLaporanMonitoring.Rows.Add(
                        no,
                        row["id_monitoring"].ToString(),
                        row["id_prakerin"].ToString(),
                        row["id_guru"].ToString(),
                        row["nis"].ToString(),
                        row["nama_siswa"].ToString(),
                        row["nama_guru"].ToString(),
                        tanggal,
                        row["catatan"].ToString(),
                        statusFoto
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
            int denganFoto = 0;
            int tanpaFoto = 0;

            HashSet<string> guruUnik = new HashSet<string>();
            HashSet<string> siswaUnik = new HashSet<string>();

            foreach (DataGridViewRow row in DGVLaporanMonitoring.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }

                total++;

                string idGuru = row.Cells["colIdGuru"].Value?.ToString().Trim();
                string idPrakerin = row.Cells["colIdPrakerin"].Value?.ToString().Trim();
                string statusFoto = row.Cells["colFoto"].Value?.ToString().Trim().ToLower();

                if (!string.IsNullOrEmpty(idGuru))
                {
                    guruUnik.Add(idGuru);
                }

                if (!string.IsNullOrEmpty(idPrakerin))
                {
                    siswaUnik.Add(idPrakerin);
                }

                if (statusFoto == "ada")
                {
                    denganFoto++;
                }
                else
                {
                    tanpaFoto++;
                }
            }

            lblTotalValue.Text = total.ToString();
            lblGuruValue.Text = guruUnik.Count.ToString();
            lblSiswaValue.Text = siswaUnik.Count.ToString();
            lblFotoValue.Text = denganFoto.ToString();
            lblTanpaFotoValue.Text = tanpaFoto.ToString();
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            TampilData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                txtSearch.Clear();

                dtpTanggal.Value = DateTime.Now;

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

            dtpTanggal.Value = DateTime.Now;

            TampilData();
        }

        /// <summary>
        /// Mengambil isi DGVLaporanMonitoring (hanya kolom yang Visible) menjadi DataTable,
        /// supaya bisa dipakai ulang oleh semua metode ekspor di Helper (CSV/Excel/PDF/Print/Preview).
        /// </summary>
        private DataTable AmbilDataTabel()
        {
            DataTable dt = new DataTable();

            foreach (DataGridViewColumn kolom in DGVLaporanMonitoring.Columns)
            {
                if (kolom.Visible)
                {
                    dt.Columns.Add(kolom.HeaderText);
                }
            }

            foreach (DataGridViewRow row in DGVLaporanMonitoring.Rows)
            {
                if (row.IsNewRow) continue;

                DataRow dr = dt.NewRow();
                int kolomKe = 0;

                foreach (DataGridViewColumn kolom in DGVLaporanMonitoring.Columns)
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
            if (DGVLaporanMonitoring.Rows.Count == 0)
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
                FileName = "Laporan_Monitoring_Prakerin.xlsx"
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
                FileName = "Laporan_Monitoring_Prakerin.csv"
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
                FileName = "Laporan_Monitoring_Prakerin.pdf"
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