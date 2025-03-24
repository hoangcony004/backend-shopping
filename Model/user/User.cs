using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace shopping_api.Model.user
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Role
    {
        [JsonPropertyName("admin")]
        Admin,

        [JsonPropertyName("customer")]
        Customer
    }

    public class User
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))] // Lưu dưới dạng chuỗi
        public Role UserRole { get; set; }

        public DateTime Created { get; set; } = DateTime.UtcNow;
    }
}
