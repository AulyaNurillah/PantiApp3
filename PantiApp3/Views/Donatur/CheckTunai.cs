using Npgsql;
using PantiApp3.Config;
using PantiApp3.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace PantiApp3.Views.Donatur
{
    public partial class CheckTunai : Form
    {
        private Donasi donasi;
        private User currentUser;

        public CheckTunai(Donasi donasi, User user)
        {
            InitializeComponent();
            this.donasi = donasi;
            this.currentUser = user;

            LoadDataDonasi();
        }

        private void LoadDataDonasi()
        {
            var dt = new DataTable();
            dt.Columns.Add("jenis_donasi");
            dt.Columns.Add("jumlah_donasi");
            dt.Columns.Add("tanggal_donasi");
            dt.Rows.Add(donasi.JenisDonasi, donasi.JumlahDonasi, donasi.TanggalDonasi.ToShortDateString());
            datatambahdonasi.DataSource = dt;
        }

        private void btnbelum_Click(object sender, EventArgs e)
        {
            var kembali = new TambahTunai(currentUser);
            kembali.tbjumlah_tunai.Text = donasi.JumlahDonasi.ToString("N0");
            kembali.Show();
            this.Hide();
        }

        private void btnyakin_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new ConnectDB();
                var conn = db.OpenConnection();

                var cmd = new NpgsqlCommand(
                    @"INSERT INTO donasi (tanggal_donasi, jenis_donasi, jumlah_donasi, id_user) 
                      VALUES (@tanggal, @jenis, @jumlah, @user) 
                      RETURNING id_donasi;", conn);

                cmd.Parameters.AddWithValue("@tanggal", donasi.TanggalDonasi);
                cmd.Parameters.AddWithValue("@jenis", donasi.JenisDonasi);
                cmd.Parameters.AddWithValue("@jumlah", donasi.JumlahDonasi);
                cmd.Parameters.AddWithValue("@user", donasi.IdUser);

                int idDonasiBaru = Convert.ToInt32(cmd.ExecuteScalar());

                var keuanganCmd = new NpgsqlCommand(
                    @"INSERT INTO pemasukan (tanggal, jumlah, id_user, catatan, id_donasi) 
                      VALUES (@tanggal, @jumlah, @id_user, @catatan, @id_donasi);", conn);

                keuanganCmd.Parameters.AddWithValue("@tanggal", donasi.TanggalDonasi);
                keuanganCmd.Parameters.AddWithValue("@jumlah", donasi.JumlahDonasi);
                keuanganCmd.Parameters.AddWithValue("@user", donasi.IdUser);
                keuanganCmd.Parameters.AddWithValue("@catatan", "Donasi Tunai");
                keuanganCmd.Parameters.AddWithValue("@id_donasi", idDonasiBaru);

                keuanganCmd.ExecuteNonQuery();

                db.CloseConnection();

                MessageBox.Show("Donasi berhasil disimpan dan dicatat keuangan!");
                new LaporanDonasi(currentUser).Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan donasi:\n" + ex.Message);
            }
        }
    }
}
