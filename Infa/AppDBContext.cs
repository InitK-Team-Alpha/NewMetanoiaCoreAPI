using MetanoiaCoreAPI.AdminUser;
using MetanoiaCoreAPI.AppUser;
using Microsoft.EntityFrameworkCore;

namespace MetanoiaCoreAPI.Infa
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {


        }
        public DbSet<AdminUserDTO> AdminUserDTOs {get;set;}
        public DbSet<AppUserDTO> AppUsersDTos{get; set;}
        public DbSet<UserPsychologyCauses> PsychologyCausess{get; set;}
        public DbSet<UserPsychologyEffects> PsychologyEffectss{get; set;}
        public object AppUserDTOs { get; internal set; }
    }
}