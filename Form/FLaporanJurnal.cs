using System;
using System.Data;
using System.Windows.Forms;
using app_prakerin.Config;

namespace app_prakerin
{
    public partial class FLaporanJurnal : Form
    {
        const string JUDUL_LAPORAN = "LAPORAN DATA JURNAL";

        public FLaporanJurnal()
        {
            InitializeComponent();

            this.Dock = DockStyle.Fill;
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;

            this.Load += new EventHandler(FLaporanJurnal_Load);
        }

        private void FLaporanJurnal_Load(object sender, EventArgs e)
        {
            try
            {
                dtpTanggal.Value = DateTime.Now;

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

                string tanggal = dtpTanggal.Value.ToString("yyyy-MM-dd");

                string query = "SELECT jurnal_harian.id_jurnal, jurnal_harian.id_prakerin, siswa.nama, jurnal_harian.tanggal, jurnal_harian.kegiatan, jurnal_harian.kendala, jurnal_harian.solusi, jurnal_harian.status_verifikasi " +
                    "FROM jurnal_harian " +
                    "INNER JOIN prakerin ON jurnal_harian.id_prakerin = prakerin.id_prakerin " +
                    "INNER JOIN siswa ON prakerin.id_siswa = siswa.id_siswa " +
                    "WHERE jurnal_harian.tanggal = '" + tanggal + "' ";

                if (!string.IsNullOrEmpty(search))
                {
                    query += "AND (jurnal_harian.id_prakerin LIKE '%" + search + "%' OR siswa.nama LIKE '%" + search + "%' OR jurnal_harian.kegiatan LIKE '%" + search + "%' OR jurnal_harian.kendala LIKE '%" + search + "%' OR jurnal_harian.solusi LIKE '%" + search + "%') ";
                }

                if (!string.IsNullOrEmpty(status))
                {
                    query += "AND jurnal_harian.status_verifikasi = '" + status + "' ";
                }

                query += "ORDER BY jurnal_harian.tanggal DESC, jurnal_harian.id_jurnal DESC";

                Koneksi.CRUD(query);

                DGVLaporan.Rows.Clear();

                int no = 1;

                foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
                {
                    string tglBaris = "";

                    if (row["tanggal"] != DBNull.Value)
                    {
                        tglBaris = Convert.ToDateTime(row["tanggal"]).ToString("dd-MM-yyyy");
                    }

                    DGVLaporan.Rows.Add(
                        no,
                        row["id_jurnal"].ToString(),
                        row["id_prakerin"].ToString(),
                        row["nama"].ToString(),
                        tglBaris,
                        row["kegiatan"].ToString(),
                        row["kendala"].ToString(),
                        row["solusi"].ToString(),
                        row["status_verifikasi"].ToString()
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
            int disetujui = 0;
            int ditolak = 0;

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
                else if (status == "disetujui")
                {
                    disetujui++;
                }
                else if (status == "ditolak")
                {
                    ditolak++;
                }
            }

            lblTotalValue.Text = total.ToString();
            lblMenungguValue.Text = menunggu.ToString();
            lblDisetujuiValue.Text = disetujui.ToString();
            lblDitolakValue.Text = ditolak.ToString();
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

            dtpTanggal.Value = DateTime.Now;

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
                FileName = "Laporan_Jurnal_Prakerin.xlsx"
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
                FileName = "Laporan_Jurnal_Prakerin.csv"
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
                FileName = "Laporan_Jurnal_Prakerin.pdf"
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