using ProductTrackingSystem.Core.DTOs;
using ProductTrackingSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTrackingSystem.Core.Services
{
    public interface IProductService : IGenericService<Products>
    {
        public Task<CustomResponseDto<List<ProductCategoryDto>>> GetApiAllProductsCategorys();
        public Task<List<ProductCategoryDto >> GetWebAllProductsCategorys();
        public Task<List<ProductCategoryDto>> GetWebAllProductsAsync ();


  

    }
}
