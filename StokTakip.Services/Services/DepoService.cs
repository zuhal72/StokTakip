using StokTakip.DataAccess.IRepository;
using StokTakip.Entities.Entities;
using StokTakip.Services.IServices;

namespace StokTakip.Services.Services
{
    public class DepoService : GenericService<Depo>, IDepoService
    {
        public DepoService(IDepoRepository depoRepository) : base(depoRepository)
        {
        }
    }
}
