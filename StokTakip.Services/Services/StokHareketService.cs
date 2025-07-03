using StokTakip.DataAccess.IRepository;
using StokTakip.Entities.Entities;
using StokTakip.Services.IServices;

namespace StokTakip.Services.Services
{
    public class StokHareketService : GenericService<StokHareket>, IStokHareketService
    {
        private readonly IStokHareketRepository _repository;

        public StokHareketService(IStokHareketRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<StokHareket>> GetHareketlerWithDetailsAsync()
        {
            return await _repository.GetHareketlerWithDetailsAsync();
        }

        public async Task<IEnumerable<StokHareket>> GetHareketlerByStokIdAsync(int stokId)
        {
            return await _repository.GetHareketlerByStokIdAsync(stokId);
        }
    }
}
