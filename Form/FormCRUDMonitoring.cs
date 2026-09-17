using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using app_prakerin.Config;

namespace app_prakerin
{
    public partial class FormCRUDMonitoring : Form
    {
        public string IdMonitoring = "";
        public string IdPrakerin = "";
        public string IdGuru = "";
        public string Tanggal = "";
        public string Catatan = "";
        public string Foto = "";
        public string Judul = "Tambah Data Monitoring";

        public FormCRUDMonitoring()
        {
            InitializeComponent();
        }

        private void FormCRUDMonitoring_Load(object sender, EventArgs e)
        {
            try
            {
                lblJudul.Text = Judul;
                Koneksi.CRUD("SELECT prakerin.id_prakerin, siswa.nama FROM prakerin INNER JOIN siswa ON siswa.id_siswa = prakerin.id_siswa;");
                CMBPrakerin.Items.Clear();

                foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
                    CMBPrakerin.Items.Add(row["id_prakerin"].ToString() + " - " + row["nama"].ToString());

                if (!string.IsNullOrEmpty(IdPrakerin))
                    CMBPrakerin.Text = IdPrakerin;

                Koneksi.CRUD("SELECT id_guru, nama FROM guru");
                CMBGuru.Items.Clear();
                foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
                    CMBGuru.Items.Add(row["id_guru"].ToString() + " - " + row["nama"].ToString());

                if (!string.IsNullOrEmpty(IdGuru))
                    CMBGuru.Text = IdGuru;

                if (!string.IsNullOrEmpty(Tanggal))
                {
                    DateTime tanggalMonitoring;

                    if (DateTime.TryParse(Tanggal, out tanggalMonitoring))
                        DTTanggal.Value = tanggalMonitoring;
                }

                TXTCatatan.Text = Catatan;

                if (!string.IsNullOrEmpty(Foto))
                {
                    try
                    {
                        string pathFoto = Path.Combine(
                            Application.StartupPath,
                            "Images",
                            Foto
                        );

                        if (File.Exists(pathFoto))
                        {
                            PBFoto.Image = Image.FromFile(pathFoto);
                            TXTFoto.Text = Foto;
                        }
                    }
                    catch
                    {
                        PBFoto.Image = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat form monitoring.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void BTNSimpan_Click(object sender, EventArgs e)
        {
            if (CMBPrakerin.SelectedIndex == -1 ||
                CMBGuru.SelectedIndex == -1 ||
                TXTCatatan.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Masukan Data yang Lengkap!",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );

                return;
            }

            try
            {
                IdPrakerin = CMBPrakerin.Text.Trim();
                IdGuru = CMBGuru.Text.Trim();
                Tanggal = DTTanggal.Value.ToString("yyyy-MM-dd");
                Catatan = TXTCatatan.Text.Trim();
                Foto = TXTFoto.Text.Trim();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menyimpan data monitoring.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void BTNBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BTNUpload_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Title = "Pilih Foto Monitoring";
                    openFileDialog.Filter = "File Gambar|*.jpg;*.jpeg;*.png;*.bmp";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string folderImages = Path.Combine(
                            Application.StartupPath,
                            "Images"
                        );

                        if (!Directory.Exists(folderImages))
                            Directory.CreateDirectory(folderImages);

                        string namaFile = Path.GetFileName(openFileDialog.FileName);
                        string tujuan = Path.Combine(folderImages, namaFile);

                        File.Copy(
                            openFileDialog.FileName,
                            tujuan,
                            true
                        );

                        PBFoto.Image = Image.FromFile(tujuan);
                        TXTFoto.Text = namaFile;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal mengupload foto.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
    }
}