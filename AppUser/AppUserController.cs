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
    [Route("appuser")]
    public class AppUserController : ControllerBase
    {

        private readonly AppDBContext _context;
        public AppUserController(AppDBContext context)
        {
            //Console.WriteLine("called");
            _context = context;
        }
        [HttpPost]
        public ActionResult PostAdminUser([FromBody] AppUserDTO appUserDTO)
        {


            Console.WriteLine("Post");
            return Ok(appUserDTO); ;

        }


        [HttpGet]

        public ActionResult GetAdminUsersDTO([FromBody] AppUserDTO appUserDTO)
        {
            Console.WriteLine("Get");
            return Ok(appUserDTO);

        }


        [HttpDelete]

        public ActionResult DeleteAdminUser([FromQuery] long id)
        {
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