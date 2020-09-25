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
           // Console.WriteLine("called");
            _context = context;
        }
        [HttpPost]
        public ActionResult PostAdminUser([FromBody] UserPsychologyEffects userPsychologyEffects)
        {


            Console.WriteLine("Post");
            return Ok(userPsychologyEffects); ;

        }


        [HttpGet]

        public ActionResult GetAdminUsersDTO([FromQuery] long id)
        {
            Console.WriteLine("Get");
            return Ok();

        }


        [HttpDelete]

        public ActionResult DeleteAdminUser(long id)
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