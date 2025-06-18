namespace PantiApp3.Models
{
    public class LaporanKeuangan
    {
        public int IdDetail { get; set; }
        public string TipeTransaksi { get; set; }
        public int Jumlah { get; set; }
        public string? JenisDonasi { get; set; }

        public DateTime? Tanggal { get; set; }
    }
}
