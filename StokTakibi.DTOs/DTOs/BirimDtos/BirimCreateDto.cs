
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StokTakip.DTOs.DTOs.BirimDtos
{
    public class BirimCreateDto
    {
        [Required(ErrorMessage = "Birim adı zorunludur.")]
        [DisplayName("Birim Adı")]
        public string Ad { get; set; }
    }
}
