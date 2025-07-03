using Microsoft.EntityFrameworkCore;
using StokTakip.DataAccess.Context;
using StokTakip.DataAccess.IRepository;
using StokTakip.Entities.Entities;

namespace StokTakip.DataAccess.Repository
{
    public class DepoRepository : GenericRepository<Depo>, IDepoRepository
    {
        private readonly StokDbContext _context;

        public DepoRepository(StokDbContext context) : base(context)
        {
            _context = context;
        }

    }
}
