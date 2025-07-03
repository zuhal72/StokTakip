
using StokTakip.DTOs.DTOs.BaseEntityDtos;
using System.ComponentModel;

namespace StokTakip.DTOs.DTOs.StokHareketDtos
{
    public class StokHareketListDto : BaseEntityDto
    {
        [DisplayName("Stok ID")]
        public int StokId { get; set; }

        [DisplayName("Stok Adı")]
        public string StokAdi { get; set; } // Navigation'dan gelen isim

        [DisplayName("Depo ID")]
        public int DepoId { get; set; }

        [DisplayName("Depo Adı")]
        public string DepoAdi { get; set; } // Navigation'dan gelen isim

        [DisplayName("Tarih")]
        public DateTime Tarih { get; set; }

        [DisplayName("Miktar")]
        public int Miktar { get; set; }

        [DisplayName("Giriş mi?")]
        public bool GirisMi { get; set; }

        [DisplayName("Açıklama")]
        public string Aciklama { get; set; }
    }
}
