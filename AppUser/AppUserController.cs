




using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MetanoiaCoreAPI.AppUser;
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
        public async Task <ActionResult> PostAppUserAsync([FromBody] AppUserDTO appUser)
        {
            await _context.AppUsersDTos.AddAsync(appUser);
            await _context.SaveChangesAsync();

           //return CreatedAtAction(nameof(GetAdminUserDTO), new { id = adminUserDTO.ID }, adminUserDTO);
          
            return Ok();
        }

         private object GetAppUserDTO()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public List<AppUserDTO> GetAppUser()
        {
            return _context.AppUsersDTos.ToList();
        }
    

        [HttpDelete("{id}")]

        public async Task<ActionResult<AppUserDTO>> DeleteAppUser(long id)
        {
            var appuser = await _context.AppUsersDTos.FindAsync(id);
            if (appuser == null)
            {
                return NotFound();
            }
            _context.AppUsersDTos.Remove(appuser);
            await _context.SaveChangesAsync();

            return appuser;
        }
        // Console.WriteLine("adminUserDTO");
        // return Accepted();


        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppUser(long id, AppUserDTO appUserDTO)
        {
            if (id != appUserDTO.ID)
            {
                return BadRequest();
            }
            _context.Entry(appUserDTO).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppUserDTOExists(id))
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

        private bool AppUserDTOExists(long id)
        {
            throw new NotImplementedException();
        }
    }
}




      
    
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using MetanoiaCoreAPI.AppUser;
// using MetanoiaCoreAPI.Infa;
// //using Microsoft.AspNetCore.Http;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
// //using Microsoft.Extensions.DependencyInjection;


// namespace MetanoiaCoreAPI.Controllers
// {
//     [Route("appuser")]
//     [ApiController]
//     public class AppUserController : ControllerBase
//     {
//         private readonly AppUserDBContext _context;

//         public AppUserController(AppUserDBContext context)
//         {
//             _context = context;
//         }

//         // GET: api/TodoItems
//         [HttpGet]
//         public async Task<ActionResult<IEnumerable<AppUserDTO>>> GetAppUserDTOs()
//         {
//             return await _context.AppUserDTOs.ToListAsync();
//         }

//         // GET: api/TodoItems/5
//         [HttpGet("{id}")]
//         public async Task<ActionResult<AppUserDTO>> GetAppUserDTOs(long id)
//         {
//             var appuser  = await _context.AppUserDTOs.FindAsync(id);

//             if (appuser == null)
//             {
//                 return NotFound();
//             }

//             return appuser;
//         }

//         // PUT: api/TodoItems/5
//         // To protect from overposting attacks, enable the specific properties you want to bind to, for
//         // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
//         [HttpPut("{id}")]
//         public async Task<IActionResult> PutAppUser(long id, AppUserDTO appuser)
//         {
//             if (id != appuser.ID)
//             {
//                 return BadRequest();
//             }

//             _context.Entry(appuser).State = EntityState.Modified;

//             try
//             {
//                 await _context.SaveChangesAsync();
//             }
//             catch (DbUpdateConcurrencyException)
//             {
//                 if (!AppUserExists(id))
//                 {
//                     return NotFound();
//                 }
//                 else
//                 {
//                     throw;
//                 }
//             }

//             return NoContent();
//         }

//         // POST: api/TodoItems
//         // To protect from overposting attacks, enable the specific properties you want to bind to, for
//         // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
//         [HttpPost]
//         public async Task<ActionResult<AppUserDTO>> PostAppUser(AppUserDTO appuser)
//         {
//             _context.AppUserDTOs.Add(appuser);
//             await _context.SaveChangesAsync();

//             return StatusCode(201);
//         }

//         // DELETE: api/TodoItems/5
//         [HttpDelete("{id}")]
//         public async Task<ActionResult<AppUserDTO>> DeleteAppUser(long id)
//         {
//             var appuser = await _context.AppUserDTOs.FindAsync(id);
//             if (appuser == null)
//             {
//                 return NotFound();
//             }

//             _context.AppUserDTOs.Remove(appuser);
//             await _context.SaveChangesAsync();

//             return appuser;
//         }

//        private bool AppUserExists(long id)
//         {
//            throw new NotImplementedException();
//         } 
//     }
// }