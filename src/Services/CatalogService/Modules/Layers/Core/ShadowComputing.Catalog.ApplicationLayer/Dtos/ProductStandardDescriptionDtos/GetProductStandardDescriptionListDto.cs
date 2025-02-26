
using Microsoft.AspNetCore.Http;

namespace ShadowComputing.Catalog.ApplicationLayer.Dtos.ProductStandardDescriptionDtos
{
    public class GetProductStandardDescriptionListDto
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid ProductDetailId { get; set; } = default!;
        public string Title { get; set; } = default!;

        public string ImageUrl { get; set; } = default!;
        public string Description { get; set; } = default!;
    }
}
