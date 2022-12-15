using ProductTrackingSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTrackingSystem.Core.Repositories
{
    public interface IProductFeaturesRepository :IGenericRepository<ProductFeatures>
    {
        Task<List<ProductFeatures>> GetApiAllProductFeaturesAsync();
        Task<List<ProductFeatures>> GetWebAllProductFeaturesAsync();
    }
}
