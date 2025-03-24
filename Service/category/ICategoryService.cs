using shopping_api.Model.category;

namespace shopping_api.Service.category
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllCategorys();
        Task<Category> GetCategoryById(int id);
        Task<Category> AddCategory(Category category);
        Task<Category> UpdateCategory(Category category);
        Task<bool> DeleteCategory(int id);
    }

}
