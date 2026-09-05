using System;
using System.Windows.Forms;

namespace app_prakerin
{
    public partial class FormCRUDJurusan : Form
    {
        public string KodeJurusan = "";
        public string NamaJurusan = "";
        public string Judul = "Tambah Data Jurusan";

        public FormCRUDJurusan()
        {
            InitializeComponent();
        }

        private void FormCRUDJurusan_Load(object sender, EventArgs e)
        {
            lblJudul.Text = Judul;
            TXTKode.Text = KodeJurusan;
            TXTNama.Text = NamaJurusan;

            //Pindah
            Helper.Pindah(TXTKode, TXTNama);
        }

        private void BTNSimpan_Click(object sender, EventArgs e)
        {
            if (TXTNama.Text.Trim() == "")
            {
                MessageBox.Show("Masukan Data yang Lengkap!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            KodeJurusan = TXTKode.Text.Trim();
            NamaJurusan = TXTNama.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BTNBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
