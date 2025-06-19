using Npgsql;
using PantiApp3.Config;
using PantiApp3.Models;
using System;
using System.Collections.Generic;

namespace PantiApp3.Controllers
{
    public class LaporanKeuanganController
    {
        private ConnectDB db;

        public LaporanKeuanganController()
        {
            db = new ConnectDB();
        }

        public List<LaporanKeuangan> GetLaporan()
        {
            var list = new List<LaporanKeuangan>();
            var conn = db.OpenConnection();

            try
            {
                const string query = @"
                    SELECT
                        dk.id_detail,
                        dk.tipe_transaksi,
                        dk.jumlah,
                        d.jenis_donasi,
                        COALESCE(p.tanggal, pg.tanggal, d.tanggal_donasi) AS tanggal
                    FROM detail_keuangan dk
                    LEFT JOIN pemasukan p ON dk.id_pemasukan = p.id_pemasukan
                    LEFT JOIN pengeluaran pg ON dk.id_pengeluaran = pg.id_pengeluaran
                    LEFT JOIN donasi d ON dk.id_donasi = d.id_donasi
                    ORDER BY dk.id_detail DESC;";

                using var cmd = new NpgsqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new LaporanKeuangan
                    {
                        IdDetail = reader.GetInt32(0),
                        TipeTransaksi = reader.GetString(1),
                        Jumlah = reader.GetInt32(2),
                        JenisDonasi = reader.IsDBNull(3) ? null : reader.GetString(3),
                        Tanggal = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4)
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Gagal load laporan: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            return list;
        }
    }
}
