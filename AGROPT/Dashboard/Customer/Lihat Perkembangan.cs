using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using AGROPT.Model;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace AGROPT.Dashboard.Customer
{
    public partial class Lihat_Perkembangan : Form
    {
        private User currentUser;
        private Lahan currentLahan;
        private DataTable dataLahan;


        public Lihat_Perkembangan(User user, Lahan lahan)
        {
            InitializeComponent();
            this.currentUser = user;
            currentLahan = lahan;

            if ((currentUser.Role == "petani" || currentUser.Role == "customer") && currentLahan == null)
            {
                MessageBox.Show("Lahan belum dipilih. Tidak bisa menampilkan perkembangan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();  
                return;
            }

            TampilkanDataSesuaiRole();
        }


        public Lihat_Perkembangan(string idLahan)
        {
            InitializeComponent();
            LoadPerkembanganLahan(idLahan); 
        }

        private void LoadPerkembanganLahan(string idLahan)
        {
            DataTable dt = new DataTable();

            using (NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=koutarou_05;Database=AGROPT;Port=5432"))
            {
                conn.Open();
                string query = "SELECT id_lahan, nama_lahan, keterangan, progress_panen FROM perkembangan_lahan WHERE id_lahan = @idLahan";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idLahan", idLahan);

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            dataGridViewPerkembangan.DataSource = dt;
        }


        private void TampilkanDataSesuaiRole()
        {
            DataTable dt = new DataTable();
            string connectionString = "Host=localhost;Username=postgres;Password=koutarou_05;Database=AGROPT;Port=5432";

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "";

                    if (currentUser.Role == "admin")
                    {
                        query = @"
                            SELECT p.id, p.id_lahan, p.nama_lahan, p.keterangan, p.progress_panen
                            FROM perkembangan_lahan p
                            ORDER BY p.id_lahan";
                    }
                    else if (currentUser.Role == "petani")
                    {
                        if (currentLahan == null)
                        {
                            MessageBox.Show("Lahan belum dipilih!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.Close();
                            return;
                        }

                        query = @"
                            SELECT p.id, p.id_lahan, p.nama_lahan, p.keterangan, p.progress_panen
                            FROM perkembangan_lahan p
                            ORDER BY p.id_lahan";
                    }
                    else if (currentUser.Role == "customer")
                    {
                        query = @"
                            SELECT p.id, p.id_lahan, p.nama_lahan, p.keterangan, p.progress_panen
                            FROM perkembangan_lahan p
                            ORDER BY p.id_lahan";
                    }

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        if (currentUser.Role == "petani")
                        {
                            
                        }
                        else if (currentUser.Role == "customer")
                        {
                            
                        }

                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);

                            MessageBox.Show("Jumlah baris perkembangan ditemukan: " + dt.Rows.Count.ToString());

                        }
                    }

                    dataGridViewPerkembangan.Columns.Clear();
                    dataGridViewPerkembangan.AutoGenerateColumns = true;
                    dataGridViewPerkembangan.DataSource = dt;

                    dataGridViewPerkembangan.ReadOnly = true;
                    dataGridViewPerkembangan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridViewPerkembangan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRefresh_Click_1(object sender, EventArgs e)
        {
            TampilkanDataSesuaiRole();
        }

        private void buttonLogout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void dataGridViewPerkembangan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
