namespace PantiApp3.Models
{
    public class Pengeluaran : BaseModel
    {
        public int IdPengeluaran { get; set; }
        public string Catatan { get; set; }
        public int Jumlah { get; set; }
        public DateTime Tanggal { get; set; }

        public override void PrintData()
        {
            Console.WriteLine($"📤 Pengeluaran: {Catatan}, Rp{Jumlah}, pada {Tanggal.ToShortDateString()}");
        }
    }
}
