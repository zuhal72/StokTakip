using StokTakip.Entities.Entities;

namespace StokTakip.Services.IServices
{
    public interface ITedarikciService : IGenericService<Tedarikci>
    {
        Task<Tedarikci> GetByEpostaAsync(string eposta);
    }
}
