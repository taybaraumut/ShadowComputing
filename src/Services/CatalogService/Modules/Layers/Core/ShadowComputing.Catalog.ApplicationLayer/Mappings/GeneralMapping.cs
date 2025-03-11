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
using ShadowComputing.Catalog.ApplicationLayer.Features.Mediator.Commands.ProductAdvancedDescriptions.Create;
using ShadowComputing.Catalog.ApplicationLayer.Features.Mediator.Commands.ProductAdvancedDescriptions.Update;
using ShadowComputing.Catalog.ApplicationLayer.Features.Mediator.Commands.ProductBasicDescriptions.Create;
using ShadowComputing.Catalog.ApplicationLayer.Features.Mediator.Commands.ProductBasicDescriptions.Update;
using ShadowComputing.Catalog.ApplicationLayer.Features.Mediator.Commands.ProductBrands.Create;
using ShadowComputing.Catalog.ApplicationLayer.Features.Mediator.Commands.ProductBrands.Update;
using ShadowComputing.Catalog.ApplicationLayer.Features.Mediator.Commands.ProductComments.Create;
using ShadowComputing.Catalog.ApplicationLayer.Features.Mediator.Commands.ProductComments.Update;
using ShadowComputing.Catalog.ApplicationLayer.Features.Mediator.Commands.ProductDetails.Create;
using ShadowComputing.Catalog.ApplicationLayer.Features.Mediator.Commands.ProductDetails.Update;
using ShadowComputing.Catalog.ApplicationLayer.Features.Mediator.Commands.ProductImages.Create;
using ShadowComputing.Catalog.ApplicationLayer.Features.Mediator.Commands.ProductImages.Update;
using ShadowComputing.Catalog.ApplicationLayer.Features.Mediator.Commands.Products.Create;
using ShadowComputing.Catalog.ApplicationLayer.Features.Mediator.Commands.Products.Update;
using ShadowComputing.Catalog.ApplicationLayer.Features.Mediator.Commands.ProductSpecifications.Create;
using ShadowComputing.Catalog.ApplicationLayer.Features.Mediator.Commands.ProductSpecifications.Update;
using ShadowComputing.Catalog.ApplicationLayer.Features.Mediator.Commands.ProductStandardDescriptions.Create;
using ShadowComputing.Catalog.ApplicationLayer.Features.Mediator.Commands.ProductStandardDescriptions.Update;
using ShadowComputing.Catalog.DomainLayer.Entities;

namespace ShadowComputing.Catalog.ApplicationLayer.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<CreateProductAdvancedDescriptionCommand, ProductAdvancedDescription>().ReverseMap();
            CreateMap<UpdateProductAdvancedDescriptionCommand, ProductAdvancedDescription>().ReverseMap();
            CreateMap<GetProductAdvancedDescriptionDto, ProductAdvancedDescription>().ReverseMap();         
            CreateMap<GetProductAdvancedDescriptionListDto, ProductAdvancedDescription>().ReverseMap();

            CreateMap<CreateProductBasicDescriptionCommand, ProductBasicDescription>().ReverseMap();
            CreateMap<UpdateProductBasicDescriptionCommand, ProductBasicDescription>().ReverseMap();
            CreateMap<GetProductBasicDescriptionDto, ProductBasicDescription>().ReverseMap();
            CreateMap<GetProductBasicDescriptionListDto, ProductBasicDescription>().ReverseMap();

            CreateMap<CreateProductBrandCommand, ProductBrand>().ReverseMap();
            CreateMap<UpdateProductBrandCommand, ProductBrand>().ReverseMap();
            CreateMap<GetProductBrandDto, ProductBrand>().ReverseMap();
            CreateMap<GetProductBrandListDto, ProductBrand>().ReverseMap();

            CreateMap<CreateProductCommentCommand, ProductComment>().ReverseMap();
            CreateMap<UpdateProductCommentCommand, ProductComment>().ReverseMap();
            CreateMap<GetProductCommentDto, ProductComment>().ReverseMap();
            CreateMap<GetProductCommentListDto, ProductComment>().ReverseMap();

            CreateMap<CreateProductDetailCommand, ProductDetail>().ReverseMap();
            CreateMap<UpdateProductDetailCommand, ProductDetail>().ReverseMap();
            CreateMap<GetProductDetailDto, ProductDetail>().ReverseMap();
            CreateMap<GetProductDetailListDto, ProductDetail>().ReverseMap();

            CreateMap<CreateProductCommand, Product>().ReverseMap();
            CreateMap<UpdateProductCommand, Product>().ReverseMap();
            CreateMap<GetProductDto, Product>().ReverseMap();
            CreateMap<GetProductListDto, Product>().ReverseMap();

            CreateMap<CreateProductImageCommand, ProductImage>().ReverseMap();
            CreateMap<UpdateProductImageCommand, ProductImage>().ReverseMap();
            CreateMap<GetProductImageDto, ProductImage>().ReverseMap();
            CreateMap<GetProductImageListDto, ProductImage>().ReverseMap();

            CreateMap<CreateProductSpecificationCommand, ProductSpecification>().ReverseMap();
            CreateMap<UpdateProductSpecificationCommand, ProductSpecification>().ReverseMap();
            CreateMap<GetProductSpecificationDto, ProductSpecification>().ReverseMap();
            CreateMap<GetProductSpecificationListDto, ProductSpecification>().ReverseMap();

            CreateMap<CreateProductStandardDescriptionCommand, ProductStandardDescription>().ReverseMap();
            CreateMap<UpdateProductStandardDescriptionCommand, ProductStandardDescription>().ReverseMap();
            CreateMap<GetProductStandardDescriptionDto, ProductStandardDescription>().ReverseMap();
            CreateMap<GetProductStandardDescriptionListDto, ProductStandardDescription>().ReverseMap();
        }
    }
}
