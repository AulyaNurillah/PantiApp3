namespace PantiApp3.Views
{
    partial class BendaharaDashboard
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel contentCard;
        private System.Windows.Forms.Button btnKelolaKeuangan;
        private System.Windows.Forms.Button btnLaporanKeuangan;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;

        private System.Windows.Forms.Panel panelGreeting;
        private System.Windows.Forms.Panel panelSaldo;
        private System.Windows.Forms.Panel panelPemasukan;
        private System.Windows.Forms.Panel panelPengeluaran;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblInfoDesc;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblTotalPemasukan;
        private System.Windows.Forms.Label lblTotalPengeluaran;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            sidebar = new Panel();
            btnKelolaKeuangan = new Button();
            btnLaporanKeuangan = new Button();
            btnLogout = new Button();
            header = new Panel();
            lblTitle = new Label();
            lblSubTitle = new Label();
            panelGreeting = new Panel();
            lblInfo = new Label();
            lblInfoDesc = new Label();
            contentCard = new Panel();
            panelSaldo = new Panel();
            lblSaldo = new Label();
            panelPemasukan = new Panel();
            lblTotalPemasukan = new Label();
            panelPengeluaran = new Panel();
            lblTotalPengeluaran = new Label();
            sidebar.SuspendLayout();
            header.SuspendLayout();
            panelGreeting.SuspendLayout();
            contentCard.SuspendLayout();
            panelSaldo.SuspendLayout();
            panelPemasukan.SuspendLayout();
            panelPengeluaran.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.Lavender;
            sidebar.Controls.Add(btnKelolaKeuangan);
            sidebar.Controls.Add(btnLaporanKeuangan);
            sidebar.Controls.Add(btnLogout);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 60);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(180, 390);
            sidebar.TabIndex = 0;
            // 
            // btnKelolaKeuangan
            // 
            btnKelolaKeuangan.BackColor = Color.MediumSlateBlue;
            btnKelolaKeuangan.FlatStyle = FlatStyle.Flat;
            btnKelolaKeuangan.Font = new Font("Sitka Display", 12F);
            btnKelolaKeuangan.ForeColor = Color.Black;
            btnKelolaKeuangan.Location = new Point(10, 20);
            btnKelolaKeuangan.Name = "btnKelolaKeuangan";
            btnKelolaKeuangan.Size = new Size(160, 40);
            btnKelolaKeuangan.TabIndex = 0;
            btnKelolaKeuangan.Text = "Kelola Keuangan";
            btnKelolaKeuangan.UseVisualStyleBackColor = false;
            btnKelolaKeuangan.Click += btnKelolaKeuangan_Click;

            // 
            // btnLaporanKeuangan
            // 
            btnLaporanKeuangan.BackColor = Color.MediumSlateBlue;
            btnLaporanKeuangan.FlatStyle = FlatStyle.Flat;
            btnLaporanKeuangan.Font = new Font("Sitka Display", 12F);
            btnLaporanKeuangan.ForeColor = Color.Black;
            btnLaporanKeuangan.Location = new Point(10, 70);
            btnLaporanKeuangan.Name = "btnLaporanKeuangan";
            btnLaporanKeuangan.Size = new Size(160, 40);
            btnLaporanKeuangan.TabIndex = 1;
            btnLaporanKeuangan.Text = "Laporan Keuangan";
            btnLaporanKeuangan.UseVisualStyleBackColor = false;
            btnLaporanKeuangan.Click += btnLaporanKeuangan_Click;

            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.IndianRed;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Sitka Display", 12F, FontStyle.Bold);
            btnLogout.ForeColor = Color.Black;
            btnLogout.Location = new Point(10, 320);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(160, 40);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;

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
            header.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Sitka Display", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(10, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(407, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Sistem Manajemen Panti - Dashboard Bendahara";
            // 
            // lblSubTitle
            // 
            lblSubTitle.AutoSize = true;
            lblSubTitle.Font = new Font("Sitka Display", 11F, FontStyle.Italic);
            lblSubTitle.ForeColor = Color.WhiteSmoke;
            lblSubTitle.Location = new Point(10, 30);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(309, 21);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "Kelola dana masuk dan keluar dengan transparan";
            // 
            // panelGreeting
            // 
            panelGreeting.BackColor = Color.LightSkyBlue;
            panelGreeting.Controls.Add(lblInfo);
            panelGreeting.Controls.Add(lblInfoDesc);
            panelGreeting.Location = new Point(200, 70);
            panelGreeting.Name = "panelGreeting";
            panelGreeting.Size = new Size(598, 84);
            panelGreeting.TabIndex = 2;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Sitka Display", 24F, FontStyle.Bold);
            lblInfo.ForeColor = Color.White;
            lblInfo.Location = new Point(10, 5);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(243, 47);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "Selamat Datang!";
            // 
            // lblInfoDesc
            // 
            lblInfoDesc.AutoSize = true;
            lblInfoDesc.Font = new Font("Sitka Display", 16F);
            lblInfoDesc.ForeColor = Color.White;
            lblInfoDesc.Location = new Point(12, 45);
            lblInfoDesc.Name = "lblInfoDesc";
            lblInfoDesc.Size = new Size(107, 32);
            lblInfoDesc.TabIndex = 1;
            lblInfoDesc.Text = "Bendahara";
            // 
            // contentCard
            // 
            contentCard.BackColor = Color.Transparent;
            contentCard.Controls.Add(panelSaldo);
            contentCard.Controls.Add(panelPemasukan);
            contentCard.Controls.Add(panelPengeluaran);
            contentCard.Location = new Point(200, 160);
            contentCard.Name = "contentCard";
            contentCard.Size = new Size(600, 270);
            contentCard.TabIndex = 3;
            // 
            // panelSaldo
            // 
            panelSaldo.BackColor = Color.MediumSeaGreen;
            panelSaldo.Controls.Add(lblSaldo);
            panelSaldo.Location = new Point(10, 23);
            panelSaldo.Name = "panelSaldo";
            panelSaldo.Size = new Size(273, 100);
            panelSaldo.TabIndex = 0;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Sitka Display", 14F, FontStyle.Bold);
            lblSaldo.ForeColor = Color.White;
            lblSaldo.Location = new Point(10, 35);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(105, 28);
            lblSaldo.TabIndex = 0;
            lblSaldo.Text = "Saldo: Rp 0";
            // 
            // panelPemasukan
            // 
            panelPemasukan.BackColor = Color.RoyalBlue;
            panelPemasukan.Controls.Add(lblTotalPemasukan);
            panelPemasukan.Location = new Point(10, 129);
            panelPemasukan.Name = "panelPemasukan";
            panelPemasukan.Size = new Size(273, 100);
            panelPemasukan.TabIndex = 1;
            // 
            // lblTotalPemasukan
            // 
            lblTotalPemasukan.AutoSize = true;
            lblTotalPemasukan.Font = new Font("Sitka Display", 14F, FontStyle.Bold);
            lblTotalPemasukan.ForeColor = Color.White;
            lblTotalPemasukan.Location = new Point(3, 35);
            lblTotalPemasukan.Name = "lblTotalPemasukan";
            lblTotalPemasukan.Size = new Size(153, 28);
            lblTotalPemasukan.TabIndex = 0;
            lblTotalPemasukan.Text = "Pemasukan: Rp 0";
            // 
            // panelPengeluaran
            // 
            panelPengeluaran.BackColor = Color.IndianRed;
            panelPengeluaran.Controls.Add(lblTotalPengeluaran);
            panelPengeluaran.Location = new Point(302, 23);
            panelPengeluaran.Name = "panelPengeluaran";
            panelPengeluaran.Size = new Size(280, 100);
            panelPengeluaran.TabIndex = 2;
            // 
            // lblTotalPengeluaran
            // 
            lblTotalPengeluaran.AutoSize = true;
            lblTotalPengeluaran.Font = new Font("Sitka Display", 14F, FontStyle.Bold);
            lblTotalPengeluaran.ForeColor = Color.White;
            lblTotalPengeluaran.Location = new Point(10, 35);
            lblTotalPengeluaran.Name = "lblTotalPengeluaran";
            lblTotalPengeluaran.Size = new Size(162, 28);
            lblTotalPengeluaran.TabIndex = 0;
            lblTotalPengeluaran.Text = "Pengeluaran: Rp 0";
            // 
            // BendaharaDashboard
            // 
            ClientSize = new Size(820, 450);
            Controls.Add(sidebar);
            Controls.Add(header);
            Controls.Add(panelGreeting);
            Controls.Add(contentCard);
            Font = new Font("Sitka Display", 11F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "BendaharaDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard Bendahara";
            Load += BendaharaDashboard_Load;
            sidebar.ResumeLayout(false);
            header.ResumeLayout(false);
            header.PerformLayout();
            panelGreeting.ResumeLayout(false);
            panelGreeting.PerformLayout();
            contentCard.ResumeLayout(false);
            panelSaldo.ResumeLayout(false);
            panelSaldo.PerformLayout();
            panelPemasukan.ResumeLayout(false);
            panelPemasukan.PerformLayout();
            panelPengeluaran.ResumeLayout(false);
            panelPengeluaran.PerformLayout();
            ResumeLayout(false);
        }
    }
}
