
using Microsoft.AspNetCore.Mvc;

namespace Pratik1_JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly JwtDbContext _context;
        private readonly JwtHelper _jwtService;

        public AuthController(JwtDbContext context, JwtHelper jwtService)
        {
            _context = context;
            _jwtService = jwtService;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequestDto login)
        {
            var user = _context.Users.SingleOrDefault(x => x.Email == login.Email && x.Password == login.Password);

            if (user == null)
            {
                return Unauthorized("Invalid user information");
            }

            var token = _jwtService.GenerateToken(user);
            return Ok(new { token });
        }

        [HttpGet]
        [Authorize]
        public IActionResult GetEmail()
        {
            var email = User.FindFirst(ClaimTypes.Email)?.Value;
            return Ok($"JWT verified. User email: {email}");
        }
    }


}