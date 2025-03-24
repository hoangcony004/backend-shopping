using shopping_api.Model.user;
using shopping_api.Repository.user;

namespace shopping_api.Service.user
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await _userRepository.GetAllUser();
        }

        public async Task<User> GetUserById(int id)
        {
            return await _userRepository.FindById(id);
        }

        public async Task<User> CreateUser(User user)
        {
            return await _userRepository.AddUser(user);
        }

        public async Task<User> UpdateUser(int id, User user)
        {
            if (id != user.Id) return null;
            return await _userRepository.UpdateUser(user);
        }

        public async Task<User> DeleteUser(int id)
        {
            return await _userRepository.DeleteUser(id);
        }
    }
}
