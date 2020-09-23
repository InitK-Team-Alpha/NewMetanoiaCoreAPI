using Microsoft.EntityFrameworkCore;

namespace MetanoiaCoreAPI.AdminUser
{
    public class AdminUserContext : DbContext
    {
        public AdminUserContext(DbContextOptions<AdminUserContext> options) : base(options)
        {


        }
        public DbSet<AdminUserDTO> AdminUserDTOs {get;set;}
        
    }
}