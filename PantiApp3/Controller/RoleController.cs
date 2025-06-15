using Npgsql;
using PantiApp3.Config;
using PantiApp3.Models;

namespace PantiApp3.Controllers
{
    public class RoleController
    {
        private readonly ConnectDB db;

        public RoleController()
        {
            db = new ConnectDB();
        }

        public List<Role> GetAll()
        {
            var list = new List<Role>();
            var conn = db.OpenConnection();

            try
            {
                conn.Open();
                string query = "SELECT id_role, nama_role FROM role";
                var cmd = new NpgsqlCommand(query, conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Role
                    {
                        RoleId = reader.GetInt32(0),
                        NamaRole = reader.GetString(1)
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Gagal mengambil data role: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            return list;
        }

        public Role GetById(int id)
        {
            Role role = null;
            var conn = db.OpenConnection();

            try
            {
                conn.Open();
                string query = "SELECT id_role, nama_role FROM role WHERE id_role = @id";
                var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    role = new Role
                    {
                        RoleId = reader.GetInt32(0),
                        NamaRole = reader.GetString(1)
                    };
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Gagal mengambil role berdasarkan ID: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            return role;
        }
    }
}
