using Microsoft.AspNetCore.Mvc;
using Users.Services.Model;
using Users.Services.Interface;

namespace Users.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;
        public UsersController(IUserService _userService)
        {
            userService = _userService;
        }
        [HttpGet]
        public IEnumerable<User> UserList()
        {
            var userList = userService.GetUserList();
            return userList;
        }
        [HttpGet("{id}")]
        public User GetUserById(int id)
        {
            return userService.GetUserById(id);
        }
        [HttpPost]
        public User AddUser(User user)
        {
            return userService.AddUser(user);
        }
        [HttpPut]
        public User UpdateUser(User user)
        {
            return userService.UpdateUser(user);
        }
        [HttpDelete("{id}")]
        public bool DeleteUser(int id)
        {
            return userService.DeleteUser(id);
        }
    }
}
