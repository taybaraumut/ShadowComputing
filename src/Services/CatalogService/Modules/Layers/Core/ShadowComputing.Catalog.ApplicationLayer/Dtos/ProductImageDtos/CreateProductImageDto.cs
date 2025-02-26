
using Microsoft.AspNetCore.Http;

namespace ShadowComputing.Catalog.ApplicationLayer.Dtos.ProductImageDtos
{
    public class CreateProductImageDto
    {
        public Guid ProductId { get; set; }
        public Guid ProductDetailId { get; set; } = default!;

        public virtual ICollection<string> BigImageUrl { get; set; } = default!;
        public virtual ICollection<string> SmallImageUrl { get; set; } = default!;
        public virtual ICollection<IFormFile>? BigImageFile { get; set; }
        public virtual ICollection<IFormFile>? SmallImageFile { get; set; }
    }
}
