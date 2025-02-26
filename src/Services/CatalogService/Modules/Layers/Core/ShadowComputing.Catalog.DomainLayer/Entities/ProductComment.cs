using ShadowComputing.Catalog.DomainLayer.Common;

namespace ShadowComputing.Catalog.DomainLayer.Entities
{
    public class ProductComment : ProductBaseEntity
    {
        public Guid UserId  { get; set; }
        public string Comment { get; set; } = default!;

        public virtual Product Product { get; set; } = default!;
    }
}
