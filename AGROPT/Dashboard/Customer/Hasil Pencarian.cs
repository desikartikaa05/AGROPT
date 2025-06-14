using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using AGROPT.Dashboard.Customer;
using AGROPT.Model;


namespace AGROPT.Dashboard.Customer
{
    public partial class Hasil_Pencarian : Form
    {
        public Lahan SelectedLahan { get; private set; }

        public Hasil_Pencarian()
        {
            InitializeComponent();
            LoadDataLahan(); 
        }

        public Hasil_Pencarian(DataTable hasilPencarian)
        {
            InitializeComponent();
            TampilkanData(hasilPencarian); 
        }

        private void TampilkanData(DataTable dt)
        {
            dataGridViewLahan.Columns.Clear(); 
            dataGridViewLahan.DataSource = dt;
            dataGridViewLahan.ReadOnly = true;
            dataGridViewLahan.AllowUserToAddRows = false;
            dataGridViewLahan.AllowUserToDeleteRows = false;
            dataGridViewLahan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLahan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void LoadDataLahan()
        {
            DataTable dt = new DataTable();

            using (NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=koutarou_05;Database=AGROPT;Port=5432"))
            {
                conn.Open();
                string query = "SELECT * FROM lahan";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            TampilkanData(dt);

        }

        private void buttonTutup_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBeli_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewLahan.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewLahan.SelectedRows[0];

                var idLahan = selectedRow.Cells["id_lahan"].Value.ToString();
                var namaLahan = selectedRow.Cells["nama_lahan"].Value.ToString();
                var lokasi = selectedRow.Cells["lokasi"].Value.ToString();
                var kodePembayaran = Guid.NewGuid().ToString().Substring(0, 8).ToUpper(); 

                DialogResult confirm = MessageBox.Show(
                    $"Apakah kamu yakin ingin membeli lahan dengan ID: {idLahan}?",
                    "Konfirmasi Pembelian",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    // Buka form Pembayaran
                    Pembayaran bayarForm = new Pembayaran(idLahan, namaLahan, lokasi, kodePembayaran);
                    bayarForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih salah satu lahan terlebih dahulu.", "Peringatan");
            }
        }
    }
}
