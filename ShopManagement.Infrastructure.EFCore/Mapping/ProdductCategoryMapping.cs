using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopManagement.Application.Contracts.ProductCategoryContract;

namespace ShopManagement.Infrastructure.EFCore.Mapping
{
    public class ProdductCategoryMapping : IEntityTypeConfiguration<EditProductCategory>
    {
        public void Configure(EntityTypeBuilder<EditProductCategory> builder)
        {
            builder.ToTable("ProductCategories");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name);
            builder.Property(x => x.Description);
            builder.Property(x => x.Picture);
            builder.Property(x => x.PictureTitle);
            builder.Property(x => x.PictureAlt);
            builder.Property(x => x.MetaDescription);
            builder.Property(x => x.Keywords);
            builder.Property(x => x.Slug);
            builder.Property(x => x.CreationDate);
        }
    }
}
