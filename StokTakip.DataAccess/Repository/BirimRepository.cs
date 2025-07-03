using Microsoft.EntityFrameworkCore;
using StokTakip.DataAccess.Context;
using StokTakip.DataAccess.IRepository;
using StokTakip.Entities.Entities;

namespace StokTakip.DataAccess.Repository
{
    public class BirimRepository : GenericRepository<Birim>, IBirimRepository
    {
        private readonly StokDbContext _context;

        public BirimRepository(StokDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Birim> GetBirimWithStokAsync(int id)
        {
            return await _context.Birimler
                .Include(b => b.Stoklar)
                .FirstOrDefaultAsync(b => b.Id == id);
        }
    }
}
