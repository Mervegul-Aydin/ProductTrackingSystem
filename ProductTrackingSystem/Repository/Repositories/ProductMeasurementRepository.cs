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
    public class ProductMeasurementRepository : GenericRepository<ProductMeasurementUnits>, IProductMeasurementUnitsRepository
    {

        public ProductMeasurementRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<List<ProductMeasurementUnits>> ProductMeasurement()
        {
            return await _context.ProductMeasurementUnits.ToListAsync();
        }



        public async Task<List<ProductMeasurementUnits>> GetWebAllProductMeasurementUnitsAsync()
        {
            return await _context.ProductMeasurementUnits.ToListAsync();
        }

        public async Task<List<ProductMeasurementUnits>> GetApiAllProductMeasurementUnitsAsync()
        {
            return await _context.ProductMeasurementUnits.ToListAsync();
        }


        public async Task<List<ProductMeasurementUnits>> GetAllProductMeasurementAsync()
        {
            return await _context.ProductMeasurementUnits.ToListAsync();
        }

        public async Task<List<ProductMeasurementUnits>> GetWebAllProductMeasurementAsync()
        {
            return await _context.ProductMeasurementUnits.ToListAsync();
        }

    }
}
