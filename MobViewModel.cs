namespace Ecommerce_Project.Models
{
    public class MobViewModel
    {
        public int Pid { get; set; }
        public string? Title { get; set; }
        public int? Price { get; set; }
        public int? Qty { get; set; }

        public string? Pic { get; set; }
        public int? Status { get; set; }
        public IFormFile? Photo {  get; set; }

        public ICollection<Review> Reviews { get; set; }
    }
}
