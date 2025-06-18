namespace PantiApp3.Views
{
    partial class LaporanKeuanganView
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridView dgvLaporan;

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
            sidebar = new System.Windows.Forms.Panel();
            content = new System.Windows.Forms.Panel();
            btnKembali = new System.Windows.Forms.Button();
            panelMain = new System.Windows.Forms.Panel();
            panelForm = new System.Windows.Forms.Panel();
            lblHeader = new System.Windows.Forms.Label();
            dgvLaporan = new System.Windows.Forms.DataGridView();

            sidebar.SuspendLayout();
            content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dgvLaporan)).BeginInit();
            SuspendLayout();

            // sidebar
            sidebar.BackColor = System.Drawing.Color.Lavender;
            sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            sidebar.Width = 160;
            sidebar.Controls.Add(btnKembali);

            // btnRefresh
            btnKembali.Text = "Kembali";
            btnKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnKembali.Font = new System.Drawing.Font("Sitka Display", 11F);
            btnKembali.BackColor = System.Drawing.Color.MediumSlateBlue;
            btnKembali.Size = new System.Drawing.Size(140, 40);
            btnKembali.Location = new System.Drawing.Point(10, 20);
            btnKembali.Click += new System.EventHandler(this.btnKembali_Click);

            // content
            content.Dock = System.Windows.Forms.DockStyle.Fill;
            content.BackColor = System.Drawing.Color.WhiteSmoke;
            content.Controls.Add(lblHeader);
            content.Controls.Add(panelMain);

            // lblHeader
            lblHeader.Text = "Laporan Keuangan";
            lblHeader.Font = new System.Drawing.Font("Sitka Display", 16F, System.Drawing.FontStyle.Bold);
            lblHeader.ForeColor = System.Drawing.Color.MediumSlateBlue;
            lblHeader.Location = new System.Drawing.Point(10, 10);
            lblHeader.AutoSize = true;

            // panelMain
            panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Controls.Add(dgvLaporan);
            panelMain.Controls.Add(panelForm);

            // dgvLaporan
            dgvLaporan.Location = new System.Drawing.Point(10, 50);
            dgvLaporan.Size = new System.Drawing.Size(600, 350);
            dgvLaporan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvLaporan.ReadOnly = true;
            dgvLaporan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // panelForm (optional future use)
            panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelForm.BackColor = System.Drawing.Color.WhiteSmoke;
            panelForm.Padding = new System.Windows.Forms.Padding(10);
            panelForm.Visible = false;

            // LaporanKeuanganView
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(content);
            this.Controls.Add(sidebar);
            this.Font = new System.Drawing.Font("Sitka Display", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laporan Keuangan";

            sidebar.ResumeLayout(false);
            content.ResumeLayout(false);
            content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(dgvLaporan)).EndInit();
            ResumeLayout(false);
        }
    }
}
