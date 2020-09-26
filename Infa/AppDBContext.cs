using Microsoft.EntityFrameworkCore;
using MetanoiaCoreAPI.AppUser;
using MetanoiaCoreAPI.AdminUser;

namespace MetanoiaCoreAPI.Infa
{

    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> opt) : base(opt)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new AdminUserConfiguration());
            modelBuilder.ApplyConfiguration(new UserPsychologyCausesConfiguration());
            modelBuilder.ApplyConfiguration(new UserPsychologyEffectsConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<AppUserDTO> AppUsers { get; set; }

        public DbSet<AdminUserDTO> AdminUserDTOs { get; set; }

        public DbSet<UserPsychologyCauses> UserPsychologyCause { get; set; }
        public DbSet<UserPsychologyEffects> UserPsychologyEffect { get; set; }
        public object AdminUserDTO { get; internal set; }
        //public object AppUserDTO{get; internal set;}
    }

}
