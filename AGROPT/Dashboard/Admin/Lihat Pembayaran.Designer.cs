namespace AGROPT.Dashboard.Admin
{
    partial class Lihat_Pembayaran
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
            dataGridView1 = new DataGridView();
            Id_Lahan = new DataGridViewTextBoxColumn();
            NamaLahan = new DataGridViewTextBoxColumn();
            Lokasi = new DataGridViewTextBoxColumn();
            KodePembayaran = new DataGridViewTextBoxColumn();
            NamaPembeli = new DataGridViewTextBoxColumn();
            AlamatPembeli = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            label1 = new Label();
            buttonEdit = new Button();
            buttonLogout = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.YellowGreen;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id_Lahan, NamaLahan, Lokasi, KodePembayaran, NamaPembeli, AlamatPembeli, Status });
            dataGridView1.Location = new Point(849, 332);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(931, 227);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // KodePembayaran
            // 
            KodePembayaran.HeaderText = "KodePembayaran";
            KodePembayaran.MinimumWidth = 6;
            KodePembayaran.Name = "KodePembayaran";
            KodePembayaran.ReadOnly = true;
            KodePembayaran.Width = 125;
            // 
            // NamaPembeli
            // 
            NamaPembeli.HeaderText = "NamaPembeli";
            NamaPembeli.MinimumWidth = 6;
            NamaPembeli.Name = "NamaPembeli";
            NamaPembeli.ReadOnly = true;
            NamaPembeli.Width = 125;
            // 
            // AlamatPembeli
            // 
            AlamatPembeli.HeaderText = "AlamatPembeli";
            AlamatPembeli.MinimumWidth = 6;
            AlamatPembeli.Name = "AlamatPembeli";
            AlamatPembeli.ReadOnly = true;
            AlamatPembeli.Width = 125;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 49.8000031F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.OliveDrab;
            label1.Location = new Point(968, 136);
            label1.Name = "label1";
            label1.Size = new Size(713, 95);
            label1.TabIndex = 1;
            label1.Text = "Data Pembayaran ";
            // 
            // buttonEdit
            // 
            buttonEdit.Font = new Font("Times New Roman", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonEdit.ForeColor = Color.OliveDrab;
            buttonEdit.Location = new Point(1371, 622);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(182, 57);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Simpan";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.Font = new Font("Times New Roman", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonLogout.ForeColor = Color.OliveDrab;
            buttonLogout.Location = new Point(1598, 622);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(182, 57);
            buttonLogout.TabIndex = 3;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.OliveDrab;
            label2.Location = new Point(849, 576);
            label2.Name = "label2";
            label2.Size = new Size(450, 38);
            label2.TabIndex = 4;
            label2.Text = "Silakan centang status pembayaran";
            // 
            // Lihat_Pembayaran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._4;
            ClientSize = new Size(1900, 1055);
            Controls.Add(label2);
            Controls.Add(buttonLogout);
            Controls.Add(buttonEdit);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Lihat_Pembayaran";
            Text = "Lihat_Pembayaran";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private DataGridViewTextBoxColumn Id_Lahan;
        private DataGridViewTextBoxColumn NamaLahan;
        private DataGridViewTextBoxColumn Lokasi;
        private DataGridViewTextBoxColumn KodePembayaran;
        private DataGridViewTextBoxColumn NamaPembeli;
        private DataGridViewTextBoxColumn AlamatPembeli;
        private DataGridViewTextBoxColumn Status;
        private Button buttonEdit;
        private Button buttonLogout;
        private Label label2;
    }
}