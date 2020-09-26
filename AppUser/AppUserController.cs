using System;
using System.Threading.Tasks;
using MetanoiaCoreAPI.Infa;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MetanoiaCoreAPI.AppUser;
using System.Collections.Generic;
using System.Linq;

namespace MetanoiaCoreAPI.AdminUser
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
        public async Task<IActionResult> PostAdminUser([FromBody] AppUserDTO appuser)
        {
            Console.WriteLine("Post Success");
            await _context.AppUsers.AddAsync(appuser);
            await _context.SaveChangesAsync();
            return Ok();

        }

       [HttpGet]
        public List<AppUserDTO> GetAdminUsers()
        {
            return _context.AppUsers.ToList();
        }
       


       [HttpDelete("{id}")]

        public async Task<ActionResult<AppUserDTO>> DeleteAppUser(long id)
        {


            var userdelete = await _context.AppUsers.FindAsync(id);
            if (userdelete == null)
            {
                return NotFound();
            }

            //_context.AdminUserDTOs.Remove(userdelete);
            await _context.SaveChangesAsync();

            return userdelete;

        }
        [HttpPut]
        public async Task<IActionResult> PutAppUser(long id, AppUserDTO appUserDTO)
        {
            Console.WriteLine("Put Method");
            return Ok(id);
        }
        private bool AdminUserDTOExists(long id)
        {
            throw new NotImplementedException();
        }
    }
}