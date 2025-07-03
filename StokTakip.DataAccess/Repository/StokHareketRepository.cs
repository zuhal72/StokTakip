using Microsoft.EntityFrameworkCore;
using StokTakip.DataAccess.Context;
using StokTakip.DataAccess.IRepository;
using StokTakip.Entities.Entities;

namespace StokTakip.DataAccess.Repository
{
    public class StokHareketRepository : GenericRepository<StokHareket>, IStokHareketRepository
    {
        private readonly StokDbContext _context;

        public StokHareketRepository(StokDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<StokHareket>> GetHareketlerWithDetailsAsync()
        {
            return await _context.StokHareketleri
                                 .Include(sh => sh.Stok)
                                 .Include(sh => sh.Depo)
                                 .ToListAsync();
        }

        public async Task<IEnumerable<StokHareket>> GetHareketlerByStokIdAsync(int stokId)
        {
            return await _context.StokHareketleri
                                 .Include(sh => sh.Depo)
                                 .Where(sh => sh.StokId == stokId)
                                 .ToListAsync();
        }
    }
}
