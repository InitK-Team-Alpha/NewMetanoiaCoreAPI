using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MetanoiaCoreAPI.Infa;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MetanoiaCoreAPI.AdminUser;
using System.Linq;

namespace MetanoiaCoreAPI.AdminUser
{
    [ApiController]
    [Route("adminuser")]
    public class AdminUserController : ControllerBase
    {

        private readonly AppDBContext _context;
        public AdminUserController(AppDBContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<ActionResult> PostAdminUser([FromBody] AdminUserDTO adminuser)
        {
            await _context.AdminUserDTOs.AddAsync(adminuser);
            await _context.SaveChangesAsync();
            return Ok();

        }

        // [HttpGet]
        // public async Task<ActionResult<AdminUserDTO>> GetAdminUsersDTO(long id)
        // {
        //     var admin = await _context.AdminUserDTOs.FindAsync(id);

        //     if (admin == null)
        //     {
        //         return NotFound();
        //     }

        //     return admin;
        // }
        [HttpGet]
        public List<AdminUserDTO> GetAdminUsers()
        {
            return _context.AdminUserDTOs.ToList();
        }
        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteAdminUser([FromQuery] int id)
        {
            var admin = await _context.AdminUserDTOs.FindAsync(id);
            if (admin == null)
            {
                return NotFound();
            }
            Console.WriteLine("Ok");

           var admin1= _context.AdminUserDTOs.Remove(admin);
            await _context.SaveChangesAsync();

            return Ok(admin1);

        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdminUser(long id, AdminUserDTO adminuser)
        {
            if (id != adminuser.ID)
            {
                return BadRequest();
            }

            _context.Entry(adminuser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdminUserDTOExists(id))
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
        private bool AdminUserDTOExists(long id)
        {
            throw new NotImplementedException();
        }
    }
}