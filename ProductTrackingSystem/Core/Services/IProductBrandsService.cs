using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductTrackingSystem.Core.DTOs;
using ProductTrackingSystem.Core.Models;

namespace ProductTrackingSystem.Core.Services
{
    public interface IProductBrandsService :IGenericService<ProductBrands>
    {
        public Task<CustomResponseDto<List<ProductBrandsDto>>> GetApiAllProductBrands();
        public Task<List<ProductBrandsDto>> GetWebAllProductBrands();
        public Task<List<ProductBrandsDto>> GetWebAllBrandsAsync();

    }
}
