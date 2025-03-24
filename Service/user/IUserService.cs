using shopping_api.Model.user;

namespace shopping_api.Service.user
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetUserById(int id);
        Task<User> CreateUser(User user);
        Task<User> UpdateUser(int id, User user);
        Task<User> DeleteUser(int id);
    }
}
