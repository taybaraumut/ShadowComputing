namespace ShadowComputing.Catalog.DomainLayer.Common
{
    public abstract class ProductDescriptionBaseEntity : ProductDetailBaseEntity
    {
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
    }
}
