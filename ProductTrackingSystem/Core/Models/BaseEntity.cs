using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTrackingSystem.Core.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? CreateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public int? IsActive { get; set; }

        public DateTime? IsActiveDate { get; set; }

        public int? IsActiveDateUserId { get; set; }

        public DateTime? ActiveDateUpdate { get; set; }

        public int? IsActiveDateUpdateUserId { get; set; }

        public int? IsDelete { get; set; }

        public DateTime? IsDeleteDate { get; set; }

        public int? IsDeleteDateUserId { get; set; }

        public DateTime? IsDeleteDateUpdate { get; set; }

        public int? IsDeleteDateUpdateUserId { get; set; }
    }
}
