using HexagonalArchitecture.Domain.Entities;
using HexagonalArchitecture.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace HexagonalArchitecture.Api.Controllers
{
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody]User user)
        {
            var id = await _userService.AddUser(user);
            return Ok(id);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var list = await _userService.GetAllUsers();
            return Ok(list);
        }
    }
}
