using System;
using System.Windows.Forms;

namespace app_prakerin
{
    public partial class FormCRUDPerusahaan : Form
    {
        public string Nama = "";
        public string Alamat = "";
        public string NoTelp = "";
        public string Email = "";
        public string BidangUsaha = "";
        public string Judul = "Tambah Data Perusahaan";

        public FormCRUDPerusahaan()
        {
            InitializeComponent();
        }

        private void FormCRUDPerusahaan_Load(object sender, EventArgs e)
        {
            lblJudul.Text = Judul;
            TXTNama.Text = Nama;
            TXTAlamat.Text = Alamat;
            TXTNoTelp.Text = NoTelp;
            TXTEmail.Text = Email;
            TXTBidang.Text = BidangUsaha;

            Helper.Pindah(TXTNama, TXTAlamat, TXTNoTelp, TXTEmail, TXTBidang);
        }

        private void BTNSimpan_Click(object sender, EventArgs e)
        {
            if (TXTNama.Text.Trim() == "")
            {
                MessageBox.Show("Masukan Data yang Lengkap!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Nama = TXTNama.Text.Trim();
            Alamat = TXTAlamat.Text.Trim();
            NoTelp = TXTNoTelp.Text.Trim();
            Email = TXTEmail.Text.Trim();
            BidangUsaha = TXTBidang.Text.Trim();
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
