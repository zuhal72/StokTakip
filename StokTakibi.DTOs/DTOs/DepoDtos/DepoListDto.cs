
using StokTakip.Entities.Entities;
using System.ComponentModel;

namespace StokTakip.DTOs.DTOs.DepoDtos
{
    public class DepoListDto
    {
        [DisplayName("Depo Adı")]
        public string Ad { get; set; }

        [DisplayName("Adres")]
        public string Adres { get; set; }

        // İsteğe bağlı: Eğer Depo ile birlikte hareketler de gösterilecekse
        //[DisplayName("Stok Hareketleri")]
        //public List<StokHareketListDto> StokHareketleri { get; set; }
    }
}
