using System;
using System.Data;
using System.Windows.Forms;
using app_prakerin.Config;

namespace app_prakerin
{
    public partial class FJurusan : Form
    {
        string idJurusan = "";

        public FJurusan()
        {
            InitializeComponent();
        }

        private void FJurusan_Load(object sender, EventArgs e)
        {
            TampilData("");
            DGVJurusan.Columns["column2"].Visible = false;
        }

        public void TampilData(string CariApa)
        {
            DGVJurusan.Rows.Clear();
            Koneksi.CRUD($"SELECT * FROM jurusan WHERE nama_jurusan LIKE '%{CariApa}%' OR kode_jurusan LIKE '%{CariApa}%'");
            int no = 1;
            foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
            {
                DGVJurusan.Rows.Add(no, row["id_jurusan"], row["kode_jurusan"], row["nama_jurusan"]);
                no++;
            }
        }

        public void Bersih()
        {
            TXTKode.Clear();
            TXTNama.Clear();
        }

        public void AmbilData(string idj)
        {
            Koneksi.CRUD($"SELECT * FROM jurusan WHERE id_jurusan = '{idj}'");
            foreach (DataRow item in Koneksi.ds.Tables[0].Rows)
            {
                TXTKode.Text = item["kode_jurusan"].ToString();
                TXTNama.Text = item["nama_jurusan"].ToString();
            }
        }

        private void DGVJurusan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            idJurusan = DGVJurusan.Rows[e.RowIndex].Cells["column2"].Value.ToString();
            AmbilData(idJurusan);
        }

        private void TXTSearch_TextChanged(object sender, EventArgs e)
        {
            TampilData(TXTSearch.Text);
        }

        private void BTNTambah_Click(object sender, EventArgs e)
        {
            FormCRUDJurusan modal = new FormCRUDJurusan();
            modal.Judul = "Tambah Data Jurusan";

            if (modal.ShowDialog() == DialogResult.OK)
            {
                Koneksi.CRUD($"INSERT INTO jurusan VALUES(null,'{modal.KodeJurusan}','{modal.NamaJurusan}')");
                MessageBox.Show("Data berhasil ditambahkan!");
                TampilData("");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (idJurusan == "")
            {
                MessageBox.Show("Pilih data terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            FormCRUDJurusan modal = new FormCRUDJurusan();
            modal.Judul = "Edit Data Jurusan";
            modal.KodeJurusan = TXTKode.Text;
            modal.NamaJurusan = TXTNama.Text;

            if (modal.ShowDialog() == DialogResult.OK)
            {
                Koneksi.CRUD($"UPDATE jurusan SET kode_jurusan='{modal.KodeJurusan}', nama_jurusan='{modal.NamaJurusan}' WHERE id_jurusan='{idJurusan}'");
                MessageBox.Show("Data berhasil diupdate!");
                Bersih();
                TampilData("");
                idJurusan = "";
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (idJurusan == "")
            {
                MessageBox.Show("Pilih data terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageBox.Show("Yakin ingin menghapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Koneksi.CRUD($"DELETE FROM jurusan WHERE id_jurusan='{idJurusan}'");
                MessageBox.Show("Data berhasil dihapus!");
                Bersih();
                TampilData("");
                idJurusan = "";
            }
        }
    }
}
