using System;
using System.Collections.Generic;

namespace Ecommerce_Project.Models
{
    public partial class ProductMaster
    {
        public ProductMaster()
        {
            BrandMasters = new HashSet<BrandMaster>();
        }

        public int ProductId { get; set; }
        public string? ProductCode { get; set; }
        public string? ProductName { get; set; }
        public string? InternalNotes { get; set; }
        public string? Status { get; set; }
        public int? DisplayFlag { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }

        public virtual ICollection<BrandMaster> BrandMasters { get; set; }
    }
}
