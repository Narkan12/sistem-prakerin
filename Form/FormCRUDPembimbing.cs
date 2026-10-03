using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using app_prakerin.Config;

namespace app_prakerin
{
    public partial class FormCRUDPembimbing : Form
    {
        public string Nama = "";
        public string Jabatan = "";
        public string NoHP = "";
        public string Email = "";
        public string IdPengguna = "";
        public string IdPerusahaan = "";
        public string Judul = "Tambah Data Pembimbing";

        // Daftar saran "ID - Nama" untuk autocomplete Perusahaan
        private readonly List<string> _daftarPerusahaan = new List<string>();

        public FormCRUDPembimbing()
        {
            InitializeComponent();
        }

        private void FormCRUDPembimbing_Load(object sender, EventArgs e)
        {
            try
            {
                lblJudul.Text = Judul;
                TXTNama.Text = Nama;
                TXTJabatan.Text = Jabatan;
                TXTNoHP.Text = NoHP;
                TXTEmail.Text = Email;

                Koneksi.CRUD("SELECT id_pengguna, username FROM pengguna");
                CMBPengguna.Items.Clear();
                foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
                    CMBPengguna.Items.Add(row["id_pengguna"] + " - " + row["username"]);

                Koneksi.CRUD("SELECT id_perusahaan, nama FROM perusahaan");
                _daftarPerusahaan.Clear();
                foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
                    _daftarPerusahaan.Add(row["id_perusahaan"] + " - " + row["nama"]);

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

                if (!string.IsNullOrEmpty(IdPerusahaan))
                {
                    foreach (string item in _daftarPerusahaan)
                    {
                        if (item.StartsWith(IdPerusahaan + " - "))
                        {
                            CMBPerusahaan.Text = item;
                            break;
                        }
                    }
                }

                // Dipasang setelah nilai awal diisi agar popup tidak muncul saat mode edit dibuka.
                PasangAutoComplete(CMBPerusahaan, _daftarPerusahaan);

                Helper.Pindah(TXTNama, TXTJabatan, TXTNoHP, TXTEmail, CMBPerusahaan, CMBPengguna);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat form pembimbing.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        // ---------- Simpan / Batal ----------

        private void BTNSimpan_Click(object sender, EventArgs e)
        {
            if (TXTNama.Text.Trim() == "" || CMBPengguna.SelectedIndex == -1 || CMBPerusahaan.Text.Trim() == "")
            {
                MessageBox.Show("Masukan Data yang Lengkap!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Perusahaan harus dipilih dari daftar (format "ID - Nama").
            string perusahaanCocok = CariCocok(_daftarPerusahaan, CMBPerusahaan.Text.Trim());
            if (perusahaanCocok == null)
            {
                MessageBox.Show("Perusahaan tidak ditemukan. Pilih salah satu dari daftar saran.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CMBPerusahaan.Focus();
                return;
            }

            try
            {
                Nama = TXTNama.Text.Trim();
                Jabatan = TXTJabatan.Text.Trim();
                NoHP = TXTNoHP.Text.Trim();
                Email = TXTEmail.Text.Trim();
                IdPengguna = CMBPengguna.Text.Split(' ')[0];
                IdPerusahaan = perusahaanCocok.Split(' ')[0];
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data pembimbing.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTNBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}