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
            TampilData("");
            DGVRole.Columns["ColIDJurnal"].Visible = false;
        }

        public void TampilData(string CariApa)
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
                DGVRole.Rows.Add(
                    no,
                    row["id_jurnal"],
                    row["id_prakerin"],
                    row["nama"],
                    Convert.ToDateTime(row["tanggal"]).ToString("yyyy-MM-dd"),
                    row["kegiatan"],
                    row["kendala"],
                    row["solusi"],
                    row["status_verifikasi"]
                );

                no++;
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
            Koneksi.CRUD($"SELECT * FROM jurnal_harian WHERE id_jurnal = '{ids}'");

            foreach (DataRow item in Koneksi.ds.Tables[0].Rows)
            {
                TXTIDPrakerin.Text = item["id_prakerin"].ToString();
                TXTKegiatan.Text = item["kegiatan"].ToString();
                TXTKendala.Text = item["kendala"].ToString();
                TXTSolusi.Text = item["solusi"].ToString();
            }
        }

        private void DGVRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            idJurnal = DGVRole.Rows[e.RowIndex].Cells["ColIDJurnal"].Value.ToString();

            AmbilData(idJurnal);
        }

        private void TXTSearch_TextChanged(object sender, EventArgs e)
        {
            TampilData(TXTSearch.Text);
        }

        private void BTNTambah_Click(object sender, EventArgs e)
        {
            FormCRUDJurnal modal = new FormCRUDJurnal();

            modal.Judul = "Tambah Data Jurnal";

            if (modal.ShowDialog() == DialogResult.OK)
            {
                
                Koneksi.CRUD($"INSERT INTO jurnal_harian (id_prakerin, tanggal, kegiatan, kendala, solusi, status_verifikasi) VALUES('{modal.IdPrakerin}','{modal.Tanggal}','{modal.Kegiatan}','{modal.Kendala}','{modal.Solusi}','{modal.StatusVerifikasi}')");
                MessageBox.Show("Data berhasil ditambahkan!");

                TampilData("");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (idJurnal == "")
            {
                MessageBox.Show("Pilih data terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int rowIdx = DGVRole.CurrentCell.RowIndex;

            FormCRUDJurnal modal = new FormCRUDJurnal();

            modal.Judul = "Edit Data Jurnal";

            Koneksi.CRUD($"SELECT * FROM jurnal_harian WHERE id_jurnal='{idJurnal}'");

            if (Koneksi.ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = Koneksi.ds.Tables[0].Rows[0];

                modal.IdPrakerin = row["id_prakerin"].ToString();
                modal.Tanggal = row["tanggal"].ToString();
                modal.Kegiatan = row["kegiatan"].ToString();
                modal.Kendala = row["kendala"].ToString();
                modal.Solusi = row["solusi"].ToString();
                modal.StatusVerifikasi = row["status_verifikasi"].ToString();
            }

            if (modal.ShowDialog() == DialogResult.OK)
            {
                Koneksi.CRUD($"UPDATE jurnal_harian SET id_prakerin='{modal.IdPrakerin}', tanggal='{modal.Tanggal}', kegiatan='{modal.Kegiatan}', kendala='{modal.Kendala}', solusi='{modal.Solusi}', status_verifikasi='{modal.StatusVerifikasi}' WHERE id_jurnal='{idJurnal}'");

                MessageBox.Show("Data berhasil diupdate!");
                Bersih();
                TampilData("");
                idJurnal = "";
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
                Koneksi.CRUD($"DELETE FROM jurnal_harian WHERE id_jurnal='{idJurnal}'");
                MessageBox.Show("Data berhasil dihapus!");

                Bersih();
                TampilData("");
                idJurnal = "";
            }
        }
    }
