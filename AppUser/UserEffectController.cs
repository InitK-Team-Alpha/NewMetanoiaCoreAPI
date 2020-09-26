

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MetanoiaCoreAPI.AppUser;
using MetanoiaCoreAPI.Infa;
//using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.DependencyInjection;


namespace MetanoiaCoreAPI.Controllers
{
    [Route("userpsychologyeffects")]
    [ApiController]
    public class UserPsychologyEffectsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UserPsychologyEffectsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult> PostUserPsychologyEffects(UserPsychologyEffects userEffect)
        {
            _context.UserPsychologyEffects.Add(userEffect);
            await _context.SaveChangesAsync();

            return StatusCode(201);
        }

        // GET: api/TodoItems
        [HttpGet]
        public List<UserPsychologyEffects> GetUserPsychologyEffects()
        {
            return _context.UserPsychologyEffects.ToList();
        }

        // GET: api/TodoItems/5
        // [HttpGet("{id}")]
        // public async Task<ActionResult<AppDbContext>> GetUserPsychologyEffects(long id)
        // {
        //     var userEffects  = await _context.UserPsychologyEffects.FindAsync(id);

        //     if ( userEffects == null)
        //     {
        //         return NotFound();
        //     }

        //     return Ok();
        // }

        // PUT: api/TodoItems/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserPsychologyEffects(long id, AppDbContext AppDbContext)
        {
            if (id != AppDbContext.ID)
            {
                return BadRequest();
            }

            _context.Entry(AppDbContext).State = EntityState.Modified;

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
        

        // DELETE: api/TodoItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AppDbContext>> DeleteUserPsychologyEffects(long id)
        {
            var userEffects = await _context.UserPsychologyEffects.FindAsync(id);
            if (userEffects == null)
            {
                return NotFound();
            }

            _context.UserPsychologyEffects.Remove(userEffects);
            await _context.SaveChangesAsync();

            return Ok();
        }

       private bool UserPsychologyEffectsExists(long id)
        {
           throw new NotImplementedException();
        } 
    }
}
 