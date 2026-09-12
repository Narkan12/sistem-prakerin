using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using app_prakerin.Config;

namespace app_prakerin
{
    public partial class FMonitoring : Form
    {
        string idMonitoring = "";
        public FMonitoring()
        {
            InitializeComponent();
        }

        private void FMonitoring_Load(object sender, EventArgs e)
        {
            try
            {
                btnEdit.Enabled = false;
                btnHapus.Enabled = false;
                TampilData("");
                DGVRole.Columns["Column2"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data monitoring.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void TampilData(string CariApa)
        {
            try
            {
                DGVRole.Rows.Clear();

                Koneksi.CRUD($"SELECT * FROM monitoring WHERE id_monitoring LIKE '%{CariApa}%' OR id_prakerin LIKE '%{CariApa}%' OR id_guru LIKE '%{CariApa}%' OR tanggal LIKE '%{CariApa}%' OR catatan LIKE '%{CariApa}%'");

                int no = 1;

                foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
                {
                    Image foto = null;
                    string namaFoto = row["foto"].ToString();
                    if (!string.IsNullOrEmpty(namaFoto))
                    {
                        try
                        {
                            string pathFoto = Path.Combine(Application.StartupPath, "Images", namaFoto);
                            if (File.Exists(pathFoto))
                            {
                                using (Image temp = Image.FromFile(pathFoto))
                                {
                                    foto = new Bitmap(temp);
                                }
                            }
                        }
                        catch
                        {
                            foto = null;
                        }
                    }

                    DGVRole.Rows.Add(
                        no,
                        row["id_monitoring"],
                        row["id_prakerin"],
                        row["id_guru"],
                        row["tanggal"],
                        row["catatan"],
                        foto
                    );

                    no++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data monitoring.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Bersih()
        {
        }

        public void AmbilData(string ids)
        {
            try
            {
                Koneksi.CRUD($"SELECT * FROM monitoring WHERE id_monitoring = '{ids}'");

                foreach (DataRow item in Koneksi.ds.Tables[0].Rows)
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data monitoring.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DGVRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                idMonitoring = DGVRole.Rows[e.RowIndex].Cells["Column2"].Value?.ToString() ?? "";

                if (!string.IsNullOrEmpty(idMonitoring))
                {
                    AmbilData(idMonitoring);
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
                FormCRUDMonitoring modal = new FormCRUDMonitoring();
                modal.Judul = "Tambah Data Monitoring";

                if (modal.ShowDialog() == DialogResult.OK)
                {
                    Koneksi.CRUD($"INSERT INTO monitoring (id_prakerin, id_guru, tanggal, catatan, foto) VALUES('{modal.IdPrakerin}','{modal.IdGuru}','{modal.Tanggal}','{modal.Catatan}','{modal.Foto}')");
                    MessageBox.Show("Data berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FMaster.CatatAktivitas($"Tambah monitoring: {modal.IdPrakerin}");

                    TampilData("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan data monitoring.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (idMonitoring == "")
            {
                MessageBox.Show("Pilih data terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                FormCRUDMonitoring modal = new FormCRUDMonitoring();
                modal.Judul = "Edit Data Monitoring";

                Koneksi.CRUD($"SELECT * FROM monitoring WHERE id_monitoring='{idMonitoring}'");

                if (Koneksi.ds.Tables[0].Rows.Count > 0)
                {
                    DataRow row = Koneksi.ds.Tables[0].Rows[0];

                    modal.IdMonitoring = row["id_monitoring"].ToString();
                    modal.IdPrakerin = row["id_prakerin"].ToString();
                    modal.IdGuru = row["id_guru"].ToString();
                    modal.Tanggal = row["tanggal"].ToString();
                    modal.Catatan = row["catatan"].ToString();
                    modal.Foto = row["foto"].ToString();
                }

                if (modal.ShowDialog() == DialogResult.OK)
                {
                    Koneksi.CRUD($"UPDATE monitoring SET id_prakerin='{modal.IdPrakerin}', id_guru='{modal.IdGuru}', tanggal='{modal.Tanggal}', catatan='{modal.Catatan}', foto='{modal.Foto}' WHERE id_monitoring='{idMonitoring}'");
                    MessageBox.Show("Data berhasil diupdate!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FMaster.CatatAktivitas($"Edit monitoring: {modal.IdPrakerin}");

                    Bersih();
                    TampilData("");

                    idMonitoring = "";
                    btnEdit.Enabled = false;
                    btnHapus.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengupdate data monitoring.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (idMonitoring == "")
            {
                MessageBox.Show("Pilih data terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Yakin ingin menghapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Koneksi.CRUD($"DELETE FROM monitoring WHERE id_monitoring='{idMonitoring}'");
                    MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FMaster.CatatAktivitas("Hapus data monitoring");
                    Bersih();
                    TampilData("");

                    idMonitoring = "";
                    btnEdit.Enabled = false;
                    btnHapus.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus data monitoring.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        
    }
}