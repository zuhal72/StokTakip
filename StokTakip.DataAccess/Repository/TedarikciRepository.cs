using Microsoft.EntityFrameworkCore;
using StokTakip.DataAccess.Context;
using StokTakip.DataAccess.IRepository;
using StokTakip.Entities.Entities;

namespace StokTakip.DataAccess.Repository
{
    public class TedarikciRepository : GenericRepository<Tedarikci>, ITedarikciRepository
    {
        private readonly StokDbContext _context;

        public TedarikciRepository(StokDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Tedarikci> GetByEpostaAsync(string eposta)
        {
            return await _context.Tedarikciler
                                 .FirstOrDefaultAsync(t => t.Eposta == eposta);
        }
    }
}
