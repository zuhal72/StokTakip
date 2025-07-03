
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StokTakip.DTOs.DTOs.DepoDtos
{
    public class DepoDeleteDto
    {
        [Required(ErrorMessage = "Depo ID zorunludur.")]
        [DisplayName("Depo ID")]
        public int Id { get; set; }
    }
}
