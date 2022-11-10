using Microsoft.EntityFrameworkCore;
using UserTemplateApi.Models;

namespace UserTemplateApi.Data
{
    public class UserTemplateDbContext : DbContext
    {
        public UserTemplateDbContext(DbContextOptions<UserTemplateDbContext> options)
            :base(options)
        {
        }

       public DbSet<User> Users { get; set; }
    }
}
