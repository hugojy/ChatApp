using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Internal_Chat_App_Project.Data;
using Internal_Chat_App_Project.Models;

namespace Internal_Chat_App_Project.Controllers
{
    public class AdminController : ControllerBase
    {
        private readonly ChatAppDbContext _context;
        public AdminController(ChatAppDbContext context)
        {
            _context = context;
        }

        [HttpGet("users")]
        public IActionResult GetAllUsers()
        {
            var users = _context.Users.ToList();
            return Ok(users);
        }

        [HttpPut("user/{id}")]
        public IActionResult UpdateUser(Guid id, [FromBody] User updateUser)
        {
            var user = _context.Users.Find(id);
            if (user == null)
            {
                return NotFound();

            }
            user.FirstName = updateUser.FirstName;
            user.LastName = updateUser.LastName;
            user.Email = updateUser.Email;
            user.Phone = updateUser.Phone;
            user.Role = updateUser.Role;

            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("user/{id}")]
        public IActionResult DeleteUser(Guid id) 
        {
            var user = _context.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
