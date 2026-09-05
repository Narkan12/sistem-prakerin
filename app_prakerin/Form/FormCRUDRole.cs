using System;
using System.Windows.Forms;

namespace app_prakerin
{
    public partial class FormCRUDDataRole : Form
    {
        public string NamaRole = "";
        public string Keterangan = "";
        public string Judul = "Tambah Data Role";

        public FormCRUDDataRole()
        {
            InitializeComponent();
        }

        private void FormCRUDDataRole_Load(object sender, EventArgs e)
        {
            lblJudul.Text = Judul;
            TXTNama.Text = NamaRole;
            TXTKeterangan.Text = Keterangan;

            Helper.Pindah(TXTNama, TXTKeterangan);
        }

        private void BTNSimpan_Click(object sender, EventArgs e)
        {
            if (TXTNama.Text.Trim() == "")
            {
                MessageBox.Show("Masukan Data yang Lengkap!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            NamaRole = TXTNama.Text.Trim();
            Keterangan = TXTKeterangan.Text.Trim();
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
