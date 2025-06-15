namespace PantiApp3.Models
{
    public class Pemasukan : BaseModel
    {
        public int IdPemasukan { get; set; }
        public string Catatan { get; set; }
        public int Jumlah { get; set; }
        public DateTime Tanggal { get; set; }
        public int IdUser { get; set; }


        public override void PrintData()
        {
            Console.WriteLine($"📥 Pemasukan oleh User #{IdUser}: {Catatan}, Rp{Jumlah}, pada {Tanggal.ToShortDateString()}");
        }
    }
}