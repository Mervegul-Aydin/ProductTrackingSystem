using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTrackingSystem.Core.DTOs
{
    public abstract class BaseDto
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public int ProductId { get; set; }
        public int ColorId { get; set; }
        public int ProductWeightId { get; set; }
        public int ProductBrandId { get; set; }
        public int ProductProjectId { get; set; }
        public int ProductCurrencyId { get; set; }
        public int ProductMeasurementId { get; set; }
        public int ProductVatId { get; set; }
        public int IsActive { get; set; }

    }
}
