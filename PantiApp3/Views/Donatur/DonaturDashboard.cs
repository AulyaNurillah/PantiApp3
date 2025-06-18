using PantiApp3.Views;
using Donatur;
using Npgsql;
using PantiApp3.Config;
using PantiApp3.Models;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace PantiApp3.Views
{
    public partial class DonaturDashboard : Form
    {
        ConnectDB db = new ConnectDB();
        private User currentUser;


        public DonaturDashboard(User user)
        {
            InitializeComponent();
            currentUser = user;

            Session.IdUser = user.IdUser;

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

        //private void btnprofile_Click(object sender, EventArgs e)
        //{
        //    new Profile().Show();
        //    this.Hide();
        //}

        private void LoadDonasiTerbaru()
        {
            var conn = db.GetConnection();
            var cmd = new NpgsqlCommand("SELECT id_donasi, tanggal_donasi, jenis_donasi, jumlah_donasi FROM donasi WHERE id_user = @id_user ORDER BY id_donasi DESC LIMIT 4", conn);
            cmd.Parameters.AddWithValue("@id_user", currentUser.IdUser);
            var dt = new DataTable();
            conn.Open();
            dt.Load(cmd.ExecuteReader());
            conn.Close();
            dataGridriwayat.DataSource = dt;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new Login();
            loginForm.Show();
            this.Close();
        }
    }
}