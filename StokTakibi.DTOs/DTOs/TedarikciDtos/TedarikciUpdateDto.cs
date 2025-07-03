
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StokTakip.DTOs.DTOs.TedarikciDtos
{
    public class TedarikciUpdateDto
    {
        [Required(ErrorMessage = "Tedarikçi ID'si zorunludur.")]
        [DisplayName("Tedarikçi ID")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tedarikçi adı zorunludur.")]
        [DisplayName("Tedarikçi Adı")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Telefon numarası zorunludur.")]
        [DisplayName("Telefon")]
        public string Telefon { get; set; }

        [Required(ErrorMessage = "E-posta adresi zorunludur.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        [DisplayName("E-posta")]
        public string Eposta { get; set; }

        [Required(ErrorMessage = "Adres zorunludur.")]
        [DisplayName("Adres")]
        public string Adres { get; set; }
    }
}
