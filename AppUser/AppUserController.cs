
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
    [Route("appuser")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private readonly AppUserContext _context;

        public AppUserController(AppUserContext context)
        {
            _context = context;
        }

        // GET: api/TodoItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUserContext>>> GetAppUserDTOs()
        {
            return await _context.AppUserDTOs.ToListAsync();
        }

        // GET: api/TodoItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUserContext>> GetAppUser(long id)
        {
            var appuser  = await _context.AppUserDTOs.FindAsync(id);

            if (appuser == null)
            {
                return NotFound();
            }

            return appuser;
        }

        // PUT: api/TodoItems/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppUser(long id, AppUserContext appuser)
        {
            if (id != appuser.ID)
            {
                return BadRequest();
            }

            _context.Entry(appuser).State = EntityState.Modified;

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
        [HttpPost]
        public async Task<ActionResult<AppUserContext>> PostAppUser(AppUserContext appuser)
        {
            _context.AppUserDTOs.Add(appuser);
            await _context.SaveChangesAsync();

            return StatusCode(201);
        }

        // DELETE: api/TodoItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AppUserContext>> DeleteAppUser(long id)
        {
            var appuser = await _context.AppUserDTOs.FindAsync(id);
            if (appuser == null)
            {
                return NotFound();
            }

            _context.AppUserDTOs.Remove(appuser);
            await _context.SaveChangesAsync();

            return appuser;
        }

       private bool AppUserExists(long id)
        {
           throw new NotImplementedException();
        } 
    }
}