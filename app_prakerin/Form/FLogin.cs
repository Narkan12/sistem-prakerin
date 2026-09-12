using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app_prakerin.Config;

namespace app_prakerin
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void FLogin_Resize(object sender, EventArgs e)
        {
            int X = (this.ClientSize.Width - PNLParent.Width) / 2;
            int Y = (this.ClientSize.Height - PNLParent.Height) / 2;
            PNLParent.Location = new Point(X, Y);

            PNLAlert.Location = new Point(this.ClientSize.Width - PNLAlert.Width, 20);
        }

        private void FLogin_Load(object sender, EventArgs e)
        {
            PNLParent.Visible = false;
            TForm.Show(PNLParent);
        }

        private void TXTPassword_IconRightClick(object sender, EventArgs e)
        {
            if (TXTPassword.UseSystemPasswordChar)
            {
                TXTPassword.UseSystemPasswordChar = false;
                TXTPassword.IconRight = Properties.Resources.Eye_50px;
            }
            else
            {
                TXTPassword.UseSystemPasswordChar = true;
                TXTPassword.IconRight = Properties.Resources.Invisible_64px;
            }
        }

        private void BTNMasuk_Click(object sender, EventArgs e)
        {
            UCAlert Toast = new UCAlert();

            if (string.IsNullOrWhiteSpace(TXTUsername.Text) && string.IsNullOrWhiteSpace(TXTPassword.Text))
            {
                Toast.untukToast("Data tidak lengkap!", "Harap masukan username dan password.", Properties.Resources.Error_48px);
                PNLAlert.Controls.Add(Toast);
                return;
            }

            if (string.IsNullOrWhiteSpace(TXTUsername.Text))
            {
                Toast.untukToast("Data tidak lengkap!", "Harap masukan username.", Properties.Resources.Error_48px);
                PNLAlert.Controls.Add(Toast);
                return;
            }

            if (string.IsNullOrWhiteSpace(TXTPassword.Text))
            {
                Toast.untukToast("Data tidak lengkap!", "Harap masukan password.", Properties.Resources.Error_48px);
                PNLAlert.Controls.Add(Toast);
                return;
            }

            try
            {
                Koneksi.CRUD($"SELECT * FROM pengguna WHERE username = '{TXTUsername.Text}' && password = MD5('{TXTPassword.Text}')");
                int cekbaris = Koneksi.ds.Tables[0].Rows.Count;

                if (cekbaris == 0)
                {
                    Toast.untukToast("Login gagal!", "Password atau username salah.", Properties.Resources.Unavailable_48px);
                    PNLAlert.Controls.Add(Toast);
                    return;
                }

                DataRow row = Koneksi.ds.Tables[0].Rows[0];
                string status = row["status"].ToString().Trim();

                if (status == "Nonaktif")
                {
                    Toast.untukToast("Tidak dapat login!", "Akun Anda sedang nonaktif.", Properties.Resources.Info_48px);
                    PNLAlert.Controls.Add(Toast);
                    return;
                }

                Toast.untukToast("Login berhasil!", "Diarahkan ke halaman utama.", Properties.Resources.Ok_48px);
                PNLAlert.Controls.Add(Toast);

                TRedirect.Interval = 4500;
                TRedirect.Start();
            }
            catch (Exception ex)
            {
                Toast.untukToast("Gagal terhubung!", "Tidak dapat mengakses database. Coba lagi.", Properties.Resources.Error_48px);
                PNLAlert.Controls.Add(Toast);
                Console.WriteLine("Login error: " + ex.Message);
            }
        }

        private void TRedirect_Tick(object sender, EventArgs e)
        {
            TRedirect.Stop();

            try
            {
                if (Koneksi.ds.Tables.Count == 0 || Koneksi.ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Sesi login tidak ditemukan. Silakan login kembali.",
                        "Peringatan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    this.Show();
                    return;
                }

                DataRow row    = Koneksi.ds.Tables[0].Rows[0];
                string DataId       = row["id_pengguna"].ToString();
                string DataUsername = row["username"].ToString();
                string DataRole     = row["role"].ToString();
                string DataStatus   = row["status"].ToString();

                FMaster FD = new FMaster();
                FD.ID       = DataId;
                FD.Username = DataUsername;
                FD.Role     = DataRole;
                FD.Status   = DataStatus;
                FD.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal membuka halaman utama. Silakan login kembali.\n\nDetail: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                this.Show();
            }
        }
    }
}
