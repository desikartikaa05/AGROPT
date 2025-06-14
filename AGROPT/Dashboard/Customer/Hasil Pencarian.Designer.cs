namespace AGROPT.Dashboard.Customer
{
    partial class Hasil_Pencarian
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            dataGridViewLahan = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Id_Lahan = new DataGridViewTextBoxColumn();
            NamaLahan = new DataGridViewTextBoxColumn();
            Lokasi = new DataGridViewTextBoxColumn();
            Deskripsi = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            TanggalUpload = new DataGridViewTextBoxColumn();
            NoHp = new DataGridViewTextBoxColumn();
            label1 = new Label();
            buttonBeli = new Button();
            buttonTutup = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLahan).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewLahan
            // 
            dataGridViewLahan.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewLahan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLahan.Columns.AddRange(new DataGridViewColumn[] { Id, Id_Lahan, NamaLahan, Lokasi, Deskripsi, Status, TanggalUpload, NoHp });
            dataGridViewLahan.Location = new Point(37, 403);
            dataGridViewLahan.Name = "dataGridViewLahan";
            dataGridViewLahan.RowHeadersWidth = 51;
            dataGridViewLahan.Size = new Size(1051, 347);
            dataGridViewLahan.TabIndex = 0;
            dataGridViewLahan.VirtualMode = true;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 125;
            // 
            // Id_Lahan
            // 
            Id_Lahan.HeaderText = "Id_Lahan";
            Id_Lahan.MinimumWidth = 6;
            Id_Lahan.Name = "Id_Lahan";
            Id_Lahan.ReadOnly = true;
            Id_Lahan.Width = 125;
            // 
            // NamaLahan
            // 
            NamaLahan.HeaderText = "NamaLahan";
            NamaLahan.MinimumWidth = 6;
            NamaLahan.Name = "NamaLahan";
            NamaLahan.ReadOnly = true;
            NamaLahan.Width = 125;
            // 
            // Lokasi
            // 
            Lokasi.HeaderText = "Lokasi";
            Lokasi.MinimumWidth = 6;
            Lokasi.Name = "Lokasi";
            Lokasi.ReadOnly = true;
            Lokasi.Width = 125;
            // 
            // Deskripsi
            // 
            Deskripsi.HeaderText = "Deskripsi";
            Deskripsi.MinimumWidth = 6;
            Deskripsi.Name = "Deskripsi";
            Deskripsi.ReadOnly = true;
            Deskripsi.Width = 125;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 125;
            // 
            // TanggalUpload
            // 
            TanggalUpload.HeaderText = "TanggalUpload";
            TanggalUpload.MinimumWidth = 6;
            TanggalUpload.Name = "TanggalUpload";
            TanggalUpload.ReadOnly = true;
            TanggalUpload.Width = 125;
            // 
            // NoHp
            // 
            NoHp.HeaderText = "NoHp";
            NoHp.MinimumWidth = 6;
            NoHp.Name = "NoHp";
            NoHp.ReadOnly = true;
            NoHp.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 49.8000031F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.OliveDrab;
            label1.Location = new Point(205, 216);
            label1.Name = "label1";
            label1.Size = new Size(739, 95);
            label1.TabIndex = 1;
            label1.Text = "Hasil  Pencarian!!!!";
            // 
            // buttonBeli
            // 
            buttonBeli.Font = new Font("Times New Roman", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonBeli.ForeColor = Color.OliveDrab;
            buttonBeli.Location = new Point(693, 915);
            buttonBeli.Name = "buttonBeli";
            buttonBeli.Size = new Size(178, 56);
            buttonBeli.TabIndex = 2;
            buttonBeli.Text = "Beli";
            buttonBeli.UseVisualStyleBackColor = true;
            buttonBeli.Click += buttonBeli_Click_1;
            // 
            // buttonTutup
            // 
            buttonTutup.Font = new Font("Times New Roman", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonTutup.ForeColor = Color.OliveDrab;
            buttonTutup.Location = new Point(910, 915);
            buttonTutup.Name = "buttonTutup";
            buttonTutup.Size = new Size(178, 56);
            buttonTutup.TabIndex = 3;
            buttonTutup.Text = "Tutup";
            buttonTutup.UseVisualStyleBackColor = true;
            buttonTutup.Click += buttonTutup_Click_1;
            // 
            // Hasil_Pencarian
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._6;
            ClientSize = new Size(1924, 1055);
            Controls.Add(buttonTutup);
            Controls.Add(buttonBeli);
            Controls.Add(label1);
            Controls.Add(dataGridViewLahan);
            Name = "Hasil_Pencarian";
            Text = "Hasil_Pencarian";
            ((System.ComponentModel.ISupportInitialize)dataGridViewLahan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewLahan;
        private Label label1;
        private Button buttonBeli;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Id_Lahan;
        private DataGridViewTextBoxColumn NamaLahan;
        private DataGridViewTextBoxColumn Lokasi;
        private DataGridViewTextBoxColumn Deskripsi;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn TanggalUpload;
        private DataGridViewTextBoxColumn NoHp;
        private Button buttonTutup;
    }
}