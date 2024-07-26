using System;
using System.Collections.Generic;

namespace Ecommerce_Project.Models
{
    public partial class BrandMaster
    {
        public int BrandId { get; set; }
        public string? BrandName { get; set; }
        public int? ProductId { get; set; }
        public string? InternalNotes { get; set; }
        public int? DisplayFlag { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }

        public virtual ProductMaster? Product { get; set; }
    }
}
