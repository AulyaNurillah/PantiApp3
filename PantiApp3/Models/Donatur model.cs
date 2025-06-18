using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Npgsql;
using Panti_Asuhan_Role_Admin.Config;

namespace Panti_Asuhan_Role_Admin.Model
{
    public class DonaturModel
    {
        public int Id_Donatur { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string No_Telepon { get; set; } = string.Empty;
    }

    internal class Donatur_model
    {
        private static readonly string _conn = config_DB.GetConnectionString();

        // Ambil semua data donatur (+ role jika ada)
        public static List<DonaturModel> TampilSemuaDonatur()
        {
            var donors = new List<DonaturModel>();

            // using → otomatis Dispose() & menutup koneksi
            using var db = new Config.ConnectDB();
            using var conn = db.OpenConnection();

            try
            {
                // ───── SQL: join ke tabel roles jika memang ada kolom role_id_role ─────
                string sql = @"
                SELECT  u.id_user          AS id_donatur,
                        u.username,
                        u.pass_word,
                        u.no_telp
                FROM    users  u
                INNER JOIN roles r ON u.role_id_role = r.id_role
                WHERE   r.nama_role = 'Donatur'          -- ← filter role
                ORDER BY u.id_user;";

                using (var cmd = new NpgsqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        donors.Add(new DonaturModel
                        {
                            Id_Donatur = reader.GetInt32(0),
                            Username = reader.GetString(1),
                            Password = reader.GetString(2),
                            No_Telepon = reader.GetString(3)          // hilangkan jika tak pakai role
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan donatur: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }

            return donors;
        }



        public static DonaturModel? GetByusername(string username)
        {
            using var conn = new NpgsqlConnection(_conn);
            conn.Open();

            const string sql = @"
        SELECT u.id_user, u.username, u.pass_word, u.no_telp
        FROM   users u
        INNER JOIN roles r ON u.role_id_role = r.id_role
        WHERE  u.username ILIKE @username
          AND  r.nama_role = 'Donatur'
        LIMIT 1;";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@username", "%" + username + "%");  // substring & case‑insensitive

            using var rd = cmd.ExecuteReader();
            return rd.Read()
                ? new DonaturModel
                {
                    Id_Donatur = rd.GetInt32(0),     // kolom id_user bertipe integer
                    Username = rd.GetString(1),
                    Password = rd.GetString(2),
                    No_Telepon = rd.GetString(3)
                }
                : null;
        }


    }
}
