namespace PantiApp3.Models
{
    public class DetailKeuangan : BaseModel
    {
        public int IdDetail { get; set; }
        public string TipeTransaksi { get; set; }
        public decimal Saldo { get; set; }

        public int? IdPemasukan { get; set; }
        public int? IdPengeluaran { get; set; }
        public int? IdDonasi { get; set; }

        public override void PrintData()
        {
            Console.WriteLine($"📊 {TipeTransaksi}: Rp{Saldo:N0}");
        }
    }
}