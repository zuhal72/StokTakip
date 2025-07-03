
using StokTakip.DTOs.DTOs.BaseEntityDtos;
using System.ComponentModel;

namespace StokTakip.DTOs.DTOs.TedarikciDtos
{
    public class TedarikciListDto : BaseEntityDto
    {
        [DisplayName("Tedarikçi Adı")]
        public string Ad { get; set; }

        [DisplayName("Telefon")]
        public string Telefon { get; set; }

        [DisplayName("E-posta")]
        public string Eposta { get; set; }

        [DisplayName("Adres")]
        public string Adres { get; set; }
    }
}
