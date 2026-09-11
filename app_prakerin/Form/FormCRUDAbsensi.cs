using System;
using System.Data;
using System.Windows.Forms;
using app_prakerin.Config;

namespace app_prakerin
{
    public partial class FormCRUDAbsensi : Form
    {
        public string IdAbsensi  = "";
        public string IdPrakerin = "";
        public string Tanggal    = "";
        public string JamMasuk   = "";
        public string JamKeluar  = "";
        public string Status     = "";
        public string Judul      = "Tambah Data Absensi";

        public FormCRUDAbsensi()
        {
            InitializeComponent();
        }

        private void FormCRUDAbsensi_Load(object sender, EventArgs e)
        {
            try
            {
                lblJudul.Text = Judul;

                CMBStatus.Items.Clear();
                CMBStatus.Items.Add("hadir");
                CMBStatus.Items.Add("izin");
                CMBStatus.Items.Add("sakit");
                CMBStatus.Items.Add("alpha");
                CMBStatus.Text = string.IsNullOrEmpty(Status) ? "hadir" : Status;

                // Load daftar prakerin
                Koneksi.CRUD(
                    "SELECT prakerin.id_prakerin, siswa.nama " +
                    "FROM prakerin " +
                    "INNER JOIN siswa ON prakerin.id_siswa = siswa.id_siswa"
                );

                CMBID.Items.Clear();
                foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
                    CMBID.Items.Add(row["id_prakerin"].ToString() + " - " + row["nama"].ToString());

                // Pre-select jika mode edit
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

                // Set tanggal
                if (!string.IsNullOrEmpty(Tanggal))
                {
                    DateTime tgl;
                    if (DateTime.TryParse(Tanggal, out tgl))
                        DTPTanggal.Value = tgl;
                }
                else
                {
                    DTPTanggal.Value = DateTime.Now;
                }

                // Set jam masuk / keluar
                TimeSpan jamMasuk;
                DTPJamMasuk.Value = TimeSpan.TryParse(JamMasuk, out jamMasuk)
                    ? DateTime.Today.Add(jamMasuk)
                    : DateTime.Today;

                TimeSpan jamKeluar;
                DTPJamKeluar.Value = TimeSpan.TryParse(JamKeluar, out jamKeluar)
                    ? DateTime.Today.Add(jamKeluar)
                    : DateTime.Today;

                Helper.Pindah(CMBID, DTPTanggal, DTPJamMasuk, DTPJamKeluar, CMBStatus);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat form absensi.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTNSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CMBID.Text) || string.IsNullOrWhiteSpace(CMBStatus.Text))
            {
                MessageBox.Show("Masukan Data yang Lengkap!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                string rawId = CMBID.Text.Contains("-") ? CMBID.Text.Split('-')[0].Trim() : CMBID.Text.Trim();

                // Validasi ID Prakerin ke DB
                Koneksi.CRUD("SELECT * FROM prakerin WHERE id_prakerin = '" + rawId + "'");
                if (Koneksi.ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("ID Prakerin tidak terdaftar!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                IdPrakerin = rawId;
                Tanggal    = DTPTanggal.Value.ToString("yyyy-MM-dd");
                JamMasuk   = DTPJamMasuk.Value.ToString("HH:mm:ss");
                JamKeluar  = DTPJamKeluar.Value.ToString("HH:mm:ss");
                Status     = CMBStatus.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data absensi.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTNBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
