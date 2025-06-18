using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using PantiApp3.Config; 

namespace Panti_Asuhan_Role_Admin.Model
{
    public class PengurusModel
    {
        public int Id_Pengurus { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string No_Telepon { get; set; } = string.Empty;
    }

    internal class Pengurus_model
    {
        private static readonly string _conn = ConnectDB.GetConnectionString();

       
        public static List<PengurusModel> TampilSemuaPengurus()
        {
            var pengurs = new List<PengurusModel>();

            using var db = new ConnectDB();
            using var conn = db.OpenConnection();

            try
            {

                string sql = @"
                SELECT  u.id_user          AS id_pengurus,
                        u.username,
                        u.pass_word,
                        u.no_telp
                FROM    users  u
                INNER JOIN roles r ON u.role_id_role = r.id_role
                WHERE   r.nama_role = 'Bendahara'          -- ← filter role
                ORDER BY u.id_user;";


                using var cmd = new NpgsqlCommand(sql, conn);
                using var reader = cmd.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        pengurs.Add(new PengurusModel
                        {
                            Id_Pengurus = reader.GetInt32(0),
                            Username = reader.GetString(1),
                            Password = reader.GetString(2),
                            No_Telepon = reader.GetString(3)          
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

            return pengurs;


        }

        public static PengurusModel? GetByUsername(string username)
        {
            using var conn = new NpgsqlConnection(_conn);
            conn.Open();

            const string sql = @"
        SELECT u.id_user AS id_pengurus,
               u.username,
               u.pass_word,
               u.no_telp
        FROM   users  u
        INNER JOIN roles r ON u.role_id_role = r.id_role
        WHERE  u.username ILIKE @username     -- pencarian username
          AND  r.nama_role = 'Bendahara'      -- hanya bendahara
        LIMIT 1;";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@username", "%" + username + "%");

            using var rd = cmd.ExecuteReader();
            return rd.Read()
                ? new PengurusModel
                {
                    Id_Pengurus = rd.GetInt32(0),
                    Username = rd.GetString(1),
                    Password = rd.GetString(2),
                    No_Telepon = rd.GetString(3)
                }
                : null;
        }


    }
}
