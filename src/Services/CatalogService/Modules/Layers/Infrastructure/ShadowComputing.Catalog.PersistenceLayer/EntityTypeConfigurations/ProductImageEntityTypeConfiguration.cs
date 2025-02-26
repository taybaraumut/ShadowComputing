using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShadowComputing.Catalog.DomainLayer.Entities;
using ShadowComputing.Catalog.PersistenceLayer.EntityTypeConfiguration;

namespace ShadowComputing.Catalog.DomainLayer.EntityTypeConfiguration
{
    public class ProductImageEntityTypeConfiguration : ProductDetailBaseEntityTypeConfiguration<ProductImage>
    {
        public override void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.ToTable(name: "product_images");

            builder.Property(config_small_image_url => config_small_image_url.SmallImageUrl).IsRequired(true).HasColumnName("small_image_url").HasColumnOrder(4);
            builder.Property(config_big_image_url => config_big_image_url.BigImageUrl).IsRequired(true).HasColumnName("big_image_url").HasColumnOrder(5);

            builder.Ignore(config_small_image_file => config_small_image_file.SmallImageFile);
            builder.Ignore(config_big_image_file => config_big_image_file.BigImageFile);

            base.Configure(builder);
        }
    }
}
