using Microsoft.AspNetCore.Http;

namespace ShadowComputing.Catalog.ApplicationLayer.Dtos.ProductAdvancedDescriptionDtos
{
    public class CreateProductAdvancedDescriptionDto
    {
        public Guid ProductId { get; set; }
        public Guid ProductDetailId { get; set; } = default!;
        public string Title { get; set; } = default!;
      
        public string ImageUrl { get; set; } = default!;
        public string VideoUrl { get; set; } = default!;

        public string Description { get; set; } = default!;

        public IFormFile ImageFile { get; set; } = default!;
        public IFormFile VideoFile { get; set; } = default!;
    }
}
