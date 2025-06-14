using Npgsql;
using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


namespace AGROPT.Dashboard.Petani
{
    public partial class Tambah_Edit_Hapus_Lahan : Form
    {
        private string type;
        private int? idLahan;
        private Dashboard_Petani parentForm;


        public Tambah_Edit_Hapus_Lahan(string type, int? idLahan = null, Dashboard_Petani parentForm = null)
        {
            InitializeComponent();
            this.type = type;
            this.idLahan = idLahan;
            this.parentForm = parentForm;

            comboBoxStatus.Items.Add("Tersedia");
            comboBoxStatus.Items.Add("Tidak Tersedia");

            if (type == "Edit" && idLahan.HasValue)
            {
                this.Text = "Edit Data Lahan";
                LoadDataLahan(idLahan.Value);
            }
            else
            {
                this.Text = "Tambah Data Lahan";
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (ValidasiInput())
            {
                SimpanData();
                if (parentForm != null)
                {
                    parentForm.LoadDataLahan();
                }

                MessageBox.Show(
                    type == "Tambah" ? "Data berhasil ditambahkan." : "Data berhasil diperbarui.",
                    "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }


        private bool ValidasiInput()
        {
            if (string.IsNullOrWhiteSpace(textBoxIdLahan.Text) ||
                string.IsNullOrWhiteSpace(textBoxNamaLahan.Text) ||
                string.IsNullOrWhiteSpace(textBoxLokasi.Text) ||
                string.IsNullOrWhiteSpace(textBoxDeskripsi.Text) ||
                string.IsNullOrWhiteSpace(comboBoxStatus.Text) ||
                string.IsNullOrWhiteSpace(textBoxNoHp.Text))
            {
                MessageBox.Show("Semua field harus diisi!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void SimpanData()
        {
            using (var conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=koutarou_05;Database=AGROPT;Port=5432"))
            {
                conn.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = conn;

                if (type == "Tambah")
                {
                    cmd.CommandText = @"
                        INSERT INTO lahan(id_lahan, nama_lahan, lokasi, deskripsi, status, tanggal_upload, no_hp)
                        VALUES (@id_lahan, @nama_lahan, @lokasi, @deskripsi, @status, @tanggal_upload, @no_hp)";
                }
                else
                {
                    cmd.CommandText = @"
                        UPDATE lahan SET 
                            id_lahan = @id_lahan,
                            nama_lahan = @nama_lahan,
                            lokasi = @lokasi,
                            deskripsi = @deskripsi,
                            status = @status,
                            tanggal_upload = @tanggal_upload,
                            no_hp = @no_hp
                        WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", idLahan.Value);
                }

                cmd.Parameters.AddWithValue("@id_lahan", textBoxIdLahan.Text);
                cmd.Parameters.AddWithValue("@nama_lahan", textBoxNamaLahan.Text);
                cmd.Parameters.AddWithValue("@lokasi", textBoxLokasi.Text);
                cmd.Parameters.AddWithValue("@deskripsi", textBoxDeskripsi.Text);

                bool statusBool = comboBoxStatus.SelectedItem.ToString() == "Tersedia";
                cmd.Parameters.AddWithValue("@status", statusBool);
                cmd.Parameters.AddWithValue("@tanggal_upload", dateTimePickerTanggal.Value);
                cmd.Parameters.AddWithValue("@no_hp", textBoxNoHp.Text);

                cmd.ExecuteNonQuery();
            }
        }

        private void LoadDataLahan(int id)
        {
            using (var conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=koutarou_05;Database=AGROPT;Port=5432"))
            {
                conn.Open();
                var cmd = new NpgsqlCommand("SELECT * FROM lahan WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        textBoxIdLahan.Text = reader["id_lahan"].ToString();
                        textBoxNamaLahan.Text = reader["nama_lahan"].ToString();
                        textBoxLokasi.Text = reader["lokasi"].ToString();
                        textBoxDeskripsi.Text = reader["deskripsi"].ToString();
                        bool status = Convert.ToBoolean(reader["status"]);
                        comboBoxStatus.Text = status ? "Tersedia" : "Tidak Tersedia";
                        dateTimePickerTanggal.Value = Convert.ToDateTime(reader["tanggal_upload"]);
                        textBoxNoHp.Text = reader["no_hp"].ToString();
                    }
                }
            }
        }

        private void textBoxIdLahan_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSimpan_Click_1(object sender, EventArgs e)
        {
            if (ValidasiInput())
            {
                SimpanData();
                if (parentForm != null)
                {
                    parentForm.LoadDataLahan();
                }

                MessageBox.Show(
                    type == "Tambah" ? "Data berhasil ditambahkan." : "Data berhasil diperbarui.",
                    "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void Tambah_Edit_Hapus_Lahan_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
