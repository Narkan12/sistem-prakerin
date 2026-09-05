using System;
using System.Data;
using System.Windows.Forms;
using app_prakerin.Config;

namespace app_prakerin
{
    public partial class FormCRUDPengguna : Form
    {
        public string Username = "";
        public string Password = "";
        public string Role = "";
        public string Status = "";
        public string Judul = "Tambah Data Pengguna";

        public FormCRUDPengguna()
        {
            InitializeComponent();
        }

        private void FormCRUDPengguna_Load(object sender, EventArgs e)
        {
            lblJudul.Text = Judul;
            TXTUsername.Text = Username;

            Koneksi.CRUD("SELECT nama_role FROM role");
            CMBRole.Items.Clear();

            foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
            {
                CMBRole.Items.Add(row["nama_role"].ToString());
            }

            CMBStatus.Items.Clear();
            CMBStatus.Items.Add("Aktif");
            CMBStatus.Items.Add("Nonaktif");

            CMBRole.Text = Role;
            CMBStatus.Text = Status;

            //Pindah
            Helper.Pindah(TXTUsername, TXTPassword, CMBRole, CMBStatus);
        }

        private void BTNSimpan_Click(object sender, EventArgs e)
        {
            if (TXTUsername.Text.Trim() == "" || CMBRole.SelectedIndex == -1 || CMBStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Masukan Data yang Lengkap!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Username = TXTUsername.Text.Trim();
            Password = TXTPassword.Text.Trim();
            Role = CMBRole.Text;
            Status = CMBStatus.Text;
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
