using System;
using System.Collections.Generic;

namespace Ecommerce_Project.Models
{
    public partial class OrderTbl
    {
        public int Oid { get; set; }
        public int? UserId { get; set; }
        public int? ProductId { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }
        public decimal TotalAmount { get; set; }
        public string? ProductName { get; set; }

        public virtual Product? Product { get; set; }
        public virtual UserTbl? User { get; set; }
    }
}
