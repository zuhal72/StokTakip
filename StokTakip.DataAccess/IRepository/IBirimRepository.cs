
using StokTakip.Entities.Entities;

namespace StokTakip.DataAccess.IRepository
{
    public interface IBirimRepository : IGenericRepository<Birim>
    {
        // Eğer Birim'e özgü özel metotların olacaksa buraya ekle
        Task<Birim> GetBirimWithStokAsync(int id); // örnek
    }
}
