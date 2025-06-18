namespace PantiApp3.Views
{
    partial class DonaturDashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            btnprofile = new Button();
            label2 = new Label();
            panel2 = new Panel();
            lbket_tambah = new Label();
            pbtambah_donasi = new PictureBox();
            lbbuat_donasi = new Label();
            btntambah_donasi = new Button();
            panel4 = new Panel();
            btnlaporan_donasi = new Button();
            lbket_laporan = new Label();
            pblaporan_donasi = new PictureBox();
            lblaporan_donasi = new Label();
            lbriwayat = new Label();
            dataGridriwayat = new DataGridView();
            btnLogout = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbtambah_donasi).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pblaporan_donasi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridriwayat).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label1.Location = new Point(15, 9);
            label1.Name = "label1";
            label1.Size = new Size(285, 31);
            label1.TabIndex = 0;
            label1.Text = "Selamat Datang, Donatur";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnprofile);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 72);
            panel1.TabIndex = 1;
            // 
            // btnprofile
            // 
            btnprofile.BackColor = SystemColors.ActiveCaption;
            btnprofile.FlatStyle = FlatStyle.Flat;
            btnprofile.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnprofile.ForeColor = Color.FromArgb(64, 64, 64);
            btnprofile.ImageAlign = ContentAlignment.MiddleRight;
            btnprofile.Location = new Point(594, 30);
            btnprofile.Name = "btnprofile";
            btnprofile.Size = new Size(88, 30);
            btnprofile.TabIndex = 3;
            btnprofile.Text = "Profile";
            btnprofile.UseCompatibleTextRendering = true;
            btnprofile.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(15, 40);
            label2.Name = "label2";
            label2.Size = new Size(405, 20);
            label2.TabIndex = 1;
            label2.Text = "Terima kasih atas kontribusi Anda dalam membantu sesama";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(lbket_tambah);
            panel2.Controls.Add(pbtambah_donasi);
            panel2.Controls.Add(lbbuat_donasi);
            panel2.Controls.Add(btntambah_donasi);
            panel2.Location = new Point(98, 87);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 172);
            panel2.TabIndex = 2;
            // 
            // lbket_tambah
            // 
            lbket_tambah.AutoSize = true;
            lbket_tambah.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbket_tambah.Location = new Point(21, 80);
            lbket_tambah.Name = "lbket_tambah";
            lbket_tambah.Size = new Size(259, 34);
            lbket_tambah.TabIndex = 8;
            lbket_tambah.Text = "Donasi baru untuk membantu mereka yang\r\nmembutuhkan";
            // 
            // pbtambah_donasi
            // 
            pbtambah_donasi.Location = new Point(24, 15);
            pbtambah_donasi.Name = "pbtambah_donasi";
            pbtambah_donasi.Size = new Size(50, 50);
            pbtambah_donasi.SizeMode = PictureBoxSizeMode.StretchImage;
            pbtambah_donasi.TabIndex = 7;
            pbtambah_donasi.TabStop = false;
            // 
            // lbbuat_donasi
            // 
            lbbuat_donasi.AutoSize = true;
            lbbuat_donasi.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lbbuat_donasi.Location = new Point(83, 26);
            lbbuat_donasi.Name = "lbbuat_donasi";
            lbbuat_donasi.Size = new Size(160, 25);
            lbbuat_donasi.TabIndex = 6;
            lbbuat_donasi.Text = "Buat Donasi Baru";
            // 
            // btntambah_donasi
            // 
            btntambah_donasi.BackColor = SystemColors.HotTrack;
            btntambah_donasi.FlatStyle = FlatStyle.Popup;
            btntambah_donasi.Location = new Point(24, 129);
            btntambah_donasi.Name = "btntambah_donasi";
            btntambah_donasi.Size = new Size(256, 25);
            btntambah_donasi.TabIndex = 5;
            btntambah_donasi.Text = "Donasi Sekarang";
            btntambah_donasi.UseVisualStyleBackColor = false;
            btntambah_donasi.Click += btntambah_donasi_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(btnlaporan_donasi);
            panel4.Controls.Add(lbket_laporan);
            panel4.Controls.Add(pblaporan_donasi);
            panel4.Controls.Add(lblaporan_donasi);
            panel4.Location = new Point(420, 87);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 172);
            panel4.TabIndex = 4;
            // 
            // btnlaporan_donasi
            // 
            btnlaporan_donasi.BackColor = SystemColors.HotTrack;
            btnlaporan_donasi.FlatStyle = FlatStyle.Popup;
            btnlaporan_donasi.Location = new Point(24, 129);
            btnlaporan_donasi.Name = "btnlaporan_donasi";
            btnlaporan_donasi.Size = new Size(256, 25);
            btnlaporan_donasi.TabIndex = 12;
            btnlaporan_donasi.Text = "Lihat Laporan";
            btnlaporan_donasi.UseVisualStyleBackColor = false;
            btnlaporan_donasi.Click += btnlaporan_donasi_Click;
            // 
            // lbket_laporan
            // 
            lbket_laporan.AutoSize = true;
            lbket_laporan.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbket_laporan.Location = new Point(21, 80);
            lbket_laporan.Name = "lbket_laporan";
            lbket_laporan.Size = new Size(235, 34);
            lbket_laporan.TabIndex = 11;
            lbket_laporan.Text = "Lihat semua donasi yang pernah Anda \r\nberikan\r\n";
            // 
            // pblaporan_donasi
            // 
            pblaporan_donasi.Location = new Point(24, 15);
            pblaporan_donasi.Name = "pblaporan_donasi";
            pblaporan_donasi.Size = new Size(48, 48);
            pblaporan_donasi.SizeMode = PictureBoxSizeMode.Zoom;
            pblaporan_donasi.TabIndex = 10;
            pblaporan_donasi.TabStop = false;
            // 
            // lblaporan_donasi
            // 
            lblaporan_donasi.AutoSize = true;
            lblaporan_donasi.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblaporan_donasi.Location = new Point(80, 26);
            lblaporan_donasi.Name = "lblaporan_donasi";
            lblaporan_donasi.Size = new Size(172, 25);
            lblaporan_donasi.TabIndex = 9;
            lblaporan_donasi.Text = "Laporan Keuangan\n";
            // 
            // lbriwayat
            // 
            lbriwayat.AutoSize = true;
            lbriwayat.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lbriwayat.Location = new Point(95, 271);
            lbriwayat.Name = "lbriwayat";
            lbriwayat.Size = new Size(218, 25);
            lbriwayat.TabIndex = 7;
            lbriwayat.Text = "Riwayat Donasi Terbaru:";
            // 
            // dataGridriwayat
            // 
            dataGridriwayat.AllowUserToAddRows = false;
            dataGridriwayat.AllowUserToDeleteRows = false;
            dataGridriwayat.AllowUserToResizeColumns = false;
            dataGridriwayat.AllowUserToResizeRows = false;
            dataGridriwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridriwayat.BorderStyle = BorderStyle.None;
            dataGridriwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridriwayat.Location = new Point(95, 307);
            dataGridriwayat.MultiSelect = false;
            dataGridriwayat.Name = "dataGridriwayat";
            dataGridriwayat.ReadOnly = true;
            dataGridriwayat.RowHeadersVisible = false;
            dataGridriwayat.RowHeadersWidth = 100;
            dataGridriwayat.Size = new Size(625, 125);
            dataGridriwayat.TabIndex = 8;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.IndianRed;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(688, 30);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(100, 30);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // DonaturDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridriwayat);
            Controls.Add(lbriwayat);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            Name = "DonaturDashboard";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbtambah_donasi).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pblaporan_donasi).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridriwayat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Button btntambah_donasi;
        private Label lbbuat_donasi;
        private PictureBox pbtambah_donasi;
        private Label lbket_tambah;
        private Label lbket_laporan;
        private PictureBox pblaporan_donasi;
        private Label lblaporan_donasi;
        private Button btnlaporan_donasi;
        private Label label2;
        private Button btnprofile;
        private Button btnLogout;
        private Label lbriwayat;
        private DataGridView dataGridriwayat;
    }
}