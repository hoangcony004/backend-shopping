using System.Text.Json.Serialization;
using shopping_api.Model.product;

namespace shopping_api.Model.category
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime Created { get; set; } = DateTime.UtcNow;

        [JsonIgnore]
        public ICollection<Product> Products { get; set; } = new List<Product>();

    }
}
