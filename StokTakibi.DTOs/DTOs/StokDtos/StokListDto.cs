
using System.ComponentModel;

namespace StokTakip.DTOs.DTOs.StokDtos
{
    public class StokListDto
    {
        [DisplayName("Ürün Adı")]
        public string UrunAdi { get; set; }

        [DisplayName("Barkod")]
        public string Barkod { get; set; }

        [DisplayName("Miktar")]
        public int Miktar { get; set; }

        [DisplayName("Alış Fiyatı")]
        public decimal AlisFiyati { get; set; }

        [DisplayName("Satış Fiyatı")]
        public decimal SatisFiyati { get; set; }

        [DisplayName("Birim ID")]
        public int BirimId { get; set; }

        [DisplayName("Kategori ID")]
        public int KategoriId { get; set; }

        // Gerekirse birim ve kategori adları da eklenebilir:
        [DisplayName("Birim Adı")]
        public string BirimAdi { get; set; }

        [DisplayName("Kategori Adı")]
        public string KategoriAdi { get; set; }
    }
}
