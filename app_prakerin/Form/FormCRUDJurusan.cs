using System;
using System.Windows.Forms;

namespace app_prakerin
{
    public partial class FormCRUDJurusan : Form
    {
        public string KodeJurusan = "";
        public string NamaJurusan = "";
        public string Judul       = "Tambah Data Jurusan";

        public FormCRUDJurusan()
        {
            InitializeComponent();
        }

        private void FormCRUDJurusan_Load(object sender, EventArgs e)
        {
            try
            {
                lblJudul.Text = Judul;
                TXTKode.Text  = KodeJurusan;
                TXTNama.Text  = NamaJurusan;
                Helper.Pindah(TXTKode, TXTNama);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat form jurusan.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTNSimpan_Click(object sender, EventArgs e)
        {
            if (TXTNama.Text.Trim() == "")
            {
                MessageBox.Show("Masukan Data yang Lengkap!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                KodeJurusan = TXTKode.Text.Trim();
                NamaJurusan = TXTNama.Text.Trim();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data jurusan.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTNBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
