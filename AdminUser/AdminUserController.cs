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

        private readonly AppDBContext _context;
        public AdminUserController(AppDBContext context)
        {
            Console.WriteLine("called");
            _context = context;
        }
        [HttpPost]
        public ActionResult PostAdminUser([FromBody] AdminUserDTO adminUserDTO)
        {
            // await _context.AdminUserDTOs.AddAsync(adminUserDTO);
            // await _context.SaveChangesAsync();

            Console.WriteLine("Accepted");
            return Ok(adminUserDTO);;

        }


        [HttpGet]

        public ActionResult GetAdminUsersDTO([FromQuery] long id)
        {
            Console.WriteLine("Accepted");
            return Ok();
            // return _context.AdminUserDTOs.ToList();
        }


         [HttpDelete("{id}")]

         public async Task<ActionResult<AdminUserDTO>> DeleteAdminUser(long id)
         {
            //  var adminUserDTO = await _context.AdminUserDTOs.FindAsync(id);
            //  if (adminUserDTO == null)
            //  {
            //      return NotFound();
            //  }
            //  _context.AdminUserDTOs.Remove(adminUserDTO);
            //  await _context.SaveChangesAsync();

            //  return adminUserDTO;
            Console.WriteLine("Delelte");
            return Ok(id);
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