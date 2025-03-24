using shopping_api.Data;
using shopping_api.Model.category;
using Microsoft.EntityFrameworkCore;

namespace shopping_api.Repository.category
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Category>> GetAllCategorys()
        {
            return await _context.Categorys.ToListAsync();
        }

        public async Task<Category> GetCategoryById(int id)
        {
            return await _context.Categorys.FindAsync(id);
        }

        public async Task<Category> AddCategory(Category category)
        {
            _context.Categorys.Add(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<Category> UpdateCategory(Category category)
        {
            _context.Categorys.Update(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<bool> DeleteCategory(int id)
        {
            var category = await _context.Categorys.FindAsync(id);
            if (category == null) return false;

            _context.Categorys.Remove(category);
            await _context.SaveChangesAsync();
            return true;
        }
    }

}
