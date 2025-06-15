namespace PantiApp3.Views
{
    partial class KelolaKeuangan
    {
        private System.ComponentModel.IContainer components = null;
        private Panel header;
        private Label lblTitle;
        private Label lblSubTitle;
        private Button btnPemasukan;
        private Button btnPengeluaran;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            header = new Panel();
            lblTitle = new Label();
            lblSubTitle = new Label();
            btnPemasukan = new Button();
            btnPengeluaran = new Button();
            header.SuspendLayout();
            SuspendLayout();
            // 
            // header
            // 
            header.BackColor = Color.MediumSlateBlue;
            header.Controls.Add(lblTitle);
            header.Controls.Add(lblSubTitle);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(820, 60);
            header.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Sitka Display", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(10, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(148, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Kelola Keuangan";
            // 
            // lblSubTitle
            // 
            lblSubTitle.AutoSize = true;
            lblSubTitle.Font = new Font("Sitka Display", 11F, FontStyle.Italic);
            lblSubTitle.ForeColor = Color.WhiteSmoke;
            lblSubTitle.Location = new Point(10, 32);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(212, 21);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "Pilih kategori transaksi keuangan";
            // 
            // btnPemasukan
            // 
            btnPemasukan.BackColor = Color.LightGreen;
            btnPemasukan.FlatStyle = FlatStyle.Flat;
            btnPemasukan.Font = new Font("Sitka Display", 12F);
            btnPemasukan.ForeColor = Color.Black;
            btnPemasukan.Location = new Point(68, 106);
            btnPemasukan.Name = "btnPemasukan";
            btnPemasukan.Size = new Size(311, 291);
            btnPemasukan.TabIndex = 1;
            btnPemasukan.Text = "Pemasukan";
            btnPemasukan.UseVisualStyleBackColor = false;
            btnPemasukan.Click += btnPemasukan_Click;
            // 
            // btnPengeluaran
            // 
            btnPengeluaran.BackColor = Color.LightCoral;
            btnPengeluaran.FlatStyle = FlatStyle.Flat;
            btnPengeluaran.Font = new Font("Sitka Display", 12F);
            btnPengeluaran.ForeColor = Color.Black;
            btnPengeluaran.Location = new Point(436, 106);
            btnPengeluaran.Name = "btnPengeluaran";
            btnPengeluaran.Size = new Size(311, 291);
            btnPengeluaran.TabIndex = 2;
            btnPengeluaran.Text = "Pengeluaran";
            btnPengeluaran.UseVisualStyleBackColor = false;
            btnPengeluaran.Click += btnPengeluaran_Click;
            // 
            // KelolaKeuangan
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 450);
            Controls.Add(btnPemasukan);
            Controls.Add(btnPengeluaran);
            Controls.Add(header);
            Font = new Font("Sitka Display", 11F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "KelolaKeuangan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kelola Keuangan";
            Load += KelolaKeuangan_Load;
            header.ResumeLayout(false);
            header.PerformLayout();
            ResumeLayout(false);
        }
    }
}
