
using Microsoft.AspNetCore.Http;

namespace ShadowComputing.Catalog.ApplicationLayer.Dtos.ProductBrandDtos
{
    public class GetProductBrandListDto
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public string Name { get; set; } = default!;
        public string ImageUrl { get; set; } = default!;
    }
}
