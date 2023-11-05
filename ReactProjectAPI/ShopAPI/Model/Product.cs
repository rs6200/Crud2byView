using ShopAPI.Enums;

namespace ShopAPI.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ProductCategory Category { get; set; }
        public int CategoryId { get; set; }
        public double Price { get; set; }
        public int Rating { get; set; }
    }
}
