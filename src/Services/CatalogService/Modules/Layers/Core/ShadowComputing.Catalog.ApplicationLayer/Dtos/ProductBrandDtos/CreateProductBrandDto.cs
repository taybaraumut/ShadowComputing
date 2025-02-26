
using Microsoft.AspNetCore.Http;

namespace ShadowComputing.Catalog.ApplicationLayer.Dtos.ProductBrandDtos
{
    public class CreateProductBrandDto
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; } = default!;
        public string ImageUrl { get; set; } = default!;

        public IFormFile ImageFile { get; set; } = default!;
    }
}
