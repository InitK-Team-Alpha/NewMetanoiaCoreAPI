using Microsoft.EntityFrameworkCore;
using MetanoiaCoreAPI.AppUser;


namespace MetanoiaCoreAPI.Infa
{



     public class AdminUserContext : DbContext
    {
        public AdminUserContext(DbContextOptions<AdminUserContext> options) : base(options)
        {


        }
        public DbSet<AdminUserContext> AdminUserDTOs { get; set; }

    }
}