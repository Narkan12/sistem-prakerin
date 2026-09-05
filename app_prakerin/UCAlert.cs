using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_prakerin
{
    public partial class UCAlert : UserControl
    {
        public UCAlert()
        {
            InitializeComponent();
           
            
        }


        public void untukToast(string judul, string deskripsi, Image ikon)
        {
            LBLJudul.Text = judul;
            LBLDeskripsi.Text = deskripsi;
            PBIcon.Image = ikon;

            PNLBungkus.Visible = false;
            TAlert.Show(PNLBungkus);
        }

        private void TMRAlert_Tick(object sender, EventArgs e)
        {
            TMRAlert.Stop();
            this.Hide();

            

        }
    }
}
