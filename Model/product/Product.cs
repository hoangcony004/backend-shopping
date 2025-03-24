using shopping_api.Model.category;
using shopping_api.Model.order_detal;

namespace shopping_api.Model.product
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Image_Link { get; set; }
        public string Description { get; set; }

        // Khóa ngoại liên kết đến Category
        public int Category_Id { get; set; }
        public Category? Category { get; set; }
        public required ICollection<Order_detall> OrderDetails { get; set; }
    }
}
