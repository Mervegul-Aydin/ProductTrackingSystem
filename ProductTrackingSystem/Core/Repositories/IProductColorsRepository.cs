using ProductTrackingSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTrackingSystem.Core.Repositories
{
    public interface IProductColorsRepository : IGenericRepository<ProductColors>
    {
        Task<List<ProductColors>> GetApiAllProductColorsAsync();
        Task<List<ProductColors>> GetWebAllProductColorsAsync();
    }
}
