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
            this.donasi.IdUser = currentUser.IdUser;


            // Sambungkan event handler ke tombol
            btnyakin.Click += btnyakin_Click;
            btnbelum.Click += btnbelum_Click;

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

                // Simpan ke tabel donasi
                var cmd = new NpgsqlCommand(
                    @"INSERT INTO donasi (tanggal_donasi, jenis_donasi, jumlah_donasi, id_user) 
                      VALUES (@tanggal, @jenis, @jumlah, @user) 
                      RETURNING id_donasi;", conn);

                cmd.Parameters.AddWithValue("@tanggal", donasi.TanggalDonasi);
                cmd.Parameters.AddWithValue("@jenis", donasi.JenisDonasi);
                cmd.Parameters.AddWithValue("@jumlah", donasi.JumlahDonasi);
                cmd.Parameters.AddWithValue("@user", donasi.IdUser);

                int idDonasiBaru = Convert.ToInt32(cmd.ExecuteScalar());

                // Simpan ke tabel pemasukan
                var pemasukanCmd = new NpgsqlCommand(
                    @"INSERT INTO pemasukan (tanggal, jumlah, id_user, catatan) 
                      VALUES (@tanggal, @jumlah, @id_user, @catatan) 
                      RETURNING id_pemasukan;", conn);

                pemasukanCmd.Parameters.AddWithValue("@tanggal", donasi.TanggalDonasi);
                pemasukanCmd.Parameters.AddWithValue("@jumlah", donasi.JumlahDonasi);
                pemasukanCmd.Parameters.AddWithValue("@id_user", donasi.IdUser);
                pemasukanCmd.Parameters.AddWithValue("@catatan", "Donasi Tunai");

                int idPemasukanBaru = Convert.ToInt32(pemasukanCmd.ExecuteScalar());

                // Simpan ke detail_keuangan
                var detailCmd = new NpgsqlCommand(
                    @"INSERT INTO detail_keuangan 
                      (tipe_transaksi, jumlah, id_pemasukan, id_pengeluaran, id_donasi, jenis_donasi) 
                      VALUES 
                      ('Pemasukan', @jumlah, @id_pemasukan, NULL, @id_donasi, @jenis);", conn);

                detailCmd.Parameters.AddWithValue("@tipe", "masuk");
                detailCmd.Parameters.AddWithValue("@jumlah", donasi.JumlahDonasi);
                detailCmd.Parameters.AddWithValue("@id_pemasukan", idPemasukanBaru);
                detailCmd.Parameters.AddWithValue("@id_donasi", idDonasiBaru);
                detailCmd.Parameters.AddWithValue("@jenis", donasi.JenisDonasi);

                detailCmd.ExecuteNonQuery();

                db.CloseConnection();

                MessageBox.Show("Donasi berhasil disimpan dan dicatat ke laporan keuangan!");
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
