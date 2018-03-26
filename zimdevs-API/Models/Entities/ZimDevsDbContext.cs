
using Microsoft.EntityFrameworkCore;

namespace zimdevsapi.Models
{
    public class ZimDevsDbContext : DbContext
    {
        public ZimDevsDbContext(DbContextOptions<ZimDevsDbContext> options)
        : base(options)
        {
        }

        public DbSet<Developer> Developers { get; set; }
    }
}