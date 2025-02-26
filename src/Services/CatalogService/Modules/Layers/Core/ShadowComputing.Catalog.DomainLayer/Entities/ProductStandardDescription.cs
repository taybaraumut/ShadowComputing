using Microsoft.AspNetCore.Http;
using ShadowComputing.Catalog.DomainLayer.Common;

namespace ShadowComputing.Catalog.DomainLayer.Entities
{
    public class ProductStandardDescription : ProductDescriptionBaseEntity
    {
        public string ImageUrl { get; set; } = default!;
        public IFormFile ImageFile { get; set; } = default!;
        public virtual ProductDetail ProductDetail { get; set; } = default!;
    }
}
