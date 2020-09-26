using Microsoft.EntityFrameworkCore;
using MetanoiaCoreAPI.AppUser;
using MetanoiaCoreAPI.AdminUser;


namespace MetanoiaCoreAPI.Infa
{
public class AppDbContext : DbContext

    {
      //internal readonly long ID;
      public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }
        public DbSet<AppUserDTO> AppUserDTOs { get; set; }
        public DbSet<AdminUserDTO> AdminUserDTOs { get; set; }
        public DbSet<UserPsychologyCauses> UserPsychologyCauses { get; set; }
         public DbSet<UserPsychologyEffects> UserPsychologyEffects { get; set; }
        public object AdminUserDTO { get; internal set; }
        public long ID { get; internal set; }
    }
}