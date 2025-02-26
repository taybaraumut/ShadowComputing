using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShadowComputing.Catalog.DomainLayer.Common;

namespace ShadowComputing.Catalog.PersistenceLayer.EntityTypeConfiguration
{
    public class ProductDescriptionBaseEntityTypeConfiguration<TEntity> : ProductDetailBaseEntityTypeConfiguration<TEntity> where TEntity : ProductDescriptionBaseEntity
    {
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.Property(config_title => config_title.Title).IsRequired(true).HasMaxLength(450).HasColumnName("title").HasColumnOrder(4);

            builder.Property(config_description => config_description.Description).IsRequired(true).HasColumnName("description").HasColumnOrder(7);

            base.Configure(builder);
        }
    }
}
