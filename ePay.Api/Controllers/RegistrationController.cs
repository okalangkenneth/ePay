using ePay.Api.Data;
using ePay.Api.Models;
using ePay.Api.ViewsModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ePay.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public RegistrationController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            if (ModelState.IsValid)
            {
                // Check if the user already exists
                var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.PhoneNumber == request.PhoneNumber);

                if (existingUser != null)
                {
                    return BadRequest("A user with this phone number already exists.");
                }

                // Hash the user's password
                var user = new User
                {
                    Name = request.Name,
                    NationalId = request.NationalId,
                    PhoneNumber = request.PhoneNumber
                };
                var passwordHasher = new PasswordHasher<User>();
                user.PasswordHash = passwordHasher.HashPassword(user, request.Password);

                // Save the new user to the database
                _context.Users.Add(user);
                await _context.SaveChangesAsync();

                return Ok("Registration successful");
            }

            return BadRequest("Invalid user data");
        }
    }
}
