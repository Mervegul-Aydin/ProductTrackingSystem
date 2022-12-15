using ProductTrackingSystem.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductTrackingSystem.Core.Models;
using ProductTrackingSystem.Core.Services;

namespace ProductTrackingSystem.Core.Services
{
    public interface IProductColorsService:IGenericService<ProductColors>
    { 
        public Task<CustomResponseDto<List<ProductColorsDto>>> GetApiAllProductColors();
        public Task<List<ProductColorsDto>> GetWebAllProductColors();
        public Task<List<ProductColorsDto>> GetWebAllColorsAsync();
    }
}
