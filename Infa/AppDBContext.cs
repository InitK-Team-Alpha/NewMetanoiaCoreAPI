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

        public DbSet<AppUserDTO> AppUserDTOs { get; set; }

        public DbSet<AdminUserDTO> AdminUserDTOs { get; set; }

        public DbSet<UserPsychologyCauses> UserPsychologyCausess {get;set;}

        public DbSet<UserPsychologyEffects> UserPsychologyEffectss {get; set;}


    }

}