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
            //Console.WriteLine("called");
            _context = context;
        }
        [HttpPost]
        public ActionResult PostAdminUser([FromBody] AdminUserDTO adminUserDTO)
        {
            // await _context.AdminUserDTOs.AddAsync(adminUserDTO);
            // await _context.SaveChangesAsync();

            Console.WriteLine("Post");
            return Ok(adminUserDTO);;

        }


        [HttpGet]

         public ActionResult GetAdminUsersDTO([FromQuery] long id)
         {
             Console.WriteLine("Get");
             return Ok();
             // return _context.AdminUserDTOs.ToList();
         }
         


         [HttpDelete]

         public ActionResult  DeleteAdminUser([FromQuery] long id)
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



         [HttpPut]
         public IActionResult PutAdminUser([FromQuery] long id)
         {
              Console.WriteLine("Put");
             return Ok();

         }


    }
}