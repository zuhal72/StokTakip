using Microsoft.EntityFrameworkCore;
using StokTakip.DataAccess.IRepository;
using StokTakip.Entities.Entities;
using StokTakip.Services.IServices;
namespace StokTakip.Services.Services
{
    public class StokService : GenericService<Stok>, IStokService
    {
        private readonly IStokRepository _stokRepository;
        private readonly DbContext _context;

        public StokService(IStokRepository stokRepository, DbContext context) : base(stokRepository)
        {
            _stokRepository = stokRepository;
            _context = context;
        }

        public async Task<List<Stok>> GetStoklarWithKategoriAndBirimAsync()
        {
            return await _context.Set<Stok>()
                .Include(s => s.Kategori)
                .Include(s => s.Birim)
                .Include(s => s.Tedarikci) // ✔ Tedarikçi dahil edildi
                .ToListAsync();
        }

        public async Task<Stok> GetStokWithDetailsByIdAsync(int id)
        {
            return await _stokRepository.GetStokWithDetailsByIdAsync(id);
        }
    }
}
