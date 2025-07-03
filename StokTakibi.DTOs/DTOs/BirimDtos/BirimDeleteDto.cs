
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StokTakip.DTOs.DTOs.BirimDtos
{
    public class BirimDeleteDto
    {
        [Required(ErrorMessage = "Silinecek birim ID'si zorunludur.")]
        [DisplayName("Birim ID")]
        public int Id { get; set; }
    }
}
