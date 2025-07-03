
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StokTakip.DTOs.DTOs.TedarikciDtos
{
    public class TedarikciDeleteDto
    {
        [Required(ErrorMessage = "Silinecek tedarikçi ID'si zorunludur.")]
        [DisplayName("Tedarikçi ID")]
        public int Id { get; set; }
    }
}
