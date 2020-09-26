using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MetanoiaCoreAPI.AppUser;
using MetanoiaCoreAPI.Infa;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MetanoiaCoreAPI.UserPsychologyCauses
{
    [ApiController]
    [Route("causes")]
    public class UserPsychologyCausesController : ControllerBase
    {

        private readonly AppDBContext _context;
        public UserPsychologyCausesController(AppDBContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<ActionResult> PostUserPsychologyCauses([FromBody] UserPsychologyCauses causes)
        {
            await _context.PsychologyCausess.AddAsync(causes);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            return Ok();
        }



        [HttpGet]
        public List<UserPsychologyCauses> GetUserPsychologyCauses()
        {
            return _context.PsychologyCausess.ToList();
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<UserPsychologyCauses>> DeleteUserPsychologyCauses(long id)
        {
            var causes = await _context.PsychologyCausess.FindAsync(id);
            if (causes == null)
            {
                return NotFound();
            }
            _context.PsychologyCausess.Remove(causes);
            await _context.SaveChangesAsync();

            return causes;
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserPsychologyCauses(long id, UserPsychologyCauses causes)
        {
            if (id != causes.ID)
            {
                return BadRequest();
            }
            _context.Entry(causes).State = EntityState.Modified;

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

        private bool UserPsychologyCausesExists(long id)
        {
            throw new NotImplementedException();
        }

       
    }
}
