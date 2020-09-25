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
    [Route("appuser")]
    public class AppUserController : ControllerBase
    {

        private readonly AppDBContext _context;
        public AppUserController(AppDBContext context)
        {

            _context = context;
        }
        [HttpPost]
        public ActionResult PostAppUser([FromBody] AppUserDTO appUserDTO)
        {

            Console.WriteLine(appUserDTO);
            return Ok(appUserDTO);
        }


        [HttpGet]

        public async Task<ActionResult<AppUserDTO>> GetAppUserDTO(long id)
        {

            return Ok(id);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<AppUserDTO>> DeleteAdminUser(int id)
        {
            var appuser = await _context.AppUsersDTos.FindAsync(id);
            if (appuser == null)
            {
                return NotFound();
            }

            _context.AppUsersDTos.Remove(appuser);
            await _context.SaveChangesAsync();

            return Ok(appuser);
        }

        private bool AppUserExists(int id)
        {
            return _context.AppUsersDTos.Any(e => e.ID == id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppUser(int id, AppUserDTO appUser)
        {
            if (id != appUser.ID)
            {
                return BadRequest();
            }

            _context.Entry(appUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppUserExists(id))
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