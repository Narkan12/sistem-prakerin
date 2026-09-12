using System;
using System.Data;
using System.Windows.Forms;
using app_prakerin.Config;

namespace app_prakerin
{
    public partial class FAbsensi : Form
    {
        public FAbsensi()
        {
            InitializeComponent();
        }

        private void FAbsensi_Load(object sender, EventArgs e)
        {
            try
            {
                btnEdit.Enabled  = false;
                btnHapus.Enabled = false;
                TampilData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data absensi.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TampilData()
        {
            try
            {
                Koneksi.CRUD(
                    "SELECT absensi.id_absensi, absensi.id_prakerin, siswa.nama, " +
                    "absensi.tanggal, absensi.jam_masuk, absensi.jam_keluar, absensi.status " +
                    "FROM absensi " +
                    "INNER JOIN prakerin ON absensi.id_prakerin = prakerin.id_prakerin " +
                    "INNER JOIN siswa ON prakerin.id_siswa = siswa.id_siswa " +
                    "ORDER BY absensi.id_absensi DESC"
                );

                DGVRole.Rows.Clear();
                int no = 1;

                foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
                {
                    DGVRole.Rows.Add(
                        no++,
                        row["id_absensi"].ToString(),
                        row["id_prakerin"].ToString(),
                        row["nama"].ToString(),
                        row["tanggal"]    == DBNull.Value ? "" : Convert.ToDateTime(row["tanggal"]).ToString("yyyy-MM-dd"),
                        row["jam_masuk"]  == DBNull.Value ? "" : row["jam_masuk"].ToString(),
                        row["jam_keluar"] == DBNull.Value ? "" : row["jam_keluar"].ToString(),
                        row["status"].ToString()
                    );
                }

                btnEdit.Enabled  = false;
                btnHapus.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data absensi.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TXTSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Koneksi.CRUD(
                    "SELECT absensi.id_absensi, absensi.id_prakerin, siswa.nama, " +
                    "absensi.tanggal, absensi.jam_masuk, absensi.jam_keluar, absensi.status " +
                    "FROM absensi " +
                    "INNER JOIN prakerin ON absensi.id_prakerin = prakerin.id_prakerin " +
                    "INNER JOIN siswa ON prakerin.id_siswa = siswa.id_siswa " +
                    "WHERE siswa.nama LIKE '%" + TXTSearch.Text.Trim() + "%' " +
                    "OR absensi.id_prakerin LIKE '%" + TXTSearch.Text.Trim() + "%' " +
                    "OR absensi.status LIKE '%" + TXTSearch.Text.Trim() + "%' " +
                    "ORDER BY absensi.id_absensi DESC"
                );

                DGVRole.Rows.Clear();
                int no = 1;

                foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
                {
                    DGVRole.Rows.Add(
                        no++,
                        row["id_absensi"].ToString(),
                        row["id_prakerin"].ToString(),
                        row["nama"].ToString(),
                        row["tanggal"]    == DBNull.Value ? "" : Convert.ToDateTime(row["tanggal"]).ToString("yyyy-MM-dd"),
                        row["jam_masuk"]  == DBNull.Value ? "" : row["jam_masuk"].ToString(),
                        row["jam_keluar"] == DBNull.Value ? "" : row["jam_keluar"].ToString(),
                        row["status"].ToString()
                    );
                }

                btnEdit.Enabled  = false;
                btnHapus.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mencari data absensi.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTNTambah_Click(object sender, EventArgs e)
        {
            try
            {
                FormCRUDAbsensi modal = new FormCRUDAbsensi();
                modal.Judul = "Tambah Data Absensi";

                if (modal.ShowDialog() == DialogResult.OK)
                {
                    Koneksi.CRUD(
                        "INSERT INTO absensi (id_prakerin, tanggal, jam_masuk, jam_keluar, status) VALUES (" +
                        "'" + modal.IdPrakerin + "', " +
                        "'" + modal.Tanggal    + "', " +
                        "'" + modal.JamMasuk   + "', " +
                        "'" + modal.JamKeluar  + "', " +
                        "'" + modal.Status     + "')"
                    );

                    MessageBox.Show("Data absensi berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FMaster.CatatAktivitas($"Tambah absensi prakerin #{modal.IdPrakerin}");
                    TampilData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan data absensi.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DGVRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            btnEdit.Enabled  = true;
            btnHapus.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (DGVRole.CurrentRow == null || DGVRole.CurrentRow.Index < 0)
            {
                MessageBox.Show("Silahkan pilih data terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                FormCRUDAbsensi modal = new FormCRUDAbsensi();
                modal.Judul      = "Edit Data Absensi";
                modal.IdAbsensi  = DGVRole.CurrentRow.Cells[1].Value?.ToString() ?? "";
                modal.IdPrakerin = DGVRole.CurrentRow.Cells[2].Value?.ToString() ?? "";
                modal.Tanggal    = DGVRole.CurrentRow.Cells[4].Value?.ToString() ?? "";
                modal.JamMasuk   = DGVRole.CurrentRow.Cells[5].Value?.ToString() ?? "";
                modal.JamKeluar  = DGVRole.CurrentRow.Cells[6].Value?.ToString() ?? "";
                modal.Status     = DGVRole.CurrentRow.Cells[7].Value?.ToString() ?? "";

                if (modal.ShowDialog() == DialogResult.OK)
                {
                    Koneksi.CRUD(
                        "UPDATE absensi SET " +
                        "id_prakerin = '" + modal.IdPrakerin + "', " +
                        "tanggal = '"     + modal.Tanggal    + "', " +
                        "jam_masuk = '"   + modal.JamMasuk   + "', " +
                        "jam_keluar = '"  + modal.JamKeluar  + "', " +
                        "status = '"      + modal.Status     + "' " +
                        "WHERE id_absensi = '" + modal.IdAbsensi + "'"
                    );

                    MessageBox.Show("Data absensi berhasil diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FMaster.CatatAktivitas($"Edit absensi #{modal.IdAbsensi}");
                    TampilData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengupdate data absensi.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (DGVRole.CurrentRow == null || DGVRole.CurrentRow.Index < 0)
            {
                MessageBox.Show("Silahkan pilih data terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Apakah Anda yakin ingin menghapus data absensi ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string id = DGVRole.CurrentRow.Cells[1].Value?.ToString() ?? "";
                    if (string.IsNullOrEmpty(id))
                    {
                        MessageBox.Show("ID absensi tidak valid.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    Koneksi.CRUD("DELETE FROM absensi WHERE id_absensi = '" + id + "'");
                    MessageBox.Show("Data absensi berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FMaster.CatatAktivitas($"Hapus absensi #{id}");
                    TampilData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus data absensi.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
