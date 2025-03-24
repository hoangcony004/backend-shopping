using System.Text.Json.Serialization;
using shopping_api.Model.order_detal;
using shopping_api.Model.user;

namespace shopping_api.Model.order
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Status
    {
        [JsonPropertyName("pending")]
        Pending,

        [JsonPropertyName("completed")]
        Completed,

        [JsonPropertyName("cancelled")]
        Cancelled
    }

    public class Order
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Address { get; set; } = null!;
        public decimal TotalPrice { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Status Status { get; set; }
        public DateTime CreatedAt { get; set; }

        public required ICollection<Order_detall> OrderDetails { get; set; }
    }
}
