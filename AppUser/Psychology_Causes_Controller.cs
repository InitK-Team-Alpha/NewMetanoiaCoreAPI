using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MetanoiaCoreAPI.Infa;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MetanoiaCoreAPI.AppUser
{
    [ApiController]
    [Route("psychologycause")]
    public class PsychologyCausesController : ControllerBase
    {

        private readonly AppDBContext _context;

        public int ID { get; private set; }

        public PsychologyCausesController(AppDBContext context)
        {

            _context = context;
        }
        [HttpPost]
        public ActionResult PostPsychologyCause([FromBody] UserPsychologyCauses psychologyCauses)
        {

            Console.WriteLine(psychologyCauses);
            return Ok(psychologyCauses);
        }


        [HttpGet]

        public async Task<ActionResult<UserPsychologyCauses>> GetPsychologyCauses(long id)
        {

            return Ok(id);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<UserPsychologyCauses>> DeletePsychologyCauses(int id)
        {
            var psychologycauses = await _context.PsychologyCausess.FindAsync(id);
            if (psychologycauses == null)
            {
                return NotFound();
            }

            _context.PsychologyCausess.Remove(psychologycauses);
            await _context.SaveChangesAsync();

            return Ok(psychologycauses);
        }

        private bool PsychologyCausesExists(int id)
        {
            return _context.PsychologyCausess.Any(e => e.ID == id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPsychologyCauses(int id, UserPsychologyCauses psychologyCauses)
        {
            if (id != psychologyCauses.ID)
            {
                return BadRequest();
            }

            _context.Entry(psychologyCauses).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PsychologyCausesExists(id))
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

    }
}