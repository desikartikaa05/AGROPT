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
using AGROPT.Dashboard.Customer;

namespace AGROPT.Dashboard.Customer
{
    public partial class Pembayaran : Form
    {
        private string idLahan, namaLahan, lokasi;

        public Pembayaran(string idLahan, string namaLahan, string lokasi, string kodePembayaran)
        {
            InitializeComponent();

            this.idLahan = idLahan;
            this.namaLahan = namaLahan;
            this.lokasi = lokasi;

            textBoxIdLahan.Text = idLahan;
            textBoxNamaLahan.Text = namaLahan;
            textBoxLokasi.Text = lokasi;
            textBoxKodePembayaran.Text = kodePembayaran;

            textBoxIdLahan.ReadOnly = true;
            textBoxNamaLahan.ReadOnly = true;
            textBoxLokasi.ReadOnly = true;
            textBoxKodePembayaran.ReadOnly = true;
        }


        private void buttonKirim_Click(object sender, EventArgs e)
        {
            string kodePembayaran = textBoxKodePembayaran.Text.Trim();
            string namaPembeli = textBoxNamaPembeli.Text.Trim();
            string alamatPembeli = textBoxAlamatPembeli.Text.Trim();

            if (string.IsNullOrEmpty(kodePembayaran) || string.IsNullOrEmpty(namaPembeli) || string.IsNullOrEmpty(alamatPembeli))
            {
                MessageBox.Show("Semua kolom harus diisi.", "Peringatan");
                return;
            }

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=koutarou_05;Database=AGROPT;Port=5432"))
                {
                    conn.Open();
                    string query = @"
                INSERT INTO pembayaran 
                    (id_lahan, nama_lahan, lokasi, kode_pembayaran, nama_pembeli, alamat_pembeli, status)
                    VALUES 
                    (@id_lahan, @nama_lahan, @lokasi, @kode_pembayaran, @nama_pembeli, @alamat_pembeli, @status)";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_lahan", idLahan);
                        cmd.Parameters.AddWithValue("@nama_lahan", namaLahan);
                        cmd.Parameters.AddWithValue("@lokasi", lokasi);
                        cmd.Parameters.AddWithValue("@kode_pembayaran", kodePembayaran);
                        cmd.Parameters.AddWithValue("@nama_pembeli", namaPembeli);
                        cmd.Parameters.AddWithValue("@alamat_pembeli", alamatPembeli);
                        cmd.Parameters.AddWithValue("@status", false); 

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Pembayaran berhasil dikirim.", "Berhasil");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error");
            }
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
