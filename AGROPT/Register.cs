using Npgsql;
using AGROPT.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGROPT
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Petani");
            comboBox1.Items.Add("Customer");
            comboBox1.Items.Add("Admin");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && comboBox1.SelectedItem != null)
            {
                User user = new User
                {
                    Nama = textBox1.Text,
                    Username = textBox2.Text,
                    Password = textBox3.Text,
                    Role = comboBox1.SelectedItem.ToString()
                };

                bool registerValidation = register(user);
                if (registerValidation)
                {
                    MessageBox.Show("Register berhasil", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); 
                }
                else
                {
                    MessageBox.Show("Register gagal", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    comboBox1.SelectedIndex = -1;
                }
            }
            else
            {
                MessageBox.Show("Harap isi semua data dengan benar", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool register(User user)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=koutarou_05;Database=AGROPT;Port=5432"))
                {
                    conn.Open();
                    string query = $"INSERT INTO akun(nama, username, password, role) VALUES ('{user.Nama}', '{user.Username}', '{user.Password}', '{user.Role}')";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close(); 
        }

    
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
    }
}

