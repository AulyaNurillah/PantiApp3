namespace PantiApp3.Views
{
    partial class DonaturDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonaturDashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnprofile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btntunai = new System.Windows.Forms.Button();
            this.lbket_tambah = new System.Windows.Forms.Label();
            this.pbtambah_donasi = new System.Windows.Forms.PictureBox();
            this.lbbuat_donasi = new System.Windows.Forms.Label();
            this.btntambah_donasi = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnlaporan_donasi = new System.Windows.Forms.Button();
            this.lbket_laporan = new System.Windows.Forms.Label();
            this.pblaporan_donasi = new System.Windows.Forms.PictureBox();
            this.lblaporan_donasi = new System.Windows.Forms.Label();
            this.lbriwayat = new System.Windows.Forms.Label();
            this.dataGridriwayat = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbtambah_donasi)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblaporan_donasi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridriwayat)).BeginInit();
            this.SuspendLayout();

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selamat Datang, Donatur";

            // panel1
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnprofile);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 72);
            this.panel1.TabIndex = 1;

            // btnprofile
            this.btnprofile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnprofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprofile.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnprofile.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.btnprofile.Image = ((System.Drawing.Image)(resources.GetObject("btnprofile.Image")));
            this.btnprofile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnprofile.Location = new System.Drawing.Point(687, 12);
            this.btnprofile.Name = "btnprofile";
            this.btnprofile.Size = new System.Drawing.Size(101, 48);
            this.btnprofile.TabIndex = 3;
            this.btnprofile.Text = "Profile";
            this.btnprofile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprofile.UseVisualStyleBackColor = false;

            // label2
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.Location = new System.Drawing.Point(15, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(405, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Terima kasih atas kontribusi Anda dalam membantu sesama";

            // panel2
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btntunai);
            this.panel2.Controls.Add(this.lbket_tambah);
            this.panel2.Controls.Add(this.pbtambah_donasi);
            this.panel2.Controls.Add(this.lbbuat_donasi);
            this.panel2.Controls.Add(this.btntambah_donasi);
            this.panel2.Location = new System.Drawing.Point(98, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 172);
            this.panel2.TabIndex = 2;

            // btntunai
            this.btntunai.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btntunai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntunai.Location = new System.Drawing.Point(24, 129);
            this.btntunai.Name = "btntunai";
            this.btntunai.Size = new System.Drawing.Size(119, 25);
            this.btntunai.TabIndex = 9;
            this.btntunai.Text = "Donasi Tunai";
            this.btntunai.UseVisualStyleBackColor = false;

            // lbket_tambah
            this.lbket_tambah.AutoSize = true;
            this.lbket_tambah.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbket_tambah.Location = new System.Drawing.Point(21, 80);
            this.lbket_tambah.Name = "lbket_tambah";
            this.lbket_tambah.Size = new System.Drawing.Size(259, 34);
            this.lbket_tambah.TabIndex = 8;
            this.lbket_tambah.Text = "Donasi baru untuk membantu mereka yang\r\nmembutuhkan";

            // pbtambah_donasi
            this.pbtambah_donasi.Image = ((System.Drawing.Image)(resources.GetObject("pbtambah_donasi.Image")));
            this.pbtambah_donasi.Location = new System.Drawing.Point(24, 15);
            this.pbtambah_donasi.Name = "pbtambah_donasi";
            this.pbtambah_donasi.Size = new System.Drawing.Size(50, 50);
            this.pbtambah_donasi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbtambah_donasi.TabIndex = 7;
            this.pbtambah_donasi.TabStop = false;

            // lbbuat_donasi
            this.lbbuat_donasi.AutoSize = true;
            this.lbbuat_donasi.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lbbuat_donasi.Location = new System.Drawing.Point(83, 26);
            this.lbbuat_donasi.Name = "lbbuat_donasi";
            this.lbbuat_donasi.Size = new System.Drawing.Size(160, 25);
            this.lbbuat_donasi.TabIndex = 6;
            this.lbbuat_donasi.Text = "Buat Donasi Baru";

            // btntambah_donasi
            this.btntambah_donasi.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btntambah_donasi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntambah_donasi.Location = new System.Drawing.Point(161, 129);
            this.btntambah_donasi.Name = "btntambah_donasi";
            this.btntambah_donasi.Size = new System.Drawing.Size(119, 25);
            this.btntambah_donasi.TabIndex = 5;
            this.btntambah_donasi.Text = "Donasi Barang";
            this.btntambah_donasi.UseVisualStyleBackColor = false;

            // panel4
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.btnlaporan_donasi);
            this.panel4.Controls.Add(this.lbket_laporan);
            this.panel4.Controls.Add(this.pblaporan_donasi);
            this.panel4.Controls.Add(this.lblaporan_donasi);
            this.panel4.Location = new System.Drawing.Point(420, 87);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 172);
            this.panel4.TabIndex = 4;

            // btnlaporan_donasi
            this.btnlaporan_donasi.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnlaporan_donasi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlaporan_donasi.Location = new System.Drawing.Point(24, 129);
            this.btnlaporan_donasi.Name = "btnlaporan_donasi";
            this.btnlaporan_donasi.Size = new System.Drawing.Size(256, 25);
            this.btnlaporan_donasi.TabIndex = 12;
            this.btnlaporan_donasi.Text = "Lihat Laporan";
            this.btnlaporan_donasi.UseVisualStyleBackColor = false;

            // lbket_laporan
            this.lbket_laporan.AutoSize = true;
            this.lbket_laporan.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbket_laporan.Location = new System.Drawing.Point(21, 80);
            this.lbket_laporan.Name = "lbket_laporan";
            this.lbket_laporan.Size = new System.Drawing.Size(235, 34);
            this.lbket_laporan.TabIndex = 11;
            this.lbket_laporan.Text = "Lihat semua donasi yang pernah Anda \r\nberikan\r\n";

            // pblaporan_donasi
            this.pblaporan_donasi.Image = ((System.Drawing.Image)(resources.GetObject("pblaporan_donasi.Image")));
            this.pblaporan_donasi.Location = new System.Drawing.Point(24, 15);
            this.pblaporan_donasi.Name = "pblaporan_donasi";
            this.pblaporan_donasi.Size = new System.Drawing.Size(48, 48);
            this.pblaporan_donasi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pblaporan_donasi.TabIndex = 10;
            this.pblaporan_donasi.TabStop = false;

            // lblaporan_donasi
            this.lblaporan_donasi.AutoSize = true;
            this.lblaporan_donasi.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblaporan_donasi.Location = new System.Drawing.Point(80, 26);
            this.lblaporan_donasi.Name = "lblaporan_donasi";
            this.lblaporan_donasi.Size = new System.Drawing.Size(172, 25);
            this.lblaporan_donasi.TabIndex = 9;
            this.lblaporan_donasi.Text = "Laporan Keuangan";

            // lbriwayat
            this.lbriwayat.AutoSize = true;
            this.lbriwayat.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lbriwayat.Location = new System.Drawing.Point(95, 271);
            this.lbriwayat.Name = "lbriwayat";
            this.lbriwayat.Size = new System.Drawing.Size(218, 25);
            this.lbriwayat.TabIndex = 7;
            this.lbriwayat.Text = "Riwayat Donasi Terbaru:";

            // dataGridriwayat
            this.dataGridriwayat.AllowUserToAddRows = false;
            this.dataGridriwayat.AllowUserToDeleteRows = false;
            this.dataGridriwayat.AllowUserToResizeColumns = false;
            this.dataGridriwayat.AllowUserToResizeRows = false;
            this.dataGridriwayat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridriwayat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridriwayat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridriwayat.Location = new System.Drawing.Point(95, 307);
            this.dataGridriwayat.MultiSelect = false;
            this.dataGridriwayat.Name = "dataGridriwayat";
            this.dataGridriwayat.ReadOnly = true;
            this.dataGridriwayat.RowHeadersVisible = false;
            this.dataGridriwayat.Size = new System.Drawing.Size(625, 125);
            this.dataGridriwayat.TabIndex = 8;

            // DonaturDashboard
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridriwayat);
            this.Controls.Add(this.lbriwayat);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DonaturDashboard";
            this.Text = "DonaturDashboard";

            // EVENT HANDLERS
            this.btntambah_donasi.Click += new System.EventHandler(this.btntambah_donasi_Click);
            this.btnlaporan_donasi.Click += new System.EventHandler(this.btnlaporan_donasi_Click);
            this.btnprofile.Click += new System.EventHandler(this.btnprofile_Click);
            this.btntunai.Click += new System.EventHandler(this.btntunai_Click);

            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbtambah_donasi)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblaporan_donasi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridriwayat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnprofile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btntunai;
        private System.Windows.Forms.Label lbket_tambah;
        private System.Windows.Forms.PictureBox pbtambah_donasi;
        private System.Windows.Forms.Label lbbuat_donasi;
        private System.Windows.Forms.Button btntambah_donasi;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnlaporan_donasi;
        private System.Windows.Forms.Label lbket_laporan;
        private System.Windows.Forms.PictureBox pblaporan_donasi;
        private System.Windows.Forms.Label lblaporan_donasi;
        private System.Windows.Forms.Label lbriwayat;
        private System.Windows.Forms.DataGridView dataGridriwayat;
    }
}
