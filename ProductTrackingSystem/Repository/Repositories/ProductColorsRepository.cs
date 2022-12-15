using MyJeweleryShop.Repository.AppDbContexts.AppDbContext;
using MyJeweleryShop.Core.Models;
using MyJeweleryShop.Core;
using MyJeweleryShop.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyJeweleryShop.Repository.Repositories
{
    public class ProductColorsRepository : GenericRepository<ProductColors>, IProductColorsRepository
    {
        public ProductColorsRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<List<ProductColors>> GetProductColors()
        {
            return await _context.ProductColors.ToListAsync();
        }


        public async Task<List<ProductColors>> GetWebAllProductColorsAsync()
        {
            return await _context.ProductColors.ToListAsync();
        }

        public async Task<List<ProductColors>> GetApiAllProductColorsAsync()
        {
            return await _context.ProductColors.ToListAsync();
        }



        public async Task<List<ProductColors>> GetAllProductColorsAsync()
        {
            return await _context.ProductColors.ToListAsync();
        }

        public async Task<List<ProductColors>> GetWebAllProductColorAsync()
        {
            return await _context.ProductColors.ToListAsync();
        }

    }
}
