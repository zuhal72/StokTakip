using StokTakip.Entities.Entities;

namespace StokTakip.DataAccess.IRepository
{
    public interface IKategoriRepository : IGenericRepository<Kategori>
    {
        // Örneğin özel metotlar eklenmek istenirse buraya eklenebilir.
        Task<Kategori> GetKategoriWithStoklarAsync(int kategoriId);
    }
}
