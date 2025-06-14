namespace AGROPT.Dashboard.Petani
{
    partial class Perkembangan
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxIdLahan = new TextBox();
            textBoxNamaLahan = new TextBox();
            textBoxKeterangan = new TextBox();
            textBoxProgresPanen = new TextBox();
            buttonSimpan = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.YellowGreen;
            label1.Location = new Point(1067, 207);
            label1.Name = "label1";
            label1.Size = new Size(707, 76);
            label1.TabIndex = 0;
            label1.Text = "Update Perkembangan ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.YellowGreen;
            label2.Location = new Point(1165, 368);
            label2.Name = "label2";
            label2.Size = new Size(132, 35);
            label2.TabIndex = 1;
            label2.Text = "Id_Lahan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.YellowGreen;
            label3.Location = new Point(1161, 478);
            label3.Name = "label3";
            label3.Size = new Size(161, 33);
            label3.TabIndex = 2;
            label3.Text = "Nama Lahan";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.YellowGreen;
            label4.Location = new Point(1161, 587);
            label4.Name = "label4";
            label4.Size = new Size(146, 33);
            label4.TabIndex = 3;
            label4.Text = "Keterangan";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.YellowGreen;
            label5.Location = new Point(1161, 694);
            label5.Name = "label5";
            label5.Size = new Size(179, 33);
            label5.TabIndex = 4;
            label5.Text = "Progres Panen";
            // 
            // textBoxIdLahan
            // 
            textBoxIdLahan.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxIdLahan.ForeColor = Color.YellowGreen;
            textBoxIdLahan.Location = new Point(1161, 406);
            textBoxIdLahan.Name = "textBoxIdLahan";
            textBoxIdLahan.Size = new Size(495, 43);
            textBoxIdLahan.TabIndex = 5;
            textBoxIdLahan.TextChanged += textBoxIdLahan_TextChanged;
            // 
            // textBoxNamaLahan
            // 
            textBoxNamaLahan.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNamaLahan.ForeColor = Color.YellowGreen;
            textBoxNamaLahan.Location = new Point(1161, 514);
            textBoxNamaLahan.Name = "textBoxNamaLahan";
            textBoxNamaLahan.Size = new Size(495, 43);
            textBoxNamaLahan.TabIndex = 6;
            textBoxNamaLahan.TextChanged += textBoxNamaLahan_TextChanged;
            // 
            // textBoxKeterangan
            // 
            textBoxKeterangan.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxKeterangan.ForeColor = Color.YellowGreen;
            textBoxKeterangan.Location = new Point(1161, 623);
            textBoxKeterangan.Name = "textBoxKeterangan";
            textBoxKeterangan.Size = new Size(496, 43);
            textBoxKeterangan.TabIndex = 7;
            textBoxKeterangan.TextChanged += textBoxKeterangan_TextChanged;
            // 
            // textBoxProgresPanen
            // 
            textBoxProgresPanen.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxProgresPanen.ForeColor = Color.YellowGreen;
            textBoxProgresPanen.Location = new Point(1161, 730);
            textBoxProgresPanen.Name = "textBoxProgresPanen";
            textBoxProgresPanen.Size = new Size(496, 43);
            textBoxProgresPanen.TabIndex = 8;
            textBoxProgresPanen.TextChanged += textBoxProgresPanen_TextChanged;
            // 
            // buttonSimpan
            // 
            buttonSimpan.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSimpan.ForeColor = Color.OliveDrab;
            buttonSimpan.Location = new Point(1257, 840);
            buttonSimpan.Name = "buttonSimpan";
            buttonSimpan.Size = new Size(318, 71);
            buttonSimpan.TabIndex = 9;
            buttonSimpan.Text = "Simpan";
            buttonSimpan.UseVisualStyleBackColor = true;
            buttonSimpan.Click += buttonSimpan_Click_1;
            // 
            // Perkembangan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._3;
            ClientSize = new Size(1924, 1055);
            Controls.Add(buttonSimpan);
            Controls.Add(textBoxProgresPanen);
            Controls.Add(textBoxKeterangan);
            Controls.Add(textBoxNamaLahan);
            Controls.Add(textBoxIdLahan);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Perkembangan";
            Text = "Perkembangan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxIdLahan;
        private TextBox textBoxNamaLahan;
        private TextBox textBoxKeterangan;
        private TextBox textBoxProgresPanen;
        private Button buttonSimpan;
    }
}