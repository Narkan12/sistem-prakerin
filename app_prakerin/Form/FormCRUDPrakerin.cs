using System;
using System.Data;
using System.Windows.Forms;
using app_prakerin.Config;

namespace app_prakerin
{
    public partial class FormCRUDPrakerin : Form
    {
        public string IdSiswa = "";
        public string IdGuru = "";
        public string IdPerusahaan = "";
        public string IdPembimbing = "";
        public string NamaSiswa = "";
        public string NamaGuru = "";
        public string NamaPerusahaan = "";
        public string NamaPembimbing = "";
        public DateTime TanggalMulai = DateTime.Now;
        public DateTime TanggalSelesai = DateTime.Now;
        public string Status = "";
        public string Judul = "Tambah Data Prakerin";

        public FormCRUDPrakerin()
        {
            InitializeComponent();
        }

        private void FormCRUDPrakerin_Load_1(object sender, EventArgs e)
        {
            lblJudul.Text = Judul;

            Koneksi.CRUD("SELECT id_siswa, nama FROM siswa");
            CMBSiswa.Items.Clear();
            foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
                CMBSiswa.Items.Add(row["id_siswa"] + " - " + row["nama"]);


            Koneksi.CRUD("SELECT id_guru, nama FROM guru");
            CMBGuru.Items.Clear();
            foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
                CMBGuru.Items.Add(row["id_guru"] + " - " + row["nama"]);


            Koneksi.CRUD("SELECT id_perusahaan, nama FROM perusahaan");
            CMBPerusahaan.Items.Clear();
            foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
                CMBPerusahaan.Items.Add(row["id_perusahaan"] + " - " + row["nama"]);


            Koneksi.CRUD("SELECT id_pembimbing, nama FROM pembimbing");
            CMBPembimbing.Items.Clear();
            foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
                CMBPembimbing.Items.Add(row["id_pembimbing"] + " - " + row["nama"]);

            CMBStatus.Items.Clear();
            CMBStatus.Items.Add("menunggu");
            CMBStatus.Items.Add("berlangsung");
            CMBStatus.Items.Add("selesai");


            if (!string.IsNullOrEmpty(IdSiswa))
            {
                foreach (object item in CMBSiswa.Items)
                {
                    if (item.ToString().StartsWith(IdSiswa + " - "))
                    {
                        CMBSiswa.Text = item.ToString();
                        break;
                    }
                }
            }


            if (!string.IsNullOrEmpty(IdGuru))
            {
                foreach (object item in CMBGuru.Items)
                {
                    if (item.ToString().StartsWith(IdGuru + " - "))
                    {
                        CMBGuru.Text = item.ToString();
                        break;
                    }
                }
            }


            if (!string.IsNullOrEmpty(IdPerusahaan))
            {
                foreach (object item in CMBPerusahaan.Items)
                {
                    if (item.ToString().StartsWith(IdPerusahaan + " - "))
                    {
                        CMBPerusahaan.Text = item.ToString();
                        break;
                    }
                }
            }


            if (!string.IsNullOrEmpty(IdPembimbing))
            {
                foreach (object item in CMBPembimbing.Items)
                {
                    if (item.ToString().StartsWith(IdPembimbing + " - "))
                    {
                        CMBPembimbing.Text = item.ToString();
                        break;
                    }
                }
            }

            DTMulai.Value = TanggalMulai;
            DTSelesai.Value = TanggalSelesai;
            CMBStatus.Text = Status;
        }


        private void BTNSimpan_Click(object sender, EventArgs e)
        {
            if (CMBSiswa.SelectedIndex == -1 || CMBGuru.SelectedIndex == -1 || CMBPerusahaan.SelectedIndex == -1 || CMBPembimbing.SelectedIndex == -1 || CMBStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Masukan Data yang Lengkap!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                );
                return;
            }


            IdSiswa = CMBSiswa.Text.Split('-')[0].Trim();
            IdGuru = CMBGuru.Text.Split('-')[0].Trim();
            IdPerusahaan = CMBPerusahaan.Text.Split('-')[0].Trim();
            IdPembimbing = CMBPembimbing.Text.Split('-')[0].Trim();

            NamaSiswa = CMBSiswa.Text.Split('-')[1].Trim();
            NamaGuru = CMBGuru.Text.Split('-')[1].Trim();
            NamaPerusahaan = CMBPerusahaan.Text.Split('-')[1].Trim();
            NamaPembimbing = CMBPembimbing.Text.Split('-')[1].Trim();

            TanggalMulai = DTMulai.Value;
            TanggalSelesai = DTSelesai.Value;
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