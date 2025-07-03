
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StokTakip.DTOs.DTOs.StokHareketDtos
{
    public class StokHareketCreateDto
    {
        [Required(ErrorMessage = "Stok seçimi zorunludur.")]
        [DisplayName("Stok ID")]
        public int StokId { get; set; }

        [Required(ErrorMessage = "Depo seçimi zorunludur.")]
        [DisplayName("Depo ID")]
        public int DepoId { get; set; }

        [Required(ErrorMessage = "Tarih alanı zorunludur.")]
        [DisplayName("Tarih")]
        public DateTime Tarih { get; set; }

        [Required(ErrorMessage = "Miktar zorunludur.")]
        [DisplayName("Miktar")]
        public int Miktar { get; set; }

        [Required(ErrorMessage = "Giriş/Çıkış bilgisi zorunludur.")]
        [DisplayName("Giriş mi?")]
        public bool GirisMi { get; set; }

        [DisplayName("Açıklama")]
        public string Aciklama { get; set; }
    }
}
