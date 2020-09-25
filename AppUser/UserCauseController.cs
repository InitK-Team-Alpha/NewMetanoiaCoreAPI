using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MetanoiaCoreAPI.Infa;
//using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.DependencyInjection;


namespace MetanoiaCoreAPI.Controllers
{
    [Route("userpsychologycauses")]
    [ApiController]
    public class UserPsychologyCausesController : ControllerBase
    {
        private readonly UserPsychologyCausesContext _context;

        public UserPsychologyCausesController(UserPsychologyCausesContext context)
        {
            _context = context;
        }

        // GET: api/TodoItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserPsychologyCausesContext>>> GetUserPsychologyCauses()
        {
            return await _context.UserPsychologyCauses.ToListAsync();
        }

        // GET: api/TodoItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserPsychologyCausesContext>> GetUserPsychologyCauses(long id)
        {
            var userCauses  = await _context.UserPsychologyCauses.FindAsync(id);

            if ( userCauses == null)
            {
                return NotFound();
            }

            return userCauses;
        }

        // PUT: api/TodoItems/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserPsychologyCauses(long id, UserPsychologyCausesContext userCauses)
        {
            if (id != userCauses.ID)
            {
                return BadRequest();
            }

            _context.Entry(userCauses).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserPsychologyCausesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TodoItems
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<UserPsychologyCausesContext>> PostUserPsychologyCauses(UserPsychologyCausesContext userCauses)
        {
            _context.UserPsychologyCauses.Add(userCauses);
            await _context.SaveChangesAsync();

            return StatusCode(201);
        }

        // DELETE: api/TodoItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<UserPsychologyCausesContext>> DeleteUserPsychologyCauses(long id)
        {
            var userCauses = await _context.UserPsychologyCauses.FindAsync(id);
            if (userCauses == null)
            {
                return NotFound();
            }

            _context.UserPsychologyCauses.Remove(userCauses);
            await _context.SaveChangesAsync();

            return userCauses;
        }

       private bool UserPsychologyCausesExists(long id)
        {
           throw new NotImplementedException();
        } 
    }
}
 