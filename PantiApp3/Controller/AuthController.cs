using Npgsql;
using PantiApp3.Config;
using PantiApp3.Models;
using System;
using System.Collections.Generic;

namespace PantiApp3.Controllers
{
    public class AuthController
    {
        private ConnectDB db;

        public AuthController()
        {
            db = new ConnectDB();
        }

        public User Register(User user)
        {
            var conn = db.OpenConnection();

            var checkCmd = new NpgsqlCommand("SELECT COUNT(*) FROM users WHERE username = @username", conn);
            checkCmd.Parameters.AddWithValue("@username", user.Username);

            int existing = Convert.ToInt32(checkCmd.ExecuteScalar());
            if (existing > 0)
            {
                MessageBox.Show("Username sudah digunakan. Silakan pilih yang lain.", "Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            try
            {
                string query = @"INSERT INTO users (username, pass_word, nama_user, no_telep, id_role)
                         VALUES (@username, @password, @nama_user, @no_telep, 3)
                         RETURNING *";

                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@nama_user", user.NamaUser);
                cmd.Parameters.AddWithValue("@no_telep", user.NoTelepon);

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new User
                    {
                        IdUser = Convert.ToInt32(reader["id_user"]),
                        Username = reader["username"].ToString(),
                        Password = reader["pass_word"].ToString(),
                        NamaUser = reader["nama_user"].ToString(),
                        NoTelepon = reader["no_telep"].ToString(),
                        RoleId = Convert.ToInt32(reader["id_role"])
                    };
                }

                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal registrasi: " + ex.Message);
                return null;
            }
            finally
            {
                db.CloseConnection();
            }
        }
        public static User Login(string username, string password)
        {
            var db = new ConnectDB();
            var conn = db.OpenConnection();
            try
            {
                string query = @"SELECT * FROM users WHERE username = @username AND pass_word = @pass_word";
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@pass_word", password);

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new User
                    {
                        IdUser = Convert.ToInt32(reader["id_user"]),
                        Username = reader["username"].ToString(),
                        Password = reader["pass_word"].ToString(),
                        NamaUser = reader["nama_user"].ToString(),
                        NoTelepon = reader["no_telep"].ToString(),
                        RoleId = Convert.ToInt32(reader["id_role"])
                    };
                }

                Console.WriteLine("Login gagal: user tidak ditemukan.");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Login gagal: " + ex.Message);
                return null;
            }
            finally
            {
                db.CloseConnection();
            }
        }
        public void Insert(User user)
        {
            var conn = db.OpenConnection();
            try
            {
                string query = @"INSERT INTO users (username, pass_word, nama_user, no_telep, id_role)
                                 VALUES (@username, @password, @nama, @telp, @role)";
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@nama", user.NamaUser);
                cmd.Parameters.AddWithValue("@telp", user.NoTelepon);
                cmd.Parameters.AddWithValue("@role", user.RoleId);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Insert gagal: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        public List<User> GetAllUsers()
        {
            var users = new List<User>();
            var conn = db.OpenConnection();

            try
            {
                string query = "SELECT * FROM users";
                using var cmd = new NpgsqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    users.Add(new User
                    {
                        IdUser = Convert.ToInt32(reader["id_user"]),
                        Username = reader["username"].ToString(),
                        Password = reader["pass_word"].ToString(),
                        NamaUser = reader["nama_user"].ToString(),
                        NoTelepon = reader["no_telep"].ToString(),
                        RoleId = Convert.ToInt32(reader["id_role"])
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetAllUsers error: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            return users;
        }
        public User GetById(int id)
        {
            var conn = db.OpenConnection();
            try
            {
                string query = "SELECT * FROM users WHERE id_user = @id";
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new User
                    {
                        IdUser = Convert.ToInt32(reader["id_user"]),
                        Username = reader["username"].ToString(),
                        Password = reader["pass_word"].ToString(),
                        NamaUser = reader["nama_user"].ToString(),
                        NoTelepon = reader["no_telep"].ToString(),
                        RoleId = Convert.ToInt32(reader["id_role"])
                    };
                }

                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetById error: " + ex.Message);
                return null;
            }
            finally
            {
                db.CloseConnection();
            }
        }
    }
}