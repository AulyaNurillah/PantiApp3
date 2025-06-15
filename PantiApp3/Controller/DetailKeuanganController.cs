using Npgsql;
using PantiApp3.Config;
using PantiApp3.Models;

namespace PantiApp3.Controllers
{
    public class DetailKeuanganController
    {
        private readonly ConnectDB db;

        public DetailKeuanganController()
        {
            db = new ConnectDB();
        }

        public void Insert(DetailKeuangan detail)
        {
            var conn = db.OpenConnection();
            try
            {
                string query = @"INSERT INTO detail_keuangan 
                                 (tipe_transaksi, saldo, id_pemasukan, id_pengeluaran, id_donasi) 
                                 VALUES (@tipe, @saldo, @id_pem, @id_peng, @id_don)";
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tipe", detail.TipeTransaksi);
                cmd.Parameters.AddWithValue("@saldo", detail.Saldo);
                cmd.Parameters.AddWithValue("@id_pem", (object?)detail.IdPemasukan ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@id_peng", (object?)detail.IdPengeluaran ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@id_don", (object?)detail.IdDonasi ?? DBNull.Value);

                cmd.ExecuteNonQuery();
                Console.WriteLine("✅ Detail keuangan berhasil ditambahkan!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Gagal insert detail keuangan: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        public List<DetailKeuangan> GetAll()
        {
            var list = new List<DetailKeuangan>();
            var conn = db.OpenConnection();

            try
            {
                string query = "SELECT * FROM detail_keuangan";
                using var cmd = new NpgsqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new DetailKeuangan
                    {
                        IdDetail = Convert.ToInt32(reader["id_detail"]),
                        TipeTransaksi = reader["tipe_transaksi"].ToString(),
                        Saldo = Convert.ToDecimal(reader["saldo"]),
                        IdPemasukan = reader["id_pemasukan"] is DBNull ? null : (int?)Convert.ToInt32(reader["id_pemasukan"]),
                        IdPengeluaran = reader["id_pengeluaran"] is DBNull ? null : (int?)Convert.ToInt32(reader["id_pengeluaran"]),
                        IdDonasi = reader["id_donasi"] is DBNull ? null : (int?)Convert.ToInt32(reader["id_donasi"])
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Gagal mengambil detail keuangan: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            return list;
        }

        public void Update(DetailKeuangan detail)
        {
            var conn = db.OpenConnection();
            try
            {
                string query = @"UPDATE detail_keuangan 
                                 SET tipe_transaksi = @tipe, saldo = @saldo, 
                                     id_pemasukan = @id_pem, id_pengeluaran = @id_peng, id_donasi = @id_don 
                                 WHERE id_detail = @id";

                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tipe", detail.TipeTransaksi);
                cmd.Parameters.AddWithValue("@saldo", detail.Saldo);
                cmd.Parameters.AddWithValue("@id_pem", (object?)detail.IdPemasukan ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@id_peng", (object?)detail.IdPengeluaran ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@id_don", (object?)detail.IdDonasi ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@id", detail.IdDetail);

                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine(rows > 0
                    ? "✅ Detail keuangan berhasil diupdate!"
                    : "⚠️ Detail keuangan tidak ditemukan.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Gagal update detail keuangan: " + ex.Message);
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
                string query = "DELETE FROM detail_keuangan WHERE id_detail = @id";
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine(rows > 0
                    ? "🗑️ Detail keuangan berhasil dihapus!"
                    : "⚠️ Detail keuangan tidak ditemukan.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Gagal hapus detail keuangan: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }
    }
}
