using StokTakip.DataAccess.Context;
using StokTakip.DataAccess.IRepository;
using StokTakip.Entities.Entities;

namespace StokTakip.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StokDbContext _context;

        private IGenericRepository<Birim> _birimRepository;
        private IGenericRepository<Depo> _depoRepository;
        private IGenericRepository<Kategori> _kategoriRepository;
        private IGenericRepository<Stok> _stokRepository;
        private IGenericRepository<StokHareket> _stokHareketRepository;
        private IGenericRepository<Tedarikci> _tedarikciRepository;

        public UnitOfWork(StokDbContext context)
        {
            _context = context;
        }

        public IGenericRepository<Birim> BirimRepository =>
            _birimRepository ??= new GenericRepository<Birim>(_context);

        public IGenericRepository<Depo> DepoRepository =>
            _depoRepository ??= new GenericRepository<Depo>(_context);

        public IGenericRepository<Kategori> KategoriRepository =>
            _kategoriRepository ??= new GenericRepository<Kategori>(_context);

        public IGenericRepository<Stok> StokRepository =>
            _stokRepository ??= new GenericRepository<Stok>(_context);

        public IGenericRepository<StokHareket> StokHareketRepository =>
            _stokHareketRepository ??= new GenericRepository<StokHareket>(_context);

        public IGenericRepository<Tedarikci> TedarikciRepository =>
            _tedarikciRepository ??= new GenericRepository<Tedarikci>(_context);

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
