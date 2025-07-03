using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.DTOs.DTOs.BaseEntityDtos
{
    public class BaseEntityDto
    {
        public int Id { get; set; }

    [Required(ErrorMessage = "Aktiflik durumu zorunludur.")]
    [DisplayName("Aktif mi?")]
    public bool IsActive { get; set; }

    [Required(ErrorMessage = "Silinme durumu zorunludur.")]
    [DisplayName("Silindi mi?")]
    public bool IsDeleted { get; set; }

    [Required(ErrorMessage = "Oluşturulma tarihi zorunludur.")]
    [DisplayName("Oluşturulma Tarihi")]
    public DateTime CreatedDate { get; set; }

    [DisplayName("Güncellenme Tarihi")]
    public DateTime? ModifiedDate { get; set; }
}
}
