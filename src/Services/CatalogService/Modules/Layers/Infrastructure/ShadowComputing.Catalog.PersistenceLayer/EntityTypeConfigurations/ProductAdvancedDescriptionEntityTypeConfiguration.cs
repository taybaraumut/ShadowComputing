using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShadowComputing.Catalog.DomainLayer.Entities;

namespace ShadowComputing.Catalog.PersistenceLayer.EntityTypeConfiguration
{
    public class ProductAdvancedDescriptionEntityTypeConfiguration : ProductDescriptionBaseEntityTypeConfiguration<ProductAdvancedDescription>
    {
        public override void Configure(EntityTypeBuilder<ProductAdvancedDescription> builder)
        {
            builder.ToTable(name: "product_advanced_descriptions");

            builder.Property(config_image_url => config_image_url.ImageUrl).IsRequired(true).HasMaxLength(40).HasColumnName("image_url").HasColumnOrder(6);

            builder.Property(config_video_url => config_video_url.VideoUrl).IsRequired(true).HasMaxLength(40).HasColumnName("video_url").HasColumnOrder(7);

            builder.Ignore(config_image_file => config_image_file.ImageFile);

            builder.Ignore(config_video_file => config_video_file.VideoFile);

            base.Configure(builder);
        }
    }
}
