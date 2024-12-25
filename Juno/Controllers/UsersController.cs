using Microsoft.AspNetCore.Mvc;
using SharedModel;
using SharedModel.Models;

namespace Juno.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly SharedModelContext _context;

        public UsersController(SharedModelContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var users = _context.Users.ToList();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(Guid id)
        {
            var user = _context.Users.Find(id);
            if (user == null) return NotFound();
            return Ok(user);
        }

        [HttpPost]
        public IActionResult AddUser([FromBody] User user)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (string.IsNullOrEmpty(user.UserName) || string.IsNullOrEmpty(user.PasswordHash))
            {
                return BadRequest("UserName and PasswordHash are required.");
            }

            _context.Users.Add(user);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetUser), new { id = user.UserId }, user);
        }


        [HttpPut("{id}")]
        public IActionResult UpdateUser(Guid id, [FromBody] User updatedUser)
        {
            var user = _context.Users.Find(id);
            if (user == null) return NotFound();

            user.FirstName = updatedUser.FirstName;
            user.LastName = updatedUser.LastName;
            user.Email = updatedUser.Email;
            user.Status = updatedUser.Status;
            user.LastLogin = updatedUser.LastLogin;

            user.UserName = updatedUser.UserName;
            user.PasswordHash = updatedUser.PasswordHash;

            _context.SaveChanges();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteUser(Guid id)
        {
            var user = _context.Users.Find(id);
            if (user == null) return NotFound();

            _context.Users.Remove(user);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
