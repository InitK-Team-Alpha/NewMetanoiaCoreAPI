using System;
using System.Collections.Generic;
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
        public ActionResult PostAdminUser([FromBody] AdminUserDTO adminUserDTO)
        {
            // _context.AdminUserDTOs.Add(adminUserDTO);
            // await _context.SaveChangesAsync();

            // return CreatedAtAction(nameof(GetAdminUserDTO), new { id = adminUserDTO.ID }, adminUserDTO);
            Console.WriteLine(adminUserDTO);
            return Ok();
        }


        [HttpGet]

        public async Task<ActionResult<AdminUserDTO>> GetAdminUsersDTO(long id)
        {
            // var adminUserDTO = await _context.AdminUserDTOs.FindAsync(id);
            // if (adminUserDTO == null)
            // {
            //     return NotFound();
            // }

            // return adminUserDTO;
            return Ok();
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
        // Console.WriteLine("adminUserDTO");
        // return Accepted();


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