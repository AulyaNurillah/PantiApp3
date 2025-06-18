using Npgsql;
using PantiApp3.Config;
using PantiApp3.Models;

namespace PantiApp3.Controllers
{
    public class DonasiController
    {
        private readonly ConnectDB db;

        public DonasiController()
        {
            db = new ConnectDB();
        }

        public void Insert(Donasi donasi)
        {
            var conn = db.OpenConnection();
            try
            {
                conn.Open();
                string query = "INSERT INTO donasi (tanggal_donasi, jenis_donasi, jumlah_donasi, id_user) " +
                               "VALUES (@tanggal, @jenis, @jumlah, @id_user)";
                var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tanggal", donasi.TanggalDonasi);
                cmd.Parameters.AddWithValue("@jenis", donasi.JenisDonasi);
                cmd.Parameters.AddWithValue("@jumlah", donasi.JumlahDonasi);
                cmd.Parameters.AddWithValue("@id_user", donasi.IdUser);

                cmd.ExecuteNonQuery();
                Console.WriteLine("✅ Donasi berhasil ditambahkan!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Gagal insert donasi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Donasi> GetAll()
        {
            List<Donasi> list = new List<Donasi>();
            var conn = db.OpenConnection();
            try
            {
                conn.Open();
                string query = "SELECT * FROM donasi";
                var cmd = new NpgsqlCommand(query, conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Donasi
                    {
                        IdDonasi = Convert.ToInt32(reader["id_donasi"]),
                        TanggalDonasi = Convert.ToDateTime(reader["tanggal_donasi"]),
                        JenisDonasi = reader["jenis_donasi"].ToString(),
                        JumlahDonasi = Convert.ToInt32(reader["jumlah_donasi"]),
                        IdUser = Convert.ToInt32(reader["id_user"])
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Gagal mengambil data donasi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return list;
        }

        public Donasi GetById(int id)
        {
            Donasi donasi = null;
            var conn = db.OpenConnection();
            try
            {
                conn.Open();
                string query = "SELECT * FROM donasi WHERE id_donasi = @id";
                var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    donasi = new Donasi
                    {
                        IdDonasi = Convert.ToInt32(reader["id_donasi"]),
                        TanggalDonasi = Convert.ToDateTime(reader["tanggal_donasi"]),
                        JenisDonasi = reader["jenis_donasi"].ToString(),
                        JumlahDonasi = Convert.ToInt32(reader["jumlah_donasi"]),
                        IdUser = Convert.ToInt32(reader["id_user"])
                    };
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Gagal mengambil donasi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return donasi;
        }

        public void Update(Donasi donasi)
        {
            var conn = db.OpenConnection();
            try
            {
                conn.Open();
                string query = "UPDATE donasi SET tanggal_donasi = @tanggal, jenis_donasi = @jenis, jumlah_donasi = @jumlah, id_user = @id_user " +
                               "WHERE id_donasi = @id";
                var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tanggal", donasi.TanggalDonasi);
                cmd.Parameters.AddWithValue("@jenis", donasi.JenisDonasi);
                cmd.Parameters.AddWithValue("@jumlah", donasi.JumlahDonasi);
                cmd.Parameters.AddWithValue("@id_user", donasi.IdUser);
                cmd.Parameters.AddWithValue("@id", donasi.IdDonasi);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    Console.WriteLine("✅ Donasi berhasil diupdate!");
                else
                    Console.WriteLine("⚠️ Donasi tidak ditemukan.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Gagal update donasi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void Delete(int id)
        {
            var conn = db.OpenConnection();
            try
            {
                conn.Open();
                string query = "DELETE FROM donasi WHERE id_donasi = @id";
                var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    Console.WriteLine("🗑️ Donasi berhasil dihapus!");
                else
                    Console.WriteLine("⚠️ Donasi tidak ditemukan.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Gagal hapus donasi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
