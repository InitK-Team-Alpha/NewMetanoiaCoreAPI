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
         public async Task<String> PostUserPEffects([FromBody] UserPsychologyEffects userPsychologyEffect)
        {

            await _context.UserPsychologyEffectss.AddAsync(userPsychologyEffect);
            await _context.SaveChangesAsync();

            return "Ok";

        }
        


        [HttpGet]

         public List<UserPsychologyEffects> GetUserPEffects()
         {
            //  Console.WriteLine("Get");
            //  return Ok();
              return _context.UserPsychologyEffectss.ToList();
         }


        [HttpDelete]

        public ActionResult DeleteUserPEffects(long id)
        {
            Console.WriteLine("Delelte");
            return Ok(id);

        }



        [HttpPut]
        public IActionResult PutUserPEffects([FromQuery] long id)
        {
            Console.WriteLine("Put");
            return Ok();

        }


    }
}