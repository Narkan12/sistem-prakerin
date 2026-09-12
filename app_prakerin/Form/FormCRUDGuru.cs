using System;
using System.Data;
using System.Windows.Forms;
using app_prakerin.Config;

namespace app_prakerin
{
    public partial class FormCRUDGuru : Form
    {
        public string Nama       = "";
        public string NIP        = "";
        public string NoHP       = "";
        public string Email      = "";
        public string IdPengguna = "";
        public string Judul      = "Tambah Data Guru";

        public FormCRUDGuru()
        {
            InitializeComponent();
        }

        private void FormCRUDGuru_Load(object sender, EventArgs e)
        {
            try
            {
                lblJudul.Text  = Judul;
                TXTNama.Text   = Nama;
                TXTNIP.Text    = NIP;
                TXTNoHP.Text   = NoHP;
                TXTEmail.Text  = Email;

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

                Helper.Pindah(TXTNama, TXTNIP, TXTNoHP, TXTEmail, CMBPengguna);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat form guru.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTNSimpan_Click(object sender, EventArgs e)
        {
            if (TXTNama.Text.Trim() == "" || CMBPengguna.SelectedIndex == -1)
            {
                MessageBox.Show("Masukan Data yang Lengkap!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                Nama       = TXTNama.Text.Trim();
                NIP        = TXTNIP.Text.Trim();
                NoHP       = TXTNoHP.Text.Trim();
                Email      = TXTEmail.Text.Trim();
                IdPengguna = CMBPengguna.Text.Split(' ')[0];
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data guru.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTNBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
