using AGROPT.Dashboard.Customer;
using AGROPT.Dashboard.Petani;
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

namespace AGROPT.Dashboard.Admin
{
    public partial class Dashboard_Admin : Form
    {
        private User currentUser;
        private Lahan currentLahan;

        public Dashboard_Admin(User user, Lahan lahan)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void buttonLihatLahan_Click(object sender, EventArgs e)
        {
            var lihat = new Dashboard_Petani(currentUser, currentLahan);
            lihat.Show();
        }

        private void buttonLihatPerkembangan_Click(object sender, EventArgs e)
        {
            var lihat = new Lihat_Perkembangan(currentUser, currentLahan); 
            lihat.ShowDialog();
        }

        private void buttonLihatPembayaran_Click_1(object sender, EventArgs e)
        {
            var lihat = new Lihat_Pembayaran(currentUser);
            lihat.ShowDialog();
        }

        private void Dashboard_Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
