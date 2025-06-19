using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Npgsql;
using PantiApp3.Config;

namespace Panti_Asuhan_Role_Admin.Model
{
    public class DonaturModel
    {
        public int Id_Donatur { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string No_Telepon { get; set; } = string.Empty;
        public int TotalDonasiUang { get; set; }

    }

    internal class Donatur_model
    {
        private static readonly string _conn = ConnectDB.GetConnectionString();


        public static List<DonaturModel> TampilSemuaDonatur()
        {
            var donors = new List<DonaturModel>();
            var db = new ConnectDB();
            using var conn = db.OpenConnection();

            try
            {
                string sql = @"
                SELECT 
                    u.id_user AS id_donatur,
                    u.username,
                    u.pass_word,
                    u.no_telep,
                    COALESCE(SUM(d.jumlah_donasi), 0) AS total_donasi_uang
                FROM users u
                INNER JOIN roles r ON u.id_role = r.id_role
                LEFT JOIN donasi d ON u.id_user = d.id_user AND d.jenis_donasi ILIKE 'uang'
                WHERE r.nama_role = 'Donatur'
                GROUP BY u.id_user, u.username, u.pass_word, u.no_telep
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
                            No_Telepon = reader.GetString(3),
                            TotalDonasiUang = reader.IsDBNull(4) ? 0 : reader.GetInt32(4)
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
        SELECT u.id_user, u.username, u.pass_word, u.no_telep
        FROM   users u
        INNER JOIN roles r ON u.id_role = r.id_role
        WHERE  u.username ILIKE @username
          AND  r.nama_role = 'Donatur'
        LIMIT 1;";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@username", "%" + username + "%");  

            using var rd = cmd.ExecuteReader();
            return rd.Read()
                ? new DonaturModel
                {
                    Id_Donatur = rd.GetInt32(0),     
                    Username = rd.GetString(1),
                    Password = rd.GetString(2),
                    No_Telepon = rd.GetString(3)
                }
                : null;
        }


    }
}
