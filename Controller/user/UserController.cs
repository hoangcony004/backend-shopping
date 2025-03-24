using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using shopping_api.Model.user;
using shopping_api.Service.user;

namespace shopping_api.Controller.user
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userService.GetAllUsers();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = await _userService.GetUserById(id);
            if (user == null) return NotFound();
            return Ok(user);
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] User user)
        {
            Console.WriteLine(JsonSerializer.Serialize(user)); // In ra request body

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var createdUser = await _userService.CreateUser(user);
            return CreatedAtAction(nameof(GetUserById), new { id = createdUser.Id }, createdUser);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, [FromBody] User user)
        {
            var updatedUser = await _userService.UpdateUser(id, user);
            if (updatedUser == null) return BadRequest("Invalid user ID");
            return Ok(updatedUser);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var deletedUser = await _userService.DeleteUser(id);
            if (deletedUser == null) return NotFound();
            return Ok(deletedUser);
        }
    }
}
