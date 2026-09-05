using System;
using System.Data;
using System.Windows.Forms;
using app_prakerin.Config;

namespace app_prakerin
{
    public partial class FormCRUDJurnal : Form
    {
        public string IdPrakerin = "";
        public string Tanggal = "";
        public string Kegiatan = "";
        public string Kendala = "";
        public string Solusi = "";
        public string StatusVerifikasi = "";
        public string Judul = "Tambah Data Jurnal";

        public FormCRUDJurnal()
        {
            InitializeComponent();
        }

        private void FormCRUDJurnal_Load(object sender, EventArgs e)
        {
            lblJudul.Text = Judul;

            CMBID.Text = IdPrakerin;
            DTPTanggal.Text = Tanggal;
            TXTKegiatan.Text = Kegiatan;
            TXTKendala.Text = Kendala;
            TXTSolusi.Text = Solusi;

            CMBStatus.Items.Clear();
            CMBStatus.Items.Add("menunggu");
            CMBStatus.Items.Add("diterima");
            CMBStatus.Items.Add("ditolak");

            CMBStatus.Text = StatusVerifikasi;

            Koneksi.CRUD("SELECT prakerin.id_prakerin, siswa.nama FROM prakerin INNER JOIN siswa ON prakerin.id_siswa = siswa.id_siswa");
            CMBID.Items.Clear();
            foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
                CMBID.Items.Add(row["id_prakerin"].ToString() + " - " + row["nama"].ToString());
            CMBID.Text = IdPrakerin;

            if (!string.IsNullOrEmpty(IdPrakerin))
            {
                foreach (object item in CMBID.Items)
                {
                    if (item.ToString().StartsWith(IdPrakerin + " - "))
                    {
                        CMBID.Text = item.ToString();
                        break;
                    }
                }
            }

            Helper.Pindah(
                CMBID,
                DTPTanggal,
                TXTKegiatan,
                TXTKendala,
                TXTSolusi,
                CMBStatus
            );
        }

        private void BTNSimpan_Click(object sender, EventArgs e)
        {
            if (TXTKegiatan.Text.Trim() == "")
            {
                MessageBox.Show("Masukan Data yang Lengkap!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Koneksi.CRUD($"SELECT * FROM prakerin WHERE id_prakerin = '{CMBID.Text.Trim()}'");

            if (Koneksi.ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("ID Prakerin tidak terdaftar!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            IdPrakerin = CMBID.Text.Split('-')[0].Trim();
            Tanggal = DTPTanggal.Value.ToString("yyyy-MM-dd");
            Kegiatan = TXTKegiatan.Text.Trim();
            Kendala = TXTKendala.Text.Trim();
            Solusi = TXTSolusi.Text.Trim();
            StatusVerifikasi = CMBStatus.Text;

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