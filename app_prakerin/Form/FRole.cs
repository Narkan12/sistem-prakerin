using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using app_prakerin.Config;

namespace app_prakerin
{
    public partial class FRole : Form
    {
        string idRole = "";

        public FRole()
        {
            InitializeComponent();
        }

        private void FRole_Load(object sender, EventArgs e)
        {
            TampilData("");
            DGVRole.Columns["Column2"].Visible = false;
        }

        public void TampilData(string CariApa)
        {
            DGVRole.Rows.Clear();
            Koneksi.CRUD($"SELECT * FROM role WHERE nama_role LIKE '%{CariApa}%'");
            int no = 1;
            foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
            {
                DGVRole.Rows.Add(no, row["id_role"], row["nama_role"], row["keterangan"]);
                no++;
            }
        }

        public void Bersih()
        {
            TXTNama.Clear();
            TXTKeterangan.Clear();
        }

        public void AmbilData(string idr)
        {
            Koneksi.CRUD($"SELECT * FROM role WHERE id_role = '{idr}'");
            foreach (DataRow item in Koneksi.ds.Tables[0].Rows)
            {
                TXTNama.Text = item["nama_role"].ToString();
                TXTKeterangan.Text = item["keterangan"].ToString();
            }
        }

        private void DGVRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            idRole = DGVRole.Rows[e.RowIndex].Cells["Column2"].Value.ToString();
            AmbilData(idRole);
        }

        private void TXTSearch_TextChanged(object sender, EventArgs e)
        {
            TampilData(TXTSearch.Text);
        }

        private void BTNTambah_Click(object sender, EventArgs e)
        {
            FormCRUDDataRole modal = new FormCRUDDataRole();
            modal.Judul = "Tambah Data Role";

            if (modal.ShowDialog() == DialogResult.OK)
            {
                Koneksi.CRUD($"INSERT INTO role VALUES(null,'{modal.NamaRole}','{modal.Keterangan}')");
                MessageBox.Show("Data berhasil ditambahkan!");
                TampilData("");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (idRole == "")
            {
                MessageBox.Show("Pilih data terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            FormCRUDDataRole modal = new FormCRUDDataRole();
            modal.Judul = "Edit Data Role";
            modal.NamaRole = TXTNama.Text;
            modal.Keterangan = TXTKeterangan.Text;

            if (modal.ShowDialog() == DialogResult.OK)
            {
                Koneksi.CRUD($"UPDATE role SET nama_role='{modal.NamaRole}', keterangan='{modal.Keterangan}' WHERE id_role='{idRole}'");
                MessageBox.Show("Data berhasil diupdate!");
                Bersih();
                TampilData("");
                idRole = "";
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (idRole == "")
            {
                MessageBox.Show("Pilih data terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageBox.Show("Yakin ingin menghapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Koneksi.CRUD($"DELETE FROM role WHERE id_role='{idRole}'");
                MessageBox.Show("Data berhasil dihapus!");
                Bersih();
                TampilData("");
                idRole = "";
            }
        }
    }
}
