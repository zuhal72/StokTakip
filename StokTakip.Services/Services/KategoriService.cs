using StokTakip.Entities.Entities;
using StokTakip.DataAccess.IRepository;
using StokTakip.Services.IServices;
using System.Threading.Tasks;

namespace StokTakip.Services.Services
{
    public class KategoriService : GenericService<Kategori>, IKategoriService
    {
        private readonly IKategoriRepository _kategoriRepository;

        public KategoriService(IKategoriRepository kategoriRepository)
            : base(kategoriRepository) // GenericService constructor'ına gönderiyoruz
        {
            _kategoriRepository = kategoriRepository;
        }

        public async Task<Kategori> GetKategoriWithStoklarAsync(int kategoriId)
        {
            return await _kategoriRepository.GetKategoriWithStoklarAsync(kategoriId);
        }
    }
}
