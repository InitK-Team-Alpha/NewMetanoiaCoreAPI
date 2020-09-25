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

        private readonly AppDBContext _context;
        public AdminUserController(AppDBContext context)
        {
            _context = context;
        }
        [HttpPost]
        public ActionResult PostAdminUser([FromBody] AdminUserDTO adminUserDTO)
        {
            // _context.AdminUserDTOs.Add(adminUserDTO);
            // await _context.SaveChangesAsync();

            // return CreatedAtAction(nameof(GetAdminUserDTO), new { id = adminUserDTO.ID }, adminUserDTO);
            Console.WriteLine(adminUserDTO);
            return Ok(adminUserDTO);
        }


        [HttpGet]

        public async Task<ActionResult<AdminUserDTO>> GetAdminUsersDTO(long id)
        {

            return Ok(id);
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
