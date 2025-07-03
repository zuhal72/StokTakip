using StokTakip.DataAccess.IRepository;
using StokTakip.Entities.Entities;
using StokTakip.Services.IServices;

namespace StokTakip.Services.Services
{
    public class TedarikciService : GenericService<Tedarikci>, ITedarikciService
    {
        private readonly ITedarikciRepository _repository;

        public TedarikciService(ITedarikciRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public async Task<Tedarikci> GetByEpostaAsync(string eposta)
        {
            return await _repository.GetByEpostaAsync(eposta);
        }
    }
}
