using ShadowComputing.Catalog.DomainLayer.Common;

namespace ShadowComputing.Catalog.DomainLayer.Entities
{
    public class ProductDetail : ProductBaseEntity
    {
        public virtual ICollection<ProductAdvancedDescription> ProductAdvancedDescriptions { get; set; } = default!;
        public virtual ICollection<ProductStandardDescription> ProductStandardDescriptions { get; set; } = default!;
        public virtual ICollection<ProductBasicDescription> ProductBasicDescriptions { get; set; } = default!;
        public virtual Product Product { get; set; } = default!;
    }   
}
