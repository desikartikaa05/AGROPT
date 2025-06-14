using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using AGROPT.Model;
using AGROPT.Dashboard.Petani;
using System.Collections;
using AGROPT.Dashboard.Customer;
using System.Windows.Forms.VisualStyles;



namespace AGROPT.Dashboard.Customer

{
    public partial class Dashboard_Customer : Form
    {
        private User currentUser;
        private Lahan currentLahan = null;

        public Dashboard_Customer(User user, Lahan lahan)
        {
            InitializeComponent();
            currentUser = user;
            currentLahan = lahan;
        }

        private void Dashboard_Customer_Load(object sender, EventArgs e)
        {
            TampilkanDataLahan();    

            dataGridViewLahan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLahan.MultiSelect = false;
            dataGridViewLahan.ReadOnly = true;
            dataGridViewLahan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewLahanSaya.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLahanSaya.MultiSelect = false;
            dataGridViewLahanSaya.ReadOnly = true;
            dataGridViewLahanSaya.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void TampilkanDataLahan()
        {
            DataTable dt = new DataTable();
            using (NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=koutarou_05;Database=AGROPT;Port=5432"))
            {
                conn.Open();
                string query = @"
                   SELECT * FROM lahan WHERE status = true";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", currentUser.Nama);

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            dataGridViewLahanSaya.AutoGenerateColumns = true;
            dataGridViewLahanSaya.Columns.Clear(); 
            dataGridViewLahanSaya.DataSource = dt;

            dataGridViewLahanSaya.ReadOnly = true;
            dataGridViewLahanSaya.AllowUserToAddRows = false;


        }

        private void buttonCari_Click_1(object sender, EventArgs e)
        {
            string jenisLahan = textBoxJenisLahan.Text.Trim();
            string lokasi = textBoxLokasi.Text.Trim();
            CariLahan(jenisLahan, lokasi);
        }

        private void CariLahan(string jenisLahan, string lokasi)
        {
            DataTable dt = new DataTable();

            string query = @"
                SELECT id, id_lahan, nama_lahan, lokasi, deskripsi, 
                status, tanggal_upload, no_hp
                FROM lahan 
                WHERE nama_lahan ILIKE @jenisLahan 
                AND lokasi ILIKE @lokasi 
                AND status = true";

            using (NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=koutarou_05;Database=AGROPT;Port=5432"))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@jenisLahan", "%" + jenisLahan + "%");
                    cmd.Parameters.AddWithValue("@lokasi", "%" + lokasi + "%");

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }

            if (dt.Rows.Count > 0)
            {
                Hasil_Pencarian hasilForm = new Hasil_Pencarian(dt);
                hasilForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tidak ditemukan lahan yang sesuai.", "Hasil Pencarian", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonLihatPerkembangan_Click(object sender, EventArgs e)
        {
            if (dataGridViewLahanSaya.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewLahanSaya.SelectedRows[0];

                string idLahan = row.Cells["id_lahan"].Value?.ToString();

                if (!string.IsNullOrEmpty(idLahan))
                {
                    var lihatForm = new Lihat_Perkembangan(idLahan);
                    lihatForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Pilih lahan dari tabel 'Lahan Saya' terlebih dahulu.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void dataGridViewLahanSaya_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridViewLahanSaya.Rows[e.RowIndex];

                Lahan lahan = new Lahan
                {
                    Id_Lahan = row.Cells["id_lahan"].Value.ToString(),
                    NamaLahan = row.Cells["nama_lahan"].Value.ToString(),
                    Lokasi = row.Cells["lokasi"].Value.ToString(),
                    Deskripsi = row.Cells["deskripsi"].Value.ToString(),
                    Status = Convert.ToBoolean(row.Cells["status"].Value), 
                    TanggalUpload = Convert.ToDateTime(row.Cells["tanggal_upload"].Value),
                    NoHp = row.Cells["no_hp"].Value.ToString()
                };

                var lihat = new Lihat_Perkembangan(currentUser, lahan);
                lihat.ShowDialog();
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            TampilkanDataLahan(); 
        }
    }
}