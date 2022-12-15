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
    internal class ProductFeaturesConfiguration : IEntityTypeConfiguration<ProductFeatures>
    {
        public void Configure(EntityTypeBuilder<ProductFeatures> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.HasOne(p => p.Products).WithMany(pF => pF.ProductFeatures).HasForeignKey(pF => pF.ProductId).IsRequired(false);
            builder.HasOne(pC => pC.ProductColors).WithMany(pF => pF.ProductFeatures).HasForeignKey(pF => pF.ColorId).IsRequired(false);
            builder.HasOne(pB => pB.ProductBrands).WithMany(pF => pF.ProductFeatures).HasForeignKey(pF => pF.ProductBrandId).IsRequired(false);
            builder.HasOne(pM => pM.ProductMeasurementUnits).WithMany(pF => pF.ProductFeatures).HasForeignKey(pF => pF.ProductMeasurementId).IsRequired(false);
            builder.HasOne(pV => pV.ProductVatUnits).WithMany(pF => pF.ProductFeatures).HasForeignKey(pF => pF.ProductVatId).IsRequired(false);
           
        }
    }
    
}

