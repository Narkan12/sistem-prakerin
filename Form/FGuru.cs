using System;
using System.Data;
using System.Windows.Forms;
using app_prakerin.Config;

namespace app_prakerin
{
    public partial class FGuru : Form
    {
        string idGuru = "";

        public FGuru()
        {
            InitializeComponent();
        }

        private void FGuru_Load(object sender, EventArgs e)
        {
            try
            {
                btnEdit.Enabled  = false;
                btnHapus.Enabled = false;
                TampilData("");
                DGVRole.Columns["Column2"].Visible = false;
                DGVRole.Columns["Column3"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data guru.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void TampilData(string CariApa)
        {
            try
            {
                DGVRole.Rows.Clear();
                Koneksi.CRUD($"SELECT * FROM guru WHERE nama LIKE '%{CariApa}%' OR nip LIKE '%{CariApa}%'");
                int no = 1;
                foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
                {
                    DGVRole.Rows.Add(no, row["id_guru"], row["id_pengguna"], row["nip"], row["nama"], row["no_hp"], row["email"]);
                    no++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data guru.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Bersih()
        {
            TXTNama.Clear();
            TXTKeterangan.Clear();
            TXTNoHP.Clear();
            TXTEmail.Clear();
        }

        public void AmbilData(string idg)
        {
            try
            {
                Koneksi.CRUD($"SELECT * FROM guru WHERE id_guru = '{idg}'");
                foreach (DataRow item in Koneksi.ds.Tables[0].Rows)
                {
                    TXTNama.Text       = item["nama"].ToString();
                    TXTKeterangan.Text = item["nip"].ToString();
                    TXTNoHP.Text       = item["no_hp"].ToString();
                    TXTEmail.Text      = item["email"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data guru.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DGVRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            try
            {
                idGuru = DGVRole.Rows[e.RowIndex].Cells["Column2"].Value?.ToString() ?? "";
                if (!string.IsNullOrEmpty(idGuru))
                {
                    AmbilData(idGuru);
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
                FormCRUDGuru modal = new FormCRUDGuru();
                modal.Judul = "Tambah Data Guru";

                if (modal.ShowDialog() == DialogResult.OK)
                {
                    Koneksi.CRUD($"INSERT INTO guru (id_pengguna, nip, nama, no_hp, email) VALUES('{modal.IdPengguna}','{modal.NIP}','{modal.Nama}','{modal.NoHP}','{modal.Email}')");
                    MessageBox.Show("Data berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FMaster.CatatAktivitas($"Tambah guru: {modal.Nama}");
                    TampilData("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan data guru.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (idGuru == "")
            {
                MessageBox.Show("Pilih data terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                int rowIdx = DGVRole.CurrentCell.RowIndex;
                FormCRUDGuru modal = new FormCRUDGuru();
                modal.Judul      = "Edit Data Guru";
                modal.IdPengguna = DGVRole.Rows[rowIdx].Cells["Column3"].Value?.ToString() ?? "";
                modal.NIP        = TXTKeterangan.Text;
                modal.Nama       = TXTNama.Text;
                modal.NoHP       = TXTNoHP.Text;
                modal.Email      = TXTEmail.Text;

                if (modal.ShowDialog() == DialogResult.OK)
                {
                    Koneksi.CRUD($"UPDATE guru SET id_pengguna='{modal.IdPengguna}', nip='{modal.NIP}', nama='{modal.Nama}', no_hp='{modal.NoHP}', email='{modal.Email}' WHERE id_guru='{idGuru}'");
                    MessageBox.Show("Data berhasil diupdate!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FMaster.CatatAktivitas($"Edit guru: {modal.Nama}");
                    Bersih();
                    TampilData("");
                    idGuru = "";
                    btnEdit.Enabled  = false;
                    btnHapus.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengupdate data guru.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (idGuru == "")
            {
                MessageBox.Show("Pilih data terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Yakin ingin menghapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Koneksi.CRUD($"DELETE FROM guru WHERE id_guru='{idGuru}'");
                    MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FMaster.CatatAktivitas("Hapus data guru");
                    Bersih();
                    TampilData("");
                    idGuru = "";
                    btnEdit.Enabled  = false;
                    btnHapus.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus data guru.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
