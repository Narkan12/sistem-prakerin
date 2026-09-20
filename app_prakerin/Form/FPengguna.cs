using System;
using System.Data;
using System.Windows.Forms;
using app_prakerin.Config;

namespace app_prakerin
{
    public partial class FPengguna : Form
    {
        string idPengguna = "";

        public FPengguna()
        {
            InitializeComponent();
        }

        private void FPengguna_Load(object sender, EventArgs e)
        {
            try
            {
                btnEdit.Enabled  = false;
                btnHapus.Enabled = false;
                TampilData("");
                DGVPengguna.Columns["Column2"].Visible = false;
                DGVPengguna.Columns["Column3"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data pengguna.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void TampilData(string CariApa)
        {
            try
            {
                DGVPengguna.Rows.Clear();
                Koneksi.CRUD($"SELECT * FROM pengguna INNER JOIN role ON role.nama_role = pengguna.role WHERE username LIKE '%{CariApa}%'");
                int no = 1;
                foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
                {
                    DGVPengguna.Rows.Add(no, row["id_pengguna"], row["username"], row["password"], row["role"], row["status"]);
                    no++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data pengguna.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Bersih()
        {
            TXTUsername.Clear();
            TXTPassword.Clear();
            CMBRole.SelectedIndex = -1;
            CMBStatus.SelectedIndex = -1;
            CMBRole.ResetText();
            CMBStatus.ResetText();
        }

        public void AmbilData(string idp)
        {
            try
            {
                Koneksi.CRUD($"SELECT * FROM pengguna INNER JOIN role ON role.nama_role = pengguna.role WHERE id_pengguna = '{idp}'");
                foreach (DataRow item in Koneksi.ds.Tables[0].Rows)
                {
                    TXTUsername.Text = item["username"].ToString();
                    CMBRole.Text     = item["nama_role"].ToString();
                    CMBStatus.Text   = item["status"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data pengguna.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DGVPengguna_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            try
            {
                idPengguna = DGVPengguna.Rows[e.RowIndex].Cells["Column2"].Value?.ToString() ?? "";
                if (!string.IsNullOrEmpty(idPengguna))
                {
                    AmbilData(idPengguna);
                    btnEdit.Enabled  = true;
                    btnHapus.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memilih data.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TXTSearch_TextChanged(object sender, EventArgs e)
        {
            TampilData(TXTSearch.Text);
        }

        private void CMBRole_DropDown(object sender, EventArgs e)
        {
            try
            {
                CMBRole.Items.Clear();
                Koneksi.CRUD("SELECT nama_role FROM role");
                foreach (DataRow row in Koneksi.ds.Tables[0].Rows)
                    CMBRole.Items.Add(row["nama_role"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data role.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CMBStatus_DropDown(object sender, EventArgs e)
        {
            CMBStatus.Items.Clear();
            CMBStatus.Items.Add("Aktif");
            CMBStatus.Items.Add("Nonaktif");
        }

        private void BTNTambah_Click(object sender, EventArgs e)
        {
            try
            {
                FormCRUDPengguna modal = new FormCRUDPengguna();
                modal.Judul = "Tambah Data Pengguna";

                if (modal.ShowDialog() == DialogResult.OK)
                {
                    Koneksi.CRUD($"INSERT INTO pengguna VALUES(null,'{modal.Username}',MD5('{modal.Password}'),'{modal.Role}','{modal.Status}')");
                    MessageBox.Show("Data berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FMaster.CatatAktivitas($"Tambah pengguna: {modal.Username}");
                    TampilData("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan data pengguna.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (idPengguna == "")
            {
                MessageBox.Show("Pilih data terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                int rowIdx = DGVPengguna.CurrentCell.RowIndex;
                FormCRUDPengguna modal = new FormCRUDPengguna();
                modal.Judul    = "Edit Data Pengguna";
                modal.Username = DGVPengguna.Rows[rowIdx].Cells["colId"].Value?.ToString() ?? "";
                modal.Password = DGVPengguna.Rows[rowIdx].Cells["Column3"].Value?.ToString() ?? "";
                modal.Role     = DGVPengguna.Rows[rowIdx].Cells["colNama"].Value?.ToString() ?? "";
                modal.Status   = DGVPengguna.Rows[rowIdx].Cells["Column1"].Value?.ToString() ?? "";

                if (modal.ShowDialog() == DialogResult.OK)
                {
                    Koneksi.CRUD($"UPDATE pengguna SET username='{modal.Username}', password = MD5('{modal.Password}'), role='{modal.Role}', status='{modal.Status}' WHERE id_pengguna='{idPengguna}'");
                    MessageBox.Show("Data berhasil diupdate!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FMaster.CatatAktivitas($"Edit pengguna: {modal.Username}");
                    Bersih();
                    TampilData("");
                    idPengguna = "";
                    btnEdit.Enabled  = false;
                    btnHapus.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengupdate data pengguna.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (idPengguna == "")
            {
                MessageBox.Show("Pilih data terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Yakin ingin menghapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Koneksi.CRUD($"DELETE FROM pengguna WHERE id_pengguna='{idPengguna}'");
                    MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FMaster.CatatAktivitas("Hapus data pengguna");
                    Bersih();
                    TampilData("");
                    idPengguna = "";
                    btnEdit.Enabled  = false;
                    btnHapus.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus data pengguna.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void TXTUsername_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == System.Convert.ToChar(System.Windows.Forms.Keys.Enter))
            {
                if (TXTUsername.Text != "")
                    TXTPassword.Select();
            }
        }

        private void CMBRole_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            TampilData("");
            TXTSearch.Text = "";
        }
    }
}
