using StokTakip.Entities.Entities;


namespace StokTakip.DataAccess.IRepository
{
    public interface IStokHareketRepository : IGenericRepository<StokHareket>
    {
        Task<IEnumerable<StokHareket>> GetHareketlerWithDetailsAsync();
        Task<IEnumerable<StokHareket>> GetHareketlerByStokIdAsync(int stokId);
    }
}
