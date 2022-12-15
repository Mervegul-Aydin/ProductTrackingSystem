using MyJeweleryShop.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace MyJeweleryShop.Repository.Configurations
{
    internal class ProductsConfiguration : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired(false).HasMaxLength(100);
            builder.HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(x=>x.CategoryId);
            builder.Property(x => x.Code).IsRequired(false).HasMaxLength(250);
            builder.Property(x => x.Barcode).IsRequired(false).HasMaxLength(100);
            builder.Property(x => x.Explanation).IsRequired(false).HasMaxLength(1000);
            builder.Property(x => x.LogoFileName).IsRequired(false).HasMaxLength(500);
            builder.Property(x => x.LogoFilePath).IsRequired(false).HasMaxLength(500);
            builder.Property(x => x.TechnicalWebUrl).IsRequired(false).HasMaxLength(500);
            builder.Property(x => x.ExplanationWebUrl).IsRequired(false).HasMaxLength(500);
            builder.Property(x => x.PurchasePrice).IsRequired(false);
            builder.Property(x => x.SalePrice).IsRequired(false);
        }
    }
}
