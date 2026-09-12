using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using app_prakerin.Config;

namespace app_prakerin
{
    public partial class FSiswa : Form
    {
        string idSiswa = "";

        public FSiswa()
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
                MessageBox.Show("Gagal memuat data siswa.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void TampilData(string CariApa)
        {
            try
            {
                DGVRole.Rows.Clear();
                Koneksi.CRUD($"SELECT * FROM siswa WHERE nama LIKE '%{CariApa}%' OR nis LIKE '%{CariApa}%'");

                int no = 1;
                foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
                {
                    Image foto = null;
                    string namaFoto = row["foto"].ToString();

                    if (!string.IsNullOrEmpty(namaFoto))
                    {
                        try
                        {
                            string pathFoto = Path.Combine(Application.StartupPath, "Images", namaFoto);
                            if (File.Exists(pathFoto))
                            {
                                using (Image temp = Image.FromFile(pathFoto))
                                {
                                    foto = new Bitmap(temp);
                                }
                            }
                        }
                        catch
                        {
                            foto = null;
                        }
                    }

                    DGVRole.Rows.Add(no, row["id_siswa"], row["id_pengguna"], foto,
                        row["nis"], row["nama"], row["kelas"], row["jurusan"],
                        row["jenis_kelamin"], row["no_hp"], row["alamat"]);
                    no++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data siswa.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Bersih()
        {
            TXTNIS.Clear();
            TXTNama.Clear();
            TXTNoHP.Clear();
            TXTAlamat.Clear();
        }

        public void AmbilData(string ids)
        {
            try
            {
                Koneksi.CRUD($"SELECT * FROM siswa WHERE id_siswa = '{ids}'");
                foreach (DataRow item in Koneksi.ds.Tables[0].Rows)
                {
                    TXTNIS.Text    = item["nis"].ToString();
                    TXTNama.Text   = item["nama"].ToString();
                    TXTNoHP.Text   = item["no_hp"].ToString();
                    TXTAlamat.Text = item["alamat"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data siswa.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DGVRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            try
            {
                idSiswa = DGVRole.Rows[e.RowIndex].Cells["Column2"].Value?.ToString() ?? "";
                if (!string.IsNullOrEmpty(idSiswa))
                {
                    AmbilData(idSiswa);
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
                FormCRUDSiswa modal = new FormCRUDSiswa();
                modal.Judul = "Tambah Data Siswa";

                if (modal.ShowDialog() == DialogResult.OK)
                {
                    Koneksi.CRUD($"INSERT INTO siswa (id_pengguna, foto, nis, nama, kelas, jurusan, jenis_kelamin, alamat, no_hp) VALUES('{modal.IdPengguna}','{modal.Foto}','{modal.NIS}','{modal.Nama}','{modal.Kelas}','{modal.Jurusan}','{modal.JenisKelamin}','{modal.Alamat}','{modal.NoHP}')");
                    MessageBox.Show("Data berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FMaster.CatatAktivitas($"Tambah siswa: {modal.Nama}");
                    TampilData("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan data siswa.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (idSiswa == "")
            {
                MessageBox.Show("Pilih data terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                FormCRUDSiswa modal = new FormCRUDSiswa();
                modal.Judul = "Edit Data Siswa";

                Koneksi.CRUD($"SELECT * FROM siswa WHERE id_siswa='{idSiswa}'");
                if (Koneksi.ds.Tables[0].Rows.Count > 0)
                {
                    DataRow row     = Koneksi.ds.Tables[0].Rows[0];
                    modal.IdPengguna  = row["id_pengguna"].ToString();
                    modal.Foto        = row["foto"].ToString();
                    modal.NIS         = row["nis"].ToString();
                    modal.Nama        = row["nama"].ToString();
                    modal.Kelas       = row["kelas"].ToString();
                    modal.Jurusan     = row["jurusan"].ToString();
                    modal.JenisKelamin = row["jenis_kelamin"].ToString();
                    modal.NoHP        = row["no_hp"].ToString();
                    modal.Alamat      = row["alamat"].ToString();
                }

                if (modal.ShowDialog() == DialogResult.OK)
                {
                    Koneksi.CRUD($"UPDATE siswa SET id_pengguna='{modal.IdPengguna}', foto='{modal.Foto}', nis='{modal.NIS}', nama='{modal.Nama}', kelas='{modal.Kelas}', jurusan='{modal.Jurusan}', jenis_kelamin='{modal.JenisKelamin}', alamat='{modal.Alamat}', no_hp='{modal.NoHP}' WHERE id_siswa='{idSiswa}'");
                    MessageBox.Show("Data berhasil diupdate!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FMaster.CatatAktivitas($"Edit siswa: {modal.Nama}");
                    Bersih();
                    TampilData("");
                    idSiswa = "";
                    btnEdit.Enabled  = false;
                    btnHapus.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengupdate data siswa.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (idSiswa == "")
            {
                MessageBox.Show("Pilih data terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Yakin ingin menghapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Koneksi.CRUD($"DELETE FROM siswa WHERE id_siswa='{idSiswa}'");
                    MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FMaster.CatatAktivitas("Hapus data siswa");
                    Bersih();
                    TampilData("");
                    idSiswa = "";
                    btnEdit.Enabled  = false;
                    btnHapus.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus data siswa.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void CMBJK_DropDown(object sender, EventArgs e)
        {
        }
    }
}
