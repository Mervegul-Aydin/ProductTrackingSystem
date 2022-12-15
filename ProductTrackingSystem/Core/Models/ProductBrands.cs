using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTrackingSystem.Core.Models
{
    public class ProductBrands : BaseEntity
    {
        public string BrandsName { get; set; }
        public string BrandsWebUrl { get; set; }
        public string ShortCode { get; set; }
        public string Explanation { get; set; }
        public string LogoBase64Content { get; set; }
        public string LogoFileName { get; set; }
        public string LogoFilePath { get; set; }
        public ICollection<ProductFeatures> ProductFeatures { get; set; }
    }
}
