using Microsoft.EntityFrameworkCore;
using PlatformService.Models;

namespace PlatformService.Data
{
    // inherits functionality from dbcontext
    public class AppDbContext : DbContext
    {
        // get connection from DI via opt and pass thu the db context via :base(opt)
        public AppDbContext(DbContextOptions<AppDbContext> opt)
            : base(opt) { }

        public DbSet<Platform> Platforms { get; set; }
    }
}
