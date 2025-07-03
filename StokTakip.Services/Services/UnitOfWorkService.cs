using StokTakip.Services.IServices;

namespace StokTakip.Services.Services
{
    public class UnitOfWorkService : IUnitOfWorkService
    {
        public IBirimService BirimService { get; }
        public IDepoService DepoService { get; }
        public IKategoriService KategoriService { get; }
        public IStokService StokService { get; }
        public IStokHareketService StokHareketService { get; }
        public ITedarikciService TedarikciService { get; }

        public UnitOfWorkService(
            IBirimService birimService,
            IDepoService depoService,
            IKategoriService kategoriService,
            IStokService stokService,
            IStokHareketService stokHareketService,
            ITedarikciService tedarikciService)
        {
            BirimService = birimService;
            DepoService = depoService;
            KategoriService = kategoriService;
            StokService = stokService;
            StokHareketService = stokHareketService;
            TedarikciService = tedarikciService;
        }
    }
}
