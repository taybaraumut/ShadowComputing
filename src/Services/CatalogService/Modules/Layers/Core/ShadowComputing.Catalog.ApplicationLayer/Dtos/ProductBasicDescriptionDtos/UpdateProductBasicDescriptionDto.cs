
namespace ShadowComputing.Catalog.ApplicationLayer.Dtos.ProductBasicDescriptionDtos
{
    public class UpdateProductBasicDescriptionDto
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid ProductDetailId { get; set; } = default!;
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
    }
}
