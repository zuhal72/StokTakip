using StokTakip.Entities.Entities;

namespace StokTakip.Services.IServices
{
    public interface IStokHareketService : IGenericService<StokHareket>
    {
        Task<IEnumerable<StokHareket>> GetHareketlerWithDetailsAsync();
        Task<IEnumerable<StokHareket>> GetHareketlerByStokIdAsync(int stokId);
    }
}
