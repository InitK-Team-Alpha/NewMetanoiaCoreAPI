using System;
using System.Threading.Tasks;
using MetanoiaCoreAPI.Infa;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MetanoiaCoreAPI.AppUser;

namespace MetanoiaCoreAPI.AdminUser
{
    [ApiController]
    [Route("appuser")]
    public class AppUserController : ControllerBase
    {

        private readonly AppDBContext _context;
        public AppUserController(AppDBContext context)
        {
            Console.WriteLine("OK");
            _context = context;
        }
        [HttpPost]
        public ActionResult PostAppUser([FromBody] AppUserDTO appUserDTO)
        {
            // _context.AdminUserDTOs.Add(adminUserDTO);
            // await _context.SaveChangesAsync();

            // return CreatedAtAction(nameof(GetAdminUserDTO), new { id = adminUserDTO.ID }, adminUserDTO);
            Console.WriteLine("Post Method");
            return Ok(appUserDTO);
        }

        [HttpGet]
        
          public ActionResult GetAppUsersDTO([FromQuery]long id)
        {

            Console.WriteLine("Get Method");
            return Ok(id);
        }

        [HttpDelete]
        public ActionResult Deleteappuser([FromQuery] long id)
        {

            Console.WriteLine("Delete Method");
            return Ok(id);
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