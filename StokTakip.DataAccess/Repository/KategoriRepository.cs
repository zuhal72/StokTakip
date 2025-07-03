using Microsoft.EntityFrameworkCore;
using StokTakip.DataAccess.Context;
using StokTakip.DataAccess.IRepository;
using StokTakip.Entities.Entities;
using System.Threading.Tasks;

namespace StokTakip.DataAccess.Repository
{
    public class KategoriRepository : GenericRepository<Kategori>, IKategoriRepository
    {
        private readonly StokDbContext _context;

        public KategoriRepository(StokDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Kategori> GetKategoriWithStoklarAsync(int kategoriId)
        {
            return await _context.Kategoriler
                                 .Include(k => k.Stoklar)
                                 .FirstOrDefaultAsync(k => k.Id == kategoriId);
        }
    }
}
