

using System;
using System.Collections.Generic;
using System.Windows.Forms;
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
        public string Nama { get; set; } = string.Empty;
    }

    internal class Pengurus_model
    {
        private static readonly string _conn = ConnectDB.GetConnectionString();

        public static List<PengurusModel> TampilSemuaPengurus()
        {
            var pengurs = new List<PengurusModel>();
            var db = new ConnectDB();
            using var conn = db.OpenConnection();

            try
            {
                string sql = @"
                SELECT  u.id_user AS id_pengurus,
                        u.username,
                        u.pass_word,
                        u.no_telep,
                        u.nama_user
                FROM    users u
                INNER JOIN roles r ON u.id_role = r.id_role
                WHERE   r.nama_role = 'Bendahara'
                ORDER BY u.id_user;";

                using var cmd = new NpgsqlCommand(sql, conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    pengurs.Add(new PengurusModel
                    {
                        Id_Pengurus = reader.GetInt32(0),
                        Username = reader.GetString(1),
                        Password = reader.GetString(2),
                        No_Telepon = reader.GetString(3),
                        Nama = reader.GetString(4)
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan pengurus: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return pengurs;
        }

        public static void TambahPengurus(string username, string password, string nama, string no_telepon)
        {
            using var conn = new NpgsqlConnection(_conn);
            conn.Open();
            try
            {
                const string sql = @"
                    INSERT INTO users (username, pass_word, nama_user, no_telep, id_role)
                    VALUES (@username, @password, @nama, @no_telepon, 
                        (SELECT id_role FROM roles WHERE nama_role = 'Bendahara'))";

                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.Parameters.AddWithValue("@no_telepon", no_telepon);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan pengurus: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static List<PengurusModel> CariPengurus(
    string? username = null,
    string? password = null,
    string? nama = null,
    string? noTelepon = null)
        {
            using var conn = new NpgsqlConnection(_conn);
            conn.Open();

            var whereClauses = new List<string>();
            var cmd = new NpgsqlCommand { Connection = conn };

            if (!string.IsNullOrWhiteSpace(username))
            {
                whereClauses.Add("u.username ILIKE @username");
                cmd.Parameters.AddWithValue("@username", "%" + username + "%");
            }

            if (!string.IsNullOrWhiteSpace(password))
            {
                whereClauses.Add("u.pass_word ILIKE @password");
                cmd.Parameters.AddWithValue("@password", "%" + password + "%");
            }

            if (!string.IsNullOrWhiteSpace(nama))
            {
                whereClauses.Add("u.nama_user ILIKE @nama");
                cmd.Parameters.AddWithValue("@nama", "%" + nama + "%");
            }

            if (!string.IsNullOrWhiteSpace(noTelepon))
            {
                whereClauses.Add("u.no_telep ILIKE @noTelepon");
                cmd.Parameters.AddWithValue("@noTelepon", "%" + noTelepon + "%");
            }

            string where = whereClauses.Count > 0
                ? "AND " + string.Join(" AND ", whereClauses)
                : "";

            cmd.CommandText = $@"
        SELECT u.id_user AS id_pengurus, u.username, u.pass_word, u.no_telep, u.nama_user
        FROM users u
        INNER JOIN roles r ON u.id_role = r.id_role
        WHERE r.nama_role = 'Bendahara'
        {where}
        ORDER BY u.id_user;";

            var hasil = new List<PengurusModel>();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                hasil.Add(new PengurusModel
                {
                    Id_Pengurus = reader.GetInt32(0),
                    Username = reader.GetString(1),
                    Password = reader.GetString(2),
                    No_Telepon = reader.GetString(3),
                    Nama = reader.GetString(4)
                });
            }

            return hasil;
        }


        
        public static bool ValidateSearchInput(string input) =>
            !string.IsNullOrWhiteSpace(input);

      
        public static List<PengurusModel> PerformSearch(string input, string tipeKriteria)
        {
            var list = new List<PengurusModel>();
            if (!ValidateSearchInput(input)) return list;

            try
            {
                list = tipeKriteria.ToLower() switch
                {
                    "username" => CariPengurus(username: input),
                    "password" => CariPengurus(password: input),
                    "nama" => CariPengurus(nama: input),
                    "telepon" or "no_telepon" or "notelp" => CariPengurus(noTelepon: input),
                    _ => new List<PengurusModel>()
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal melakukan pencarian: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return list;


        }

    }
}
