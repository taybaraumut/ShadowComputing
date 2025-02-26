using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShadowComputing.Catalog.DomainLayer.Entities;
using ShadowComputing.Catalog.DomainLayer.EntityTypeConfiguration;

namespace ShadowComputing.Catalog.PersistenceLayer.EntityTypeConfiguration
{
    public class ProductDetailEntityTypeConfiguration : ProductBaseEntityTypeConfiguration<ProductDetail>
    {
        public override void Configure(EntityTypeBuilder<ProductDetail> builder)
        {
            builder.ToTable(name: "product_details");

            base.Configure(builder);
        }
    }
}
