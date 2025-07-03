using StokTakip.Entities.Entities;


namespace StokTakip.DataAccess.IRepository
{
    public interface IStokRepository : IGenericRepository<Stok>
    {
        // Özel metotlar eklenebilir
        Task<IEnumerable<Stok>> GetStoklarWithKategoriAndBirimAsync();
        Task<Stok> GetStokWithDetailsByIdAsync(int id);
    }
}
