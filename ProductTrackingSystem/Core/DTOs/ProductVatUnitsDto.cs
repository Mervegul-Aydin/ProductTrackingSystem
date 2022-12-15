using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTrackingSystem.Core.DTOs
{
    public class ProductVatUnitsDto:BaseDto
    {
        public string Name { get; set; }        
        public string Code { get; set; }
        public string Explanation { get; set; }
    }
}
