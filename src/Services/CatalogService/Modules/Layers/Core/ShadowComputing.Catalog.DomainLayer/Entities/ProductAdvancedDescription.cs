using Microsoft.AspNetCore.Http;
using ShadowComputing.Catalog.DomainLayer.Common;

namespace ShadowComputing.Catalog.DomainLayer.Entities
{
    public class ProductAdvancedDescription : ProductDescriptionBaseEntity
    {               
        public string ImageUrl { get; set; } = default!;
        public string VideoUrl { get; set; } = default!;

        public IFormFile ImageFile { get; set; } = default!;
        public IFormFile VideoFile { get; set; } = default!;
        public virtual ProductDetail ProductDetail { get; set; } = default!;
    } 
}
