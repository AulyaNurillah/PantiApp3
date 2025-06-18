using Npgsql;
using System;
using System.Data;

namespace PantiApp3.Config
{
    public class ConnectDB : IDisposable
    {
        private static readonly string connString =
            "Host=localhost;Port=5432;Username=postgres;Password=1098765432;Database=PantiApp";

        private NpgsqlConnection connection;

        public ConnectDB()
        {
            connection = new NpgsqlConnection(connString);
        }

        public NpgsqlConnection OpenConnection()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Koneksi gagal: " + ex.Message);
            }

            return connection;
        }

        public void CloseConnection()
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        public NpgsqlConnection GetConnection() => connection;

        // Ini penting supaya class ini bisa pakai 'using'
        public void Dispose()
        {
            CloseConnection();
            connection.Dispose(); // pastikan resource benar-benar dilepas
        }

        public static string GetConnectionString() => connString;
    }
}