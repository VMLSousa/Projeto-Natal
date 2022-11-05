using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoNatal.Server.dbcontext;

namespace ProjetoNatal.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly DataContext _context;

        public UserController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAllUsers()
        {
            return Ok(await _context.user.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _context.user.FindAsync(id);
            if (user == null)
            {
                return BadRequest("User not found");
            }
            return Ok(user);
        }

        [HttpPut]
        public async Task<ActionResult<User>> UpdatetUser(User user)
        {
            _context.user.Update(user);
            await _context.SaveChangesAsync();

            return Ok(await _context.user.ToListAsync());
        }
    }
}
