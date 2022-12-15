using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTrackingSystem.Core.Models
{
    public class Products : BaseEntity
    {
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public string Barcode { get; set; }

        public DateTime ExpirationDate { get; set; }

        public string Explanation { get; set; }

        public string LogoBase64Content { get; set; }

        public string LogoFileName { get; set; }

        public string LogoFilePath { get; set; }

        public string TechnicalWebUrl { get; set; }

        public string ExplanationWebUrl { get; set; }

        public int? PurchasePrice { get; set; }

        public int? SalePrice { get; set; }

        public int Stock { get; set; }

        public int IsMixture { get; set; }

        public ICollection<ProductFeatures> ProductFeatures { get; set; }
  
        
    }
}
