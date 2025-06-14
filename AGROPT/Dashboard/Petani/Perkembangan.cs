using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AGROPT.Dashboard.Customer;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;

namespace AGROPT.Dashboard.Petani
{
    public partial class Perkembangan : Form
    {

        private User currentUser;

        public Perkembangan(User user)
        {
            InitializeComponent();
            currentUser = user;
        }


        public Perkembangan(string idLahan, string namaLahan)
        {
            InitializeComponent();

            textBoxIdLahan.Text = idLahan;
            textBoxNamaLahan.Text = namaLahan;

            textBoxIdLahan.ReadOnly = true;
            textBoxNamaLahan.ReadOnly = true;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxIdLahan_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNamaLahan_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxKeterangan_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxProgresPanen_TextChanged(object sender, EventArgs e)
        {

        }



        private void buttonSimpan_Click_1(object sender, EventArgs e)
        {
            string connStr = "Host =localhost;Username=postgres;Password=koutarou_05;Database=AGROPT;Port=5432";
            string idLahan = textBoxIdLahan.Text.Trim();
            string namaLahan = textBoxNamaLahan.Text.Trim();
            string keterangan = textBoxKeterangan.Text.Trim();
            string progress = textBoxProgresPanen.Text.Trim();

            if (string.IsNullOrEmpty(idLahan) || string.IsNullOrEmpty(namaLahan))
            {
                MessageBox.Show("ID Lahan dan Nama Lahan wajib diisi.");
                return;
            }

            using (var conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO perkembangan_lahan (id_lahan, nama_lahan, keterangan, progress_panen)
                             VALUES (@id_lahan, @nama_lahan, @keterangan, @progress_panen)";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_lahan", idLahan);
                        cmd.Parameters.AddWithValue("@nama_lahan", namaLahan);
                        cmd.Parameters.AddWithValue("@keterangan", keterangan);
                        cmd.Parameters.AddWithValue("@progress_panen", progress);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Perkembangan lahan berhasil disimpan.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                }
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
