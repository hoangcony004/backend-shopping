using Microsoft.EntityFrameworkCore;
using shopping_api.Model.product;
using shopping_api.Repository.product;

namespace shopping_api.Service.product
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _productRepository.GetAllProducts();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _productRepository.GetProductById(id);
        }

        public async Task<Product> AddProduct(Product product)
        {
            return await _productRepository.AddProduct(product);
        }

        public async Task<Product> UpdateProduct(Product product)
        {
            return await _productRepository.UpdateProduct(product);
        }

        public async Task<bool> DeleteProduct(int id)
        {
            return await _productRepository.DeleteProduct(id);
        }

        public async Task<IEnumerable<Product>> GetProductsByCategory(string categoryName)
        {
            return await _productRepository.GetProductsByCategory(categoryName);
        }

    }

}
