using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using shopping_api.Model.order;
using shopping_api.Model.product;

namespace shopping_api.Model.order_detal
{
    public class Order_detall
    {
        [Key]
        public int Id { get; set; }

        // Khóa ngoại đến bảng Order
        [ForeignKey("Order")]
        public int Order_id { get; set; }
        public Order? Order { get; set; } // Navigation property

        // Khóa ngoại đến bảng Product
        [ForeignKey("Product")]
        public int Product_id { get; set; }
        public Product? Product { get; set; } // Navigation property

        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}

