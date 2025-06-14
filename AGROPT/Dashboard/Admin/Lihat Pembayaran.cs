using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using AGROPT.Model;

namespace AGROPT.Dashboard.Admin
{
    public partial class Lihat_Pembayaran : Form
    {
        private User currentUser;
        public Lihat_Pembayaran(User user)
        {
            InitializeComponent();
            currentUser = user;
            LoadDataPembayaran(); 
        }

        private void LoadDataPembayaran()
        {
            string connStr = "Host=localhost;Username=postgres;Password=koutarou_05;Database=AGROPT;Port=5432";
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    id_lahan, 
                    nama_lahan, 
                    lokasi, 
                    kode_pembayaran, 
                    nama_pembeli, 
                    alamat_pembeli,
                    status
                FROM pembayaran
                ORDER BY id_lahan;
            ";

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridView1.Columns.Clear();
                        dataGridView1.DataSource = dt;

                        if (dataGridView1.Columns["status"] != null)
                        {
                            dataGridView1.Columns["status"].ReadOnly = false;
                            if (!(dataGridView1.Columns["status"] is DataGridViewCheckBoxColumn))
                            {
                                int statusIndex = dataGridView1.Columns["status"].Index;
                                DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn
                                {
                                    Name = "status",
                                    HeaderText = "Status",
                                    DataPropertyName = "status",
                                    TrueValue = true,
                                    FalseValue = false
                                };

                                dataGridView1.Columns.Remove("status");
                                dataGridView1.Columns.Insert(statusIndex, checkColumn);
                            }
                        }

                        foreach (DataGridViewColumn col in dataGridView1.Columns)
                        {
                            if (col.Name != "status")
                            {
                                col.ReadOnly = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }


        private void FormPembayaran_Load(object sender, EventArgs e)
        {
            LoadDataPembayaran();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string connStr = "Host=localhost;Username=postgres;Password=koutarou_05;Database=AGROPT;Port=5432";

                var idLahanObj = dataGridView1.CurrentRow.Cells["id_lahan"].Value;
                var statusCell = dataGridView1.CurrentRow.Cells["status"].Value;

                if (idLahanObj == null)
                {
                    MessageBox.Show("Kolom ID Lahan kosong. Pilih baris yang benar.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (statusCell == null)
                {
                    MessageBox.Show("Kolom status kosong. Silakan isi terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    bool statusBaru = Convert.ToBoolean(statusCell);
                    string idLahan = Convert.ToString(idLahanObj);

                    using (var conn = new NpgsqlConnection(connStr))
                    {
                        conn.Open();
                        string query = "UPDATE pembayaran SET status = @status WHERE id_lahan = @idLahan";

                        using (var cmd = new NpgsqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@status", statusBaru);
                            cmd.Parameters.AddWithValue("@idLahan", idLahan);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Status berhasil diperbarui!");
                                LoadDataPembayaran();
                            }
                            else
                            {
                                MessageBox.Show("Gagal memperbarui status.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Pilih satu baris terlebih dahulu.");
            }

        }  
    }
}
