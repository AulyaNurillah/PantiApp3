using Npgsql;
using PantiApp3.Config;
using PantiApp3.Models;
using System;
using System.Windows.Forms;

namespace PantiApp3.Views.Donatur
{
    public partial class Profile : Form
    {
        private ConnectDB db = new ConnectDB();
        private User currentUser;

        public Profile(User user)
        {
            InitializeComponent();
            currentUser = user;
            Session.IdUser = user.IdUser;
            tbno_telp.ReadOnly = false; // bisa diubah
            LoadProfile();
        }

        private void LoadProfile()
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT id_user, nama_user, no_telep, pass_word FROM users WHERE id_user = @id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", currentUser.IdUser);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tbid_donatur.Text = reader["id_user"].ToString();
                            tbnama.Text = reader["nama_user"].ToString();
                            tbno_telp.Text = reader["no_telep"].ToString();
                            tbpassword.Text = new string('*', reader["pass_word"].ToString().Length);
                        }
                    }
                }
            }
        }
        private void btnkembali_Click(object sender, EventArgs e)
        {
            var dashboard = new DonaturDashboard(currentUser);
            dashboard.Show();
            this.Hide();
        }

        private void btnkembali_Click(object sender, EventArgs e)
        {
            new DonaturDashboard(currentUser).Show();
            this.Close();
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            string nomor = tbno_telp.Text.Trim();

            if (!nomor.StartsWith("08"))
            {
                MessageBox.Show("Nomor telepon harus diawali dengan 08");
                return;
            }

            using (var conn = db.GetConnection())
            {
                MessageBox.Show("Nomor yang akan disimpan: " + nomor);

                conn.Open();
                string update = "UPDATE users SET no_telep = @telep WHERE id_user = @id";

                using (var cmd = new NpgsqlCommand(update, conn))
                {
                    cmd.Parameters.AddWithValue("@telep", nomor);
                    cmd.Parameters.AddWithValue("@id", currentUser.IdUser);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Nomor telepon berhasil disimpan.");
                    }
                    else
                    {
                        MessageBox.Show("Gagal menyimpan.");
                    }
                }
            }
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
