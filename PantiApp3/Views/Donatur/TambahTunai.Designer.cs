namespace PantiApp3.Views.Donatur
{
    partial class TambahTunai
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
            label1 = new Label();
            panel1 = new Panel();
            btnkembali = new Button();
            panel2 = new Panel();
            btninput_donasi = new Button();
            tbjumlah_tunai = new TextBox();
            lb = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold);
            label1.Location = new Point(150, 99);
            label1.Name = "label1";
            label1.Size = new Size(448, 31);
            label1.TabIndex = 7;
            label1.Text = "Mari berbagi untuk masa depan mereka!";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnkembali);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 50);
            panel1.TabIndex = 6;
            // 
            // btnkembali
            // 
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
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(btninput_donasi);
            panel2.Controls.Add(tbjumlah_tunai);
            panel2.Controls.Add(lb);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(98, 170);
            panel2.Name = "panel2";
            panel2.Size = new Size(594, 218);
            panel2.TabIndex = 8;
            // 
            // btninput_donasi
            // 
            btninput_donasi.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btninput_donasi.Location = new Point(245, 157);
            btninput_donasi.Name = "btninput_donasi";
            btninput_donasi.Size = new Size(112, 35);
            btninput_donasi.TabIndex = 7;
            btninput_donasi.Text = "Tambah";
            btninput_donasi.UseVisualStyleBackColor = true;
            // 
            // tbjumlah_tunai
            // 
            tbjumlah_tunai.Font = new Font("Segoe UI", 11F);
            tbjumlah_tunai.ForeColor = Color.Gray;
            tbjumlah_tunai.Location = new Point(36, 101);
            tbjumlah_tunai.Name = "tbjumlah_tunai";
            tbjumlah_tunai.Size = new Size(520, 27);
            tbjumlah_tunai.TabIndex = 6;
            tbjumlah_tunai.Text = "Masukkan Jumlah Nominal...";
            // 
            // lb
            // 
            lb.AutoSize = true;
            lb.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb.Location = new Point(35, 75);
            lb.Name = "lb";
            lb.Size = new Size(141, 21);
            lb.TabIndex = 5;
            lb.Text = "Jumlah Nominal:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Italic);
            label2.Location = new Point(29, 27);
            label2.Name = "label2";
            label2.Size = new Size(455, 25);
            label2.TabIndex = 2;
            label2.Text = "Yuk, tambahkan nominal yang ingin Anda sumbangkan.";
            // 
            // TambahTunai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "TambahTunai";
            Text = "TambahTunai";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label lb;
        public TextBox tbjumlah_tunai;
        public Button btninput_donasi;
        public Button btnkembali;
    }
}
