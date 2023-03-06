using System.ComponentModel.DataAnnotations;

namespace CoreApiWithJWT.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string? ImageUrl { get; set; }
        public string? Description { get; set; }
        public bool? Status { get; set; }
    }
}
