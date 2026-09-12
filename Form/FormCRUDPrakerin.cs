using System;
using System.Data;
using System.Windows.Forms;
using app_prakerin.Config;

namespace app_prakerin
{
    public partial class FormCRUDPrakerin : Form
    {
        public string   IdSiswa        = "";
        public string   IdGuru         = "";
        public string   IdPerusahaan   = "";
        public string   IdPembimbing   = "";
        public string   NamaSiswa      = "";
        public string   NamaGuru       = "";
        public string   NamaPerusahaan = "";
        public string   NamaPembimbing = "";
        public DateTime TanggalMulai   = DateTime.Now;
        public DateTime TanggalSelesai = DateTime.Now;
        public string   Status         = "";
        public string   Judul          = "Tambah Data Prakerin";

        public FormCRUDPrakerin()
        {
            InitializeComponent();
        }

        private void FormCRUDPrakerin_Load_1(object sender, EventArgs e)
        {
            try
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

                // Pre-select item jika mode edit
                PilihItem(CMBSiswa,      IdSiswa);
                PilihItem(CMBGuru,       IdGuru);
                PilihItem(CMBPerusahaan, IdPerusahaan);
                PilihItem(CMBPembimbing, IdPembimbing);

                DTMulai.Value   = TanggalMulai;
                DTSelesai.Value = TanggalSelesai;
                CMBStatus.Text  = Status;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat form prakerin.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PilihItem(ComboBox cmb, string id)
        {
            if (string.IsNullOrEmpty(id)) return;
            foreach (object item in cmb.Items)
            {
                if (item.ToString().StartsWith(id + " - "))
                {
                    cmb.Text = item.ToString();
                    break;
                }
            }
        }

        private void BTNSimpan_Click(object sender, EventArgs e)
        {
            if (CMBSiswa.SelectedIndex == -1 || CMBGuru.SelectedIndex == -1 ||
                CMBPerusahaan.SelectedIndex == -1 || CMBPembimbing.SelectedIndex == -1 ||
                CMBStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Masukan Data yang Lengkap!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                string[] siswaArr      = CMBSiswa.Text.Split('-');
                string[] guruArr       = CMBGuru.Text.Split('-');
                string[] perusahaanArr = CMBPerusahaan.Text.Split('-');
                string[] pembimbingArr = CMBPembimbing.Text.Split('-');

                if (siswaArr.Length < 2 || guruArr.Length < 2 ||
                    perusahaanArr.Length < 2 || pembimbingArr.Length < 2)
                {
                    MessageBox.Show("Pilihan data tidak valid. Silakan pilih ulang.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                IdSiswa        = siswaArr[0].Trim();
                IdGuru         = guruArr[0].Trim();
                IdPerusahaan   = perusahaanArr[0].Trim();
                IdPembimbing   = pembimbingArr[0].Trim();

                NamaSiswa      = siswaArr[1].Trim();
                NamaGuru       = guruArr[1].Trim();
                NamaPerusahaan = perusahaanArr[1].Trim();
                NamaPembimbing = pembimbingArr[1].Trim();

                TanggalMulai   = DTMulai.Value;
                TanggalSelesai = DTSelesai.Value;
                Status         = CMBStatus.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data prakerin.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTNBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
