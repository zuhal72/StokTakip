
namespace StokTakip.Entities.Entities
{
    public class Depo : BaseEntity
    {
        public string Ad {  get; set; }

        public string Adres { get; set; }
    
        public ICollection<StokHareket> StokHareketleri { get; set; }
    }
}
