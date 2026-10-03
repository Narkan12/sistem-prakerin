using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using app_prakerin.Config;

namespace app_prakerin
{
    public partial class FormCRUDSiswa : Form
    {
        public string NIS = "";
        public string Nama = "";
        public string Kelas = "";
        public string Jurusan = "";
        public string JenisKelamin = "";
        public string NoHP = "";
        public string Alamat = "";
        public string IdPengguna = "";
        public string Foto = "";
        public string Judul = "Tambah Data Siswa";

        // Daftar saran untuk autocomplete Kelas & Jurusan
        private readonly List<string> _daftarKelas = new List<string>();
        private readonly List<string> _daftarJurusan = new List<string>();

        public FormCRUDSiswa()
        {
            InitializeComponent();
        }

        private void FormCRUDSiswa_Load(object sender, EventArgs e)
        {
            try
            {
                lblJudul.Text = Judul;
                TXTNIS.Text = NIS;
                TXTNama.Text = Nama;
                TXTNoHP.Text = NoHP;
                TXTAlamat.Text = Alamat;

                CMBJK.Items.Clear();
                CMBJK.Items.Add("L");
                CMBJK.Items.Add("P");
                CMBJK.Text = JenisKelamin;

                Koneksi.CRUD("SELECT nama_kelas FROM kelas");
                _daftarKelas.Clear();
                foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
                    _daftarKelas.Add(row["nama_kelas"].ToString());
                CMBKelas.Text = Kelas;

                Koneksi.CRUD("SELECT nama_jurusan FROM jurusan");
                _daftarJurusan.Clear();
                foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
                    _daftarJurusan.Add(row["nama_jurusan"].ToString());
                CMBJurusan.Text = Jurusan;

                Koneksi.CRUD("SELECT id_pengguna, username FROM pengguna");
                CMBPengguna.Items.Clear();
                foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
                    CMBPengguna.Items.Add(row["id_pengguna"] + " - " + row["username"]);

                if (!string.IsNullOrEmpty(IdPengguna))
                {
                    foreach (object item in CMBPengguna.Items)
                    {
                        if (item.ToString().StartsWith(IdPengguna + " - "))
                        {
                            CMBPengguna.Text = item.ToString();
                            break;
                        }
                    }
                }

                // Muat foto jika tersedia
                if (!string.IsNullOrEmpty(Foto))
                {
                    try
                    {
                        string pathFoto = Path.Combine(Application.StartupPath, "Images", Foto);
                        if (File.Exists(pathFoto))
                        {
                            PBSiswa.Image = Image.FromFile(pathFoto);
                            TXTFoto.Text = Foto;
                        }
                    }
                    catch
                    {
                        // Foto tidak bisa dimuat, biarkan kosong
                        PBSiswa.Image = null;
                    }
                }

                // Dipasang setelah nilai awal diisi agar popup tidak muncul saat mode edit dibuka.
                PasangAutoComplete(CMBKelas, _daftarKelas);
                PasangAutoComplete(CMBJurusan, _daftarJurusan);

                Helper.Pindah(TXTNIS, TXTNama, CMBKelas, CMBJurusan, CMBJK, TXTNoHP, TXTAlamat, CMBPengguna);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat form siswa.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

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
                lb.SetBounds(pt.X, pt.Y + txt.Height, txt.Width, maxItem * lb.ItemHeight + 4);

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

        // ---------- Simpan / Batal / Upload ----------

        private void BTNSimpan_Click(object sender, EventArgs e)
        {
            if (TXTNIS.Text.Trim() == "" || TXTNama.Text.Trim() == "" || CMBPengguna.SelectedIndex == -1 || PBSiswa.Image == null)
            {
                MessageBox.Show("Masukan Data yang Lengkap!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string kelasInput = CMBKelas.Text.Trim();
            string jurusanInput = CMBJurusan.Text.Trim();
            string kelasCocok = CariCocok(_daftarKelas, kelasInput);
            string jurusanCocok = CariCocok(_daftarJurusan, jurusanInput);

            if (kelasInput != "" && kelasCocok == null)
            {
                MessageBox.Show("Kelas tidak ditemukan. Pilih salah satu dari daftar saran.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CMBKelas.Focus();
                return;
            }

            if (jurusanInput != "" && jurusanCocok == null)
            {
                MessageBox.Show("Jurusan tidak ditemukan. Pilih salah satu dari daftar saran.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CMBJurusan.Focus();
                return;
            }

            try
            {
                NIS = TXTNIS.Text.Trim();
                Nama = TXTNama.Text.Trim();
                Kelas = kelasCocok ?? "";
                Jurusan = jurusanCocok ?? "";
                JenisKelamin = CMBJK.Text;
                NoHP = TXTNoHP.Text.Trim();
                Alamat = TXTAlamat.Text.Trim();
                IdPengguna = CMBPengguna.Text.Split(' ')[0];
                Foto = TXTFoto.Text.Trim();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data siswa.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    openFileDialog.Title = "Pilih Foto";
                    openFileDialog.Filter = "File Gambar|*.jpg;*.jpeg;*.png;*.bmp";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string folderImages = Path.Combine(Application.StartupPath, "Images");
                        if (!Directory.Exists(folderImages))
                            Directory.CreateDirectory(folderImages);

                        string namaFile = Path.GetFileName(openFileDialog.FileName);
                        string tujuan = Path.Combine(folderImages, namaFile);

                        File.Copy(openFileDialog.FileName, tujuan, true);

                        PBSiswa.Image = Image.FromFile(tujuan);
                        TXTFoto.Text = namaFile;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengupload foto.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}