using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductTrackingSystem.Core.DTOs;
using ProductTrackingSystem.Core.Models;

namespace ProductTrackingSystem.Core.Services
{
    public interface IProductVatUnitsService :IGenericService<ProductVatUnits>
    {
        public Task<CustomResponseDto<List<ProductVatUnitsDto>>> GetApiAllProductVatUnits ();
        public Task<List<ProductVatUnitsDto>> GetWebAllProductVatUnits();
        public Task<List<ProductVatUnitsDto>> GetWebAllVatAsync();

    }
}
