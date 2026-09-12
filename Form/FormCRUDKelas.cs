using System;
using System.Data;
using System.Windows.Forms;
using app_prakerin.Config;

namespace app_prakerin
{
    public partial class FormCRUDKelas : Form
    {
        public string NamaKelas   = "";
        public string Tingkat     = "";
        public string NamaJurusan = "";
        public string Judul       = "Tambah Data Kelas";

        public FormCRUDKelas()
        {
            InitializeComponent();
        }

        private void FormCRUDKelas_Load(object sender, EventArgs e)
        {
            try
            {
                lblJudul.Text  = Judul;
                TXTNama.Text   = NamaKelas;
                TXTTingkat.Text = Tingkat;

                Koneksi.CRUD("SELECT nama_jurusan FROM jurusan");
                CMBJurusan.Items.Clear();
                foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
                    CMBJurusan.Items.Add(row["nama_jurusan"].ToString());

                CMBJurusan.Text = NamaJurusan;
                Helper.Pindah(TXTNama, TXTTingkat, CMBJurusan);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat form kelas.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTNSimpan_Click(object sender, EventArgs e)
        {
            if (TXTNama.Text.Trim() == "" || TXTTingkat.Text.Trim() == "" || CMBJurusan.SelectedIndex == -1)
            {
                MessageBox.Show("Masukan Data yang Lengkap!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                NamaKelas   = TXTNama.Text.Trim();
                Tingkat     = TXTTingkat.Text.Trim();
                NamaJurusan = CMBJurusan.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data kelas.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTNBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
