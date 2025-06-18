namespace PantiApp3.Views
{
    partial class Setelah_Donasi
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
            lbucapan_terimakasih = new Label();
            btnbelum = new Button();
            panel1 = new Panel();
            label1 = new Label();
            datatambahdonasi = new DataGridView();
            btnyakin = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datatambahdonasi).BeginInit();
            SuspendLayout();
            // 
            // lbucapan_terimakasih
            // 
            lbucapan_terimakasih.AutoSize = true;
            lbucapan_terimakasih.BackColor = Color.Transparent;
            lbucapan_terimakasih.FlatStyle = FlatStyle.Flat;
            lbucapan_terimakasih.Font = new Font("Book Antiqua", 14F, FontStyle.Bold);
            lbucapan_terimakasih.ForeColor = Color.DarkSlateGray;
            lbucapan_terimakasih.Location = new Point(59, 45);
            lbucapan_terimakasih.Name = "lbucapan_terimakasih";
            lbucapan_terimakasih.Size = new Size(610, 69);
            lbucapan_terimakasih.TabIndex = 1;
            lbucapan_terimakasih.Text = "Terima kasih atas donasi Anda!\r\nBantuan Anda sangat berarti bagi anak-anak di panti asuhan kami. \r\nSemoga kebaikan Anda dibalas berlipat ganda.";
            lbucapan_terimakasih.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnbelum
            // 
            btnbelum.BackColor = Color.DodgerBlue;
            btnbelum.FlatStyle = FlatStyle.Flat;
            btnbelum.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnbelum.Location = new Point(112, 312);
            btnbelum.Name = "btnbelum";
            btnbelum.Size = new Size(200, 45);
            btnbelum.TabIndex = 2;
            btnbelum.Text = "Belum";
            btnbelum.UseVisualStyleBackColor = false;
            btnbelum.Click += btnbelum_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(datatambahdonasi);
            panel1.Controls.Add(btnyakin);
            panel1.Controls.Add(lbucapan_terimakasih);
            panel1.Controls.Add(btnbelum);
            panel1.Location = new Point(39, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(735, 391);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(163, 147);
            label1.Name = "label1";
            label1.Size = new Size(414, 20);
            label1.TabIndex = 5;
            label1.Text = "Apakah Anda sudah yakin ingin berdonasi seperti berikut?";
            // 
            // datatambahdonasi
            // 
            datatambahdonasi.AllowUserToAddRows = false;
            datatambahdonasi.AllowUserToDeleteRows = false;
            datatambahdonasi.AllowUserToResizeColumns = false;
            datatambahdonasi.AllowUserToResizeRows = false;
            datatambahdonasi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datatambahdonasi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datatambahdonasi.BackgroundColor = Color.White;
            datatambahdonasi.ColumnHeadersHeight = 40;
            datatambahdonasi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            datatambahdonasi.Location = new Point(188, 180);
            datatambahdonasi.Name = "datatambahdonasi";
            datatambahdonasi.ReadOnly = true;
            datatambahdonasi.RowHeadersVisible = false;
            datatambahdonasi.Size = new Size(347, 80);
            datatambahdonasi.TabIndex = 6;
            // 
            // btnyakin
            // 
            btnyakin.BackColor = Color.DodgerBlue;
            btnyakin.FlatStyle = FlatStyle.Flat;
            btnyakin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnyakin.Location = new Point(424, 311);
            btnyakin.Name = "btnyakin";
            btnyakin.Size = new Size(200, 45);
            btnyakin.TabIndex = 3;
            btnyakin.Text = "Yakin";
            btnyakin.UseVisualStyleBackColor = false;
            btnyakin.Click += btnyakin_Click;
            // 
            // Setelah_Donasi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Setelah_Donasi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Setelah_Donasi";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datatambahdonasi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lbucapan_terimakasih;
        private Button btnbelum;
        private Panel panel1;
        private Button btnyakin;
        private DataGridView datatambahdonasi;
        private Label label1;
    }
}