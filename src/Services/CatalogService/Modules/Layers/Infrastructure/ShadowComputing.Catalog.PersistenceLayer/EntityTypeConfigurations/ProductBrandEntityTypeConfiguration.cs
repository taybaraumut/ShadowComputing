using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShadowComputing.Catalog.DomainLayer.Entities;

namespace ShadowComputing.Catalog.DomainLayer.EntityTypeConfiguration
{
    public class ProductBrandEntityTypeConfiguration:ProductBaseEntityTypeConfiguration<ProductBrand>
    {
        public override void Configure(EntityTypeBuilder<ProductBrand> builder)
        {

            builder.ToTable(name: "product_brands");

            builder.Property(config_name => config_name.Name).IsRequired(true).HasMaxLength(100).HasColumnName("name").HasColumnOrder(3);

            builder.Property(config_image_url => config_image_url.ImageUrl).IsRequired(true).HasMaxLength(300).HasColumnName("image_url").HasColumnOrder(4);

            builder.Ignore(config_image_file => config_image_file.ImageFile);

            base.Configure(builder);
        }
    }
}
