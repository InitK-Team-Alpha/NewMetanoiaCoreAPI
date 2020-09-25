

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
    [Route("/userpsychologyeffects")]
    [ApiController]
    public class UserPsychologyEffectsController : ControllerBase
    {
        private readonly UserPsychologyEffectsContext _context;

        public UserPsychologyEffectsController(UserPsychologyEffectsContext context)
        {
            _context = context;
        }

        // GET: api/TodoItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserPsychologyEffectsContext>>> GetUserPsychologyEffects()
        {
            return await _context.UserPsychologyEffects.ToListAsync();
        }

        // GET: api/TodoItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserPsychologyEffectsContext>> GetUserPsychologyEffects(long id)
        {
            var userEffects  = await _context.UserPsychologyEffects.FindAsync(id);

            if ( userEffects == null)
            {
                return NotFound();
            }

            return userEffects;
        }

        // PUT: api/TodoItems/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserPsychologyEffects(long id, UserPsychologyEffectsContext userEffects)
        {
            if (id != userEffects.ID)
            {
                return BadRequest();
            }

            _context.Entry(userEffects).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserPsychologyEffectsExists(id))
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
        public async Task<ActionResult<UserPsychologyEffectsContext>> PostUserPsychologyEffects(UserPsychologyEffectsContext userEffects)
        {
            _context.UserPsychologyEffects.Add(userEffects);
            await _context.SaveChangesAsync();

            return StatusCode(201);
        }

        // DELETE: api/TodoItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<UserPsychologyEffectsContext>> DeleteUserPsychologyEffects(long id)
        {
            var userEffects = await _context.UserPsychologyEffects.FindAsync(id);
            if (userEffects == null)
            {
                return NotFound();
            }

            _context.UserPsychologyEffects.Remove(userEffects);
            await _context.SaveChangesAsync();

            return userEffects;
        }

       private bool UserPsychologyEffectsExists(long id)
        {
           throw new NotImplementedException();
        } 
    }
}
 