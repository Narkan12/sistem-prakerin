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
            TampilData("");
            DGVRole.Columns["Column2"].Visible = false;
            DGVRole.Columns["Column3"].Visible = false;
            DGVRole.Columns["Column3a"].Visible = false;
        }

        public void TampilData(string CariApa)
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

        public void Bersih()
        {
            TXTNama.Clear();
            TXTJabatan.Clear();
            TXTNoHP.Clear();
            TXTEmail.Clear();
        }

        public void AmbilData(string idpe)
        {
            Koneksi.CRUD($"SELECT * FROM pembimbing WHERE id_pembimbing = '{idpe}'");
            foreach (DataRow item in Koneksi.ds.Tables[0].Rows)
            {
                TXTNama.Text = item["nama"].ToString();
                TXTJabatan.Text = item["jabatan"].ToString();
                TXTNoHP.Text = item["no_hp"].ToString();
                TXTEmail.Text = item["email"].ToString();
            }
        }

        private void DGVRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            idPembimbing = DGVRole.Rows[e.RowIndex].Cells["Column2"].Value.ToString();
            AmbilData(idPembimbing);
        }

        private void TXTSearch_TextChanged(object sender, EventArgs e)
        {
            TampilData(TXTSearch.Text);
        }

        private void BTNTambah_Click(object sender, EventArgs e)
        {
            FormCRUDPembimbing modal = new FormCRUDPembimbing();
            modal.Judul = "Tambah Data Pembimbing";

            if (modal.ShowDialog() == DialogResult.OK)
            {

                Koneksi.CRUD($"INSERT INTO pembimbing (id_pengguna, id_perusahaan, nama, jabatan, no_hp, email) VALUES('{modal.IdPengguna}', '{modal.IdPerusahaan}','{modal.Nama}','{modal.Jabatan}','{modal.NoHP}','{modal.Email}')");
                MessageBox.Show("Data berhasil ditambahkan!");
                TampilData("");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (idPembimbing == "")
            {
                MessageBox.Show("Pilih data terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int rowIdx = DGVRole.CurrentCell.RowIndex;
            FormCRUDPembimbing modal = new FormCRUDPembimbing();
            modal.Judul = "Edit Data Guru";
            modal.IdPengguna = DGVRole.Rows[rowIdx].Cells["Column3"].Value.ToString();
            modal.IdPerusahaan = DGVRole.Rows[rowIdx].Cells["Column3a"].Value.ToString();
            modal.Jabatan = TXTJabatan.Text;
            modal.Nama = TXTNama.Text;
            modal.NoHP = TXTNoHP.Text;
            modal.Email = TXTEmail.Text;

            if (modal.ShowDialog() == DialogResult.OK)
            {
                Koneksi.CRUD($"UPDATE pembimbing SET id_pengguna='{modal.IdPengguna}', id_perusahaan = '{modal.IdPerusahaan}', nama='{modal.Nama}', jabatan='{modal.Jabatan}', no_hp='{modal.NoHP}', email='{modal.Email}' WHERE id_pembimbing='{idPembimbing}'");
                MessageBox.Show("Data berhasil diupdate!");
                Bersih();
                TampilData("");
                idPembimbing = "";
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
                Koneksi.CRUD($"DELETE FROM pembimbing WHERE id_pembimbing='{idPembimbing}'");
                MessageBox.Show("Data berhasil dihapus!");
                Bersih();
                TampilData("");
                idPembimbing = "";
            }
        }
    }
}
