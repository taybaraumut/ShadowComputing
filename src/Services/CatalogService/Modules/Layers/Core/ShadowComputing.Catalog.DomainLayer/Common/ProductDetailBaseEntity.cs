namespace ShadowComputing.Catalog.DomainLayer.Common
{
    public abstract class ProductDetailBaseEntity : ProductBaseEntity
    {
        public Guid ProductDetailId { get; set; } = default!;
    }
}
