using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyJeweleryShop.Core.Models;

namespace MyJeweleryShop.Repository.Seeds
{
    internal class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category>builder)
        {
            builder.HasData(new Category { Id = 1, Name = "Alya Küpe" },
                            new Category { Id = 2, Name = "Neva Kolye" },
                            new Category { Id = 3, Name = "Mira Halhal" },
                            new Category { Id = 4, Name = "Sina Gümüş Yüzük" },
                            new Category { Id = 5, Name = "Afşin Piercing" },
                            new Category { Id = 6, Name = "Ahter Kolye" },
                            new Category { Id = 7, Name = "Berfu Bileklik" },
                            new Category { Id = 8, Name = "Pandora Bileklik" },
                            new Category { Id = 9, Name = "Delfin Halhal" },
                            new Category { Id = 10, Name = "Eva Küpe" },
                            new Category { Id = 11, Name = "İnci Yüzük" },
                            new Category { Id = 12, Name = "Kayra Broş" }
                            );
        }
    }
}
