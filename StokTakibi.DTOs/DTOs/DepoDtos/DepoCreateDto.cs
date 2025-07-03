
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StokTakip.DTOs.DTOs.DepoDtos
{
    public class DepoCreateDto
    {
        [Required(ErrorMessage = "Depo adı zorunludur.")]
        [DisplayName("Depo Adı")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Adres alanı zorunludur.")]
        [DisplayName("Adres")]
        public string Adres { get; set; }
    }
}
