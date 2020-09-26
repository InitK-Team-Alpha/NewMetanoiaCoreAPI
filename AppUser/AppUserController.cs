
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
    [Route("appuser")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AppUserController(AppDbContext context)
        {
            _context = context;
        }

          [HttpPost]
        public async Task<ActionResult> PostAppUser ([FromBody] AppUserDTO appUser) 
        {
            await _context.AppUserDTOs.AddAsync(appUser);
            await _context.SaveChangesAsync();

            return Ok();
        }

        // GET: api/TodoItems
        [HttpGet]
        public List<AppUserDTO> GetAppUser()
        {
            return _context.AppUserDTOs.ToList();
        }

        // GET: api/TodoItems/5
        // [HttpGet("{id}")]
        // public async Task<ActionResult<AppDbContext>> GetAppUser(long id)
        // {
        //     var appuser  = await _context.AppUserDTOs.FindAsync(id);

        //     if (appuser == null)
        //     {
        //         return NotFound();
        //     }

        //     return Ok();
        // }

        // PUT: api/TodoItems/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppUser(long id, AppDbContext appUser)
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

        // POST: api/TodoItems
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
      

        // DELETE: api/TodoItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AppDbContext>> DeleteAppUser(long id)
        {
            var appUser = await _context.AppUserDTOs.FindAsync(id);
            if (appUser == null)
            {
                return NotFound();
            }

            _context.AppUserDTOs.Remove(appUser);
            await _context.SaveChangesAsync();

            return Ok();
        }

       private bool AppUserExists(long id)
        {
           throw new NotImplementedException();
        } 
    }
}