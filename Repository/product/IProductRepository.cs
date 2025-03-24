using shopping_api.Model.product;

namespace shopping_api.Repository.product
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProductById(int id);
        Task<Product> AddProduct(Product product);
        Task<Product> UpdateProduct(Product product);
        Task<bool> DeleteProduct(int id);
        Task<IEnumerable<Product>> GetProductsByCategory(string categoryName);
    }

}
