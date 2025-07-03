
namespace StokTakip.Entities.Entities
{
    public class Stok : BaseEntity
    {
        public string UrunAdi { get; set; }
        public string Barkod { get; set; }
        public int Miktar { get; set; }
        public decimal AlisFiyati { get; set; }
        public decimal SatisFiyati { get; set; }

        public int BirimId { get; set; }
        public Birim Birim { get; set; }

        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }

        // ✅ DOĞRU TEDARİKÇİ İLİŞKİSİ
        public int TedarikciId { get; set; }              // Foreign key
        public Tedarikci Tedarikci { get; set; }
        public string? Status { get; set; }
    }
}
