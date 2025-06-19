using Npgsql;
using PantiApp3.Config;
using PantiApp3.Models;
using PantiApp3.Views.Donatur;
using System;
using System.Data;
using System.Windows.Forms;

namespace PantiApp3.Views
{
    public partial class LaporanDonasi : Form
    {
        private readonly ConnectDB db = new ConnectDB();
        private readonly User currentUser;

        public LaporanDonasi(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void LaporanDonasi_Load(object sender, EventArgs e)
        {
            LoadAllData();
            cbjangka_waktu.SelectedIndex = 0;
        }

        private void btnkembali_Click(object sender, EventArgs e)
        {
            new DonaturDashboard(currentUser).Show();
            this.Close();
        }

        private void cbjangka_waktu_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataByRange();
        }

        private void LoadAllData()
        {
            string query = "SELECT id_donasi, tanggal_donasi, jenis_donasi, jumlah_donasi FROM donasi WHERE id_user = @id_user ORDER BY tanggal_donasi DESC";

            using var conn = db.OpenConnection();
            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id_user", currentUser.IdUser);

            using var adapter = new NpgsqlDataAdapter(cmd);
            var dt = new DataTable();
            adapter.Fill(dt);
            dataGridriwayat1.DataSource = dt;
        }

        private void LoadDataByRange()
        {
            string selected = cbjangka_waktu.SelectedItem.ToString();
            string query = "SELECT id_donasi, tanggal_donasi, jenis_donasi, jumlah_donasi FROM donasi WHERE id_user = @id_user";

            if (!selected.Equals("Semua"))
            {
                int bulan = selected.Contains("Tahun") ? 12 : int.Parse(selected.Split(' ')[0]);
                query += " AND tanggal_donasi >= @mulai";
            }

            query += " ORDER BY tanggal_donasi DESC";

            using var conn = db.OpenConnection();
            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id_user", currentUser.IdUser);

            if (!selected.Equals("Semua"))
            {
                int bulan = selected.Contains("Tahun") ? 12 : int.Parse(selected.Split(' ')[0]);
                cmd.Parameters.AddWithValue("@mulai", DateTime.Now.AddMonths(-bulan));
            }

            using var adapter = new NpgsqlDataAdapter(cmd);
            var dt = new DataTable();
            adapter.Fill(dt);
            dataGridriwayat1.DataSource = dt;
        }

        private void dataGridriwayat1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional handling
        }
    }
}
