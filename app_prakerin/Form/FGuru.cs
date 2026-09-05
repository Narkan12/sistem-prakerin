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
            TampilData("");
            DGVRole.Columns["Column2"].Visible = false;
            DGVRole.Columns["Column3"].Visible = false;
        }

        public void TampilData(string CariApa)
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

        public void Bersih()
        {
            TXTNama.Clear();
            TXTKeterangan.Clear();
            TXTNoHP.Clear();
            TXTEmail.Clear();
        }

        public void AmbilData(string idg)
        {
            Koneksi.CRUD($"SELECT * FROM guru WHERE id_guru = '{idg}'");
            foreach (DataRow item in Koneksi.ds.Tables[0].Rows)
            {
                TXTNama.Text = item["nama"].ToString();
                TXTKeterangan.Text = item["nip"].ToString();
                TXTNoHP.Text = item["no_hp"].ToString();
                TXTEmail.Text = item["email"].ToString();
            }
        }

        private void DGVRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            idGuru = DGVRole.Rows[e.RowIndex].Cells["Column2"].Value.ToString();
            AmbilData(idGuru);
        }

        private void TXTSearch_TextChanged(object sender, EventArgs e)
        {
            TampilData(TXTSearch.Text);
        }

        private void BTNTambah_Click(object sender, EventArgs e)
        {
            FormCRUDGuru modal = new FormCRUDGuru();
            modal.Judul = "Tambah Data Guru";

            if (modal.ShowDialog() == DialogResult.OK)
            {
                Koneksi.CRUD($"INSERT INTO guru (id_pengguna, nip, nama, no_hp, email) VALUES('{modal.IdPengguna}','{modal.NIP}','{modal.Nama}','{modal.NoHP}','{modal.Email}')");
                MessageBox.Show("Data berhasil ditambahkan!");
                TampilData("");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (idGuru == "")
            {
                MessageBox.Show("Pilih data terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int rowIdx = DGVRole.CurrentCell.RowIndex;
            FormCRUDGuru modal = new FormCRUDGuru();
            modal.Judul = "Edit Data Guru";
            modal.IdPengguna = DGVRole.Rows[rowIdx].Cells["Column3"].Value.ToString();
            modal.NIP = TXTKeterangan.Text;
            modal.Nama = TXTNama.Text;
            modal.NoHP = TXTNoHP.Text;
            modal.Email = TXTEmail.Text;

            if (modal.ShowDialog() == DialogResult.OK)
            {
                Koneksi.CRUD($"UPDATE guru SET id_pengguna='{modal.IdPengguna}', nip='{modal.NIP}', nama='{modal.Nama}', no_hp='{modal.NoHP}', email='{modal.Email}' WHERE id_guru='{idGuru}'");
                MessageBox.Show("Data berhasil diupdate!");
                Bersih();
                TampilData("");
                idGuru = "";
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
                Koneksi.CRUD($"DELETE FROM guru WHERE id_guru='{idGuru}'");
                MessageBox.Show("Data berhasil dihapus!");
                Bersih();
                TampilData("");
                idGuru = "";
            }
        }
    }
}
