using System;
using System.Threading.Tasks;
using MetanoiaCoreAPI.Infa;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MetanoiaCoreAPI.AppUser;
using System.Linq;
using System.Collections.Generic;

namespace MetanoiaCoreAPI.AdminUser
{
    [ApiController]
    [Route("effect")]
    public class EffectController : ControllerBase
    {

        private readonly AppDBContext _context;
        public  EffectController(AppDBContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<ActionResult> PostEffects([FromBody] UserPsychologyEffects causes)
        {
            await _context.UserPsychologyEffect.AddAsync(causes);
            await _context.SaveChangesAsync();
            return Ok();


        }

        [HttpGet]
        public List<UserPsychologyEffects> GetEffects()
        {
            return _context.UserPsychologyEffect.ToList();
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteUserEffects([FromQuery] int id)
        {
            var admin = await _context.UserPsychologyEffect .FindAsync(id);
            if (admin == null)
            {
                return NotFound();
            }
            Console.WriteLine("Ok");

           var admin1= _context.UserPsychologyEffect .Remove(admin);
            await _context.SaveChangesAsync();

            return Ok(admin1);

        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserEffects(long id, UserPsychologyEffects cause)
        {
            if (id != cause.ID)
            {
                return BadRequest();
            }

            _context.Entry(cause).State = EntityState.Modified;

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
        private bool UserPsychologyEffectsExists(long id)
        {
            throw new NotImplementedException();
        }
    }
}