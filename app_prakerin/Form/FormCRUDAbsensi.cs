using System;
using System.Data;
using System.Windows.Forms;
using app_prakerin.Config;

namespace app_prakerin
{
    public partial class FormCRUDAbsensi : Form
    {
        public string IdAbsensi = "";
        public string IdPrakerin = "";
        public string Tanggal = "";
        public string JamMasuk = "";
        public string JamKeluar = "";
        public string Status = "";
        public string Judul = "Tambah Data Absensi";

        public FormCRUDAbsensi()
        {
            InitializeComponent();
        }

        private void FormCRUDAbsensi_Load(object sender, EventArgs e)
        {
            lblJudul.Text = Judul;

            CMBStatus.Items.Clear();
            CMBStatus.Items.Add("hadir");
            CMBStatus.Items.Add("izin");
            CMBStatus.Items.Add("sakit");
            CMBStatus.Items.Add("alpha");

            CMBStatus.Text = string.IsNullOrEmpty(Status)
                ? "hadir"
                : Status;

            Koneksi.CRUD(
                "SELECT prakerin.id_prakerin, siswa.nama " +
                "FROM prakerin " +
                "INNER JOIN siswa ON prakerin.id_siswa = siswa.id_siswa"
            );

            CMBID.Items.Clear();

            foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
            {
                CMBID.Items.Add(
                    row["id_prakerin"].ToString() +
                    " - " +
                    row["nama"].ToString()
                );
            }

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

            if (!string.IsNullOrEmpty(Tanggal))
            {
                DateTime tanggal;

                if (DateTime.TryParse(Tanggal, out tanggal))
                    DTPTanggal.Value = tanggal;
            }
            else
            {
                DTPTanggal.Value = DateTime.Now;
            }

            TimeSpan jamMasuk;
            if (TimeSpan.TryParse(JamMasuk, out jamMasuk))
                DTPJamMasuk.Value = DateTime.Today.Add(jamMasuk);
            else
                DTPJamMasuk.Value = DateTime.Today;

            TimeSpan jamKeluar;
            if (TimeSpan.TryParse(JamKeluar, out jamKeluar))
                DTPJamKeluar.Value = DateTime.Today.Add(jamKeluar);
            else
                DTPJamKeluar.Value = DateTime.Today;

            Helper.Pindah(
                CMBID,
                DTPTanggal,
                DTPJamMasuk,
                DTPJamKeluar,
                CMBStatus
            );
        }

        private void BTNSimpan_Click(object sender, EventArgs e)
        {
            if (CMBID.Text.Trim() == "" ||
                CMBStatus.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Masukan Data yang Lengkap!",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );

                return;
            }

            string idPrakerin = CMBID.Text.Split('-')[0].Trim();

            Koneksi.CRUD("SELECT * FROM prakerin WHERE id_prakerin = '" + idPrakerin + "'");

            if (Koneksi.ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show(
                    "ID Prakerin tidak terdaftar!",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );

                return;
            }

            IdPrakerin = idPrakerin;
            Tanggal = DTPTanggal.Value.ToString("yyyy-MM-dd");
            JamMasuk = DTPJamMasuk.Value.ToString("HH:mm:ss");
            JamKeluar = DTPJamKeluar.Value.ToString("HH:mm:ss");
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