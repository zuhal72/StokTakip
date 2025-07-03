
using StokTakip.Entities.Entities;

namespace StokTakip.DataAccess.IRepository
{
    public interface IUnitOfWork
    {
        IGenericRepository<Birim> BirimRepository { get; }
        IGenericRepository<Depo> DepoRepository { get; }
        IGenericRepository<Kategori> KategoriRepository { get; }
        IGenericRepository<Stok> StokRepository { get; }
        IGenericRepository<StokHareket> StokHareketRepository { get; }
        IGenericRepository<Tedarikci> TedarikciRepository { get; }

        Task<int> SaveAsync();
    }
}
