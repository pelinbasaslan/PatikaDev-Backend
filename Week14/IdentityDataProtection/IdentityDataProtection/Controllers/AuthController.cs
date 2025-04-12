using IdentityDataProtection.Context;
using IdentityDataProtection.Entities;
using IdentityDataProtection.Models;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;

namespace IdentityDataProtection.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IdentityDbContext _context;
        private readonly IDataProtector _dataProtector;

        public AuthController(IDataProtectionProvider dataProtectionProvider, IdentityDbContext context)
        {
            _dataProtector = dataProtectionProvider.CreateProtector("UserDataProtection");
            _context = context;
        }

        [HttpPost]
        public IActionResult Register([FromBody] UserRegister data)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = _context.Users.FirstOrDefault(x => x.Email == data.Email);
            if (user != null)
            {
                return BadRequest("Kullanıcı zaten mevcut");
            }


            var newUser = new UserEntity
            {
                Email = data.Email,
                Password = _dataProtector.Protect(data.Password)
            };


            _context.Users.Add(newUser);
            _context.SaveChanges();

            return Ok("Kullanıcı başarıyla kaydedildi.");
        }

        [HttpGet("login")]
        public IActionResult Login([FromQuery] UserLogin data)
        {
            var user = _context.Users.FirstOrDefault(x => x.Email == data.Email);
            if (user == null)
            {
                return BadRequest("Kullanıcı bulunamadı.");
            }

            var decryptedPassword = _dataProtector.Unprotect(user.Password); // Şifreyi çöz
            if (decryptedPassword != data.Password)
            {
                return BadRequest("Şifre yanlış.");
            }

            return Ok("Giriş başarılı.");
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var users = _context.Users.ToList();
            return Ok(users);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id == id);
            if (user == null)
            {
                return NotFound("Kullanıcı bulunamadı.");
            }

            return Ok(user);
        }
    }
}
