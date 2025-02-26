using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShadowComputing.Catalog.DomainLayer.Entities;

namespace ShadowComputing.Catalog.DomainLayer.EntityTypeConfiguration
{
    public class ProductEntityTypeConfiguration : BaseEntityTypeConfiguration<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable(name: "products");           

            builder.Property(config_name => config_name.Name).IsRequired(true).HasMaxLength(350).HasColumnName("name").HasColumnOrder(2);

            builder.Property(config_model => config_model.Model).IsRequired(true).HasMaxLength(250).HasColumnName("model").HasColumnOrder(3);

            builder.Property(config_model => config_model.Manufacturer).IsRequired(true).HasMaxLength(350).HasColumnName("manufacturer").HasColumnOrder(4);

            builder.Property(config_model => config_model.ImageUrl).IsRequired(true).HasMaxLength(300).HasColumnName("image_url").HasColumnOrder(5);            

            builder.Property(config_serial_number => config_serial_number.SerialNumber).IsRequired().HasMaxLength(15).HasColumnName("serial_number").HasColumnOrder(6);

            builder.Property(config_return_policy => config_return_policy.ReturnPolicy).IsRequired(true).HasMaxLength(350).HasColumnName("return_policy").HasColumnOrder(7);

            builder.Property(config_price => config_price.Price).IsRequired(true).HasColumnName("price").HasColumnOrder(8);

            builder.Property(config_stock_quantity => config_stock_quantity.StockQuantity).IsRequired(true).HasColumnName("stock_quantity").HasColumnOrder(9);

            builder.Property(config_warranty_period => config_warranty_period.WarrantyPeriod).IsRequired(true).HasColumnName("warranty_Period").HasColumnOrder(10);

            builder.Property(config_weight => config_weight.Weight).IsRequired(true).HasColumnName("weight").HasColumnOrder(11);

            builder.Property(config_estimated_delivery_time => config_estimated_delivery_time.EstimatedDeliveryTime).IsRequired(true).HasMaxLength(400).HasColumnName("estimated_delivery_time").HasColumnOrder(12);


            builder.Property(config_created_at => config_created_at.CreatedAt)
                .HasConversion(config_created_at => config_created_at, config_created_at_options => DateTime.SpecifyKind(config_created_at_options, DateTimeKind.Utc)).HasColumnName("created_at").HasColumnOrder(13);


            builder.Property(config_updated_at => config_updated_at.UpdatedAt)
                .HasConversion(config_updated_at => config_updated_at, config_updated_at_options => DateTime.SpecifyKind(config_updated_at_options, DateTimeKind.Utc)).HasColumnName("updated_at").HasColumnOrder(14);


            builder.Property(config_discontinued_at => config_discontinued_at.DiscontinuedAt)
                .HasConversion(config_discontinued_at => config_discontinued_at, config_discontinued_at_options => DateTime.SpecifyKind(config_discontinued_at_options, DateTimeKind.Utc)).HasColumnName("discontinued_at").HasColumnOrder(15);


            builder.Property(config_is_new_arrival => config_is_new_arrival.IsNewArrival).IsRequired(true).HasColumnName("is_new_arrival").HasColumnOrder(15);

            builder.Property(config_ıs_best_seller => config_ıs_best_seller.IsBestSeller).IsRequired(true).HasColumnName("is_best_seller").HasColumnOrder(16);

            builder.Property(config_ıs_featured => config_ıs_featured.IsFeatured).IsRequired(true).HasColumnName("is_featured").HasColumnOrder(17);

            builder.Property(config_ıs_active => config_ıs_active.IsActive).IsRequired(true).HasColumnName("is_active").HasColumnOrder(18);


            builder.Ignore(config_image_file => config_image_file.ImageFile);

            builder.HasMany(config_product_seos => config_product_seos.ProductSeos)
               .WithOne(config_product => config_product.Product)
               .HasForeignKey(config_product_id => config_product_id.ProductId)
               .OnDelete(DeleteBehavior.Cascade);

          
            builder.HasMany(config_product_details => config_product_details.ProductDetails)
                .WithOne(config_product => config_product.Product)
                .HasForeignKey(config_product_id => config_product_id.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(config_product_brands => config_product_brands.ProductBrands)
                .WithOne(config_product => config_product.Product)
                .HasForeignKey(config_product_id  => config_product_id.ProductId)
                .OnDelete(DeleteBehavior.Cascade); ;

            builder.HasMany(config_product_images => config_product_images.ProductImages)
                .WithOne(config_product => config_product.Product)
                .HasForeignKey(config_product_id => config_product_id.ProductId)
                .OnDelete(DeleteBehavior.Cascade); ;

            builder.HasMany(config_product_specifications => config_product_specifications.ProductSpecifications)
                .WithOne(config_product => config_product.Product)
                .HasForeignKey(config_product_id => config_product_id.ProductId)
                .OnDelete(DeleteBehavior.Cascade); ;

            builder.HasMany(config_comments => config_comments.ProductComments)
                .WithOne(config_product => config_product.Product)
                .HasForeignKey(config_product_id => config_product_id.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            base.Configure(builder);
        }
    }
}
