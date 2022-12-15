using ProductTrackingSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTrackingSystem.Core.Repositories
{
    public interface IProductMeasurementUnitsRepository : IGenericRepository<ProductMeasurementUnits>
    {
        Task<List<ProductMeasurementUnits>> GetApiAllProductMeasurementUnitsAsync();
        Task<List<ProductMeasurementUnits>> GetWebAllProductMeasurementUnitsAsync();
    }
}
