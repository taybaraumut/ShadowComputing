
namespace ShadowComputing.Catalog.ApplicationLayer.Dtos.ProductSeoDtos
{
    public class GetProductSeoListDto
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public string SeoTitle { get; set; } = default!;
        public string SeoDescription { get; set; } = default!;
        public string SeoKeywords { get; set; } = default!;
    }
}
