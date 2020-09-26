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
    [Route("userpsychologycauses")]
    [ApiController]
    public class UserPsychologyCausesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UserPsychologyCausesController(AppDbContext context)
        {
            _context = context;
        }

         [HttpPost]
        public async Task<ActionResult> PostUserPsychologyCauses(UserPsychologyCauses usercause)
        {
            _context.UserPsychologyCauses.Add(usercause);
            await _context.SaveChangesAsync();

            return Ok();
        }

        // GET: api/TodoItems
        [HttpGet]
        public List<UserPsychologyCauses> GetUserPsychologyCauses()
        {
            return _context.UserPsychologyCauses.ToList();
        }

        // GET: api/TodoItems/5
        // [HttpGet("{id}")]
        // public async Task<ActionResult<AppDbContext>> GetUserPsychologyCauses(long id)
        // {
        //     var userCauses  = await _context.UserPsychologyCauses.FindAsync(id);

        //     if ( userCauses == null)
        //     {
        //         return NotFound();
        //     }

        //     return Ok();
        // }

        // PUT: api/TodoItems/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserPsychologyCauses(long id, AppDbContext userCauses)
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
       

        // DELETE: api/TodoItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AppDbContext>> DeleteUserPsychologyCauses(long id)
        {
            var userCauses = await _context.UserPsychologyCauses.FindAsync(id);
            if (userCauses == null)
            {
                return NotFound();
            }

            _context.UserPsychologyCauses.Remove(userCauses);
            await _context.SaveChangesAsync();

            return Ok();
        }

       private bool UserPsychologyCausesExists(long id)
        {
           throw new NotImplementedException();
        } 
    }
}
 