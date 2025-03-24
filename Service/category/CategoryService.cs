using shopping_api.Model.category;
using shopping_api.Repository.category;

namespace shopping_api.Service.category
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> GetAllCategorys()
        {
            return await _categoryRepository.GetAllCategorys();
        }

        public async Task<Category> GetCategoryById(int id)
        {
            return await _categoryRepository.GetCategoryById(id);
        }

        public async Task<Category> AddCategory(Category category)
        {
            return await _categoryRepository.AddCategory(category);
        }

        public async Task<Category> UpdateCategory(Category category)
        {
            return await _categoryRepository.UpdateCategory(category);
        }

        public async Task<bool> DeleteCategory(int id)
        {
            return await _categoryRepository.DeleteCategory(id);
        }
    }

}
