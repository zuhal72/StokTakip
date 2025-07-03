namespace StokTakip.Services.IServices
{
    public interface IUnitOfWorkService
    {
        IBirimService BirimService { get; }
        IDepoService DepoService { get; }
        IKategoriService KategoriService { get; }
        IStokService StokService { get; }
        IStokHareketService StokHareketService { get; }
        ITedarikciService TedarikciService { get; }
    }
}
