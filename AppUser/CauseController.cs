using System;
using System.Threading.Tasks;
using MetanoiaCoreAPI.Infa;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MetanoiaCoreAPI.AppUser;

namespace MetanoiaCoreAPI.AdminUser
{
    [ApiController]
    [Route("cause")]
    public class CauseController : ControllerBase
    {

        private readonly AppDBContext _context;
        public CauseController(AppDBContext context)
        {
            Console.WriteLine("OK");
            _context = context;
        }
        [HttpPost]
        public ActionResult PostAppUser([FromBody] UserPsychologyCauses causes)
        {
            // _context.AdminUserDTOs.Add(adminUserDTO);
            // await _context.SaveChangesAsync();

            // return CreatedAtAction(nameof(GetAdminUserDTO), new { id = adminUserDTO.ID }, adminUserDTO);
            Console.WriteLine("Post Method");
            return Ok(causes);
        }

        [HttpGet]
        
          public ActionResult GetAppUsersDTO([FromQuery]long id)
        {

            Console.WriteLine("Get Method");
            return Ok(id);
        }

        [HttpDelete]
        public ActionResult Deletec([FromQuery] long id)
        {

            Console.WriteLine("Delete Method");
            return Ok(id);
        }
        [HttpPut]
        public async Task<IActionResult> PutAppUser(long id)
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