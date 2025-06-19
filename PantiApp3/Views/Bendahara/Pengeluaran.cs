using Npgsql;
using PantiApp3.Config;
using PantiApp3.Controllers;
using PantiApp3.Models;
using PantiApp3.Views;
using System;
using System.Windows.Forms;

namespace PantiApp3.Views
{
    public partial class PengeluaranView : Form
    {
        private readonly PengeluaranController controller = new PengeluaranController();
        private User currentUser;

        public PengeluaranView(User user)
        {
            InitializeComponent();
            currentUser = user;
            LoadData();
            BindEvents();
        }
        private void BindEvents()
        {
            btnTambah.Click += btnTambah_Click;
            btnEdit.Click += btnEdit_Click;
            btnKembali.Click += btnKembali_Click;
        }
        private void LoadData()
        {
            dgvPengeluaran.DataSource = controller.GetAllPengeluaran();
            dgvPengeluaran.Visible = true;
            panelForm.Visible = false;
        }

        private decimal GetSaldoNow()
        {
            using var conn = new NpgsqlConnection(ConnectDB.GetConnectionString());
            conn.Open();

            decimal pemasukan = (decimal)new NpgsqlCommand("SELECT COALESCE(SUM(jumlah), 0) FROM pemasukan", conn).ExecuteScalar();
            decimal pengeluaran = (decimal)new NpgsqlCommand("SELECT COALESCE(SUM(jumlah), 0) FROM pengeluaran", conn).ExecuteScalar();

            return pemasukan - pengeluaran;
        }
        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (GetSaldoNow() <= 50000)
            {
                MessageBox.Show(
                    "Saldo saat ini kurang dari Rp 50.000.\n" +
                    "Transaksi pengeluaran tidak dapat dilakukan.",
                    "Saldo Minimum",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            dgvPengeluaran.Visible = false;
            panelForm.Controls.Clear();

            var form = new InputPengeluaran();
            form.Dock = DockStyle.Fill;
            form.OnDataSaved += LoadData;
            panelForm.Controls.Add(form);
            panelForm.Visible = true;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPengeluaran.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang ingin diedit.");
                return;
            }

            var row = dgvPengeluaran.SelectedRows[0];
            if (row.DataBoundItem is Pengeluaran selected)
            {
                dgvPengeluaran.Visible = false;
                panelForm.Controls.Clear();

                var form = new InputPengeluaran(selected);
                form.Dock = DockStyle.Fill;
                form.OnDataSaved += LoadData;
                panelForm.Controls.Add(form);
                panelForm.Visible = true;
            }
            else
            {
                MessageBox.Show("Gagal membaca data. Pastikan model data benar.");
            }
        }
        private void btnKembali_Click(object sender, EventArgs e)
        {
            var dashboard = new KelolaKeuangan(currentUser);
            dashboard.Show();
            this.Close();
        }
    }
}
