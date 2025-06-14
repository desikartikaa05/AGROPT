namespace AGROPT.Dashboard.Petani
{
    partial class Dashboard_Petani
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
            label1 = new Label();
            dataGridViewLahan = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Id_Lahan = new DataGridViewTextBoxColumn();
            NamaLahan = new DataGridViewTextBoxColumn();
            Lokasi = new DataGridViewTextBoxColumn();
            Deskripsi = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            TanggalUpload = new DataGridViewTextBoxColumn();
            NoHp = new DataGridViewTextBoxColumn();
            Tambah = new Button();
            Edit = new Button();
            Hapus = new Button();
            Refresh = new Button();
            Logout = new Button();
            buttonLihatPerkembangan = new Button();
            buttonUpdatePerkembangan = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLahan).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Britannic Bold", 48F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.OliveDrab;
            label1.Location = new Point(92, 145);
            label1.Name = "label1";
            label1.Size = new Size(1017, 89);
            label1.TabIndex = 0;
            label1.Text = "Selamat Datang  di Agropt !";
            // 
            // dataGridViewLahan
            // 
            dataGridViewLahan.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewLahan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLahan.Columns.AddRange(new DataGridViewColumn[] { Id, Id_Lahan, NamaLahan, Lokasi, Deskripsi, Status, TanggalUpload, NoHp });
            dataGridViewLahan.Location = new Point(76, 281);
            dataGridViewLahan.Name = "dataGridViewLahan";
            dataGridViewLahan.RowHeadersWidth = 51;
            dataGridViewLahan.Size = new Size(1054, 270);
            dataGridViewLahan.TabIndex = 1;
            dataGridViewLahan.CellContentClick += dataGridViewLahan_CellContentClick;
            // 
            // Id
            // 
            Id.Frozen = true;
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // Id_Lahan
            // 
            Id_Lahan.HeaderText = "Id_Lahan";
            Id_Lahan.MinimumWidth = 6;
            Id_Lahan.Name = "Id_Lahan";
            Id_Lahan.Width = 125;
            // 
            // NamaLahan
            // 
            NamaLahan.HeaderText = "NamaLahan";
            NamaLahan.MinimumWidth = 6;
            NamaLahan.Name = "NamaLahan";
            NamaLahan.Width = 125;
            // 
            // Lokasi
            // 
            Lokasi.HeaderText = "Lokasi";
            Lokasi.MinimumWidth = 6;
            Lokasi.Name = "Lokasi";
            Lokasi.Width = 125;
            // 
            // Deskripsi
            // 
            Deskripsi.HeaderText = "Deskripsi";
            Deskripsi.MinimumWidth = 6;
            Deskripsi.Name = "Deskripsi";
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
            // Tambah
            // 
            Tambah.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Tambah.ForeColor = Color.OliveDrab;
            Tambah.Location = new Point(76, 593);
            Tambah.Name = "Tambah";
            Tambah.Size = new Size(148, 50);
            Tambah.TabIndex = 2;
            Tambah.Text = "Tambah";
            Tambah.UseVisualStyleBackColor = true;
            Tambah.Click += Tambah_Click;
            // 
            // Edit
            // 
            Edit.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Edit.ForeColor = Color.OliveDrab;
            Edit.Location = new Point(263, 593);
            Edit.Name = "Edit";
            Edit.Size = new Size(148, 50);
            Edit.TabIndex = 3;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = true;
            Edit.Click += Edit_Click;
            // 
            // Hapus
            // 
            Hapus.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Hapus.ForeColor = Color.OliveDrab;
            Hapus.Location = new Point(445, 593);
            Hapus.Name = "Hapus";
            Hapus.Size = new Size(148, 50);
            Hapus.TabIndex = 5;
            Hapus.Text = "Hapus";
            Hapus.UseVisualStyleBackColor = true;
            Hapus.Click += Hapus_Click;
            // 
            // Refresh
            // 
            Refresh.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Refresh.ForeColor = Color.OliveDrab;
            Refresh.Location = new Point(638, 593);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(148, 50);
            Refresh.TabIndex = 6;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = true;
            Refresh.Click += Refresh_Click;
            // 
            // Logout
            // 
            Logout.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Logout.ForeColor = Color.OliveDrab;
            Logout.Location = new Point(1291, 743);
            Logout.Name = "Logout";
            Logout.Size = new Size(148, 50);
            Logout.TabIndex = 7;
            Logout.Text = "Logout";
            Logout.UseVisualStyleBackColor = true;
            Logout.Click += Logout_Click;
            // 
            // buttonLihatPerkembangan
            // 
            buttonLihatPerkembangan.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLihatPerkembangan.ForeColor = Color.OliveDrab;
            buttonLihatPerkembangan.Location = new Point(445, 673);
            buttonLihatPerkembangan.Name = "buttonLihatPerkembangan";
            buttonLihatPerkembangan.Size = new Size(341, 50);
            buttonLihatPerkembangan.TabIndex = 8;
            buttonLihatPerkembangan.Text = "Lihat Perkembangan";
            buttonLihatPerkembangan.UseVisualStyleBackColor = true;
            buttonLihatPerkembangan.Click += buttonLihatPerkembangan_Click_1;
            // 
            // buttonUpdatePerkembangan
            // 
            buttonUpdatePerkembangan.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonUpdatePerkembangan.ForeColor = Color.OliveDrab;
            buttonUpdatePerkembangan.Location = new Point(70, 674);
            buttonUpdatePerkembangan.Name = "buttonUpdatePerkembangan";
            buttonUpdatePerkembangan.Size = new Size(341, 48);
            buttonUpdatePerkembangan.TabIndex = 9;
            buttonUpdatePerkembangan.Text = "Update Perkembangan";
            buttonUpdatePerkembangan.UseVisualStyleBackColor = true;
            buttonUpdatePerkembangan.Click += buttonUpdatePerkembangan_Click;
            // 
            // Dashboard_Petani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._2;
            ClientSize = new Size(1537, 864);
            Controls.Add(buttonUpdatePerkembangan);
            Controls.Add(buttonLihatPerkembangan);
            Controls.Add(Logout);
            Controls.Add(Refresh);
            Controls.Add(Hapus);
            Controls.Add(Edit);
            Controls.Add(Tambah);
            Controls.Add(dataGridViewLahan);
            Controls.Add(label1);
            Name = "Dashboard_Petani";
            Text = "Dashboard_Petani";
            Load += Dashboard_Petani_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLahan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewLahan;
        private Button Tambah;
        private Button Edit;
        private Button Hapus;
        private Button Refresh;
        private Button Logout;
        private Button buttonLihatPerkembangan;
        private Button buttonUpdatePerkembangan;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Id_Lahan;
        private DataGridViewTextBoxColumn NamaLahan;
        private DataGridViewTextBoxColumn Lokasi;
        private DataGridViewTextBoxColumn Deskripsi;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewTextBoxColumn TanggalUpload;
        private DataGridViewTextBoxColumn NoHp;
    }
}