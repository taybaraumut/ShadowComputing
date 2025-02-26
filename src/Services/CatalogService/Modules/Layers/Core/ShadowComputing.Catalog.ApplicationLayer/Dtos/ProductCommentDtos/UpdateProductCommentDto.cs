
namespace ShadowComputing.Catalog.ApplicationLayer.Dtos.ProductCommentDtos
{
    public class UpdateProductCommentDto
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid UserId { get; set; }
        public string Comment { get; set; } = default!;
    }
}
