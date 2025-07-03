

using StokTakip.DTOs.DTOs.BaseEntityDtos;
using StokTakip.DTOs.DTOs.StokDtos;
using System.ComponentModel;

namespace StokTakip.DTOs.DTOs.BirimDtos
{
    public class BirimListDto:BaseEntityDto
    {
        [DisplayName("Birim Adı")]
        public string Ad { get; set; }

        [DisplayName("Stoklar")]
        public List<StokListDto> Stoklar { get; set; }
    }
}
