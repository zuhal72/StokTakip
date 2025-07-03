
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StokTakip.DTOs.DTOs.KategoriDtos
{
    public class KategoriCreateDto
    {
        [Required(ErrorMessage = "Kategori adı zorunludur.")]
        [DisplayName("Kategori Adı")]
        public string Ad { get; set; }
    }
}
