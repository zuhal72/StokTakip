
namespace StokTakip.Entities.Entities
{
    public class Kategori : BaseEntity
    {
        public string Ad { get; set; }
        public ICollection<Stok> Stoklar { get; set; }
    }
}
