using API.DTO;
using AutoMapper;
using Core.Entities;

namespace API.MappingProfiles
{
    public class ProductMappings : Profile
    {
        public ProductMappings()
        {
            CreateMap<Product, AddProductDTO>();
            CreateMap<Product, GetProductDTO>()
                 .ForMember(dest => dest.ImageUrls, opt => opt.MapFrom(src => src.ImageUrls.Select(i => i.Url)))
                 .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.category.Name))
                 .ForMember(dest => dest.DiscountNames, opt => opt.MapFrom(src => src.Discounts.Select(i => i.Name)));
        }
    }
}
