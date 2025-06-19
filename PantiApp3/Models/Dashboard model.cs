using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using PantiApp3.Config;

namespace Panti_Asuhan_Role_Admin.Model
{
    public class UserViewModel
    {
        public int ID { get; set; }
        public string Nama { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
    }

    internal static class Dashboard_model
    {

        public static List<UserViewModel> TampilSemuaUser()
        {
            var users = new List<UserViewModel>();
            using var db = new ConnectDB();
            using var conn = db.OpenConnection();

            const string sql = @"
                SELECT u.id_user, u.nama_user, r.nama_role
                FROM   users u
                INNER JOIN roles r ON u.id_role = r.id_role
                ORDER  BY u.id_user";

            using var cmd = new NpgsqlCommand(sql, conn);
            using var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                users.Add(new UserViewModel
                {
                    ID = rd.GetInt32(0),
                    Nama = rd.GetString(1),
                    Role = rd.GetString(2)
                });
            }
            return users;
        }


        public static UserViewModel? CariUserBynama(string nama)
        {
            using var db = new ConnectDB();
            using var conn = db.OpenConnection();

            const string sql = @"
        SELECT u.id_user, u.nama_user, r.nama_role
        FROM   users u
        INNER JOIN roles r ON u.id_role = r.id_role
        WHERE  u.nama_user ILIKE @uname         -- pencarian username
        LIMIT 1;";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@uname", "%" + nama + "%"); 

            using var rd = cmd.ExecuteReader();
            return rd.Read()
                ? new UserViewModel
                {
                    ID = rd.GetInt32(0),
                    Nama = rd.GetString(1),
                    Role = rd.GetString(2)
                }
                : null;
        }



        public static bool ValidateSearchInput(string input)
        {
            return !string.IsNullOrWhiteSpace(input);
        }



        public static List<UserViewModel> PerformSearch(string input)
        {
            var list = new List<UserViewModel>();
            if (!ValidateSearchInput(input)) return list;

            var usr = CariUserBynama(input);
            if (usr != null) list.Add(usr);
            return list;
        }

    }
}
