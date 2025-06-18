namespace PantiApp3.Views
{
    partial class LaporanDonasi
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
            panel1 = new Panel();
            btnkembali = new Button();
            cbjangka_waktu = new ComboBox();
            dataGridriwayat1 = new DataGridView();
            lbjudul_laporan = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridriwayat1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnkembali);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 50);
            panel1.TabIndex = 1;
            // 
            // btnkembali
            // 
            btnkembali.BackColor = Color.Transparent;
            btnkembali.BackgroundImageLayout = ImageLayout.None;
            btnkembali.FlatStyle = FlatStyle.Flat;
            btnkembali.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnkembali.ForeColor = Color.FromArgb(64, 64, 64);
            btnkembali.Location = new Point(31, 7);
            btnkembali.Name = "btnkembali";
            btnkembali.Size = new Size(103, 37);
            btnkembali.TabIndex = 0;
            btnkembali.Text = "<  Kembali";
            btnkembali.TextAlign = ContentAlignment.TopLeft;
            btnkembali.UseVisualStyleBackColor = false;
            btnkembali.Click += new EventHandler(btnkembali_Click);
            // 
            // cbjangka_waktu
            // 
            cbjangka_waktu.Font = new Font("Segoe UI", 13F);
            cbjangka_waktu.Items.AddRange(new object[] { "1 Bulan", "3 Bulan", "6 Bulan", "1 Tahun", "Semua" });
            cbjangka_waktu.Location = new Point(87, 139);
            cbjangka_waktu.Name = "cbjangka_waktu";
            cbjangka_waktu.Size = new Size(211, 31);
            cbjangka_waktu.TabIndex = 2;
            cbjangka_waktu.Text = "Pilih Jangka Waktu";
            cbjangka_waktu.SelectedIndexChanged += new EventHandler(cbjangka_waktu_SelectedIndexChanged);
            // 
            // dataGridriwayat1
            // 
            dataGridriwayat1.AllowUserToAddRows = false;
            dataGridriwayat1.AllowUserToDeleteRows = false;
            dataGridriwayat1.AllowUserToOrderColumns = true;
            dataGridriwayat1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridriwayat1.BorderStyle = BorderStyle.None;
            dataGridriwayat1.Location = new Point(85, 176);
            dataGridriwayat1.Name = "dataGridriwayat1";
            dataGridriwayat1.ReadOnly = true;
            dataGridriwayat1.RowHeadersVisible = false;
            dataGridriwayat1.RowHeadersWidth = 100;
            dataGridriwayat1.Size = new Size(625, 262);
            dataGridriwayat1.TabIndex = 7;
            // 
            // lbjudul_laporan
            // 
            lbjudul_laporan.AutoSize = true;
            lbjudul_laporan.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lbjudul_laporan.Location = new Point(239, 86);
            lbjudul_laporan.Name = "lbjudul_laporan";
            lbjudul_laporan.Size = new Size(334, 31);
            lbjudul_laporan.TabIndex = 8;
            lbjudul_laporan.Text = "Laporan Riwayat Donasi Anda";
            // 
            // Laporan_Donasi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbjudul_laporan);
            Controls.Add(dataGridriwayat1);
            Controls.Add(cbjangka_waktu);
            Controls.Add(panel1);
            Name = "Laporan_Donasi";
            Text = "Laporan_Donasi";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridriwayat1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Panel panel1;
        private Button btnkembali;
        private ComboBox cbjangka_waktu;
        private DataGridView dataGridriwayat1;
        private Label lbjudul_laporan;
    }
}