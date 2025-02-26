using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShadowComputing.Catalog.DomainLayer.Entities;

namespace ShadowComputing.Catalog.DomainLayer.EntityTypeConfiguration
{
    public class ProductCommentEntityTypeConfiguration : ProductBaseEntityTypeConfiguration<ProductComment>
    {
        public override void Configure(EntityTypeBuilder<ProductComment> builder)
        {

            builder.ToTable(name: "product_comments");


            builder.Property(config_user_id => config_user_id.UserId).IsRequired().HasMaxLength(40).HasColumnName("user_id").HasColumnOrder(3);
            builder.Property(config_comment => config_comment.Comment).IsRequired().HasMaxLength(500).HasColumnName("comment").HasColumnOrder(4);

            base.Configure(builder);
        }
    }
}
