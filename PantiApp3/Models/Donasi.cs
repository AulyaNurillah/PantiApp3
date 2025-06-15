namespace PantiApp3.Models
{
    public class Donasi : BaseModel
    {
        public int IdDonasi { get; set; }
        public DateTime TanggalDonasi { get; set; }
        public int Jumlah { get; set; }
        public int IdUser { get; set; }

        public override void PrintData()
        {
            Console.WriteLine($"🤝 Donasi: Rp{Jumlah}, Tanggal: {TanggalDonasi.ToShortDateString()}, oleh User ID: {IdUser}");
        }
    }
}