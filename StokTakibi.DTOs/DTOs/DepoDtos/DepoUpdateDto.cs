

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StokTakip.DTOs.DTOs.DepoDtos
{
    public class DepoUpdateDto
    {
        [Required(ErrorMessage = "Depo ID zorunludur.")]
        [DisplayName("Depo ID")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Depo adı zorunludur.")]
        [DisplayName("Depo Adı")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Adres alanı zorunludur.")]
        [DisplayName("Adres")]
        public string Adres { get; set; }
    }
}
