using System;
using System.Collections.Generic;

namespace Ecommerce_Project.Models
{
    public partial class LatestProduct
    {
        public int Pid { get; set; }
        public string? Title { get; set; }
        public int? Price { get; set; }
        public int? Qty { get; set; }
        public string? Pic { get; set; }
        public int? Status { get; set; }
    }
}
