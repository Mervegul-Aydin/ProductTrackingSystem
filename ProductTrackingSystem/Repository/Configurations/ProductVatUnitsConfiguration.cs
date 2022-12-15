using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

using MyJeweleryShop.Core.Models;

namespace MyJeweleryShop.Repository.Configurations
{
    internal class ProductVatUnitsConfiguration : IEntityTypeConfiguration<ProductVatUnits>
    { 
        public void Configure(EntityTypeBuilder<ProductVatUnits>builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired(false).HasMaxLength(100);
            builder.Property(x => x.Explanation).IsRequired(false).HasMaxLength(1000);
            builder.Property(x => x.Code).IsRequired(false).HasMaxLength(1000);
        }
    }
}

