using StokTakip.Entities.Entities;
using System.Threading.Tasks;

namespace StokTakip.Services.IServices
{
    public interface IBirimService : IGenericService<Birim>
    {
        Task<Birim> GetBirimWithStokAsync(int id);
    }
}
