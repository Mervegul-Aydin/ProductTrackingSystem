using MyJeweleryShop.Repository.AppDbContexts.AppDbContext;
using MyJeweleryShop.Core.Models;
using MyJeweleryShop.Core;
using MyJeweleryShop.Core.Repositories;
using Microsoft.EntityFrameworkCore;


namespace MyJeweleryShop.Repository.Repositories
{
    public class ProductRepository : GenericRepository<Products>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<List<Products>> GetProductsCategorys()
        {
            return await _context.Products.Include(x => x.Category).ToListAsync();
        }


        public async Task<List<Products>> GetWebAllProductsCategorysAsync()
        {
            return await _context.Products.Include(x => x.Category).ToListAsync();
        }




        public async Task<List<Products>> GetApiAllProductsCategorysAsync()
        {
            return await _context.Products.Include(x => x.Category).ToListAsync();
        }



        public async Task<List<Products>> GetAllProductsCategorysAsync()
        {
            return await _context.Products.Include(x => x.Category).ToListAsync();
        }

        public async Task<List<Products>> GetWebAllProductsAsync()
        {
            return await _context.Products.Include(x => x.Category).ToListAsync();

        }


    }
}
