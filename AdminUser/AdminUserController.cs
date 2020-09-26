using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MetanoiaCoreAPI.Infa;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MetanoiaCoreAPI.AdminUser
{
    [ApiController]
    [Route("adminuser")]
    public class AdminUserController : ControllerBase
    {

        private readonly AppDbContext _context;
        public AdminUserController(AppDbContext context)
        {
            
            _context = context;
        }
        
        [HttpPost]
        public async Task<ActionResult> PostAdminUser([FromBody] AdminUserDTO adminUser)
        {

            await _context.AdminUserDTOs.AddAsync(adminUser);
            await _context.SaveChangesAsync();
            return Ok();
        }


        [HttpGet]

       public List<AdminUserDTO> GetAppUser()
       {
           return _context.AdminUserDTOs.ToList();
       }

        [HttpDelete("{id}")]

        public async Task<ActionResult<AppDbContext>> DeleteAdminUser(long id)
        {
            var adminUserDTO = await _context.AdminUserDTOs.FindAsync(id);
            if (adminUserDTO == null)
            {
                return NotFound();
            }
            _context.AdminUserDTOs.Remove(adminUserDTO);
            await _context.SaveChangesAsync();

            return Ok();
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdminUser(long id, AdminUserDTO adminUserDTO)
        {
            if (id != adminUserDTO.ID)
            {
                return BadRequest();
            }
            _context.Entry(adminUserDTO).State = EntityState.Modified;

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