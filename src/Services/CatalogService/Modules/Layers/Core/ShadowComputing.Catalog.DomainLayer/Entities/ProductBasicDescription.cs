using ShadowComputing.Catalog.DomainLayer.Common;

namespace ShadowComputing.Catalog.DomainLayer.Entities
{
    public class ProductBasicDescription : ProductDescriptionBaseEntity
    {
        public virtual ProductDetail ProductDetail { get; set; } = default!;
    }
}
