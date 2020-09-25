using Microsoft.EntityFrameworkCore;
using MetanoiaCoreAPI.AppUser;


namespace MetanoiaCoreAPI.Infa
{



     public class AppUserContext : DbContext
    {
        internal readonly long ID;

        public AppUserContext(DbContextOptions<AdminUserContext> options) : base(options)
        {


        }
        public DbSet<AppUserContext> AppUserDTOs { get; set; }

    }
}