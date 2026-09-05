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

            //untuk lokasi alert
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

            Koneksi.CRUD($"SELECT * FROM pengguna WHERE username = '{TXTUsername.Text}' && password = MD5('{TXTPassword.Text}')");
            int cekbaris = Koneksi.ds.Tables[0].Rows.Count;


             if (TXTUsername.Text == "" && TXTPassword.Text == "")
             {

                Toast.untukToast("Data tidak lengkap!", "harap masukan data secara lengkap", Properties.Resources.Error_48px);
                PNLAlert.Controls.Add(Toast);
             }

            if (cekbaris == 0)
            {
                Toast.untukToast("Login gagal!", "password atau username salah", Properties.Resources.Unavailable_48px);
                PNLAlert.Controls.Add(Toast);
                return;

            }

            DataRow row = Koneksi.ds.Tables[0].Rows[0];
            string status = row["status"].ToString().Trim();

            if (status == "Nonaktif")
            {
                Toast.untukToast("Tidak dapat login!", "User sedang nonaktif.", Properties.Resources.Info_48px);
                PNLAlert.Controls.Add(Toast);
                return;
            }

            Toast.untukToast("Login berhasil!", "Diarahkan ke halaman utama.", Properties.Resources.Ok_48px);
            PNLAlert.Controls.Add(Toast);

            TRedirect.Interval = 4500;
            TRedirect.Start();

            
        }

        private void TRedirect_Tick(object sender, EventArgs e)
        {
            UCAlert Toast = new UCAlert();
            TRedirect.Stop();

            DataRow row = Koneksi.ds.Tables[0].Rows[0];
            string DataId = row["id_pengguna"].ToString();
            string DataUsername = row["username"].ToString();
            string DataRole = row["role"].ToString();
            string DataStatus = row["status"].ToString();

                FMaster FD = new FMaster();
                FD.ID = DataId;
                FD.Username = DataUsername;
                FD.Role = DataRole;
                FD.Status = DataStatus;
                FD.Show();
                this.Hide();
          

           
        }
    }
}
