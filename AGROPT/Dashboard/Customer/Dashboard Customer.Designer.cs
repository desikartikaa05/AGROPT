namespace AGROPT.Dashboard.Customer
{
    partial class Dashboard_Customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        internal System.Windows.Forms.DataGridView dataGridViewLahan;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxJenisLahan = new TextBox();
            textBoxLokasi = new TextBox();
            buttonCari = new Button();
            buttonLihat = new Button();
            dataGridViewLahanSaya = new DataGridView();
            buttonSimpan = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLahanSaya).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.YellowGreen;
            label1.Location = new Point(304, 329);
            label1.Name = "label1";
            label1.Size = new Size(158, 38);
            label1.TabIndex = 0;
            label1.Text = "Jenis Lahan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.YellowGreen;
            label2.Location = new Point(304, 422);
            label2.Name = "label2";
            label2.Size = new Size(106, 34);
            label2.TabIndex = 1;
            label2.Text = "Lokasi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 49.8000031F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.OliveDrab;
            label3.Location = new Point(172, 174);
            label3.Name = "label3";
            label3.Size = new Size(750, 101);
            label3.TabIndex = 2;
            label3.Text = "Selamat Datang ";
            // 
            // textBoxJenisLahan
            // 
            textBoxJenisLahan.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxJenisLahan.ForeColor = Color.YellowGreen;
            textBoxJenisLahan.Location = new Point(304, 368);
            textBoxJenisLahan.Name = "textBoxJenisLahan";
            textBoxJenisLahan.Size = new Size(458, 43);
            textBoxJenisLahan.TabIndex = 3;
            // 
            // textBoxLokasi
            // 
            textBoxLokasi.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLokasi.ForeColor = Color.OliveDrab;
            textBoxLokasi.Location = new Point(304, 459);
            textBoxLokasi.Name = "textBoxLokasi";
            textBoxLokasi.Size = new Size(458, 43);
            textBoxLokasi.TabIndex = 4;
            // 
            // buttonCari
            // 
            buttonCari.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCari.ForeColor = Color.OliveDrab;
            buttonCari.Location = new Point(357, 528);
            buttonCari.Name = "buttonCari";
            buttonCari.Size = new Size(356, 64);
            buttonCari.TabIndex = 5;
            buttonCari.Text = "CARI";
            buttonCari.UseVisualStyleBackColor = true;
            buttonCari.Click += buttonCari_Click_1;
            // 
            // buttonLihat
            // 
            buttonLihat.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLihat.ForeColor = Color.OliveDrab;
            buttonLihat.Location = new Point(524, 922);
            buttonLihat.Name = "buttonLihat";
            buttonLihat.Size = new Size(368, 64);
            buttonLihat.TabIndex = 6;
            buttonLihat.Text = "Lihat Perkembangan";
            buttonLihat.UseVisualStyleBackColor = true;
            buttonLihat.Click += buttonLihatPerkembangan_Click;
            // 
            // dataGridViewLahanSaya
            // 
            dataGridViewLahanSaya.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewLahanSaya.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLahanSaya.Location = new Point(29, 632);
            dataGridViewLahanSaya.Name = "dataGridViewLahanSaya";
            dataGridViewLahanSaya.RowHeadersWidth = 51;
            dataGridViewLahanSaya.Size = new Size(1049, 264);
            dataGridViewLahanSaya.TabIndex = 7;
            dataGridViewLahanSaya.CellContentClick += dataGridViewLahanSaya_CellContentClick;
            // 
            // buttonSimpan
            // 
            buttonSimpan.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSimpan.ForeColor = Color.OliveDrab;
            buttonSimpan.Location = new Point(922, 921);
            buttonSimpan.Name = "buttonSimpan";
            buttonSimpan.Size = new Size(156, 64);
            buttonSimpan.TabIndex = 8;
            buttonSimpan.Text = "Simpan";
            buttonSimpan.UseVisualStyleBackColor = true;
            buttonSimpan.Click += buttonSimpan_Click;
            // 
            // Dashboard_Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._6;
            ClientSize = new Size(1924, 1055);
            Controls.Add(buttonSimpan);
            Controls.Add(dataGridViewLahanSaya);
            Controls.Add(buttonLihat);
            Controls.Add(buttonCari);
            Controls.Add(textBoxLokasi);
            Controls.Add(textBoxJenisLahan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Dashboard_Customer";
            Text = "Dashboard_Customer";
            ((System.ComponentModel.ISupportInitialize)dataGridViewLahanSaya).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxJenisLahan;
        private TextBox textBoxLokasi;
        private Button buttonCari;
        private Button buttonLihat;
        private DataGridView dataGridViewLahanSaya;
        private Button buttonSimpan;
    }
}