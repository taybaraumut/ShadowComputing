using Microsoft.AspNetCore.Http;
using ShadowComputing.Catalog.DomainLayer.Common;

namespace ShadowComputing.Catalog.DomainLayer.Entities
{
    public class ProductBrand : ProductBaseEntity
    {
        public string Name { get; set; } = default!;
        public string ImageUrl { get; set; } = default!;

        public IFormFile ImageFile { get; set; } = default!;
        public virtual Product Product { get; set; } = default!;
    }
}
