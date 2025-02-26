
namespace ShadowComputing.Catalog.ApplicationLayer.Dtos.ProductImageDtos
{
    public class GetProductImageDto
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid ProductDetailId { get; set; } = default!;

        public virtual ICollection<string> BigImageUrl { get; set; } = default!;
        public virtual ICollection<string> SmallImageUrl { get; set; } = default!;
    }
}
