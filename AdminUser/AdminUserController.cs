using System;
using System.Collections.Generic;
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

        private readonly AdminUserContext _context;
        public AdminUserController(AdminUserContext context)
        {
            // Console.WriteLine("called");
            _context = context;
        }
        [HttpPost]
        public ActionResult PostAdminUser([FromBody] AdminUserDTO adminUserDTO)
        {

            Console.WriteLine(adminUserDTO);
            return Ok(adminUserDTO);
        }


        [HttpGet]
        //public ActionResult GetAdminUser ([FromBody] AdminUserDTO adminUserDTO)

        public async Task<ActionResult<AdminUserDTO>> GetAdminUsersDTO(long id)
        {
            Console.WriteLine(id);
            return Ok(id);
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<AdminUserContext>> DeleteAdminUser(long id)
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