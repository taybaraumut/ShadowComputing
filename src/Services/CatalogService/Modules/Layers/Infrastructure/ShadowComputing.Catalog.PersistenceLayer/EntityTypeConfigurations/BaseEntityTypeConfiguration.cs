using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShadowComputing.Catalog.DomainLayer.Common;

namespace ShadowComputing.Catalog.DomainLayer.EntityTypeConfiguration
{
    public class BaseEntityTypeConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(config_id => config_id.Id);
            builder.Property(config_id => config_id.Id).IsRequired(true).HasMaxLength(40).HasColumnName("id").HasColumnOrder(1);
        }
    }
}
