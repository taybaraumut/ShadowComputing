using Microsoft.AspNetCore.Http;
using ShadowComputing.Catalog.DomainLayer.Common;

namespace ShadowComputing.Catalog.DomainLayer.Entities
{
    public class ProductImage : ProductDetailBaseEntity
    {
        public virtual ICollection<string> BigImageUrl { get; set; } = default!;
        public virtual ICollection<string> SmallImageUrl { get; set; } = default!;
        public virtual ICollection<IFormFile>? BigImageFile { get; set; }
        public virtual ICollection<IFormFile>? SmallImageFile { get; set; }

        public virtual Product Product { get; set; } = default!;        
    }
}
