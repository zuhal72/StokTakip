
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StokTakip.DTOs.DTOs.KategoriDtos
{
    public class KategoriUpdateDto
    {
        [Required(ErrorMessage = "Kategori ID zorunludur.")]
        [DisplayName("Kategori ID")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Kategori adı zorunludur.")]
        [DisplayName("Kategori Adı")]
        public string Ad { get; set; }
    }
}
