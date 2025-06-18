namespace PantiApp3.Models
{
    public class DetailKeuangan : BaseModel
    {
        public int IdDetail { get; set; }
        public string TipeTransaksi { get; set; }
        public int Jumlah { get; set; }
        public string JenisDonasi { get; set; }

        public int? IdPemasukan { get; set; }
        public int? IdPengeluaran { get; set; }
        public int? IdDonasi { get; set; }

        public override void PrintData()
        {
            Console.WriteLine($"{TipeTransaksi}: Rp{Jumlah:N0}");
        }
    }
}