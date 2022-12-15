using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTrackingSystem.Core.DTOs
{
    public class ProductDto : BaseDto
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Barcode { get; set; }
        public string Explanation { get; set; }
        public decimal SalePrice { get; set; }
        public decimal PurchasePrice { get; set; }
        public string Stock { get; set; }
        public string TechnicalWebUrl { get; set; }
        public string ExplanationWebUrl { get; set; }
        public string ShortCode { get; set; }

    }
}
