using Npgsql;
using PantiApp3.Config;
using PantiApp3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PantiApp3.Views
{
    public partial class LaporanDonasi : Form
    {
        ConnectDB db = new ConnectDB();
        private User currentUser;
        public LaporanDonasi(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void Laporan_Donasi_Load(object sender, EventArgs e)
        {
            cbjangka_waktu.SelectedIndex = 0;
            LoadDataByRange();
        }


        private void btnkembali_Click(object sender, EventArgs e)
        {
            new DonaturDashboard(Session.CurrentUser).Show();
            this.Hide();
        }

        private void cbjangka_waktu_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataByRange();
        }

        private void LoadDataByRange()
        {
            string selected = cbjangka_waktu.SelectedItem.ToString();
            string query = "SELECT id_donasi, tanggal_donasi, jenis_donasi, jumlah_donasi FROM donasi WHERE id_user = @id_user";

            if (selected != "Semua")
            {
                int bulan = selected.Contains("Tahun") ? 12 : int.Parse(selected.Split(' ')[0]);
                query += " AND tanggal_donasi >= @mulai";
            }

            query += " ORDER BY tanggal_donasi DESC";

            var conn = db.GetConnection();
            var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id_user", currentUser.IdUser);

            if (!selected.Equals("Semua"))
            {
                int bulan = selected.Contains("Tahun") ? 12 : int.Parse(selected.Split(' ')[0]);
                cmd.Parameters.AddWithValue("@mulai", DateTime.Now.AddMonths(-bulan));
            }

            var dt = new DataTable();
            conn.Open();
            dt.Load(cmd.ExecuteReader());
            conn.Close();

            dataGridriwayat1.DataSource = dt;
        }

        private void dataGridriwayat1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}