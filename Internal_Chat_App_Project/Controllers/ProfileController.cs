using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Internal_Chat_App_Project.Data;
using Internal_Chat_App_Project.Models;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Internal_Chat_App_Project.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ProfileController
    {
        private readonly ChatAppDbContext _context;

        public ProfileController(ChatAppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetProfile() 
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.Users.Find(Guid.Parse(userId));

            if (user == null) 
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpPut]
        public IActionResult UpdateProfile([FromBody] User updateUser)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.Users.Find(Guid.Parse(userId));

            if (user == null)
            {
                return NotFound();
            }

            user.FirstName = updateUser.FirstName;
            user.LastName = updateUser.LastName;
            user.Email = updateUser.Email;
            user.Phone = updateUser.Phone;

            _context.SaveChanges();

            return NoContent();
        }

    }
    }
