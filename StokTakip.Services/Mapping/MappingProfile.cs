using AutoMapper;
using StokTakip.DTOs.DTOs.BirimDtos;
using StokTakip.DTOs.DTOs.DepoDtos;
using StokTakip.DTOs.DTOs.KategoriDtos;
using StokTakip.DTOs.DTOs.StokDtos;
using StokTakip.DTOs.DTOs.StokHareketDtos;
using StokTakip.DTOs.DTOs.TedarikciDtos;
using StokTakip.Entities.Entities;

namespace StokTakip.Service.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Kategori
            CreateMap<Kategori, KategoriListDto>().ReverseMap();
            CreateMap<Kategori, KategoriCreateDto>().ReverseMap();
            CreateMap<Kategori, KategoriUpdateDto>().ReverseMap();
            CreateMap<Kategori, KategoriDeleteDto>().ReverseMap();

            // Tedarikçi
            CreateMap<Tedarikci, TedarikciListDto>().ReverseMap();
            CreateMap<Tedarikci, TedarikciCreateDto>().ReverseMap();
            CreateMap<Tedarikci, TedarikciUpdateDto>().ReverseMap();
            CreateMap<Tedarikci, TedarikciDeleteDto>().ReverseMap();

            CreateMap<Stok, StokListDto>().ReverseMap();
            CreateMap<Stok, StokCreateDto>().ReverseMap();
            CreateMap<Stok, StokUpdateDto>().ReverseMap();
            CreateMap<Stok, StokDeleteDto>().ReverseMap();

            // Birim
            CreateMap<Birim, BirimListDto>().ReverseMap();
            CreateMap<Birim, BirimCreateDto>().ReverseMap();
            CreateMap<Birim, BirimUpdateDto>().ReverseMap();
            CreateMap<Birim, BirimDeleteDto>().ReverseMap();


            // Depo
            CreateMap<Depo, DepoListDto>().ReverseMap();
            CreateMap<Depo, DepoCreateDto>().ReverseMap();
            CreateMap<Depo, DepoUpdateDto>().ReverseMap();
            CreateMap<Depo, DepoDeleteDto>().ReverseMap();

            // StokHareket
            CreateMap<StokHareket, StokHareketListDto>().ReverseMap();
            CreateMap<StokHareket, StokHareketCreateDto>().ReverseMap();
            CreateMap<StokHareket, StokHareketUpdateDto>().ReverseMap();
            CreateMap<StokHareket, StokHareketDeleteDto>().ReverseMap();
        }
    }
}
