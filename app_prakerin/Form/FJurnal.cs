using System;
using System.Data;
using System.Windows.Forms;
using app_prakerin.Config;

namespace app_prakerin
{
    public partial class FJurnal : Form
    {
        string idJurnal = "";

        public FJurnal()
        {
            InitializeComponent();
        }

        private void FJurnal_Load(object sender, EventArgs e)
        {
            try
            {
                btnEdit.Enabled  = false;
                btnHapus.Enabled = false;
                TampilData("");
                DGVRole.Columns["ColIDJurnal"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data jurnal.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void TampilData(string CariApa)
        {
            try
            {
                DGVRole.Rows.Clear();

                Koneksi.CRUD($"SELECT jurnal_harian.*, siswa.nama " +
                             $"FROM jurnal_harian " +
                             $"INNER JOIN prakerin ON jurnal_harian.id_prakerin = prakerin.id_prakerin " +
                             $"INNER JOIN siswa ON prakerin.id_siswa = siswa.id_siswa " +
                             $"WHERE jurnal_harian.id_jurnal LIKE '%{CariApa}%' " +
                             $"OR jurnal_harian.id_prakerin LIKE '%{CariApa}%' " +
                             $"OR siswa.nama LIKE '%{CariApa}%' " +
                             $"OR jurnal_harian.kegiatan LIKE '%{CariApa}%' " +
                             $"OR jurnal_harian.kendala LIKE '%{CariApa}%' " +
                             $"OR jurnal_harian.solusi LIKE '%{CariApa}%'");

                int no = 1;
                foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
                {
                    string tanggal = row["tanggal"] != DBNull.Value
                        ? Convert.ToDateTime(row["tanggal"]).ToString("yyyy-MM-dd")
                        : "-";

                    DGVRole.Rows.Add(
                        no,
                        row["id_jurnal"],
                        row["id_prakerin"],
                        row["nama"],
                        tanggal,
                        row["kegiatan"],
                        row["kendala"],
                        row["solusi"],
                        row["status_verifikasi"]
                    );
                    no++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data jurnal.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Bersih()
        {
            TXTIDPrakerin.Clear();
            TXTKegiatan.Clear();
            TXTKendala.Clear();
            TXTSolusi.Clear();
        }

        public void AmbilData(string ids)
        {
            try
            {
                Koneksi.CRUD($"SELECT * FROM jurnal_harian WHERE id_jurnal = '{ids}'");
                foreach (DataRow item in Koneksi.ds.Tables[0].Rows)
                {
                    TXTIDPrakerin.Text = item["id_prakerin"].ToString();
                    TXTKegiatan.Text   = item["kegiatan"].ToString();
                    TXTKendala.Text    = item["kendala"].ToString();
                    TXTSolusi.Text     = item["solusi"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data jurnal.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DGVRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            try
            {
                idJurnal = DGVRole.Rows[e.RowIndex].Cells["ColIDJurnal"].Value?.ToString() ?? "";
                if (!string.IsNullOrEmpty(idJurnal))
                {
                    AmbilData(idJurnal);
                    btnEdit.Enabled  = true;
                    btnHapus.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memilih data.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TXTSearch_TextChanged(object sender, EventArgs e)
        {
            TampilData(TXTSearch.Text);
        }

        private void BTNTambah_Click(object sender, EventArgs e)
        {
            try
            {
                FormCRUDJurnal modal = new FormCRUDJurnal();
                modal.Judul = "Tambah Data Jurnal";

                if (modal.ShowDialog() == DialogResult.OK)
                {
                    Koneksi.CRUD($"INSERT INTO jurnal_harian (id_prakerin, tanggal, kegiatan, kendala, solusi, status_verifikasi) VALUES('{modal.IdPrakerin}','{modal.Tanggal}','{modal.Kegiatan}','{modal.Kendala}','{modal.Solusi}','{modal.StatusVerifikasi}')");
                    MessageBox.Show("Data berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FMaster.CatatAktivitas($"Tambah jurnal prakerin #{modal.IdPrakerin}");
                    TampilData("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan data jurnal.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (idJurnal == "")
            {
                MessageBox.Show("Pilih data terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                FormCRUDJurnal modal = new FormCRUDJurnal();
                modal.Judul = "Edit Data Jurnal";

                Koneksi.CRUD($"SELECT * FROM jurnal_harian WHERE id_jurnal='{idJurnal}'");

                if (Koneksi.ds.Tables[0].Rows.Count > 0)
                {
                    DataRow row          = Koneksi.ds.Tables[0].Rows[0];
                    modal.IdPrakerin     = row["id_prakerin"].ToString();
                    modal.Tanggal        = row["tanggal"].ToString();
                    modal.Kegiatan       = row["kegiatan"].ToString();
                    modal.Kendala        = row["kendala"].ToString();
                    modal.Solusi         = row["solusi"].ToString();
                    modal.StatusVerifikasi = row["status_verifikasi"].ToString();
                }

                if (modal.ShowDialog() == DialogResult.OK)
                {
                    Koneksi.CRUD($"UPDATE jurnal_harian SET id_prakerin='{modal.IdPrakerin}', tanggal='{modal.Tanggal}', kegiatan='{modal.Kegiatan}', kendala='{modal.Kendala}', solusi='{modal.Solusi}', status_verifikasi='{modal.StatusVerifikasi}' WHERE id_jurnal='{idJurnal}'");
                    MessageBox.Show("Data berhasil diupdate!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FMaster.CatatAktivitas($"Edit jurnal #{idJurnal}");
                    Bersih();
                    TampilData("");
                    idJurnal = "";
                    btnEdit.Enabled  = false;
                    btnHapus.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengupdate data jurnal.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (idJurnal == "")
            {
                MessageBox.Show("Pilih data terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Yakin ingin menghapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Koneksi.CRUD($"DELETE FROM jurnal_harian WHERE id_jurnal='{idJurnal}'");
                    MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FMaster.CatatAktivitas($"Hapus jurnal #{idJurnal}");
                    Bersih();
                    TampilData("");
                    idJurnal = "";
                    btnEdit.Enabled  = false;
                    btnHapus.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus data jurnal.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
