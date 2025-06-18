using System;
using System.Collections.Generic;
using Npgsql;
using PantiApp3.Config;

namespace Panti_Asuhan_Role_Admin.Model
{
    public class AnakAsuhModel
    {
        public int Id_Anak { get; set; }
        public string Nama { get; set; } = string.Empty;
        public string Jenis_Kelamin { get; set; } = string.Empty;
        public int Usia { get; set; } 
    }

    internal class Anak_Asuh_model
    {
        private static readonly string _conn = ConnectDB.GetConnectionString();

        public static List<AnakAsuhModel> GetAll()
        {
            var list = new List<AnakAsuhModel>();
            using var conn = new NpgsqlConnection(_conn);
            conn.Open();

            string sql = @"SELECT id_anak, nama_anak, jenis_kelamin, usia FROM anak_asuh ORDER BY id_anak";
            using var cmd = new NpgsqlCommand(sql, conn);
            using var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                list.Add(new AnakAsuhModel
                {
                    Id_Anak = rd.GetInt32(0),
                    Nama = rd.GetString(1),
                    Jenis_Kelamin = rd.GetString(2),
                    Usia = rd.GetInt32(3)
                });
            }
            return list;
        }

        public static List<AnakAsuhModel> Search(string nama, string jk, int usia)
        {
            var list = new List<AnakAsuhModel>();
            using var conn = new NpgsqlConnection(_conn);
            conn.Open();

            string sql = @"SELECT id_anak, nama_anak, jenis_kelamin, usia
                           FROM anak_asuh
                           WHERE nama_anak ILIKE @nama
                             AND jenis_kelamin ILIKE @jk
                             AND usia = @usia"; 

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nama", $"%{nama}%");
            cmd.Parameters.AddWithValue("@jk", $"%{jk}%");
            cmd.Parameters.AddWithValue("@usia", usia);  

            using var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                list.Add(new AnakAsuhModel
                {
                    Id_Anak = rd.GetInt32(0),
                    Nama = rd.GetString(1),
                    Jenis_Kelamin = rd.GetString(2),
                    Usia = rd.GetInt32(3)
                });
            }
            return list;
        }

        public static void Insert(string nama, string jenisKelamin, int usia, int userId)
        {
            using var conn = new NpgsqlConnection(_conn);
            conn.Open();

            const string sql = @"INSERT INTO anak_asuh (nama_anak, jenis_kelamin, usia, id_user)
                                 VALUES (@nama, @jk, @usia, @userId)";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nama", nama);
            cmd.Parameters.AddWithValue("@jk", jenisKelamin);
            cmd.Parameters.AddWithValue("@usia", usia);
            cmd.Parameters.AddWithValue("@userId", userId);
            cmd.ExecuteNonQuery();
        }
    }
}
