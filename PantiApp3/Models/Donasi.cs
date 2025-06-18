namespace PantiApp3.Models
{
    public class Donasi
    {
        public int IdDonasi { get; set; }
        public DateTime TanggalDonasi { get; set; }
        public string JenisDonasi { get; set; }
        public int JumlahDonasi { get; set; }

        public int IdUser { get; set; } 

        public Donasi()
        {
            TanggalDonasi = DateTime.Now;
            JenisDonasi = string.Empty;
            JumlahDonasi = 0;
            IdUser = 0;
        }

        public Donasi(string jenisDonasi, int jumlahDonasi, int idUser)
        {
            TanggalDonasi = DateTime.Now;
            JenisDonasi = jenisDonasi;
            JumlahDonasi = jumlahDonasi;
            IdUser = idUser;
        }
    }
}
