using shopping_api.Model.user;

namespace shopping_api.Repository.user
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUser();
        Task<User> FindById(int id);
        Task<User> AddUser (User user);
        Task<User> UpdateUser (User user);
        Task<User> DeleteUser (int id);
    }
}
