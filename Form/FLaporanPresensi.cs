using System;
using System.Data;
using System.Windows.Forms;
using app_prakerin.Config;

namespace app_prakerin
{
    public partial class FlaporanPresensi : Form
    {
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

                string query = "SELECT absensi.id_absensi, absensi.id_prakerin, siswa.nis, siswa.nama, absensi.tanggal, absensi.jam_masuk, absensi.jam_keluar, absensi.status FROM absensi INNER JOIN prakerin ON absensi.id_prakerin = prakerin.id_prakerin INNER JOIN siswa ON prakerin.id_siswa = siswa.id_siswa WHERE absensi.tanggal BETWEEN '" + tanggalMulai + "' AND '" + tanggalSelesai + "' ";

                if (!string.IsNullOrEmpty(search))
                {
                    query += "AND (siswa.nama LIKE '%" + search + "%' OR siswa.nis LIKE '%" + search + "%') ";
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
                        row["nama"].ToString(),
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

        private void btnCetak_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Data laporan siap untuk dicetak.",
                "Cetak Laporan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}