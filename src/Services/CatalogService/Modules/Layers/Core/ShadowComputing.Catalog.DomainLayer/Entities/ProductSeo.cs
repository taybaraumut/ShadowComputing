using ShadowComputing.Catalog.DomainLayer.Common;

namespace ShadowComputing.Catalog.DomainLayer.Entities
{
    public class ProductSeo : ProductBaseEntity
    {
        public string SeoTitle { get; set; } = default!;
        public string SeoDescription { get; set; } = default!;
        public string SeoKeywords { get; set; } = default!;

        public virtual Product Product { get; set; } = default!;
    }
}
