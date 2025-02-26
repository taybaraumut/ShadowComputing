using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShadowComputing.Catalog.DomainLayer.Entities;

namespace ShadowComputing.Catalog.PersistenceLayer.EntityTypeConfiguration
{
    public class ProductBasicDescriptionEntityTypeConfiguration : ProductDescriptionBaseEntityTypeConfiguration<ProductBasicDescription>
    {
        public override void Configure(EntityTypeBuilder<ProductBasicDescription> builder)
        {            

            builder.ToTable(name: "product_basic_descriptions");

            base.Configure(builder);
        }
    }
}
