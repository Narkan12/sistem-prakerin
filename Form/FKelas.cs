using System;
using System.Data;
using System.Windows.Forms;
using app_prakerin.Config;

namespace app_prakerin
{
    public partial class FKelas : Form
    {
        string idKelas = "";

        public FKelas()
        {
            InitializeComponent();
        }

        private void FRole_Load(object sender, EventArgs e)
        {
            try
            {
                btnEdit.Enabled  = false;
                btnHapus.Enabled = false;
                TampilData("");
                DGVRole.Columns["Column2"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data kelas.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void TampilData(string CariApa)
        {
            try
            {
                DGVRole.Rows.Clear();
                Koneksi.CRUD($"SELECT k.*, j.nama_jurusan FROM kelas k INNER JOIN jurusan j ON j.id_jurusan = k.id_jurusan WHERE k.nama_kelas LIKE '%{CariApa}%'");
                int no = 1;
                foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
                {
                    DGVRole.Rows.Add(no, row["id_kelas"], row["nama_kelas"], row["tingkat"], row["nama_jurusan"]);
                    no++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data kelas.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Bersih()
        {
            TXTNama.Clear();
            TXTKeterangan.Clear();
            CMBJurusan.SelectedIndex = -1;
            CMBJurusan.ResetText();
        }

        public void AmbilData(string idk)
        {
            try
            {
                Koneksi.CRUD($"SELECT k.*, j.nama_jurusan FROM kelas k INNER JOIN jurusan j ON j.id_jurusan = k.id_jurusan WHERE k.id_kelas = '{idk}'");
                foreach (DataRow item in Koneksi.ds.Tables[0].Rows)
                {
                    TXTNama.Text       = item["nama_kelas"].ToString();
                    TXTKeterangan.Text = item["tingkat"].ToString();
                    CMBJurusan.Text    = item["nama_jurusan"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data kelas.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DGVRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            try
            {
                idKelas = DGVRole.Rows[e.RowIndex].Cells["Column2"].Value?.ToString() ?? "";
                if (!string.IsNullOrEmpty(idKelas))
                {
                    AmbilData(idKelas);
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

        private void CMBJurusan_DropDown(object sender, EventArgs e)
        {
            try
            {
                CMBJurusan.Items.Clear();
                Koneksi.CRUD("SELECT nama_jurusan FROM jurusan");
                foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
                    CMBJurusan.Items.Add(row["nama_jurusan"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data jurusan.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTNTambah_Click(object sender, EventArgs e)
        {
            try
            {
                FormCRUDKelas modal = new FormCRUDKelas();
                modal.Judul = "Tambah Data Kelas";

                if (modal.ShowDialog() == DialogResult.OK)
                {
                    Koneksi.CRUD($"SELECT id_jurusan FROM jurusan WHERE nama_jurusan='{modal.NamaJurusan}'");
                    if (Koneksi.ds.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("Jurusan tidak ditemukan!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    string idJurusan = Koneksi.ds.Tables[0].Rows[0]["id_jurusan"].ToString();
                    Koneksi.CRUD($"INSERT INTO kelas (nama_kelas, tingkat, id_jurusan) VALUES('{modal.NamaKelas}','{modal.Tingkat}','{idJurusan}')");
                    MessageBox.Show("Data berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FMaster.CatatAktivitas($"Tambah kelas: {modal.NamaKelas}");
                    TampilData("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan data kelas.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (idKelas == "")
            {
                MessageBox.Show("Pilih data terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                int rowIdx = DGVRole.CurrentCell.RowIndex;
                FormCRUDKelas modal = new FormCRUDKelas();
                modal.Judul       = "Edit Data Kelas";
                modal.NamaKelas   = DGVRole.Rows[rowIdx].Cells["dataGridViewTextBoxColumn2"].Value?.ToString() ?? "";
                modal.Tingkat     = DGVRole.Rows[rowIdx].Cells["dataGridViewTextBoxColumn3"].Value?.ToString() ?? "";
                modal.NamaJurusan = DGVRole.Rows[rowIdx].Cells["Column3"].Value?.ToString() ?? "";

                if (modal.ShowDialog() == DialogResult.OK)
                {
                    Koneksi.CRUD($"SELECT id_jurusan FROM jurusan WHERE nama_jurusan='{modal.NamaJurusan}'");
                    if (Koneksi.ds.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("Jurusan tidak ditemukan!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    string idJurusan = Koneksi.ds.Tables[0].Rows[0]["id_jurusan"].ToString();
                    Koneksi.CRUD($"UPDATE kelas SET nama_kelas='{modal.NamaKelas}', tingkat='{modal.Tingkat}', id_jurusan='{idJurusan}' WHERE id_kelas='{idKelas}'");
                    MessageBox.Show("Data berhasil diupdate!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FMaster.CatatAktivitas($"Edit kelas: {modal.NamaKelas}");
                    Bersih();
                    TampilData("");
                    idKelas = "";
                    btnEdit.Enabled  = false;
                    btnHapus.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengupdate data kelas.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (idKelas == "")
            {
                MessageBox.Show("Pilih data terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Yakin ingin menghapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Koneksi.CRUD($"DELETE FROM kelas WHERE id_kelas='{idKelas}'");
                    MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FMaster.CatatAktivitas("Hapus data kelas");
                    Bersih();
                    TampilData("");
                    idKelas = "";
                    btnEdit.Enabled  = false;
                    btnHapus.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus data kelas.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
