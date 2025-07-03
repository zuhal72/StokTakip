
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StokTakip.DTOs.DTOs.StokDtos
{
    public class StokUpdateDto
    {
        [Required(ErrorMessage = "Stok ID zorunludur.")]
        [DisplayName("Stok ID")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Ürün adı zorunludur.")]
        [DisplayName("Ürün Adı")]
        public string UrunAdi { get; set; }

        [Required(ErrorMessage = "Barkod alanı zorunludur.")]
        [DisplayName("Barkod")]
        public string Barkod { get; set; }

        [Required(ErrorMessage = "Miktar zorunludur.")]
        [DisplayName("Miktar")]
        public int Miktar { get; set; }

        [Required(ErrorMessage = "Alış fiyatı zorunludur.")]
        [DisplayName("Alış Fiyatı")]
        public decimal AlisFiyati { get; set; }

        [Required(ErrorMessage = "Satış fiyatı zorunludur.")]
        [DisplayName("Satış Fiyatı")]
        public decimal SatisFiyati { get; set; }

        [Required(ErrorMessage = "Birim seçimi zorunludur.")]
        [DisplayName("Birim")]
        public int BirimId { get; set; }

        [Required(ErrorMessage = "Kategori seçimi zorunludur.")]
        [DisplayName("Kategori")]
        public int KategoriId { get; set; }
    }
}
