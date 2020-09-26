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
    [Route("cause")]
    public class CauseController : ControllerBase
    {

        private readonly AppDBContext _context;
        public CauseController(AppDBContext context)
        {

            _context = context;
        }
        [HttpPost]
        public async Task<ActionResult> PostAdminUser([FromBody] UserPsychologyCauses causes)
        {
            await _context.UserPsychologyCause.AddAsync(causes);
            await _context.SaveChangesAsync();
            return Ok();


        }

        [HttpGet]
        public List<UserPsychologyCauses> GetCauses()
        {
            return _context.UserPsychologyCause.ToList();
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteUserCauses([FromQuery] int id)
        {
            var admin = await _context.UserPsychologyCause .FindAsync(id);
            if (admin == null)
            {
                return NotFound();
            }
            Console.WriteLine("Ok");

           var admin1= _context.UserPsychologyCause .Remove(admin);
            await _context.SaveChangesAsync();

            return Ok(admin1);

        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserCauses(long id, UserPsychologyCauses cause)
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