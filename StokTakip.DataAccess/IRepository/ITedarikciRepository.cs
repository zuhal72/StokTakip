using StokTakip.Entities.Entities;

namespace StokTakip.DataAccess.IRepository
{
    public interface ITedarikciRepository : IGenericRepository<Tedarikci>
    {
        // Özel metotlar eklenebilir, örn:
        Task<Tedarikci> GetByEpostaAsync(string eposta);
    }
}
