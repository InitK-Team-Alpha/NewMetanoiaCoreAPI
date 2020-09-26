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
         public async Task<String> PostAppUser([FromBody] AppUserDTO appUserDTO)
         {

             await _context.AppUserDTOs.AddAsync(appUserDTO);
             await _context.SaveChangesAsync();
            
             Console.WriteLine("AppUser Post");
             return "Ok"; 

         }
        


        [HttpGet]

        public List<AppUserDTO> GetAppUsersDTO()
        {
             Console.WriteLine("AppUser Get");
            // return Ok(appUserDTO);
            return _context.AppUserDTOs.ToList();

        }


        [HttpDelete]

        public ActionResult DeleteAppUser([FromQuery] long id)
        {
            Console.WriteLine("Delelte");
            return Ok(id);

        }



        [HttpPut]
        public IActionResult PutAppUser([FromQuery] long id)
        {
            Console.WriteLine("Put");
            return Ok();



        }


    }
}