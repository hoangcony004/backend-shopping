using shopping_api.Model.category;

namespace shopping_api.Repository.category
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllCategorys();
        Task<Category> GetCategoryById(int id);
        Task<Category> AddCategory(Category category);
        Task<Category> UpdateCategory(Category category);
        Task<bool> DeleteCategory(int id);
    }

}
