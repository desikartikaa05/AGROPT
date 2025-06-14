using Npgsql;
using AGROPT.Model;
using AGROPT.Dashboard.Petani;
using AGROPT.Dashboard.Customer;
using AGROPT.Dashboard.Admin;

namespace AGROPT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                User user = new User() { Username = textBox1.Text, Password = textBox2.Text };
                User loggedUser = authLogin(user);

                if (loggedUser != null)
                {
                    MessageBox.Show($"Login berhasil\nSelamat datang, {loggedUser.Nama}!\nRole: {loggedUser.Role}", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();

                    string role = loggedUser.Role?.Trim().ToLower();

                    if (role == "petani")
                    {
                        var dashboard = new Dashboard_Petani(loggedUser, null);
                        dashboard.ShowDialog();
                    }
                    else if (role == "customer")
                    {
                        var dashboard = new Dashboard_Customer(loggedUser, null);
                        dashboard.ShowDialog();
                    }
                    else if (role == "admin")
                    {
                        var dashboard = new Dashboard_Admin(loggedUser, null); 
                        dashboard.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Role belum didukung.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username atau password salah", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Harap isi username dan password!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private User authLogin(User user)
        {
            User loggedInUser = null;
            string connString = "Host=localhost;Username=postgres;Password=koutarou_05;Database=AGROPT;port=5432";

            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT * FROM Akun WHERE username = @username AND password = @password";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", user.Username);
                    cmd.Parameters.AddWithValue("@password", user.Password);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            loggedInUser = new User()
                            {
                                Username = reader["username"].ToString(),
                                Password = reader["password"].ToString(),
                                Nama = reader["nama"].ToString(),
                                Role = reader["role"].ToString().Trim().ToLower(),
                                Id = Convert.ToInt32(reader["id"])
                            };
                        }
                    }
                }
            }
            return loggedInUser;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox2.PasswordChar == '*')
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
            this.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
