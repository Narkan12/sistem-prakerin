using System;
using System.Data;
using System.Windows.Forms;
using app_prakerin.Config;

namespace app_prakerin
{
    public partial class FPerusahaan : Form
    {
        string idPerusahaan = "";

        public FPerusahaan()
        {
            InitializeComponent();
        }

        private void FPerusahaan_Load(object sender, EventArgs e)
        {
            TampilData("");
            DGVRole.Columns["Column2"].Visible = false;
        }

        public void TampilData(string CariApa)
        {
            DGVRole.Rows.Clear();
            Koneksi.CRUD($"SELECT * FROM perusahaan WHERE nama LIKE '%{CariApa}%'");
            int no = 1;
            foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
            {
                DGVRole.Rows.Add(no, row["id_perusahaan"], row["nama"], row["alamat"], row["no_telp"], row["email"], row["bidang_usaha"]);
                no++;
            }
        }

        public void Bersih()
        {
            TXTNama.Clear();
            TXTAlamat.Clear();
            TXTNoTelp.Clear();
            TXTEmail.Clear();
            TXTBidang.Clear();
        }

        public void AmbilData(string idp)
        {
            Koneksi.CRUD($"SELECT * FROM perusahaan WHERE id_perusahaan = '{idp}'");
            foreach (DataRow item in Koneksi.ds.Tables[0].Rows)
            {
                TXTNama.Text = item["nama"].ToString();
                TXTAlamat.Text = item["alamat"].ToString();
                TXTNoTelp.Text = item["no_telp"].ToString();
                TXTEmail.Text = item["email"].ToString();
                TXTBidang.Text = item["bidang_usaha"].ToString();
            }
        }

        private void DGVRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            idPerusahaan = DGVRole.Rows[e.RowIndex].Cells["Column2"].Value.ToString();
            AmbilData(idPerusahaan);
        }

        private void TXTSearch_TextChanged(object sender, EventArgs e)
        {
            TampilData(TXTSearch.Text);
        }

        private void BTNTambah_Click(object sender, EventArgs e)
        {
            FormCRUDPerusahaan modal = new FormCRUDPerusahaan();
            modal.Judul = "Tambah Data Perusahaan";

            if (modal.ShowDialog() == DialogResult.OK)
            {
                Koneksi.CRUD($"INSERT INTO perusahaan (nama, alamat, no_telp, email, bidang_usaha) VALUES('{modal.Nama}','{modal.Alamat}','{modal.NoTelp}','{modal.Email}','{modal.BidangUsaha}')");
                MessageBox.Show("Data berhasil ditambahkan!");
                TampilData("");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (idPerusahaan == "")
            {
                MessageBox.Show("Pilih data terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            FormCRUDPerusahaan modal = new FormCRUDPerusahaan();
            modal.Judul = "Edit Data Perusahaan";
            modal.Nama = TXTNama.Text;
            modal.Alamat = TXTAlamat.Text;
            modal.NoTelp = TXTNoTelp.Text;
            modal.Email = TXTEmail.Text;
            modal.BidangUsaha = TXTBidang.Text;

            if (modal.ShowDialog() == DialogResult.OK)
            {
                Koneksi.CRUD($"UPDATE perusahaan SET nama='{modal.Nama}', alamat='{modal.Alamat}', no_telp='{modal.NoTelp}', email='{modal.Email}', bidang_usaha='{modal.BidangUsaha}' WHERE id_perusahaan='{idPerusahaan}'");
                MessageBox.Show("Data berhasil diupdate!");
                Bersih();
                TampilData("");
                idPerusahaan = "";
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (idPerusahaan == "")
            {
                MessageBox.Show("Pilih data terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageBox.Show("Yakin ingin menghapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Koneksi.CRUD($"DELETE FROM perusahaan WHERE id_perusahaan='{idPerusahaan}'");
                MessageBox.Show("Data berhasil dihapus!");
                Bersih();
                TampilData("");
                idPerusahaan = "";
            }
        }
    }
}
