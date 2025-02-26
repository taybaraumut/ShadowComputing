
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShadowComputing.Catalog.DomainLayer.Entities;

namespace ShadowComputing.Catalog.DomainLayer.EntityTypeConfiguration
{
    public class ProductSpecificationEntityTypeConfiguration : ProductBaseEntityTypeConfiguration<ProductSpecification>
    {
        public override void Configure(EntityTypeBuilder<ProductSpecification> builder)
        {
            builder.ToTable(name: "product_specifications");

            builder.Property(config_processor => config_processor.Processor).IsRequired(true).HasMaxLength(250).HasColumnName("processor").HasColumnOrder(3);
            builder.Property(config_graphics_card => config_graphics_card.GraphicsCard).IsRequired(true).HasMaxLength(250).HasColumnName("graphics_card").HasColumnOrder(4);
            builder.Property(config_ram => config_ram.Ram).IsRequired(true).HasMaxLength(50).HasColumnName("ram").HasColumnOrder(5);
            builder.Property(config_storage => config_storage.Storage).IsRequired(true).HasMaxLength(50).HasColumnName("storage").HasColumnOrder(6);      
            builder.Property(config_display => config_display.Display).IsRequired(true).HasMaxLength(80).HasColumnName("display").HasColumnOrder(7);
            builder.Property(config_operating_system => config_operating_system.OperatingSystem).IsRequired(true).HasMaxLength(20).HasColumnName("operating_system").HasColumnOrder(8);
            builder.Property(config_battery_life => config_battery_life.BatteryLife).IsRequired(true).HasMaxLength(20).HasColumnName("battery_life").HasColumnOrder(9);
            builder.Property(config_weight => config_weight.Weight).IsRequired(true).HasMaxLength(10).HasColumnName("weight").HasColumnOrder(10);


            base.Configure(builder);
        }
    }
}
