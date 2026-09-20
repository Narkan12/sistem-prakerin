using System;
using System.Data;
using System.Windows.Forms;
using app_prakerin.Config;

namespace app_prakerin
{
    public partial class FPembimbing : Form
    {
        string idPembimbing = "";

        public FPembimbing()
        {
            InitializeComponent();
        }

        private void FPembimbing_Load(object sender, EventArgs e)
        {
            try
            {
                btnEdit.Enabled  = false;
                btnHapus.Enabled = false;
                TampilData("");
                DGVRole.Columns["Column2"].Visible  = false;
                DGVRole.Columns["Column3"].Visible  = false;
                DGVRole.Columns["Column3a"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data pembimbing.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void TampilData(string CariApa)
        {
            try
            {
                DGVRole.Rows.Clear();
                Koneksi.CRUD($"SELECT * FROM pembimbing WHERE nama LIKE '%{CariApa}%'");
                int no = 1;
                foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
                {
                    DGVRole.Rows.Add(no, row["id_pembimbing"], row["id_pengguna"], row["id_perusahaan"], row["nama"], row["jabatan"], row["no_hp"], row["email"]);
                    no++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data pembimbing.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Bersih()
        {
            TXTNama.Clear();
            TXTJabatan.Clear();
            TXTNoHP.Clear();
            TXTEmail.Clear();
        }

        public void AmbilData(string idpe)
        {
            try
            {
                Koneksi.CRUD($"SELECT * FROM pembimbing WHERE id_pembimbing = '{idpe}'");
                foreach (DataRow item in Koneksi.ds.Tables[0].Rows)
                {
                    TXTNama.Text    = item["nama"].ToString();
                    TXTJabatan.Text = item["jabatan"].ToString();
                    TXTNoHP.Text    = item["no_hp"].ToString();
                    TXTEmail.Text   = item["email"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data pembimbing.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DGVRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            try
            {
                idPembimbing = DGVRole.Rows[e.RowIndex].Cells["Column2"].Value?.ToString() ?? "";
                if (!string.IsNullOrEmpty(idPembimbing))
                {
                    AmbilData(idPembimbing);
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
                FormCRUDPembimbing modal = new FormCRUDPembimbing();
                modal.Judul = "Tambah Data Pembimbing";

                if (modal.ShowDialog() == DialogResult.OK)
                {
                    Koneksi.CRUD($"INSERT INTO pembimbing (id_pengguna, id_perusahaan, nama, jabatan, no_hp, email) VALUES('{modal.IdPengguna}','{modal.IdPerusahaan}','{modal.Nama}','{modal.Jabatan}','{modal.NoHP}','{modal.Email}')");
                    MessageBox.Show("Data berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FMaster.CatatAktivitas($"Tambah pembimbing: {modal.Nama}");
                    TampilData("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan data pembimbing.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (idPembimbing == "")
            {
                MessageBox.Show("Pilih data terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                int rowIdx = DGVRole.CurrentCell.RowIndex;
                FormCRUDPembimbing modal = new FormCRUDPembimbing();
                modal.Judul       = "Edit Data Pembimbing";
                modal.IdPengguna  = DGVRole.Rows[rowIdx].Cells["Column3"].Value?.ToString() ?? "";
                modal.IdPerusahaan = DGVRole.Rows[rowIdx].Cells["Column3a"].Value?.ToString() ?? "";
                modal.Jabatan     = TXTJabatan.Text;
                modal.Nama        = TXTNama.Text;
                modal.NoHP        = TXTNoHP.Text;
                modal.Email       = TXTEmail.Text;

                if (modal.ShowDialog() == DialogResult.OK)
                {
                    Koneksi.CRUD($"UPDATE pembimbing SET id_pengguna='{modal.IdPengguna}', id_perusahaan='{modal.IdPerusahaan}', nama='{modal.Nama}', jabatan='{modal.Jabatan}', no_hp='{modal.NoHP}', email='{modal.Email}' WHERE id_pembimbing='{idPembimbing}'");
                    MessageBox.Show("Data berhasil diupdate!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FMaster.CatatAktivitas($"Edit pembimbing: {modal.Nama}");
                    Bersih();
                    TampilData("");
                    idPembimbing = "";
                    btnEdit.Enabled  = false;
                    btnHapus.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengupdate data pembimbing.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (idPembimbing == "")
            {
                MessageBox.Show("Pilih data terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Yakin ingin menghapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Koneksi.CRUD($"DELETE FROM pembimbing WHERE id_pembimbing='{idPembimbing}'");
                    MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FMaster.CatatAktivitas("Hapus data pembimbing");
                    Bersih();
                    TampilData("");
                    idPembimbing = "";
                    btnEdit.Enabled  = false;
                    btnHapus.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus data pembimbing.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            TampilData("");
            TXTSearch.Text = "";
            idPembimbing   = "";
            btnEdit.Enabled  = false;
            btnHapus.Enabled = false;
        }
    }
}
