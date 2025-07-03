
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StokTakip.DTOs.DTOs.StokHareketDtos
{
    public class StokHareketDeleteDto
    {
        [Required(ErrorMessage = "Silinecek hareket ID'si zorunludur.")]
        [DisplayName("Stok Hareket ID")]
        public int Id { get; set; }
    }
}
