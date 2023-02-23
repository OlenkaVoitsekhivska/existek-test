using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly Context _context;
        public UserController(Context context)
        {
            _context = context;
        }

        [HttpPost("signup")]
        [Produces("application/json")]
        public async Task<ActionResult<string>> RegisterUser(User request)
        {
            try
            {
                var _user = new User
                {
                    Name = request.Name,
                    Email = request.Email,
                    Password = request.Password
                };

                var newUser = await _context.Users.AddAsync(_user);
                await _context.SaveChangesAsync();
                return Ok("user successfully registered");
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        [HttpPost("login")]
        [Produces("application/json")]
        public ActionResult Login([FromBody] LoginReq request)
        {
            try
            {
                var logginUser = _context.Users.First(user => user.Email == request.Email && user.Password == request.Password);
                string passwordHash = BCrypt.Net.BCrypt.HashPassword(request.Password);
                var _user = new LoginResp
                {
                    Token = passwordHash
                };
                return Ok(_user);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}