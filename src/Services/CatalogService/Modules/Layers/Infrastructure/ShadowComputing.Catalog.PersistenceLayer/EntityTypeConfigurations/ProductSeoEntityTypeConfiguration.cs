using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShadowComputing.Catalog.DomainLayer.Entities;
using ShadowComputing.Catalog.DomainLayer.EntityTypeConfiguration;

namespace ShadowComputing.Catalog.PersistenceLayer.EntityTypeConfiguration
{
    public class ProductSeoEntityTypeConfiguration : ProductBaseEntityTypeConfiguration<ProductSeo>
    {
        public override void Configure(EntityTypeBuilder<ProductSeo> builder)
        {
            builder.ToTable("product_seos");

            builder.Property(config_seo_title => config_seo_title.SeoTitle).HasColumnName("seo_title").HasMaxLength(60).HasColumnOrder(3);
            builder.Property(config_seo_description => config_seo_description.SeoDescription).HasColumnName("seo_description").HasMaxLength(160).IsRequired(true).HasColumnOrder(4);
            builder.Property(config_seo_keywords => config_seo_keywords.SeoKeywords).HasColumnName("seo_keywords").HasMaxLength(450).IsRequired(true).HasColumnOrder(5);

            base.Configure(builder);
        }
    }
}
