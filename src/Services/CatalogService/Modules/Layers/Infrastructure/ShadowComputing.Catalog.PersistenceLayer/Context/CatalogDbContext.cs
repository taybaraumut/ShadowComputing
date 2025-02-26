using Microsoft.EntityFrameworkCore;
using ShadowComputing.Catalog.DomainLayer.Entities;
using ShadowComputing.Catalog.DomainLayer.EntityTypeConfiguration;
using ShadowComputing.Catalog.PersistenceLayer.EntityTypeConfiguration;

namespace ShadowComputing.Catalog.PersistenceLayer.Context
{
    public class CatalogDbContext : DbContext
    {     
        public CatalogDbContext(DbContextOptions<CatalogDbContext> options):base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }    
        public DbSet<ProductAdvancedDescription> productAdvancedDescriptions { get; set; }    
        public DbSet<ProductBasicDescription> productBasicDescriptions { get; set; }    
        public DbSet<ProductBrand> productBrands { get; set; }    
        public DbSet<ProductComment> productComments { get; set; }    
        public DbSet<ProductDetail> productDetails { get; set; }    
        public DbSet<ProductImage> productImages { get; set; }    
        public DbSet<ProductSeo> productSeos { get; set; }    
        public DbSet<ProductSpecification> productSpecifications { get; set; }    
        public DbSet<ProductStandardDescription> productStandardDescriptions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("shadow-computing");

            modelBuilder.ApplyConfiguration(new ProductAdvancedDescriptionEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductBasicDescriptionEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductDetailEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductBrandEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductCommentEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductSeoEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductImageEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductSpecificationEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductStandardDescriptionEntityTypeConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
