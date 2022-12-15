using ProductTrackingSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTrackingSystem.Core.Repositories
{
    public interface IProductRepository : IGenericRepository<Products>
    {
        Task<List<Products>> GetApiAllProductsCategorysAsync();
        Task<List<Products>> GetWebAllProductsCategorysAsync();
        Task<List<Products>> GetWebAllProductsAsync();
    }
    
    
}
   

