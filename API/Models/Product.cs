using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
   
        public required string Title { get; set; }
        public required string Image { get; set; }
        public required int Price { get; set; }
        public required string Category { get; set; }
        public required string Brand { get; set; }
    }
}