namespace PantiApp3.Views
{
    partial class KelolaKeuangan
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Button btnPemasukan;
        private System.Windows.Forms.Button btnPengeluaran;
        private System.Windows.Forms.Button btnKembali;

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
            this.header = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.btnPemasukan = new System.Windows.Forms.Button();
            this.btnPengeluaran = new System.Windows.Forms.Button();
            this.btnKembali = new System.Windows.Forms.Button();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.header.Controls.Add(this.lblTitle);
            this.header.Controls.Add(this.lblSubTitle);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(820, 60);
            this.header.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Sitka Display", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(10, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(148, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Kelola Keuangan";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Sitka Display", 11F, System.Drawing.FontStyle.Italic);
            this.lblSubTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSubTitle.Location = new System.Drawing.Point(10, 32);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(212, 21);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Pilih kategori transaksi keuangan";
            // 
            // btnPemasukan
            // 
            this.btnPemasukan.BackColor = System.Drawing.Color.LightGreen;
            this.btnPemasukan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPemasukan.Font = new System.Drawing.Font("Sitka Display", 12F);
            this.btnPemasukan.ForeColor = System.Drawing.Color.Black;
            this.btnPemasukan.Location = new System.Drawing.Point(68, 106);
            this.btnPemasukan.Name = "btnPemasukan";
            this.btnPemasukan.Size = new System.Drawing.Size(311, 291);
            this.btnPemasukan.TabIndex = 1;
            this.btnPemasukan.Text = "Pemasukan";
            this.btnPemasukan.UseVisualStyleBackColor = false;
            this.btnPemasukan.Click += new System.EventHandler(this.btnPemasukan_Click);
            // 
            // btnPengeluaran
            // 
            this.btnPengeluaran.BackColor = System.Drawing.Color.LightCoral;
            this.btnPengeluaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPengeluaran.Font = new System.Drawing.Font("Sitka Display", 12F);
            this.btnPengeluaran.ForeColor = System.Drawing.Color.Black;
            this.btnPengeluaran.Location = new System.Drawing.Point(436, 106);
            this.btnPengeluaran.Name = "btnPengeluaran";
            this.btnPengeluaran.Size = new System.Drawing.Size(311, 291);
            this.btnPengeluaran.TabIndex = 2;
            this.btnPengeluaran.Text = "Pengeluaran";
            this.btnPengeluaran.UseVisualStyleBackColor = false;
            this.btnPengeluaran.Click += new System.EventHandler(this.btnPengeluaran_Click);
            // 
            // btnKembali
            // 
            this.btnKembali.BackColor = System.Drawing.Color.LightGray;
            this.btnKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKembali.Font = new System.Drawing.Font("Sitka Display", 10F, System.Drawing.FontStyle.Bold);
            this.btnKembali.ForeColor = System.Drawing.Color.Black;
            this.btnKembali.Location = new System.Drawing.Point(12, 410);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(100, 30);
            this.btnKembali.TabIndex = 3;
            this.btnKembali.Text = "⬅ Kembali";
            this.btnKembali.UseVisualStyleBackColor = false;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // KelolaKeuangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnPemasukan);
            this.Controls.Add(this.btnPengeluaran);
            this.Controls.Add(this.header);
            this.Font = new System.Drawing.Font("Sitka Display", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "KelolaKeuangan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelola Keuangan";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
