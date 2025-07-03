
namespace StokTakip.Entities.Entities
{
    public class StokHareket :   BaseEntity
    {
        public int StokId { get; set; }
        public Stok Stok { get; set; }
        
        public int DepoId { get; set; }
        public Depo Depo { get; set; }

        public DateTime Tarih {  get; set; }
        public int Miktar { get; set; }
        public bool GirisMi {  get; set; }//true = giris, false = cıkıs
        public string Aciklama { get; set; }
    }
}
