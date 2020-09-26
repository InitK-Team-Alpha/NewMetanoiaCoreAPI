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
        public async Task<String> PostUserPCause([FromBody] UserPsychologyCauses userPsychologyCauses)
        {

            await _context.UserPsychologyCausess.AddAsync(userPsychologyCauses);
            await _context.SaveChangesAsync();

            return "Ok";

        }


        [HttpGet]

        public List<UserPsychologyCauses> GetUserPCause()
        {
            // Console.WriteLine("Get");
            // return Ok(appUserDTO);
            return _context.UserPsychologyCausess.ToList();

        }


        [HttpDelete]

        public ActionResult DeleteUserPCause([FromQuery] long id)
        {
            Console.WriteLine("Delelte");
            return Ok(id);
        }



        [HttpPut]
        public IActionResult PutUserPCauses([FromQuery] long id)
        {
            Console.WriteLine("Put");
            return Ok();


        }


    }
}