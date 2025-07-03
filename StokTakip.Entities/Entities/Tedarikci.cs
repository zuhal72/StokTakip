
namespace StokTakip.Entities.Entities
{
    public class Tedarikci : BaseEntity
    {
        public string Ad {  get; set; }

        public string Telefon { get; set; }

        public string Eposta { get; set; }

        public string Adres { get; set; }

        public ICollection<Stok> Stoklar { get; set; }
    }
}
