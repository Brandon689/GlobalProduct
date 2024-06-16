using AutoMapper;
using GlobalProduct.ExternalProducts;
using GlobalProduct.Products;

namespace GlobalProduct
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Mapping ExternalProduct to Product, including nested collections
            CreateMap<ExternalProduct, Product>()
                .ForMember(dest => dest.Variants, opt => opt.MapFrom(src => src.Variants))
                .ForMember(dest => dest.Options, opt => opt.MapFrom(src => src.Options))
                .ForMember(dest => dest.Images, opt => opt.MapFrom(src => src.Images));

            // Mapping ExternalVariant to Variant
            CreateMap<ExternalVariant, Variant>();

            // Mapping ExternalOption to Option
            CreateMap<ExternalOption, Option>();

            CreateMap<ExternalImage, Image>();
        }
    }
}
