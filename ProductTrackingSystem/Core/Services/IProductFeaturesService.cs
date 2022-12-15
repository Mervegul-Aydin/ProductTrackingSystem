using ProductTrackingSystem.Core.DTOs;
using ProductTrackingSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTrackingSystem.Core.Services
{
    public interface IProductFeaturesService:IGenericService<ProductFeatures>
    {
        public Task<CustomResponseDto<List<ProductFeaturesDto>>> GetApiAllProductFeatures();
        public Task<List<ProductFeaturesDto>> GetWebAllProductFeatures();

     }
}
