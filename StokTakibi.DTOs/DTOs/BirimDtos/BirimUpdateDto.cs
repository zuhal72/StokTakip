
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StokTakip.DTOs.DTOs.BirimDtos
{
    public class BirimUpdateDto
    {
        [Required(ErrorMessage = "Güncellenecek birim ID'si zorunludur.")]
        [DisplayName("Birim ID")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Birim adı zorunludur.")]
        [DisplayName("Birim Adı")]
        public string Ad { get; set; }
    }
}
