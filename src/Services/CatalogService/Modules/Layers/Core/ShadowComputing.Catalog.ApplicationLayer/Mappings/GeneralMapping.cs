using AutoMapper;
using ShadowComputing.Catalog.ApplicationLayer.Dtos.ProductAdvancedDescriptionDtos;
using ShadowComputing.Catalog.ApplicationLayer.Dtos.ProductBasicDescriptionDtos;
using ShadowComputing.Catalog.ApplicationLayer.Dtos.ProductBrandDtos;
using ShadowComputing.Catalog.ApplicationLayer.Dtos.ProductCommentDtos;
using ShadowComputing.Catalog.ApplicationLayer.Dtos.ProductDetailDtos;
using ShadowComputing.Catalog.ApplicationLayer.Dtos.ProductDtos;
using ShadowComputing.Catalog.ApplicationLayer.Dtos.ProductImageDtos;
using ShadowComputing.Catalog.ApplicationLayer.Dtos.ProductSpecificationDtos;
using ShadowComputing.Catalog.ApplicationLayer.Dtos.ProductStandardDescriptionDtos;
using ShadowComputing.Catalog.DomainLayer.Entities;

namespace ShadowComputing.Catalog.ApplicationLayer.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<CreateProductAdvancedDescriptionDto, ProductAdvancedDescription>().ReverseMap();
            CreateMap<UpdateProductAdvancedDescriptionDto, ProductAdvancedDescription>().ReverseMap();
            CreateMap<GetProductAdvancedDescriptionDto, ProductAdvancedDescription>().ReverseMap();         
            CreateMap<GetProductAdvancedDescriptionListDto, ProductAdvancedDescription>().ReverseMap();

            CreateMap<CreateProductBasicDescriptionDto, ProductBasicDescription>().ReverseMap();
            CreateMap<UpdateProductBasicDescriptionDto, ProductBasicDescription>().ReverseMap();
            CreateMap<GetProductBasicDescriptionDto, ProductBasicDescription>().ReverseMap();
            CreateMap<GetProductBasicDescriptionListDto, ProductBasicDescription>().ReverseMap();

            CreateMap<CreateProductBrandDto, ProductBrand>().ReverseMap();
            CreateMap<UpdateProductBrandDto, ProductBrand>().ReverseMap();
            CreateMap<GetProductBrandDto, ProductBrand>().ReverseMap();
            CreateMap<GetProductBrandListDto, ProductBrand>().ReverseMap();

            CreateMap<CreateProductCommentDto, ProductComment>().ReverseMap();
            CreateMap<UpdateProductCommentDto, ProductComment>().ReverseMap();
            CreateMap<GetProductCommentDto, ProductComment>().ReverseMap();
            CreateMap<GetProductCommentListDto, ProductComment>().ReverseMap();

            CreateMap<CreateProductDetailDto, ProductDetail>().ReverseMap();
            CreateMap<UpdateProductDetailDto, ProductDetail>().ReverseMap();
            CreateMap<GetProductDetailDto, ProductDetail>().ReverseMap();
            CreateMap<GetProductDetailListDto, ProductDetail>().ReverseMap();

            CreateMap<CreateProductDto, Product>().ReverseMap();
            CreateMap<UpdateProductDto, Product>().ReverseMap();
            CreateMap<GetProductDto, Product>().ReverseMap();
            CreateMap<GetProductListDto, Product>().ReverseMap();

            CreateMap<CreateProductImageDto, ProductImage>().ReverseMap();
            CreateMap<UpdateProductImageDto, ProductImage>().ReverseMap();
            CreateMap<GetProductImageDto, ProductImage>().ReverseMap();
            CreateMap<GetProductImageListDto, ProductImage>().ReverseMap();

            CreateMap<CreateProductSpecificationDto, ProductSpecification>().ReverseMap();
            CreateMap<UpdateProductSpecificationDto, ProductSpecification>().ReverseMap();
            CreateMap<GetProductSpecificationDto, ProductSpecification>().ReverseMap();
            CreateMap<GetProductSpecificationListDto, ProductSpecification>().ReverseMap();

            CreateMap<CreateProductStandardDescriptionDto, ProductStandardDescription>().ReverseMap();
            CreateMap<UpdateProductStandardDescriptionDto, ProductStandardDescription>().ReverseMap();
            CreateMap<GetProductStandardDescriptionDto, ProductStandardDescription>().ReverseMap();
            CreateMap<GetProductStandardDescriptionListDto, ProductStandardDescription>().ReverseMap();
        }
    }
}
