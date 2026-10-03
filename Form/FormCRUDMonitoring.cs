using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using app_prakerin.Config;

namespace app_prakerin
{
    public partial class FormCRUDMonitoring : Form
    {
        public string IdMonitoring = "";
        public string IdPrakerin = "";
        public string IdGuru = "";
        public string Tanggal = "";
        public string Catatan = "";
        public string Foto = "";
        public string Judul = "Tambah Data Monitoring";

        // Daftar saran "ID - Nama" untuk autocomplete Prakerin & Guru
        private readonly List<string> _daftarPrakerin = new List<string>();
        private readonly List<string> _daftarGuru = new List<string>();

        public FormCRUDMonitoring()
        {
            InitializeComponent();
        }

        private void FormCRUDMonitoring_Load(object sender, EventArgs e)
        {
            try
            {
                lblJudul.Text = Judul;
                Koneksi.CRUD("SELECT prakerin.id_prakerin, siswa.nama FROM prakerin INNER JOIN siswa ON siswa.id_siswa = prakerin.id_siswa;");
                _daftarPrakerin.Clear();

                foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
                    _daftarPrakerin.Add(row["id_prakerin"].ToString() + " - " + row["nama"].ToString());

                if (!string.IsNullOrEmpty(IdPrakerin))
                    CMBPrakerin.Text = CariLabel(_daftarPrakerin, IdPrakerin);

                Koneksi.CRUD("SELECT id_guru, nama FROM guru");
                _daftarGuru.Clear();
                foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
                    _daftarGuru.Add(row["id_guru"].ToString() + " - " + row["nama"].ToString());

                if (!string.IsNullOrEmpty(IdGuru))
                    CMBGuru.Text = CariLabel(_daftarGuru, IdGuru);

                if (!string.IsNullOrEmpty(Tanggal))
                {
                    DateTime tanggalMonitoring;

                    if (DateTime.TryParse(Tanggal, out tanggalMonitoring))
                        DTTanggal.Value = tanggalMonitoring;
                }

                TXTCatatan.Text = Catatan;

                if (!string.IsNullOrEmpty(Foto))
                {
                    try
                    {
                        string pathFoto = Path.Combine(
                            Application.StartupPath,
                            "Images",
                            Foto
                        );

                        if (File.Exists(pathFoto))
                        {
                            PBFoto.Image = Image.FromFile(pathFoto);
                            TXTFoto.Text = Foto;
                        }
                    }
                    catch
                    {
                        PBFoto.Image = null;
                    }
                }

                // Dipasang setelah nilai awal diisi agar popup tidak muncul saat mode edit dibuka.
                PasangAutoComplete(CMBPrakerin, _daftarPrakerin);
                PasangAutoComplete(CMBGuru, _daftarGuru);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat form monitoring.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        // ---------- Autocomplete (ListBox popup, sama seperti FormCRUDPenilaian) ----------

        /// <summary>
        /// Memasang autocomplete berbasis ListBox popup pada sebuah Guna2TextBox.
        /// Guna2TextBox kehilangan fokus sebelum item saran bawaan Windows sempat dipilih,
        /// sehingga daftar saran dikelola sendiri lewat ListBox.
        /// </summary>
        private void PasangAutoComplete(Guna.UI2.WinForms.Guna2TextBox txt, List<string> data)
        {
            ListBox lb = new ListBox
            {
                Visible = false,
                BorderStyle = BorderStyle.FixedSingle,
                Font = txt.Font,
                IntegralHeight = false
            };
            this.Controls.Add(lb);
            lb.BringToFront();

            bool abaikan = false;

            Action sembunyikan = () => lb.Visible = false;

            Action pilih = () =>
            {
                if (lb.SelectedItem == null) return;

                abaikan = true;
                txt.Text = lb.SelectedItem.ToString();
                abaikan = false;

                lb.Visible = false;
                txt.Focus();
                txt.SelectionStart = txt.Text.Length;
            };

            txt.TextChanged += (s, ev) =>
            {
                if (abaikan) return;

                string ketik = txt.Text.Trim().ToLower();
                if (string.IsNullOrEmpty(ketik))
                {
                    sembunyikan();
                    return;
                }

                lb.Items.Clear();
                foreach (string item in data)
                {
                    if (item.ToLower().Contains(ketik))
                        lb.Items.Add(item);
                }

                // Tidak ada saran, atau satu-satunya saran sudah sama persis dengan yang diketik.
                if (lb.Items.Count == 0 ||
                    (lb.Items.Count == 1 && string.Equals(lb.Items[0].ToString(), txt.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
                {
                    sembunyikan();
                    return;
                }

                Point pt = this.PointToClient(txt.Parent.PointToScreen(txt.Location));
                int maxItem = Math.Min(lb.Items.Count, 7);
                int tinggi = maxItem * lb.ItemHeight + 4;

                // Bila ruang di bawah tidak cukup, tampilkan daftar di atas kotak input.
                int y = pt.Y + txt.Height;
                if (y + tinggi > this.ClientSize.Height)
                    y = pt.Y - tinggi;

                lb.SetBounds(pt.X, y, txt.Width, tinggi);

                lb.Visible = true;
                lb.BringToFront();
            };

            txt.KeyDown += (s, ev) =>
            {
                if (!lb.Visible) return;

                if (ev.KeyCode == Keys.Down)
                {
                    if (lb.Items.Count > 0)
                    {
                        lb.Focus();
                        lb.SelectedIndex = 0;
                    }
                    ev.Handled = true;
                }
                else if (ev.KeyCode == Keys.Escape)
                {
                    sembunyikan();
                    ev.Handled = true;
                }
            };

            txt.Leave += (s, ev) =>
            {
                // Beri jeda singkat agar klik pada listbox sempat terproses lebih dulu.
                System.Threading.Tasks.Task.Delay(150).ContinueWith(_ =>
                {
                    if (this.IsDisposed || !this.IsHandleCreated) return;
                    this.BeginInvoke((Action)(() =>
                    {
                        if (!lb.Focused)
                            lb.Visible = false;
                    }));
                });
            };

            lb.Click += (s, ev) => pilih();

            lb.KeyDown += (s, ev) =>
            {
                if (ev.KeyCode == Keys.Enter || ev.KeyCode == Keys.Return)
                {
                    pilih();
                    ev.Handled = true;
                }
                else if (ev.KeyCode == Keys.Escape)
                {
                    sembunyikan();
                    txt.Focus();
                    ev.Handled = true;
                }
            };
        }

        /// <summary>
        /// Mengembalikan item daftar yang cocok persis (tanpa memperhatikan huruf besar/kecil), atau null.
        /// </summary>
        private string CariCocok(List<string> data, string teks)
        {
            foreach (string item in data)
            {
                if (string.Equals(item, teks, StringComparison.OrdinalIgnoreCase))
                    return item;
            }
            return null;
        }

        /// <summary>
        /// Untuk mode edit: nilai awal bisa berupa ID saja ("3") atau label lengkap ("3 - Nama").
        /// Mengembalikan label lengkap dari daftar bila ada; bila tidak, nilai apa adanya.
        /// </summary>
        private string CariLabel(List<string> data, string nilai)
        {
            foreach (string item in data)
            {
                if (string.Equals(item, nilai, StringComparison.OrdinalIgnoreCase) ||
                    item.StartsWith(nilai + " - ", StringComparison.OrdinalIgnoreCase))
                    return item;
            }
            return nilai;
        }

        // ---------- Simpan / Batal / Upload ----------

        private void BTNSimpan_Click(object sender, EventArgs e)
        {
            if (CMBPrakerin.Text.Trim() == "" ||
                CMBGuru.Text.Trim() == "" ||
                TXTCatatan.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Masukan Data yang Lengkap!",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );

                return;
            }

            // Prakerin & Guru harus dipilih dari daftar (format "ID - Nama").
            string prakerinCocok = CariCocok(_daftarPrakerin, CMBPrakerin.Text.Trim());
            string guruCocok = CariCocok(_daftarGuru, CMBGuru.Text.Trim());

            if (prakerinCocok == null)
            {
                MessageBox.Show("Data prakerin tidak ditemukan. Pilih salah satu dari daftar saran.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CMBPrakerin.Focus();
                return;
            }

            if (guruCocok == null)
            {
                MessageBox.Show("Guru pembimbing tidak ditemukan. Pilih salah satu dari daftar saran.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CMBGuru.Focus();
                return;
            }

            try
            {
                IdPrakerin = prakerinCocok;
                IdGuru = guruCocok;
                Tanggal = DTTanggal.Value.ToString("yyyy-MM-dd");
                Catatan = TXTCatatan.Text.Trim();
                Foto = TXTFoto.Text.Trim();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menyimpan data monitoring.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void BTNBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BTNUpload_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Title = "Pilih Foto Monitoring";
                    openFileDialog.Filter = "File Gambar|*.jpg;*.jpeg;*.png;*.bmp";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string folderImages = Path.Combine(
                            Application.StartupPath,
                            "Images"
                        );

                        if (!Directory.Exists(folderImages))
                            Directory.CreateDirectory(folderImages);

                        string namaFile = Path.GetFileName(openFileDialog.FileName);
                        string tujuan = Path.Combine(folderImages, namaFile);

                        File.Copy(
                            openFileDialog.FileName,
                            tujuan,
                            true
                        );

                        PBFoto.Image = Image.FromFile(tujuan);
                        TXTFoto.Text = namaFile;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal mengupload foto.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
    }
}