using Microsoft.EntityFrameworkCore;
using MetanoiaCoreAPI.AppUser;


namespace MetanoiaCoreAPI.Infa
{



     public class UserPsychologyCausesContext : DbContext
    {
        internal readonly long ID;

        public UserPsychologyCausesContext(DbContextOptions<UserPsychologyCausesContext> options) : base(options)
        {


        }
        public DbSet<UserPsychologyCausesContext> UserPsychologyCauses { get; set; }

    }
}