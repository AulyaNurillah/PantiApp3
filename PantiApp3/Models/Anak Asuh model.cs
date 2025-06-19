using Npgsql;
using PantiApp3.Config;

public class AnakAsuhModel
{
    public int Id_Anak { get; set; }
    public string Nama { get; set; } = string.Empty;
    public string Jenis_Kelamin { get; set; } = string.Empty;
    public int Usia { get; set; }
    public string Status { get; set; } = "Aktif";


    public DateTime TanggalLahir { get; set; }
}
internal class Anak_Asuh_model
{

private static readonly string _conn = ConnectDB.GetConnectionString();

    /* ---------------------------- BACA SEMUA DATA ---------------------------- */
    public static List<AnakAsuhModel> GetAll()
    {
        var list = new List<AnakAsuhModel>();
        using var conn = new NpgsqlConnection(_conn);
        conn.Open();

        const string sql = @"SELECT id_anak, nama_anak, jenis_kelamin, usia, tanggal_lahir, status
                     FROM anak_asuh
                     ORDER BY id_anak";

        using var cmd = new NpgsqlCommand(sql, conn);
        using var rd = cmd.ExecuteReader();
        while (rd.Read())
        {
            list.Add(new AnakAsuhModel
            {
                Id_Anak = rd.GetInt32(0),
                Nama = rd.GetString(1),
                Jenis_Kelamin = rd.GetString(2),
                Usia = rd.GetInt32(3),
                TanggalLahir = rd.IsDBNull(4) ? DateTime.MinValue : rd.GetDateTime(4),
                Status = rd.IsDBNull(5) ? "Aktif" : rd.GetString(5)
            });

        }
        return list;
    }

    /* ------------------ PENCARIAN TEPAT SATU KRITERIA SAJA ------------------ */
    public static List<AnakAsuhModel> CariAnak(
     string? nama = null,
     string? jenisKelamin = null,
     int? usia = null,
     DateTime? tanggalLahir = null)
    {
        using var conn = new NpgsqlConnection(_conn);
        conn.Open();

        var whereClauses = new List<string>();
        var cmd = new NpgsqlCommand { Connection = conn };

        if (!string.IsNullOrWhiteSpace(nama))
        {
            whereClauses.Add("nama_anak ILIKE @nama");
            cmd.Parameters.AddWithValue("@nama", $"%{nama}%");
        }

        if (!string.IsNullOrWhiteSpace(jenisKelamin))
        {
            whereClauses.Add("jenis_kelamin = @jk");
            cmd.Parameters.AddWithValue("@jk", jenisKelamin);
        }

        if (usia.HasValue)
        {
            whereClauses.Add("usia = @usia");
            cmd.Parameters.AddWithValue("@usia", usia.Value);
        }

        if (tanggalLahir.HasValue)
        {
            whereClauses.Add("tanggal_lahir = @tgl");
            cmd.Parameters.AddWithValue("@tgl", tanggalLahir.Value.Date);
        }

        string where = whereClauses.Count > 0
            ? "WHERE " + string.Join(" AND ", whereClauses)
            : "";

        cmd.CommandText = $@"
        SELECT id_anak, nama_anak, jenis_kelamin, usia, tanggal_lahir, status
        FROM anak_asuh
        {where}
        ORDER BY id_anak;";

        var list = new List<AnakAsuhModel>();
        using var rd = cmd.ExecuteReader();
        while (rd.Read())
        {
            list.Add(new AnakAsuhModel
            {
                Id_Anak = rd.GetInt32(0),
                Nama = rd.GetString(1),
                Jenis_Kelamin = rd.GetString(2),
                Usia = rd.GetInt32(3),
                TanggalLahir = rd.IsDBNull(4) ? DateTime.MinValue : rd.GetDateTime(4),
                Status = rd.IsDBNull(5) ? "Aktif" : rd.GetString(5)
            });
        }

        return list;
    }


    /* ------------------------- HELPER UNTUK UI/FORM ------------------------- */
    public static bool ValidateSearchInput(string input) =>
        !string.IsNullOrWhiteSpace(input);

    
    public static List<AnakAsuhModel> PerformSearch(string input, string tipeKriteria)
    {
        var list = new List<AnakAsuhModel>();
        if (!ValidateSearchInput(input)) return list;

        try
        {
            list = tipeKriteria.ToLower() switch
            {
                "nama" => CariAnak(nama: input),
                "jk" or "jeniskelamin" => CariAnak(jenisKelamin: input),
                "usia" => int.TryParse(input, out int u) ? CariAnak(usia: u) : new List<AnakAsuhModel>(),
                _ => new List<AnakAsuhModel>()
            };
        }
        catch (Exception ex)
        {
            // Silakan ganti dengan logging atau MessageBox sesuai kebutuhan UI
            MessageBox.Show("Gagal melakukan pencarian: " + ex.Message);
        }

        return list;
    }

    /* ---------------------------- INSERT DATA BARU ---------------------------- */
    public static void Insert(string nama, string jenisKelamin, DateTime tanggalLahir, int userId)
    {
        int usia = HitungUsia(tanggalLahir);

        using var conn = new NpgsqlConnection(_conn);
        conn.Open();

        const string sql = @"INSERT INTO anak_asuh 
        (nama_anak, jenis_kelamin, usia, tanggal_lahir, id_user, status)
        VALUES (@nama, @jk, @usia, @tanggal, @userId, @status)";


        using var cmd = new NpgsqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@nama", nama);
        cmd.Parameters.AddWithValue("@jk", jenisKelamin);
        cmd.Parameters.AddWithValue("@usia", usia);
        cmd.Parameters.AddWithValue("@tanggal", tanggalLahir);
        cmd.Parameters.AddWithValue("@userId", userId);
        cmd.Parameters.AddWithValue("@status", "Aktif");


        cmd.ExecuteNonQuery();
    }


    private static int HitungUsia(DateTime tanggalLahir)
    {
    DateTime today = DateTime.Today;
    int usia = today.Year - tanggalLahir.Year;
    if (tanggalLahir > today.AddYears(-usia)) usia--;
    return usia;
    }

    public static void UpdateStatus(int idAnak, string status)
    {
        using var conn = new NpgsqlConnection(_conn);
        conn.Open();

        const string sql = @"UPDATE anak_asuh SET status = @status WHERE id_anak = @id";
        using var cmd = new NpgsqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@status", status);
        cmd.Parameters.AddWithValue("@id", idAnak);
        cmd.ExecuteNonQuery();
    }




}
