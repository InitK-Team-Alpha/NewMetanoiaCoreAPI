using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MetanoiaCoreAPI.AdminUser
{
    [ApiController]
    [Route("adminuser")]
    public class AdminUserController : ControllerBase
    {

        private readonly AdminUserContext _context;
        public AdminUserController(AdminUserContext context)
        {
            Console.WriteLine("called");
            _context = context;
        }
        [HttpPost]
        public async Task<String> PostAdminUser([FromBody] AdminUserDTO adminUserDTO)
        {
            await _context.AdminUserDTOs.AddAsync(adminUserDTO);
            await _context.SaveChangesAsync();

            return "Ok";

        }


        [HttpGet]

        public List<AdminUserDTO> GetAdminUsersDTO()
        {
            Console.WriteLine("Accepted");
            return _context.AdminUserDTOs.ToList();
        }


        [HttpDelete("{id}")]

        public async Task<ActionResult<AdminUserDTO>> DeleteAdminUser(long id)
        {
            var adminUserDTO = await _context.AdminUserDTOs.FindAsync(id);
            if (adminUserDTO == null)
            {
                return NotFound();
            }
            _context.AdminUserDTOs.Remove(adminUserDTO);
            await _context.SaveChangesAsync();

            return adminUserDTO;
        }



        // [HttpPut("{id}")]
        // public async Task<IActionResult> PutAdminUser(long id, AdminUserDTO adminUserDTO)
        // {
        //     if (id != adminUserDTO.ID)
        //     {
        //         return BadRequest();
        //     }
        //     _context.Entry(adminUserDTO).State = EntityState.Modified;

        //     try
        //     {
        //         await _context.SaveChangesAsync();
        //     }
        //     catch (DbUpdateConcurrencyException)
        //     {
        //         if (!AdminUserDTOExists(id))
        //         {
        //             return NotFound();

        //         }
        //         else
        //         {
        //             throw;
        //         }
        //     }
        //     return NoContent();

        // }


    }
}