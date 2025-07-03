
namespace StokTakip.Entities.Entities
{
    public class Birim : BaseEntity
    {
        public string Ad { get; set; }
        public ICollection<Stok> Stoklar { get; set; }
    }
}
