using Npgsql;
using PantiApp3.Views;
using PantiApp3.Models;
using System;
using System.Windows.Forms;

namespace PantiApp3.Views
{
    public partial class BendaharaDashboard : Form
    {
        private User currentUser;
        public BendaharaDashboard(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void btnKelolaKeuangan_Click(object sender, EventArgs e)
        {
            var formKelolaKeuangan = new KelolaKeuangan(currentUser);
            formKelolaKeuangan.Show();
            this.Close();
        }

        private void btnLaporanKeuangan_Click(object sender, EventArgs e)
        {
            var laporanForm = new LaporanKeuanganView(currentUser);
            laporanForm.Show();
            this.Close();
        }

        private void LoadRingkasanKeuangan()
        {
            decimal totalPemasukan = 0;
            decimal totalPengeluaran = 0;

            string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=wily;Database=Asuh.in";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                using (var cmdIn = new NpgsqlCommand("SELECT COALESCE(SUM(jumlah), 0) FROM pemasukan", conn))
                {
                    totalPemasukan = Convert.ToDecimal(cmdIn.ExecuteScalar());
                }

                using (var cmdOut = new NpgsqlCommand("SELECT COALESCE(SUM(jumlah), 0) FROM pengeluaran", conn))
                {
                    totalPengeluaran = Convert.ToDecimal(cmdOut.ExecuteScalar());
                }

                conn.Close();
            }

            decimal saldo = totalPemasukan - totalPengeluaran;

            lblSaldo.Text = $"Saldo: Rp {saldo:N0}";
            lblTotalPemasukan.Text = $"Total Pemasukan: Rp {totalPemasukan:N0}";
            lblTotalPengeluaran.Text = $"Total Pengeluaran: Rp {totalPengeluaran:N0}";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var loginForm = new Login();
            loginForm.Show();
            this.Close();
        }


        private void BendaharaDashboard_Load(object sender, EventArgs e)
        {
            LoadRingkasanKeuangan();
        }
    }
}
