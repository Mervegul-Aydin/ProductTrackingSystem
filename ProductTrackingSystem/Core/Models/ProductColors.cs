using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTrackingSystem.Core.Models
{
    public class ProductColors : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string ColorBase64Content { get; set; }
        public string ColorFileName { get; set; }
        public string ColorFilePath { get; set; }
        public string Explanation { get; set; }
        public ICollection<ProductFeatures> ProductFeatures { get; set; }
    }
}
