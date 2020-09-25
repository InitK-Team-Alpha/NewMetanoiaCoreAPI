using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MetanoiaCoreAPI.AppUser;
using MetanoiaCoreAPI.Infa;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MetanoiaCoreAPI.AdminUser
{
    [ApiController]
    [Route("userpsychologyeffects")]
    public class UserPsychologyEffectsController : ControllerBase
    {

        private readonly AppDBContext _context;
        public UserPsychologyEffectsController(AppDBContext context)
        {
            Console.WriteLine("called");
            _context = context;
        }
        [HttpPost]
        public ActionResult PostAdminUser([FromBody] UserPsychologyEffects userPsychologyEffects)
        {
            // await _context.AdminUserDTOs.AddAsync(adminUserDTO);
            // await _context.SaveChangesAsync();

            Console.WriteLine("Accepted");
            return Ok(userPsychologyEffects);;

        }


        [HttpGet]

        public ActionResult GetAdminUsersDTO([FromQuery] long id)
        {
            Console.WriteLine("Accepted");
            return Ok();
            // return _context.AdminUserDTOs.ToList();
        }


        // [HttpDelete("{id}")]

        // public async Task<ActionResult<AdminUserDTO>> DeleteAdminUser(long id)
        // {
        //     var adminUserDTO = await _context.AdminUserDTOs.FindAsync(id);
        //     if (adminUserDTO == null)
        //     {
        //         return NotFound();
        //     }
        //     _context.AdminUserDTOs.Remove(adminUserDTO);
        //     await _context.SaveChangesAsync();

        //     return adminUserDTO;
        // }



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