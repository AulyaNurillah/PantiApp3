using Npgsql;
using PantiApp3.Config;
using PantiApp3.Models;

namespace PantiApp3.Controllers
{
    public class PemasukanController
    {
        private readonly ConnectDB db;

        public PemasukanController()
        {
            db = new ConnectDB();
        }

        public List<Pemasukan> GetAllPemasukan()
        {
            var list = new List<Pemasukan>();
            var conn = db.OpenConnection();

            try
            {
                string query = "SELECT * FROM pemasukan ORDER BY tanggal DESC";
                using var cmd = new NpgsqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Pemasukan
                    {
                        IdPemasukan = Convert.ToInt32(reader["id_pemasukan"]),
                        Tanggal = Convert.ToDateTime(reader["tanggal"]),
                        Jumlah = Convert.ToInt32(reader["jumlah"]),
                        Catatan = reader["catatan"].ToString(),
                        IdUser = Convert.ToInt32(reader["id_user"])
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Gagal mengambil data pemasukan: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            return list;
        }
        public Pemasukan GetById(int id)
        {
            var conn = db.OpenConnection();
            try
            {
                string query = "SELECT * FROM pemasukan WHERE id_pemasukan = @id";
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                using var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Pemasukan
                    {
                        IdPemasukan = Convert.ToInt32(reader["id_pemasukan"]),
                        Tanggal = Convert.ToDateTime(reader["tanggal"]),
                        Jumlah = Convert.ToInt32(reader["jumlah"]),
                        Catatan = reader["catatan"].ToString(),
                        IdUser = Convert.ToInt32(reader["id_user"])
                    };
                }
                Console.WriteLine("⚠️ Pemasukan tidak ditemukan.");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Gagal mengambil pemasukan: " + ex.Message);
                return null;
            }
            finally
            {
                db.CloseConnection();
            }
        }
        public void Insert(Pemasukan data)
        {
            var conn = db.OpenConnection();
            var transaction = conn.BeginTransaction(); 

            try
            {
                string queryPemasukan = @"
            INSERT INTO pemasukan (tanggal, jumlah, catatan, id_user) 
            VALUES (@tanggal, @jumlah, @catatan, @id_user)
            RETURNING id_pemasukan;";

                int idPemasukan;

                using (var cmd = new NpgsqlCommand(queryPemasukan, conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@tanggal", data.Tanggal);
                    cmd.Parameters.AddWithValue("@jumlah", data.Jumlah);
                    cmd.Parameters.AddWithValue("@catatan", data.Catatan);
                    cmd.Parameters.AddWithValue("@id_user", data.IdUser);

                    idPemasukan = Convert.ToInt32(cmd.ExecuteScalar());
                }

                string queryDetail = @"
            INSERT INTO detail_keuangan (tipe_transaksi, saldo, id_pemasukan)
            VALUES ('Pemasukan', @saldo, @idPemasukan);";

                using (var cmdDetail = new NpgsqlCommand(queryDetail, conn, transaction))
                {
                    cmdDetail.Parameters.AddWithValue("@saldo", data.Jumlah);
                    cmdDetail.Parameters.AddWithValue("@idPemasukan", idPemasukan);
                    cmdDetail.ExecuteNonQuery();
                }

                transaction.Commit();
                Console.WriteLine("✅ Pemasukan dan detail keuangan berhasil ditambahkan.");
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine("❌ Gagal menambah pemasukan/detail keuangan: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        public void Update(Pemasukan data)
        {
            var conn = db.OpenConnection();
            try
            {
                string query = @"UPDATE pemasukan SET tanggal = @tanggal, jumlah = @jumlah, 
                                 catatan = @catatan, id_user = @id_user WHERE id_pemasukan = @id";
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", data.IdPemasukan);
                cmd.Parameters.AddWithValue("@tanggal", data.Tanggal);
                cmd.Parameters.AddWithValue("@jumlah", data.Jumlah);
                cmd.Parameters.AddWithValue("@catatan", data.Catatan);
                cmd.Parameters.AddWithValue("@id_user", data.IdUser);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    Console.WriteLine("✅ Pemasukan berhasil diperbarui.");
                else
                    Console.WriteLine("⚠️ Pemasukan tidak ditemukan.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Gagal update pemasukan: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }
        public void Delete(int id)
        {
            var conn = db.OpenConnection();
            try
            {
                string query = "DELETE FROM pemasukan WHERE id_pemasukan = @id";
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    Console.WriteLine("🗑️ Pemasukan berhasil dihapus.");
                else
                    Console.WriteLine("⚠️ Pemasukan tidak ditemukan.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Gagal menghapus pemasukan: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }
    }
}
