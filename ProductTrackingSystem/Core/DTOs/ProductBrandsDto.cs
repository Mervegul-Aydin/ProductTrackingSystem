using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTrackingSystem.Core.DTOs
{
    public class ProductBrandsDto:BaseDto
    {
        public string BrandsName { get; set; }
        public string ShortCode { get; set; }
        public string BrandsWebUrl { get; set; }
        public string Explanation { get; set; }
    
    }
}
