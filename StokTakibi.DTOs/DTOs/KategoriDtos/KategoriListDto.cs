
using StokTakip.DTOs.DTOs.StokDtos;
using System.ComponentModel;

namespace StokTakip.DTOs.DTOs.KategoriDtos
{
    public class KategoriListDto
    {
        [DisplayName("Kategori Adı")]
        public string Ad { get; set; }

        // İsteğe bağlı: stokları da göstermek istersen:
        [DisplayName("Stoklar")]
        public List<StokListDto> Stoklar { get; set; }
    }
}
