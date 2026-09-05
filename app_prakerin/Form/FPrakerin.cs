using System;
using System.Data;
using System.Windows.Forms;
using app_prakerin.Config;

namespace app_prakerin
{
    public partial class FPrakerin : Form
    {
        string idPrakerin = "";

        public FPrakerin()
        {
            InitializeComponent();
        }

        private void FPrakerin_Load(object sender, EventArgs e)
        {
            TampilData("");
            DGVPrakerin.Columns["Column2"].Visible = false;
        }

        public void TampilData(string CariApa)
        {
            DGVPrakerin.Rows.Clear();

            Koneksi.CRUD($@"SELECT p.id_prakerin, s.nama AS nama_siswa, g.nama AS nama_guru, pe.nama AS nama_perusahaan, pb.nama AS nama_pembimbing, p.tanggal_mulai, p.tanggal_selesai, p.status 
                FROM prakerin p 
                INNER JOIN siswa s ON s.id_siswa = p.id_siswa 
                INNER JOIN guru g ON g.id_guru = p.id_guru 
                INNER JOIN perusahaan pe ON pe.id_perusahaan = p.id_perusahaan 
                INNER JOIN pembimbing pb ON pb.id_pembimbing = p.id_pembimbing 
                WHERE s.nama LIKE '%{CariApa}%' OR g.nama LIKE '%{CariApa}%' OR pe.nama LIKE '%{CariApa}%' OR pb.nama LIKE '%{CariApa}%' 
                ORDER BY p.id_prakerin DESC");

            int no = 1;
            foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
            {
                string mulai = row["tanggal_mulai"] != DBNull.Value ? Convert.ToDateTime(row["tanggal_mulai"]).ToString("dd/MM/yyyy") : "-";
                string selesai = row["tanggal_selesai"] != DBNull.Value ? Convert.ToDateTime(row["tanggal_selesai"]).ToString("dd/MM/yyyy") : "-";

                DGVPrakerin.Rows.Add(no, row["id_prakerin"], row["nama_siswa"], row["nama_guru"], row["nama_perusahaan"], row["nama_pembimbing"], mulai, selesai, row["status"]);
                no++;
            }
        }

        public void AmbilData(string id)
        {
            Koneksi.CRUD($@"SELECT p.*, s.nama AS nama_siswa, g.nama AS nama_guru, pe.nama AS nama_perusahaan, pb.nama AS nama_pembimbing 
                FROM prakerin p 
                INNER JOIN siswa s ON s.id_siswa = p.id_siswa 
                INNER JOIN guru g ON g.id_guru = p.id_guru 
                INNER JOIN perusahaan pe ON pe.id_perusahaan = p.id_perusahaan 
                INNER JOIN pembimbing pb ON pb.id_pembimbing = p.id_pembimbing 
                WHERE p.id_prakerin = '{id}'");
        }

        private void DGVPrakerin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            idPrakerin = DGVPrakerin.Rows[e.RowIndex].Cells["Column2"].Value.ToString();
            AmbilData(idPrakerin);
        }

        private void TXTSearch_TextChanged(object sender, EventArgs e)
        {
            TampilData(TXTSearch.Text);
        }

        private void BTNTambah_Click(object sender, EventArgs e)
        {
            FormCRUDPrakerin modal = new FormCRUDPrakerin { Judul = "Tambah Data Prakerin" };

            if (modal.ShowDialog() == DialogResult.OK)
            {

                Koneksi.CRUD($"SELECT id_siswa FROM siswa WHERE nama='{modal.NamaSiswa}'");
                if (Koneksi.ds.Tables[0].Rows.Count == 0) { MessageBox.Show("Data siswa tidak ditemukan!"); return; }
                string idSiswa = Koneksi.ds.Tables[0].Rows[0]["id_siswa"].ToString();

                Koneksi.CRUD($"SELECT id_guru FROM guru WHERE nama='{modal.NamaGuru}'");
                if (Koneksi.ds.Tables[0].Rows.Count == 0) { MessageBox.Show("Data guru tidak ditemukan!"); return; }
                string idGuru = Koneksi.ds.Tables[0].Rows[0]["id_guru"].ToString();

                Koneksi.CRUD($"SELECT id_perusahaan FROM perusahaan WHERE nama='{modal.NamaPerusahaan}'");
                if (Koneksi.ds.Tables[0].Rows.Count == 0) { MessageBox.Show("Data perusahaan tidak ditemukan!"); return; }
                string idPerusahaan = Koneksi.ds.Tables[0].Rows[0]["id_perusahaan"].ToString();

                Koneksi.CRUD($"SELECT id_pembimbing FROM pembimbing WHERE nama='{modal.NamaPembimbing}'");
                if (Koneksi.ds.Tables[0].Rows.Count == 0) { MessageBox.Show("Data pembimbing tidak ditemukan!"); return; }
                string idPembimbing = Koneksi.ds.Tables[0].Rows[0]["id_pembimbing"].ToString();

                Koneksi.CRUD($@"INSERT INTO prakerin (id_siswa, id_guru, id_perusahaan, id_pembimbing, tanggal_mulai, tanggal_selesai, status) 
                    VALUES ('{idSiswa}', '{idGuru}', '{idPerusahaan}', '{idPembimbing}', '{modal.TanggalMulai:yyyy-MM-dd}', '{modal.TanggalSelesai:yyyy-MM-dd}', '{modal.Status}')");

                MessageBox.Show("Data berhasil ditambahkan!");
                TampilData("");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idPrakerin))
            {
                MessageBox.Show("Pilih data terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Koneksi.CRUD($@"SELECT p.*, s.nama AS nama_siswa, g.nama AS nama_guru, pe.nama AS nama_perusahaan, pb.nama AS nama_pembimbing 
                FROM prakerin p 
                INNER JOIN siswa s ON s.id_siswa = p.id_siswa 
                INNER JOIN guru g ON g.id_guru = p.id_guru 
                INNER JOIN perusahaan pe ON pe.id_perusahaan = p.id_perusahaan 
                INNER JOIN pembimbing pb ON pb.id_pembimbing = p.id_pembimbing 
                WHERE p.id_prakerin = '{idPrakerin}'");

            if (Koneksi.ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Data tidak ditemukan!");
                return;
            }

            DataRow row = Koneksi.ds.Tables[0].Rows[0];
            FormCRUDPrakerin modal = new FormCRUDPrakerin
            {
                Judul = "Edit Data Prakerin",

                IdSiswa = row["id_siswa"].ToString(),
                IdGuru = row["id_guru"].ToString(),
                IdPerusahaan = row["id_perusahaan"].ToString(),
                IdPembimbing = row["id_pembimbing"].ToString(),

                NamaSiswa = row["nama_siswa"].ToString(),
                NamaGuru = row["nama_guru"].ToString(),
                NamaPerusahaan = row["nama_perusahaan"].ToString(),
                NamaPembimbing = row["nama_pembimbing"].ToString(),
                Status = row["status"].ToString()
            };

            if (row["tanggal_mulai"] != DBNull.Value) modal.TanggalMulai = Convert.ToDateTime(row["tanggal_mulai"]);
            if (row["tanggal_selesai"] != DBNull.Value) modal.TanggalSelesai = Convert.ToDateTime(row["tanggal_selesai"]);

            if (modal.ShowDialog() == DialogResult.OK)
            {
                Koneksi.CRUD($"SELECT id_siswa FROM siswa WHERE nama='{modal.NamaSiswa}'");
                string idSiswa = Koneksi.ds.Tables[0].Rows[0]["id_siswa"].ToString();

                Koneksi.CRUD($"SELECT id_guru FROM guru WHERE nama='{modal.NamaGuru}'");
                string idGuru = Koneksi.ds.Tables[0].Rows[0]["id_guru"].ToString();

                Koneksi.CRUD($"SELECT id_perusahaan FROM perusahaan WHERE nama='{modal.NamaPerusahaan}'");
                string idPerusahaan = Koneksi.ds.Tables[0].Rows[0]["id_perusahaan"].ToString();

                Koneksi.CRUD($"SELECT id_pembimbing FROM pembimbing WHERE nama='{modal.NamaPembimbing}'");
                string idPembimbing = Koneksi.ds.Tables[0].Rows[0]["id_pembimbing"].ToString();

                Koneksi.CRUD($@"UPDATE prakerin SET 
                    id_siswa='{idSiswa}', id_guru='{idGuru}', id_perusahaan='{idPerusahaan}', id_pembimbing='{idPembimbing}', 
                    tanggal_mulai='{modal.TanggalMulai:yyyy-MM-dd}', tanggal_selesai='{modal.TanggalSelesai:yyyy-MM-dd}', status='{modal.Status}' 
                    WHERE id_prakerin='{idPrakerin}'");

                MessageBox.Show("Data berhasil diupdate!");
                TampilData("");
                idPrakerin = "";
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idPrakerin))
            {
                MessageBox.Show("Pilih data terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Yakin ingin menghapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Koneksi.CRUD($"DELETE FROM prakerin WHERE id_prakerin='{idPrakerin}'");
                MessageBox.Show("Data berhasil dihapus!");
                TampilData("");
                idPrakerin = "";
            }
        }
    }
}