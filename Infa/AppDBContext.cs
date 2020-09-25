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

            base.OnModelCreating(modelBuilder);
        }

        DbSet<AppUserDTO> AppUsers { get; set; }

        DbSet<AdminUserDTO> AdminUserDTOs{ get; set; }

        DbSet <UserPsychologyCauses> UserPsychologyCause{get;set;}
        DbSet <UserPsychologyEffects> UserPsychologyEffect{get; set;}
        public object AdminUserDTO { get; internal set; }
    }

}
