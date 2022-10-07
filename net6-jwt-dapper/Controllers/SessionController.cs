using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using net6_jwt_dapper.Entities;
using net6_jwt_dapper.Services;

namespace net6_jwt_dapper.Controllers
{

    [Route("api/session")]
    [ApiController]
    public class SessionController:ControllerBase
    {
        private IUserService _userService;

        public SessionController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("authenticate")]
        [AllowAnonymous]
        public IActionResult Authenticate(AuthenticateRequest model)
        {
            var response = _userService.Authenticate(model);

            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(response);
        }

        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }
    }
}
