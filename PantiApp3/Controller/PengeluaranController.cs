using Npgsql;
using PantiApp3.Config;
using PantiApp3.Models;

namespace PantiApp3.Controllers
{
    public class PengeluaranController
    {
        private readonly ConnectDB db;

        public PengeluaranController()
        {
            db = new ConnectDB();
        }

        public List<Pengeluaran> GetAllPengeluaran()
        {
            var list = new List<Pengeluaran>();
            var conn = db.OpenConnection();

            try
            {
                string query = "SELECT * FROM pengeluaran ORDER BY tanggal DESC";
                using var cmd = new NpgsqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Pengeluaran
                    {
                        IdPengeluaran = Convert.ToInt32(reader["id_pengeluaran"]),
                        Tanggal = Convert.ToDateTime(reader["tanggal"]),
                        Jumlah = Convert.ToInt32(reader["jumlah"]),
                        Catatan = reader["catatan"].ToString(),
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Gagal mengambil data pengeluaran: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            return list;
        }

        public Pengeluaran GetById(int id)
        {
            var conn = db.OpenConnection();
            try
            {
                string query = "SELECT * FROM pengeluaran WHERE id_pengeluaran = @id";
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                using var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Pengeluaran
                    {
                        IdPengeluaran = Convert.ToInt32(reader["id_pengeluaran"]),
                        Tanggal = Convert.ToDateTime(reader["tanggal"]),
                        Jumlah = Convert.ToInt32(reader["jumlah"]),
                        Catatan = reader["catatan"].ToString(),
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Gagal mengambil Pengeluaran: " + ex.Message);
                return null;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        public void Insert(Pengeluaran data)
        {
            var conn = db.OpenConnection();
            var transaction = conn.BeginTransaction();

            try
            {
                string queryPengeluaran = @"
            INSERT INTO pengeluaran (tanggal, jumlah, catatan) 
            VALUES (@tanggal, @jumlah, @catatan)
            RETURNING id_pengeluaran;";

                int idPengeluaran;

                using (var cmd = new NpgsqlCommand(queryPengeluaran, conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@tanggal", data.Tanggal);
                    cmd.Parameters.AddWithValue("@jumlah", data.Jumlah);
                    cmd.Parameters.AddWithValue("@catatan", data.Catatan);

                    idPengeluaran = Convert.ToInt32(cmd.ExecuteScalar());
                }

                string queryDetail = @"
            INSERT INTO detail_keuangan (tipe_transaksi, saldo, id_pengeluaran)
            VALUES ('Pengeluaran', @saldo, @idPengeluaran);";

                using (var cmdDetail = new NpgsqlCommand(queryDetail, conn, transaction))
                {
                    cmdDetail.Parameters.AddWithValue("@saldo", data.Jumlah);
                    cmdDetail.Parameters.AddWithValue("@idPengeluaran", idPengeluaran);
                    cmdDetail.ExecuteNonQuery();
                }

                transaction.Commit();
                Console.WriteLine("✅ Pengeluarann dan detail keuangan berhasil ditambahkan.");
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine("❌ Gagal menambah Pengeluaran/detail keuangan: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        public void Update(Pengeluaran data)
        {
            var conn = db.OpenConnection();
            try
            {
                string query = @"UPDATE pengeluaran SET tanggal = @tanggal, jumlah = @jumlah, 
                                 catatan = @catatan WHERE id_pengeluaran = @id";
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", data.IdPengeluaran);
                cmd.Parameters.AddWithValue("@tanggal", data.Tanggal);
                cmd.Parameters.AddWithValue("@jumlah", data.Jumlah);
                cmd.Parameters.AddWithValue("@catatan", data.Catatan);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Gagal update Pengeluaran: " + ex.Message);
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
                string query = "DELETE FROM pengeluaran WHERE id_pengeluaran = @id";
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Gagal menghapus Pengeluaran: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }
    }
}
