using API.Models;

namespace API.Data
{
    public class ProductResponse
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public int Pages { get; set; }
        public int CurrentPage { get; set; }
        public int Total { get; set; }


    }
}