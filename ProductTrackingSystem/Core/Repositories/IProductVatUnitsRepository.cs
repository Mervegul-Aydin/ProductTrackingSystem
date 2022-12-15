using ProductTrackingSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTrackingSystem.Core.Repositories
{
    public interface IProductVatUnitsRepository : IGenericRepository<ProductVatUnits>
    {
        Task<List<ProductVatUnits>> GetApiAllProductVatUnitsAsync();
        Task<List<ProductVatUnits>> GetWebAllProductVatUnitsAsync();
       
    }

}
