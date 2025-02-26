using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ShadowComputing.Catalog.PersistenceLayer.Context
{
    public class CatalogDbContextDesignFactory : IDesignTimeDbContextFactory<CatalogDbContext>
    {
        public CatalogDbContext CreateDbContext(string[] args)
        {
            var connection_string = "Server=DESKTOP-HHE13EC\\SQLEXPRESS;initial Catalog=shadow-computing_catalog_db;integrated Security=true;TrustServerCertificate=True;";

            var options_builder = new DbContextOptionsBuilder<CatalogDbContext>().UseSqlServer(connection_string, builder =>
            {
                builder.EnableRetryOnFailure(maxRetryCount: 5);
                builder.CommandTimeout(60);

            }).UseLazyLoadingProxies();
             

            return new CatalogDbContext(options_builder.Options);
        }
    }
}
