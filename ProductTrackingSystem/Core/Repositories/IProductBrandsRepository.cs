using ProductTrackingSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTrackingSystem.Core.Repositories
{
    public interface IProductBrandsRepository :IGenericRepository<ProductBrands>
    {
        Task<List<ProductBrands>> GetApiAllProductBrandsAsync();
        Task<List<ProductBrands>> GetWebAllProductBrandsAsync();
    }
}
