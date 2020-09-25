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
    [Route("userpsychologycauses")]
    public class UserPsychologyCausesController : ControllerBase
    {

        private readonly AppDBContext _context;
        public UserPsychologyCausesController(AppDBContext context)
        {
            //Console.WriteLine("called");
            _context = context;
        }
        [HttpPost]
        public ActionResult PostAdminUser([FromBody] UserPsychologyCauses userPsychologyCauses)
        {


            Console.WriteLine("Post");
            return Ok(userPsychologyCauses);

        }


        [HttpGet]

        public ActionResult GetAdminUsersDTO([FromQuery] long id)
        {
            Console.WriteLine("Get");
            return Ok();

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