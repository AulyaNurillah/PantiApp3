using Donatur;
using Npgsql;
using PantiApp3.Config;
using PantiApp3.Models;
using PantiApp3.Views.Donatur;
using System;
using System.Data;
using System.Windows.Forms;

namespace PantiApp3.Views
{
    public partial class DonaturDashboard : Form
    {
        private readonly ConnectDB db = new ConnectDB();
        private readonly User currentUser;

        public DonaturDashboard(User user)
        {
            InitializeComponent();
            currentUser = user;

            // Simpan ID user ke session
            Session.IdUser = user.IdUser;
            Session.CurrentUser = user;

            LoadDonasiTerbaru();
        }

        private void btntambah_donasi_Click(object sender, EventArgs e)
        {
            new TambahDonasi(currentUser).Show();
            this.Hide();
        }

        private void btnlaporan_donasi_Click(object sender, EventArgs e)
        {
            new LaporanDonasi(currentUser).Show();
            this.Hide();
        }

        private void btnprofile_Click(object sender, EventArgs e)
        {
            new Profile(currentUser).Show();
            this.Hide();
        }

        private void btntunai_Click(object sender, EventArgs e)
        {
            new TambahTunai(currentUser).Show();
            this.Hide();
        }

        private void LoadDonasiTerbaru()
        {
            var conn = db.OpenConnection();
            var cmd = new NpgsqlCommand(@"
                SELECT id_donasi, tanggal_donasi, jenis_donasi, jumlah_donasi
                FROM donasi
                WHERE id_user = @id_user
                ORDER BY id_donasi DESC
                LIMIT 4", conn);

            cmd.Parameters.AddWithValue("@id_user", currentUser.IdUser);

            var dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            conn.Close();

            dataGridriwayat.DataSource = dt;
        }
    }
}
