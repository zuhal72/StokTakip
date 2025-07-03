
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StokTakip.DTOs.DTOs.StokDtos
{
    public class StokDeleteDto
    {
        [Required(ErrorMessage = "Silinecek stok ID'si zorunludur.")]
        [DisplayName("Stok ID")]
        public int Id { get; set; }
    }
}
