
using Microsoft.EntityFrameworkCore;
using shopping_api.Data;
using shopping_api.Model.user;


namespace shopping_api.Repository.user
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<User> AddUser(User user)
        {
            // Mã hóa mật khẩu trước khi lưu
            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);

            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<User> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null) return null;

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<User> FindById(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<IEnumerable<User>> GetAllUser()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> UpdateUser(User user)
        {
            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);

            _context.Users.Update(user);
            await _context.SaveChangesAsync();
            return user;
        }
    }
}
