using System;
using System.Data;
using System.Windows.Forms;
using app_prakerin.Config;
using System.IO;
using System.Drawing;

namespace app_prakerin
{
    public partial class FormCRUDSiswa : Form
    {
        public string NIS = "";
        public string Nama = "";
        public string Kelas = "";
        public string Jurusan = "";
        public string JenisKelamin = "";
        public string NoHP = "";
        public string Alamat = "";
        public string IdPengguna = "";
        public string Foto = "";
        public string Judul = "Tambah Data Siswa";

        public FormCRUDSiswa()
        {
            InitializeComponent();
        }

        private void FormCRUDSiswa_Load(object sender, EventArgs e)
        {
            lblJudul.Text = Judul;
            TXTNIS.Text = NIS;
            TXTNama.Text = Nama;
            TXTNoHP.Text = NoHP;
            TXTAlamat.Text = Alamat;

            CMBJK.Items.Clear();
            CMBJK.Items.Add("L");
            CMBJK.Items.Add("P");
            CMBJK.Text = JenisKelamin;

            Koneksi.CRUD("SELECT nama_kelas FROM kelas");
            CMBKelas.Items.Clear();
            foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
                CMBKelas.Items.Add(row["nama_kelas"].ToString());
            CMBKelas.Text = Kelas;

            Koneksi.CRUD("SELECT nama_jurusan FROM jurusan");
            CMBJurusan.Items.Clear();
            foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
                CMBJurusan.Items.Add(row["nama_jurusan"].ToString());
            CMBJurusan.Text = Jurusan;

            Koneksi.CRUD("SELECT id_pengguna, username FROM pengguna");
            CMBPengguna.Items.Clear();
            foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
                CMBPengguna.Items.Add(row["id_pengguna"] + " - " + row["username"]);

            if (!string.IsNullOrEmpty(IdPengguna))
            {
                foreach (object item in CMBPengguna.Items)
                {
                    if (item.ToString().StartsWith(IdPengguna + " - "))
                    {
                        CMBPengguna.Text = item.ToString();
                        break;
                    }
                }
            }

            if (!string.IsNullOrEmpty(Foto))
            {
                string pathFoto = Path.Combine(Application.StartupPath, "Images", Foto);

                if (File.Exists(pathFoto))
                {
                    PBSiswa.Image = Image.FromFile(pathFoto);
                    TXTFoto.Text = Foto;
                }
            }

            //Pindah
            Helper.Pindah(TXTNIS, TXTNama, CMBKelas, CMBJurusan, CMBJK, TXTNoHP, TXTAlamat, CMBPengguna);
        }

        private void BTNSimpan_Click(object sender, EventArgs e)
        {
            if (TXTNIS.Text.Trim() == "" || TXTNama.Text.Trim() == "" || CMBPengguna.SelectedIndex == -1 || PBSiswa.Image == null)
            {
                MessageBox.Show("Masukan Data yang Lengkap!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            NIS = TXTNIS.Text.Trim();
            Nama = TXTNama.Text.Trim();
            Kelas = CMBKelas.Text;
            Jurusan = CMBJurusan.Text;
            JenisKelamin = CMBJK.Text;
            NoHP = TXTNoHP.Text.Trim();
            Alamat = TXTAlamat.Text.Trim();
            IdPengguna = CMBPengguna.Text.Split(' ')[0];
            Foto = TXTFoto.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BTNBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BTNUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Pilih Foto";
                openFileDialog.Filter = "File Gambar|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string folderImages = Path.Combine(Application.StartupPath, "Images");
                    if (!Directory.Exists(folderImages))
                    {
                        Directory.CreateDirectory(folderImages);
                    }
                    string namaFile = Path.GetFileName(openFileDialog.FileName);
                    string tujuan = Path.Combine(folderImages, namaFile);

                    File.Copy(openFileDialog.FileName, tujuan, true);

                    PBSiswa.Image = Image.FromFile(tujuan);
                    TXTFoto.Text = namaFile;
                }
            }
        }
    }
}
