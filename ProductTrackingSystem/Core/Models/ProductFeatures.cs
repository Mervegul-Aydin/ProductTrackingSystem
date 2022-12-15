using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTrackingSystem.Core.Models
{
    public class ProductFeatures : BaseEntity
    {
        public int ProductId { get; set; }
        public Products Products { get; set; }

        public int ColorId { get; set; }
        public ProductColors ProductColors { get; set; }

       
        public int ProductBrandId { get; set; }
        public ProductBrands ProductBrands { get; set; }

      
        public int ProductMeasurementId { get; set; }
        public ProductMeasurementUnits ProductMeasurementUnits { get; set; }

        public int ProductVatId { get; set; }
        public ProductVatUnits ProductVatUnits { get; set; }

    


    }
}
