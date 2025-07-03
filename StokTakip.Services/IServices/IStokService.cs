using StokTakip.Entities.Entities;

namespace StokTakip.Services.IServices
{
    public interface IStokService : IGenericService<Stok>
    {
        Task<List<Stok>> GetStoklarWithKategoriAndBirimAsync(); // ✔ GÜNCELLENDİ
        Task<Stok> GetStokWithDetailsByIdAsync(int id);
    }
}
