namespace AGROPT.Dashboard.Admin
{
    partial class Dashboard_Admin
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
            buttonLihatLahan = new Button();
            buttonLihatPerkembangan = new Button();
            buttonLihatPembayaran = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonLihatLahan
            // 
            buttonLihatLahan.Font = new Font("Times New Roman", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonLihatLahan.ForeColor = Color.OliveDrab;
            buttonLihatLahan.Location = new Point(1174, 355);
            buttonLihatLahan.Name = "buttonLihatLahan";
            buttonLihatLahan.Size = new Size(376, 51);
            buttonLihatLahan.TabIndex = 0;
            buttonLihatLahan.Text = "Lihat Lahan";
            buttonLihatLahan.UseVisualStyleBackColor = true;
            buttonLihatLahan.Click += buttonLihatLahan_Click;
            // 
            // buttonLihatPerkembangan
            // 
            buttonLihatPerkembangan.Font = new Font("Times New Roman", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonLihatPerkembangan.ForeColor = Color.OliveDrab;
            buttonLihatPerkembangan.Location = new Point(1174, 558);
            buttonLihatPerkembangan.Name = "buttonLihatPerkembangan";
            buttonLihatPerkembangan.Size = new Size(376, 51);
            buttonLihatPerkembangan.TabIndex = 1;
            buttonLihatPerkembangan.Text = "Lihat Perkembangan";
            buttonLihatPerkembangan.UseVisualStyleBackColor = true;
            buttonLihatPerkembangan.Click += buttonLihatPerkembangan_Click;
            // 
            // buttonLihatPembayaran
            // 
            buttonLihatPembayaran.Font = new Font("Times New Roman", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonLihatPembayaran.ForeColor = Color.OliveDrab;
            buttonLihatPembayaran.Location = new Point(1174, 463);
            buttonLihatPembayaran.Name = "buttonLihatPembayaran";
            buttonLihatPembayaran.Size = new Size(376, 51);
            buttonLihatPembayaran.TabIndex = 4;
            buttonLihatPembayaran.Text = "Lihat Pembayaran";
            buttonLihatPembayaran.UseVisualStyleBackColor = true;
            buttonLihatPembayaran.Click += buttonLihatPembayaran_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 49.8000031F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.OliveDrab;
            label1.Location = new Point(1105, 151);
            label1.Name = "label1";
            label1.Size = new Size(514, 95);
            label1.TabIndex = 5;
            label1.Text = "Menu Admin";
            // 
            // Dashboard_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._4;
            ClientSize = new Size(1924, 1055);
            Controls.Add(label1);
            Controls.Add(buttonLihatPembayaran);
            Controls.Add(buttonLihatPerkembangan);
            Controls.Add(buttonLihatLahan);
            Name = "Dashboard_Admin";
            Text = "Dashboard_Admin";
            Load += Dashboard_Admin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLihatLahan;
        private Button buttonLihatPerkembangan;
        private Button buttonLihatPembayaran;
        private Label label1;
    }
}