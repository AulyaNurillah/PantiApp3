namespace PantiApp3.Views
{
    partial class PemasukanView
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridView dgvPemasukan;

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
            btnTambah = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            btnKembali = new System.Windows.Forms.Button();
            panelMain = new System.Windows.Forms.Panel();
            panelForm = new System.Windows.Forms.Panel();
            lblHeader = new System.Windows.Forms.Label();
            dgvPemasukan = new System.Windows.Forms.DataGridView();

            sidebar.SuspendLayout();
            content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dgvPemasukan)).BeginInit();
            SuspendLayout();

            // sidebar
            sidebar.BackColor = System.Drawing.Color.Lavender;
            sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            sidebar.Width = 160;
            sidebar.Controls.Add(btnTambah);
            sidebar.Controls.Add(btnEdit);
            sidebar.Controls.Add(btnKembali);

            // btnTambah
            btnTambah.Text = "Tambah";
            btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTambah.Font = new System.Drawing.Font("Sitka Display", 11F);
            btnTambah.BackColor = System.Drawing.Color.MediumSlateBlue;
            btnTambah.Size = new System.Drawing.Size(140, 40);
            btnTambah.Location = new System.Drawing.Point(10, 20);

            // btnEdit
            btnEdit.Text = "Edit";
            btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEdit.Font = new System.Drawing.Font("Sitka Display", 11F);
            btnEdit.BackColor = System.Drawing.Color.MediumSlateBlue;
            btnEdit.Size = new System.Drawing.Size(140, 40);
            btnEdit.Location = new System.Drawing.Point(10, 70);

            // btnKembali
            btnKembali.Text = "Kembali";
            btnKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnKembali.Font = new System.Drawing.Font("Sitka Display", 11F);
            btnKembali.BackColor = System.Drawing.Color.IndianRed;
            btnKembali.Size = new System.Drawing.Size(140, 40);
            btnKembali.Location = new System.Drawing.Point(10, 120);

            // content
            content.Dock = System.Windows.Forms.DockStyle.Fill;
            content.BackColor = System.Drawing.Color.WhiteSmoke;
            content.Controls.Add(lblHeader);
            content.Controls.Add(panelMain);

            // panelMain
            panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Controls.Add(dgvPemasukan);
            panelMain.Controls.Add(panelForm);

            // dgvPemasukan
            dgvPemasukan.Location = new System.Drawing.Point(10, 50);
            dgvPemasukan.Size = new System.Drawing.Size(600, 350);
            dgvPemasukan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvPemasukan.ReadOnly = true;
            dgvPemasukan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // panelForm
            panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelForm.BackColor = System.Drawing.Color.WhiteSmoke;
            panelForm.Padding = new System.Windows.Forms.Padding(10);
            panelForm.Visible = false;

            // PemasukanView
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(content);
            this.Controls.Add(sidebar);
            this.Font = new System.Drawing.Font("Sitka Display", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelola Pemasukan";

            sidebar.ResumeLayout(false);
            content.ResumeLayout(false);
            content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(dgvPemasukan)).EndInit();
            ResumeLayout(false);
        }
    }
}
