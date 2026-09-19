using System;
using System.Data;
using System.Windows.Forms;
using app_prakerin.Config;

namespace app_prakerin
{
    public partial class FPenilaian : Form
    {
        string idPenilaian = "";

        public FPenilaian()
        {
            InitializeComponent();
        }

        private void FPenilaian_Load(object sender, EventArgs e)
        {
            try
            {
                btnEdit.Enabled = false;
                btnHapus.Enabled = false;
                TampilData("");
                DGVPenilaian.Columns["Column2"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data penilaian.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void TampilData(string CariApa)
        {
            try
            {
                DGVPenilaian.Rows.Clear();

                Koneksi.CRUD($"SELECT * FROM penilaian WHERE id_penilaian LIKE '%{CariApa}%' OR id_prakerin LIKE '%{CariApa}%' OR nilai_akhir LIKE '%{CariApa}%' OR catatan LIKE '%{CariApa}%'");

                int no = 1;

                foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
                {
                    DGVPenilaian.Rows.Add(
                        no,
                        row["id_penilaian"],
                        row["id_prakerin"],
                        row["disiplin"],
                        row["kerjasama"],
                        row["tanggung_jawab"],
                        row["inisiatif"],
                        row["keahlian"],
                        row["nilai_akhir"],
                        row["catatan"]
                    );

                    no++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data penilaian.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Bersih()
        {
        }

        public void AmbilData(string idpen)
        {
            try
            {
                Koneksi.CRUD($"SELECT * FROM penilaian WHERE id_penilaian = '{idpen}'");

                foreach (DataRow item in Koneksi.ds.Tables[0].Rows)
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data penilaian.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DGVPenilaian_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                idPenilaian = DGVPenilaian.Rows[e.RowIndex].Cells["Column2"].Value?.ToString() ?? "";

                if (!string.IsNullOrEmpty(idPenilaian))
                {
                    AmbilData(idPenilaian);
                    btnEdit.Enabled = true;
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
                FormCRUDPenilaian modal = new FormCRUDPenilaian();
                modal.Judul = "Tambah Data Penilaian";

                if (modal.ShowDialog() == DialogResult.OK)
                {
                    Koneksi.CRUD($"INSERT INTO penilaian (id_prakerin, disiplin, kerjasama, tanggung_jawab, inisiatif, keahlian, nilai_akhir, catatan) VALUES('{modal.IdPrakerin}','{modal.Disiplin}','{modal.Kerjasama}','{modal.TanggungJawab}','{modal.Inisiatif}','{modal.Keahlian}','{modal.NilaiAkhir}','{modal.Catatan}')");
                    MessageBox.Show("Data berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FMaster.CatatAktivitas($"Tambah penilaian: {modal.IdPrakerin}");
                    TampilData("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan data penilaian.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (idPenilaian == "")
            {
                MessageBox.Show("Pilih data terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                FormCRUDPenilaian modal = new FormCRUDPenilaian();
                modal.Judul = "Edit Data Penilaian";

                Koneksi.CRUD($"SELECT * FROM penilaian WHERE id_penilaian='{idPenilaian}'");

                if (Koneksi.ds.Tables[0].Rows.Count > 0)
                {
                    DataRow row = Koneksi.ds.Tables[0].Rows[0];

                    modal.IdPrakerin = row["id_prakerin"].ToString();
                    modal.Disiplin = row["disiplin"].ToString();
                    modal.Kerjasama = row["kerjasama"].ToString();
                    modal.TanggungJawab = row["tanggung_jawab"].ToString();
                    modal.Inisiatif = row["inisiatif"].ToString();
                    modal.Keahlian = row["keahlian"].ToString();
                    modal.NilaiAkhir = row["nilai_akhir"].ToString();
                    modal.Catatan = row["catatan"].ToString();
                }

                if (modal.ShowDialog() == DialogResult.OK)
                {
                    Koneksi.CRUD($"UPDATE penilaian SET id_prakerin='{modal.IdPrakerin}', disiplin='{modal.Disiplin}', kerjasama='{modal.Kerjasama}', tanggung_jawab='{modal.TanggungJawab}', inisiatif='{modal.Inisiatif}', keahlian='{modal.Keahlian}', nilai_akhir='{modal.NilaiAkhir}', catatan='{modal.Catatan}' WHERE id_penilaian='{idPenilaian}'");
                    MessageBox.Show("Data berhasil diupdate!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FMaster.CatatAktivitas($"Edit penilaian: {modal.IdPrakerin}");
                    Bersih();
                    TampilData("");
                    idPenilaian = "";
                    btnEdit.Enabled = false;
                    btnHapus.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengupdate data penilaian.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (idPenilaian == "")
            {
                MessageBox.Show("Pilih data terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Yakin ingin menghapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Koneksi.CRUD($"DELETE FROM penilaian WHERE id_penilaian='{idPenilaian}'");
                    MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FMaster.CatatAktivitas("Hapus data penilaian");
                    Bersih();
                    TampilData("");
                    idPenilaian = "";
                    btnEdit.Enabled = false;
                    btnHapus.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus data penilaian.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}