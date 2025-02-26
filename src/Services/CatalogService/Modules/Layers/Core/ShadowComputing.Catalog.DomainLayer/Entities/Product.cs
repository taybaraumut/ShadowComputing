using Microsoft.AspNetCore.Http;
using ShadowComputing.Catalog.DomainLayer.Common;

namespace ShadowComputing.Catalog.DomainLayer.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; } = default!; 
        public string Model { get; set; } = default!;
        public string ImageUrl { get; set; } = default!;
        public string Manufacturer { get; set; } = default!;
        public string SerialNumber { get; set; } = default!;
        public string ReturnPolicy { get; set; } = default!;

        public string EstimatedDeliveryTime { get; set; } = default!;

        public decimal Price { get; set; }
        public decimal Weight { get; set; }

        public int StockQuantity { get; set; } 
        public int WarrantyPeriod { get; set; } 

        public DateTime CreatedAt { get; set; } 
        public DateTime UpdatedAt { get; set; } 
        public DateTime DiscontinuedAt { get; set; }

        public bool IsNewArrival { get; set; }
        public bool IsBestSeller { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsActive { get; set; }

        public IFormFile ImageFile { get; set; } = default!;

        public virtual ICollection<ProductSeo> ProductSeos { get; set; } = default!;
        public virtual ICollection<ProductDetail> ProductDetails { get; set; } = default!;
        public virtual ICollection<ProductBrand> ProductBrands { get; set; } = default!;
        public virtual ICollection<ProductImage> ProductImages { get; set; } = default!;
        public virtual ICollection<ProductSpecification> ProductSpecifications { get; set; } = default!; 
        public virtual ICollection<ProductComment> ProductComments { get; set; } = default!;
    } 
}
