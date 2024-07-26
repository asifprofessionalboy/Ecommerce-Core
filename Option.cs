using System;
using System.Collections.Generic;

namespace Ecommerce_Project.Models
{
    public partial class Option
    {
        public int Id { get; set; }
        public string? Logo { get; set; }
        public string? SiteName { get; set; }
        public string? SiteTitle { get; set; }
        public string? SiteDesc { get; set; }
        public string? Email { get; set; }
        public string? Mobile { get; set; }
        public string? FooterTitle { get; set; }
        public string? Address { get; set; }
    }
}
