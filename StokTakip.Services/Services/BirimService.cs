using StokTakip.DataAccess.IRepository;
using StokTakip.Entities.Entities;
using StokTakip.Services.IServices;

namespace StokTakip.Services.Services
{
    public class BirimService : GenericService<Birim>, IBirimService
    {
        private readonly IBirimRepository _birimRepository;

        public BirimService(IBirimRepository birimRepository)
            : base(birimRepository) // GenericService'e veriyoruz
        {
            _birimRepository = birimRepository;
        }

        public async Task<Birim> GetBirimWithStokAsync(int id)
        {
            return await _birimRepository.GetBirimWithStokAsync(id);
        }
    }
}
