using System;
using System.Collections.Generic;

namespace Ecommerce_Project.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderTbls = new HashSet<OrderTbl>();
        }

        public int Pid { get; set; }
        public string? Title { get; set; }
        public int? Price { get; set; }
        public int? Qty { get; set; }
        public string? Pic { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<OrderTbl> OrderTbls { get; set; }
    }
}
