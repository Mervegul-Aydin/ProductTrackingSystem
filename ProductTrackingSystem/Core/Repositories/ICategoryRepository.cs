using ProductTrackingSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTrackingSystem.Core.Repositories
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
            Task<Category> GetApiCategoryIdProductsAsync(int categoryId);
            Task<Category> GetWebCategoryIdProductsAsync(int categoryId);
            Task<List<Category>> GetApiAllCategoriesAsync();
            Task<List<Category>> GetWebAllCategoriesAsync();
    }
}
