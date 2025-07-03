
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StokTakip.DTOs.DTOs.KategoriDtos
{
    public class KategoriDeleteDto
    {
        [Required(ErrorMessage = "Silinecek kategori ID'si zorunludur.")]
        [DisplayName("Kategori ID")]
        public int Id { get; set; }
    }
}
