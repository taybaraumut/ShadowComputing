using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShadowComputing.Catalog.DomainLayer.Entities;

namespace ShadowComputing.Catalog.PersistenceLayer.EntityTypeConfiguration
{
    public class ProductStandardDescriptionEntityTypeConfiguration : ProductDescriptionBaseEntityTypeConfiguration<ProductStandardDescription>
    {
        public override void Configure(EntityTypeBuilder<ProductStandardDescription> builder)
        {
            builder.ToTable(name: "product_standard_descriptions");

            builder.Property(config_image_url => config_image_url.ImageUrl).IsRequired(true).HasMaxLength(40).HasColumnName("image_url").HasColumnOrder(6);

            builder.Ignore(config_image_file => config_image_file.ImageFile);

            base.Configure(builder);
        }
    }
}
