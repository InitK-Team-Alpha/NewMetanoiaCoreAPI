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
            Console.WriteLine("called");
            _context = context;
        }
        [HttpPost]
        public ActionResult PostAdminUser([FromBody] AdminUserDTO adminUserDTO)
        {
           Console.WriteLine("Post Method");
            return Ok(adminUserDTO);
        }


        [HttpGet]

        public async Task<ActionResult<AdminUserDTO>> GetAdminUsersDTO(long id)
        {
           
            Console.WriteLine("Get Method");
            return Ok(id);
        }
        [HttpDelete]

        public async Task<ActionResult<AdminUserDTO>> DeleteAdminUser(long id)
        {
            
            
            Console.WriteLine("Delete Method");
            return Ok();

        }
        

        [HttpPut]
        public async Task<IActionResult> PutAdminUser(long id, AdminUserDTO adminUserDTO)
        {
            
            Console.WriteLine("Put Method");
            return Ok();

        }

        private bool AdminUserDTOExists(long id)
        {
            throw new NotImplementedException();
        }
    }
}