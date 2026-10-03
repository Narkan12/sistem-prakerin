using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using app_prakerin.Config;

namespace app_prakerin
{
    public partial class FormCRUDPenilaian : Form
    {
        private DataTable _dtPrakerin = new DataTable();
        private ListBox _listBoxSaran;

        public FormCRUDPenilaian()
        {
            InitializeComponent();

            this.Load += new EventHandler(FormCRUDPenilaian_Load);

            // Live-calculate Nilai Akhir setiap kali salah satu kategori diketik/berubah.
            TXTDisiplin.TextChanged += Kategori_TextChanged;
            TXTKerjasama.TextChanged += Kategori_TextChanged;
            TXTTanggungJawab.TextChanged += Kategori_TextChanged;
            TXTInisiatif.TextChanged += Kategori_TextChanged;
            TXTKeahlian.TextChanged += Kategori_TextChanged;
        }

        // ---------- Properti yang dipakai FPenilaian.cs ----------

        public string Judul
        {
            get => lblJudul.Text;
            set => lblJudul.Text = value;
        }

        /// <summary>
        /// ID prakerin murni (tanpa label nama siswa) untuk dipakai di query.
        /// TXTIDPrakerin menampilkan "ID – Nama Siswa" lewat autocomplete;
        /// getter ini mengambil bagian ID saja.
        /// </summary>
        public string IdPrakerin
        {
            get
            {
                string teks = TXTIDPrakerin.Text.Trim();
                int idx = teks.IndexOf(" – ", StringComparison.Ordinal);
                return idx >= 0 ? teks.Substring(0, idx).Trim() : teks;
            }
            set => TXTIDPrakerin.Text = value;
        }

        public string Disiplin
        {
            get => TXTDisiplin.Text.Trim();
            set { TXTDisiplin.Text = value; HitungNilaiAkhir(); }
        }

        public string Kerjasama
        {
            get => TXTKerjasama.Text.Trim();
            set { TXTKerjasama.Text = value; HitungNilaiAkhir(); }
        }

        public string TanggungJawab
        {
            get => TXTTanggungJawab.Text.Trim();
            set { TXTTanggungJawab.Text = value; HitungNilaiAkhir(); }
        }

        public string Inisiatif
        {
            get => TXTInisiatif.Text.Trim();
            set { TXTInisiatif.Text = value; HitungNilaiAkhir(); }
        }

        public string Keahlian
        {
            get => TXTKeahlian.Text.Trim();
            set { TXTKeahlian.Text = value; HitungNilaiAkhir(); }
        }

        /// <summary>
        /// Nilai akhir bersifat read-only di form ini (selalu hasil rata-rata otomatis),
        /// tapi tetap punya setter supaya FPenilaian.cs bisa mengisi nilai awal saat mode edit.
        /// </summary>
        public string NilaiAkhir
        {
            get => TXTNilaiAkhir.Text.Trim();
            set => TXTNilaiAkhir.Text = value;
        }

        /// <summary>
        /// Status/predikat bersifat read-only (selalu dihitung otomatis dari nilai akhir),
        /// tapi tetap punya setter supaya FPenilaian.cs bisa mengisi nilai awal saat mode edit.
        /// </summary>
        public string Status
        {
            get => TXTStatus.Text.Trim();
            set => TXTStatus.Text = value;
        }

        // ---------- Logika ----------

        private void FormCRUDPenilaian_Load(object sender, EventArgs e)
        {
            MuatAutoCompletePrakerin();
            HitungNilaiAkhir();
        }

        /// <summary>
        /// Mengisi daftar saran ID Prakerin berupa "ID – Nama Siswa" dari database.
        /// Guna2TextBox kehilangan fokus sebelum item saran bawaan Windows sempat dipilih,
        /// sehingga autocomplete diganti dengan ListBox popup yang dikelola sendiri.
        /// Sesuaikan nama tabel/kolom bila berbeda.
        /// </summary>
        private void MuatAutoCompletePrakerin()
        {
            try
            {
                Koneksi.CRUD("SELECT prakerin.id_prakerin, siswa.nama FROM prakerin INNER JOIN siswa ON prakerin.id_siswa = siswa.id_siswa ORDER BY siswa.nama");
                _dtPrakerin = Koneksi.ds.Tables[0].Copy();

                _listBoxSaran = new ListBox
                {
                    Visible = false,
                    BorderStyle = BorderStyle.FixedSingle,
                    Font = TXTIDPrakerin.Font,
                    IntegralHeight = false
                };
                _listBoxSaran.Click += ListBoxSaran_Click;
                _listBoxSaran.KeyDown += ListBoxSaran_KeyDown;

                this.Controls.Add(_listBoxSaran);
                _listBoxSaran.BringToFront();

                TXTIDPrakerin.TextChanged -= TXTIDPrakerin_TextChanged;
                TXTIDPrakerin.TextChanged += TXTIDPrakerin_TextChanged;
                TXTIDPrakerin.KeyDown -= TXTIDPrakerin_KeyDown;
                TXTIDPrakerin.KeyDown += TXTIDPrakerin_KeyDown;
                TXTIDPrakerin.Leave -= TXTIDPrakerin_Leave;
                TXTIDPrakerin.Leave += TXTIDPrakerin_Leave;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat daftar prakerin untuk autocomplete.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void TXTIDPrakerin_TextChanged(object sender, EventArgs e)
        {
            string ketik = TXTIDPrakerin.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(ketik) || _dtPrakerin == null)
            {
                SembunyikanSaran();
                return;
            }

            _listBoxSaran.Items.Clear();
            foreach (DataRow row in _dtPrakerin.Rows)
            {
                string label = $"{row["id_prakerin"]} \u2013 {row["nama"]}";
                if (label.ToLower().Contains(ketik))
                    _listBoxSaran.Items.Add(label);
            }

            if (_listBoxSaran.Items.Count == 0)
            {
                SembunyikanSaran();
                return;
            }

            var pt = this.PointToClient(TXTIDPrakerin.Parent.PointToScreen(TXTIDPrakerin.Location));
            int maxItem = Math.Min(_listBoxSaran.Items.Count, 7);
            _listBoxSaran.SetBounds(
                pt.X,
                pt.Y + TXTIDPrakerin.Height,
                TXTIDPrakerin.Width,
                maxItem * _listBoxSaran.ItemHeight + 4);

            _listBoxSaran.Visible = true;
            _listBoxSaran.BringToFront();
        }

        private void TXTIDPrakerin_KeyDown(object sender, KeyEventArgs e)
        {
            if (!_listBoxSaran.Visible) return;

            if (e.KeyCode == Keys.Down)
            {
                if (_listBoxSaran.Items.Count > 0)
                {
                    _listBoxSaran.Focus();
                    _listBoxSaran.SelectedIndex = 0;
                }
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                SembunyikanSaran();
                e.Handled = true;
            }
        }

        private void TXTIDPrakerin_Leave(object sender, EventArgs e)
        {
            // Beri jeda singkat agar klik pada listbox sempat terproses lebih dulu.
            System.Threading.Tasks.Task.Delay(150).ContinueWith(_ =>
            {
                this.Invoke((Action)(() =>
                {
                    if (!_listBoxSaran.Focused)
                        SembunyikanSaran();
                }));
            });
        }

        private void ListBoxSaran_Click(object sender, EventArgs e)
        {
            PilihSaran();
        }

        private void ListBoxSaran_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                PilihSaran();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                SembunyikanSaran();
                TXTIDPrakerin.Focus();
                e.Handled = true;
            }
        }

        private void PilihSaran()
        {
            if (_listBoxSaran.SelectedItem == null) return;

            TXTIDPrakerin.TextChanged -= TXTIDPrakerin_TextChanged;
            TXTIDPrakerin.Text = _listBoxSaran.SelectedItem.ToString();
            TXTIDPrakerin.TextChanged += TXTIDPrakerin_TextChanged;

            SembunyikanSaran();
            TXTIDPrakerin.Focus();
            TXTIDPrakerin.SelectionStart = TXTIDPrakerin.Text.Length;
        }

        private void SembunyikanSaran()
        {
            if (_listBoxSaran != null)
                _listBoxSaran.Visible = false;
        }

        private void Kategori_TextChanged(object sender, EventArgs e)
        {
            HitungNilaiAkhir();
        }

        private void HitungNilaiAkhir()
        {
            double d = ParseNilai(TXTDisiplin.Text);
            double k = ParseNilai(TXTKerjasama.Text);
            double t = ParseNilai(TXTTanggungJawab.Text);
            double i = ParseNilai(TXTInisiatif.Text);
            double ke = ParseNilai(TXTKeahlian.Text);

            double rata = (d + k + t + i + ke) / 5.0;

            TXTNilaiAkhir.Text = Math.Round(rata, 2).ToString(CultureInfo.InvariantCulture);
            TXTStatus.Text = GetPredikat(Math.Round(rata, 2));
        }

        public static string GetPredikat(double nilai)
        {
            if (nilai >= 90) return "Sangat Baik";
            if (nilai >= 75) return "Baik";
            if (nilai >= 50) return "Cukup";
            return "Kurang";
        }

        private double ParseNilai(string nilai)
        {
            double hasil;
            double.TryParse((nilai ?? "").Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out hasil);
            return hasil;
        }

        private bool ValidasiRentang(string nilai)
        {
            double angka;
            if (!double.TryParse((nilai ?? "").Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out angka))
                return false;

            return angka >= 0 && angka <= 100;
        }

        private void BTNSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(IdPrakerin))
            {
                MessageBox.Show("Pilih atau ketik ID Prakerin terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTIDPrakerin.Focus();
                return;
            }

            if (!ValidasiRentang(TXTDisiplin.Text) || !ValidasiRentang(TXTKerjasama.Text) ||
                !ValidasiRentang(TXTTanggungJawab.Text) || !ValidasiRentang(TXTInisiatif.Text) ||
                !ValidasiRentang(TXTKeahlian.Text))
            {
                MessageBox.Show("Semua nilai kategori harus berupa angka 0 - 100.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            HitungNilaiAkhir();

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
