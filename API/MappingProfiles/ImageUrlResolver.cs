using API.DTO;
using AutoMapper;
using Core.Entities;

namespace API.MappingProfiles
{
    public class ImageUrlResolver:IValueResolver<Product,AddProductDTO,Image>
    {
        public ImageUrlResolver()
        {
            
        }
    }
}
