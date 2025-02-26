using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShadowComputing.Catalog.DomainLayer.Common;

namespace ShadowComputing.Catalog.DomainLayer.EntityTypeConfiguration
{
    public class ProductBaseEntityTypeConfiguration<TEntity> : BaseEntityTypeConfiguration<TEntity>
                                                              where TEntity : ProductBaseEntity
    {
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.Property(config_product_id => config_product_id.ProductId).IsRequired(true).HasMaxLength(40).HasColumnName("product_id").HasColumnOrder(2);
            base.Configure(builder);
        }
    }
}
