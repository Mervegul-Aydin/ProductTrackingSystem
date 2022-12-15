using MyJeweleryShop.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyJeweleryShop.Repository.Configurations
{
    internal class ProductBrandsConfiguration :IEntityTypeConfiguration<ProductBrands>
    {
        public void Configure(EntityTypeBuilder<ProductBrands>builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.ShortCode).IsRequired(false).HasMaxLength(100);
            builder.Property(x => x.BrandsName).IsRequired(false).HasMaxLength(100);
            builder.Property(x => x.BrandsWebUrl).IsRequired(false).HasMaxLength(250);
            builder.Property(x => x.Explanation).IsRequired(false).HasMaxLength(1000);
            builder.Property(x => x.LogoFileName).IsRequired(false).HasMaxLength(500);
            builder.Property(x => x.LogoFilePath).IsRequired(false).HasMaxLength(500);
            builder.Property(x => x.LogoFilePath).IsRequired(false).HasMaxLength(500);

        }

    }
}
