using AGROPT.Dashboard.Customer;
using AGROPT.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AGROPT.Dashboard.Customer;

namespace AGROPT.Dashboard.Petani
{
    public partial class Dashboard_Petani : Form
    {
        private List<Lahan> daftarLahan = new List<Lahan>();
        private int idCounter = 1;
        private User currentUser;
        private Lahan currentLahan;

        public Dashboard_Petani(User user, Lahan lahan)
        {
            InitializeComponent();
            currentUser = user;
            currentLahan = lahan;

            dataGridViewLahan.DataError += (s, e) =>
            {
                e.ThrowException = false;
            };

            dataGridViewLahan.CellFormatting += dataGridView1_CellFormatting;

            LoadDataLahan();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewLahan.Columns[e.ColumnIndex].Name == "status")
            {
                if (e.Value is bool boolVal)
                {
                    e.Value = boolVal ? "Tersedia" : "Tidak Tersedia";
                    e.FormattingApplied = true;
                }
            }
        }




        public void dataGridViewLahan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewLahan.Columns.Count == 0)
            {
                dataGridViewLahan.ColumnCount = 8;
                dataGridViewLahan.Columns[0].Name = "ID";
                dataGridViewLahan.Columns[1].Name = "Id_Lahan";
                dataGridViewLahan.Columns[2].Name = "Nama Lahan";
                dataGridViewLahan.Columns[3].Name = "Lokasi";
                dataGridViewLahan.Columns[4].Name = "Deskripsi";
                dataGridViewLahan.Columns[5].Name = "Status";
                dataGridViewLahan.Columns[6].Name = "Tanggal Upload";
                dataGridViewLahan.Columns[7].Name = "NoHp";

                dataGridViewLahan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewLahan.MultiSelect = false;
            }
        }

        public void LoadDataLahan()
        {
            dataGridViewLahan.Rows.Clear();

            string connectionString = "your_connection_string_here";
            string query = "SELECT * FROM Lahan";

            using (NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=koutarou_05;Database=AGROPT;Port=5432"))
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                NpgsqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dataGridViewLahan.Rows.Add(
                        reader["id"] != DBNull.Value ? reader["id"] : null,
                        reader["id_lahan"] != DBNull.Value ? reader["id_lahan"] : null,
                        reader["nama_lahan"] != DBNull.Value ? reader["nama_lahan"] : null,
                        reader["lokasi"] != DBNull.Value ? reader["lokasi"] : null,
                        reader["deskripsi"] != DBNull.Value ? reader["deskripsi"] : null,
                        reader["status"] != DBNull.Value ? reader["status"] : null,
                        reader["tanggal_upload"] != DBNull.Value ? reader["tanggal_upload"] : null,
                        reader["no_hp"] != DBNull.Value ? reader["no_hp"] : null
                    );

                }

                reader.Close();
            }
        }

        public DataTable GetDataLahan()
        {
            DataTable dt = new DataTable();
            using (NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=koutarou_05;Database=AGROPT;Port=5432"))
            {
                conn.Open();
                string query = "SELECT * FROM Lahan";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }


        private void Tambah_Click(object sender, EventArgs e)
        {
            var formTambah = new Tambah_Edit_Hapus_Lahan("Tambah");
            formTambah.ShowDialog();

            LoadDataLahan();
        }


        private void Edit_Click(object sender, EventArgs e)
        {
            if (dataGridViewLahan.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewLahan.SelectedRows[0].Index;
                int idSelected = Convert.ToInt32(dataGridViewLahan.Rows[selectedIndex].Cells["ID"].Value);

                var formEdit = new Tambah_Edit_Hapus_Lahan("Edit", idSelected);
                formEdit.ShowDialog();

                LoadDataLahan();
            }
            else
            {
                MessageBox.Show("Silakan pilih data terlebih dahulu.");
            }
        }


        private void Hapus_Click(object sender, EventArgs e)
        {
            if (dataGridViewLahan.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewLahan.SelectedRows[0].Index;
                int idSelected = Convert.ToInt32(dataGridViewLahan.Rows[selectedIndex].Cells["ID"].Value);

                var confirm = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    using (var conn = new Npgsql.NpgsqlConnection("Host=localhost;Username=postgres;Password=koutarou_05;Database=AGROPT;Port=5432"))
                    {
                        conn.Open();
                        using (var cmd = new Npgsql.NpgsqlCommand("DELETE FROM lahan WHERE id = @id", conn))
                        {
                            cmd.Parameters.AddWithValue("@id", idSelected);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    LoadDataLahan();
                    MessageBox.Show("Data berhasil dihapus.");
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih data yang ingin dihapus.");
            }
        }


        private void Refresh_Click(object sender, EventArgs e)
        {
            LoadDataLahan();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout berhasil.");


            Form1 loginForm = new Form1();
            loginForm.Show();

            this.Hide();
        }


        private void Dashboard_Petani_Load(object sender, EventArgs e)
        {
            dataGridViewLahan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLahan.MultiSelect = false;


            dataGridViewLahan.Columns["ID"].Visible = true;

            dataGridViewLahan.Columns["Id_Lahan"].Visible = true;
            dataGridViewLahan.Columns["Id_Lahan"].Frozen = false;

            dataGridViewLahan.Columns["NamaLahan"].Visible = true;
            dataGridViewLahan.Columns["NamaLahan"].Frozen = true;

            dataGridViewLahan.Columns["Lokasi"].Visible = true;
            dataGridViewLahan.Columns["Lokasi"].Frozen = true;

            dataGridViewLahan.Columns["Deskripsi"].Visible = true;
            dataGridViewLahan.Columns["Deskripsi"].Frozen = true;

            dataGridViewLahan.Columns["Status"].Visible = true;
            dataGridViewLahan.Columns["Status"].ReadOnly = true;

            dataGridViewLahan.Columns["TanggalUpload"].Visible = true;
            dataGridViewLahan.Columns["TanggalUpload"].ReadOnly = true;

            dataGridViewLahan.Columns["NoHp"].Visible = true;
            dataGridViewLahan.Columns["NoHp"].Frozen = true;

            LoadDataLahan();
        }


        private void buttonUpdatePerkembangan_Click(object sender, EventArgs e)
        {
            if (dataGridViewLahan.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewLahan.SelectedRows[0];
                string idLahan = selectedRow.Cells[1].Value?.ToString();    
                string namaLahan = selectedRow.Cells[2].Value?.ToString();    


                if (!string.IsNullOrEmpty(idLahan) && !string.IsNullOrEmpty(namaLahan))
                {
                    var formPerkembangan = new Perkembangan(idLahan, namaLahan);
                    formPerkembangan.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Data lahan tidak valid.", "Peringatan");
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih data lahan terlebih dahulu.", "Peringatan");
            }
        }

        public DataTable GetDataPerkembangan()
        {
            DataTable dt = new DataTable();
            string query = "SELECT id, id_lahan, nama_lahan, keterangan, progress_panen FROM perkembangan_lahan";

            using (NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=koutarou_05;Database=AGROPT;Port=5432"))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        private void buttonLihatPerkembangan_Click_1(object sender, EventArgs e)
        {
            if (currentUser.Role == "petani" || currentUser.Role == "customer")
            {
                if (dataGridViewLahan.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridViewLahan.SelectedRows[0];

                    bool status = selectedRow.Cells["status"].Value?.ToString() == "True";

                    Lahan selectedLahan = new Lahan
                    {
                        Id_Lahan = selectedRow.Cells["Id_Lahan"].Value?.ToString(),
                        NamaLahan = selectedRow.Cells["NamaLahan"].Value?.ToString(),
                        Lokasi = selectedRow.Cells["Lokasi"].Value?.ToString(),
                        Deskripsi = selectedRow.Cells["Deskripsi"].Value?.ToString(),
                        Status = status,
                        TanggalUpload = selectedRow.Cells["TanggalUpload"].Value != null
                                        ? Convert.ToDateTime(selectedRow.Cells["TanggalUpload"].Value)
                                        : DateTime.MinValue,
                        NoHp = selectedRow.Cells["NoHp"].Value?.ToString()
                    };

                    var lihat = new Lihat_Perkembangan(currentUser, selectedLahan);
                    lihat.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Silakan pilih lahan terlebih dahulu.");
                }
            }
            else if (currentUser.Role == "admin")
            {
                var lihat = new Lihat_Perkembangan(currentUser, null);
                lihat.ShowDialog();
            }
        }
    }
}
