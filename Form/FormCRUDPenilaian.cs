using System;
using System.Data;
using System.Windows.Forms;
using app_prakerin.Config;

namespace app_prakerin
{
    public partial class FormCRUDPenilaian : Form
    {
        public string IdPrakerin = "";
        public string Disiplin = "";
        public string Kerjasama = "";
        public string TanggungJawab = "";
        public string Inisiatif = "";
        public string Keahlian = "";
        public string NilaiAkhir = "";
        public string Catatan = "";
        public string Judul = "Tambah Data Penilaian";

        public FormCRUDPenilaian()
        {
            InitializeComponent();
        }

        private void FormCRUDPenilaian_Load(object sender, EventArgs e)
        {
            try
            {
                lblJudul.Text = Judul;
                TXTDisiplin.Text = Disiplin;
                TXTKerjasama.Text = Kerjasama;
                TXTTanggungJawab.Text = TanggungJawab;
                TXTInisiatif.Text = Inisiatif;
                TXTKeahlian.Text = Keahlian;
                TXTNilaiAkhir.Text = NilaiAkhir;
                TXTCatatan.Text = Catatan;

                Koneksi.CRUD("SELECT prakerin.id_prakerin, siswa.nama FROM prakerin INNER JOIN siswa ON siswa.id_siswa = prakerin.id_siswa;");
                CMBPrakerin.Items.Clear();

                foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
                    CMBPrakerin.Items.Add(row["id_prakerin"] + " - " + row["nama"]);

                if (!string.IsNullOrEmpty(IdPrakerin))
                {
                    foreach (object item in CMBPrakerin.Items)
                    {
                        if (item.ToString() == IdPrakerin)
                        {
                            CMBPrakerin.Text = item.ToString();
                            break;
                        }
                    }
                }

                Helper.Pindah(
                    CMBPrakerin,
                    TXTDisiplin,
                    TXTKerjasama,
                    TXTTanggungJawab,
                    TXTInisiatif,
                    TXTKeahlian,
                    TXTNilaiAkhir,
                    TXTCatatan
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat form penilaian.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTNSimpan_Click(object sender, EventArgs e)
        {
            if (CMBPrakerin.SelectedIndex == -1 ||
                TXTDisiplin.Text.Trim() == "" ||
                TXTKerjasama.Text.Trim() == "" ||
                TXTTanggungJawab.Text.Trim() == "" ||
                TXTInisiatif.Text.Trim() == "" ||
                TXTKeahlian.Text.Trim() == "" ||
                TXTNilaiAkhir.Text.Trim() == "")
            {
                MessageBox.Show("Masukan Data yang Lengkap!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                IdPrakerin = CMBPrakerin.Text.Trim();
                Disiplin = TXTDisiplin.Text.Trim();
                Kerjasama = TXTKerjasama.Text.Trim();
                TanggungJawab = TXTTanggungJawab.Text.Trim();
                Inisiatif = TXTInisiatif.Text.Trim();
                Keahlian = TXTKeahlian.Text.Trim();
                NilaiAkhir = TXTNilaiAkhir.Text.Trim();
                Catatan = TXTCatatan.Text.Trim();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data penilaian.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTNBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void HitungNilaiAkhir()
        {
            double disiplin;
            double kerjasama;
            double tanggungJawab;
            double inisiatif;
            double keahlian;

            if (double.TryParse(TXTDisiplin.Text, out disiplin) &&
                double.TryParse(TXTKerjasama.Text, out kerjasama) &&
                double.TryParse(TXTTanggungJawab.Text, out tanggungJawab) &&
                double.TryParse(TXTInisiatif.Text, out inisiatif) &&
                double.TryParse(TXTKeahlian.Text, out keahlian))
            {
                double nilaiAkhir = (disiplin + kerjasama + tanggungJawab + inisiatif + keahlian) / 5;
                TXTNilaiAkhir.Text = nilaiAkhir.ToString("0.00");
            }
        }

        private void TXTKeahlian_TextChanged(object sender, EventArgs e)
        {
            HitungNilaiAkhir();
        }
    }
}