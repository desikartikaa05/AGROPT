using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGROPT
{
    public partial class Dashboard : Form
    {
        string username;

        Model.Model model = new Model.Model();
        public Dashboard(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            label1.Text = $"Welcome {this.username} !!";

            label2.Text = model.daftatMahasiswa[0].nama;
            label3.Text = model.daftatMahasiswa[0].id;
            label5.Text = model.daftatMahasiswa[1].nama;
            label4.Text = model.daftatMahasiswa[1].id;
        }
    }
}
