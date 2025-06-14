using System;
using System.Drawing;
using System.Windows.Forms;

namespace AGROPT.Dashboard.Customer
{
    public partial class Lihat_Perkembangan : Form
    {
        private System.ComponentModel.IContainer components = null;

        private DataGridView dataGridViewPerkembangan;
        private Label label1;
        private Button buttonLogout;
        private Button buttonRefresh;

        public Lihat_Perkembangan()
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dataGridViewPerkembangan = new DataGridView();
            label1 = new Label();
            buttonLogout = new Button();
            buttonRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPerkembangan).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPerkembangan
            // 
            dataGridViewPerkembangan.BackgroundColor = Color.WhiteSmoke;
            dataGridViewPerkembangan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPerkembangan.Location = new Point(160, 395);
            dataGridViewPerkembangan.Name = "dataGridViewPerkembangan";
            dataGridViewPerkembangan.RowHeadersWidth = 51;
            dataGridViewPerkembangan.Size = new Size(815, 368);
            dataGridViewPerkembangan.TabIndex = 0;
            dataGridViewPerkembangan.CellContentClick += dataGridViewPerkembangan_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 49.8000031F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.OliveDrab;
            label1.Location = new Point(147, 227);
            label1.Name = "label1";
            label1.Size = new Size(841, 95);
            label1.TabIndex = 2;
            label1.Text = "Perkembangan Lahan";
            // 
            // buttonLogout
            // 
            buttonLogout.Font = new Font("Times New Roman", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonLogout.ForeColor = Color.OliveDrab;
            buttonLogout.Location = new Point(813, 879);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(162, 53);
            buttonLogout.TabIndex = 1;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click_1;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Font = new Font("Times New Roman", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonRefresh.ForeColor = Color.OliveDrab;
            buttonRefresh.Location = new Point(563, 879);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(162, 53);
            buttonRefresh.TabIndex = 0;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click_1;
            // 
            // Lihat_Perkembangan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._6;
            ClientSize = new Size(1924, 1055);
            Controls.Add(buttonRefresh);
            Controls.Add(buttonLogout);
            Controls.Add(label1);
            Controls.Add(dataGridViewPerkembangan);
            Name = "Lihat_Perkembangan";
            Text = "Lihat_Perkembangan";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPerkembangan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            // Tambahkan logika logout di sini
            MessageBox.Show("Logout berhasil.");
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            // Tambahkan logika refresh data di sini
            MessageBox.Show("Data diperbarui.");
        }
    }
}
