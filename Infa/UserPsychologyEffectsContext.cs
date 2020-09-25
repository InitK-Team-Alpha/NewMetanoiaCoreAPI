using Microsoft.EntityFrameworkCore;
using MetanoiaCoreAPI.AppUser;


namespace MetanoiaCoreAPI.Infa
{



     public class UserPsychologyEffectsContext : DbContext
    {
        internal readonly long ID;

        public UserPsychologyEffectsContext(DbContextOptions<UserPsychologyEffectsContext> options) : base(options)
        {


        }
        public DbSet<UserPsychologyEffectsContext> UserPsychologyEffects { get; set; }

    }
}