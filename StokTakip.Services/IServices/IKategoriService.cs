using StokTakip.Entities.Entities;
using System.Threading.Tasks;

namespace StokTakip.Services.IServices
{
    public interface IKategoriService : IGenericService<Kategori>
    {
        // Kategoriye ait stokları da birlikte döndürür
        Task<Kategori> GetKategoriWithStoklarAsync(int kategoriId);
    }
}
