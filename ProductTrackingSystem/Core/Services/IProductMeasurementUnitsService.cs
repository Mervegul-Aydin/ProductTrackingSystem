using ProductTrackingSystem.Core.DTOs;
using ProductTrackingSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTrackingSystem.Core.Services
{
    public interface IProductMeasurementUnitsService :IGenericService<ProductMeasurementUnits>
    {
        public Task<CustomResponseDto<List<ProductMeasurementUnitsDto>>> GetApiAllProductMeasurement();
        public Task<List<ProductMeasurementUnitsDto>> GetWebAllProductMeasurement ();
        public Task<List<ProductMeasurementUnitsDto>> GetWebAllMeasurementAsync();


    }
}
