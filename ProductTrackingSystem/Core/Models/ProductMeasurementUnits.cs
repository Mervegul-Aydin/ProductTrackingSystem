using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTrackingSystem.Core.Models
{
    public class ProductMeasurementUnits : BaseEntity
    {
        public string Name { get; set; }
        public string ShortCode { get; set; }
        public string Explanation { get; set; }
        public ICollection<ProductFeatures> ProductFeatures { get; set; }
    }
}
