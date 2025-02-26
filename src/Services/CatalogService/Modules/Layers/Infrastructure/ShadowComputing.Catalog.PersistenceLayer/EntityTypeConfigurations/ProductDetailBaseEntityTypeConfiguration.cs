using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShadowComputing.Catalog.DomainLayer.Common;
using ShadowComputing.Catalog.DomainLayer.EntityTypeConfiguration;

namespace ShadowComputing.Catalog.PersistenceLayer.EntityTypeConfiguration
{
    public class ProductDetailBaseEntityTypeConfiguration<TEntity> : ProductBaseEntityTypeConfiguration<TEntity> where TEntity : ProductDetailBaseEntity
    {
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.Property(config_product_detail_id => config_product_detail_id.ProductDetailId).HasColumnName("product_detail_id").HasMaxLength(40).HasColumnOrder(3);

            base.Configure(builder);
        }
    }
}
