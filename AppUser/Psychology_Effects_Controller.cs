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
    [Route("psychologyeffect")]
    public class PsychologyEffectsController : ControllerBase
    {

        private readonly AppDBContext _context;

        public int ID { get; private set; }

        public PsychologyEffectsController(AppDBContext context)
        {
            _context = context;
        }
        [HttpPost]
        public ActionResult PostPsychologyEffect([FromBody] UserPsychologyEffects psychologyEffects)
        {

            Console.WriteLine(psychologyEffects);
            return Ok(psychologyEffects);
        }


        [HttpGet]

        public async Task<ActionResult<UserPsychologyEffects>> GetPsychologyEffect(long id)
        {

            return Ok(id);
        }
        [HttpDelete]
        public async Task<ActionResult<UserPsychologyEffects>> DeletePsychologyEffect(int id)
        {
            // var psychologyeffect = await _context.PsychologyEffectss.FindAsync(id);
            // if (psychologyeffect == null)
            // {
            //     return NotFound();
            // }

            // _context.PsychologyEffectss.Remove(psychologyeffect);
            // await _context.SaveChangesAsync();
            Console.WriteLine("Delete id");
            return Ok(id);
        }

        private bool PsychologyEffectExists(int id)
        {
            return _context.PsychologyEffectss.Any(e => e.ID == id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPsychologyEffect(int id, UserPsychologyEffects psychologyEffects)
        {
            if (id != psychologyEffects.ID)
            {
                return BadRequest();
            }

            _context.Entry(psychologyEffects).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PsychologyEffectExists(id))
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