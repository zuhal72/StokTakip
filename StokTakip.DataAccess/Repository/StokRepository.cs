using Microsoft.EntityFrameworkCore;
using StokTakip.DataAccess.Context;
using StokTakip.DataAccess.IRepository;
using StokTakip.Entities.Entities;

namespace StokTakip.DataAccess.Repository
{
    public class StokRepository : GenericRepository<Stok>, IStokRepository
    {
        private readonly StokDbContext _context;

        public StokRepository(StokDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Stok>> GetStoklarWithKategoriAndBirimAsync()
        {
            return await _context.Stoklar
                                 .Include(s => s.Kategori)
                                 .Include(s => s.Birim)
                                 .ToListAsync();
        }

        public async Task<Stok> GetStokWithDetailsByIdAsync(int id)
        {
            return await _context.Stoklar
                                 .Include(s => s.Kategori)
                                 .Include(s => s.Birim)
                                 .FirstOrDefaultAsync(s => s.Id == id);
        }
    }
}
