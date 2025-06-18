namespace Donatur
{
    partial class TambahDonasi
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnkembali = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbjenis_barang = new TextBox();
            panel2 = new Panel();
            btninput_donasi = new Button();
            tbjumlah_barang = new TextBox();
            lb = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();

            // panel1
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnkembali);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 50);
            panel1.TabIndex = 0;

            // btnkembali
            btnkembali.BackColor = Color.Transparent;
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
            btnkembali.Click += new EventHandler(this.btnkembali_Click);

            // label1
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold);
            label1.Location = new Point(150, 80);
            label1.Name = "label1";
            label1.Size = new Size(448, 31);
            label1.TabIndex = 1;
            label1.Text = "Mari berbagi untuk masa depan mereka!";

            // label2
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Italic);
            label2.Location = new Point(29, 27);
            label2.Name = "label2";
            label2.Size = new Size(446, 25);
            label2.TabIndex = 2;
            label2.Text = "Yuk, tambahkan barang yang ingin Anda sumbangkan.";

            // label3
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(34, 69);
            label3.Name = "label3";
            label3.Size = new Size(110, 21);
            label3.TabIndex = 3;
            label3.Text = "Jenis Barang:";

            // tbjenis_barang
            tbjenis_barang.Font = new Font("Segoe UI", 11F);
            tbjenis_barang.Location = new Point(35, 95);
            tbjenis_barang.Name = "tbjenis_barang";
            tbjenis_barang.Size = new Size(520, 27);
            tbjenis_barang.TabIndex = 4;
            tbjenis_barang.Text = "Masukkan Jenis Barang...";
            tbjenis_barang.ForeColor = Color.Gray;
            tbjenis_barang.Enter += new EventHandler(this.tbjenis_barang_Enter);
            tbjenis_barang.Leave += new EventHandler(this.tbjenis_barang_Leave);

            // panel2
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(btninput_donasi);
            panel2.Controls.Add(tbjumlah_barang);
            panel2.Controls.Add(lb);
            panel2.Controls.Add(tbjenis_barang);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(98, 141);
            panel2.Name = "panel2";
            panel2.Size = new Size(594, 287);
            panel2.TabIndex = 5;

            // btninput_donasi
            btninput_donasi.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btninput_donasi.Location = new Point(250, 223);
            btninput_donasi.Name = "btninput_donasi";
            btninput_donasi.Size = new Size(112, 35);
            btninput_donasi.TabIndex = 7;
            btninput_donasi.Text = "Tambah";
            btninput_donasi.UseVisualStyleBackColor = true;
            btninput_donasi.Click += new EventHandler(this.btninput_donasi_Click);

            // tbjumlah_barang
            tbjumlah_barang.Font = new Font("Segoe UI", 11F);
            tbjumlah_barang.Location = new Point(36, 167);
            tbjumlah_barang.Name = "tbjumlah_barang";
            tbjumlah_barang.Size = new Size(520, 27);
            tbjumlah_barang.TabIndex = 6;
            tbjumlah_barang.Text = "Masukkan Jumlah Barang...";
            tbjumlah_barang.ForeColor = Color.Gray;
            tbjumlah_barang.Enter += new EventHandler(this.tbjumlah_barang_Enter);
            tbjumlah_barang.Leave += new EventHandler(this.tbjumlah_barang_Leave);

            // lb
            lb.AutoSize = true;
            lb.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb.Location = new Point(35, 141);
            lb.Name = "lb";
            lb.Size = new Size(128, 21);
            lb.TabIndex = 5;
            lb.Text = "Jumlah Barang:";

            // TambahDonasi
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "TambahDonasi";
            Text = "TambahDonasi";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        public TextBox tbjenis_barang;
        private Panel panel2;
        public TextBox tbjumlah_barang;
        private Label lb;
        public Button btninput_donasi;
        public Button btnkembali;
    }
}
