using Microsoft.EntityFrameworkCore;

namespace WebApiStep1
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> User { get; set; }
    }
}
