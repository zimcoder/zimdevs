
using Microsoft.EntityFrameworkCore;
using zimdevsapi.Models.Entities;

namespace zimdevsapi.Repositories
{
    public class ZimDevsDbContext : DbContext
    {
        public ZimDevsDbContext(DbContextOptions<ZimDevsDbContext> options)
        : base(options)
        {
        }

        public DbSet<Developer> Developers { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Application> Applications { get; set; }

        public DbSet<ShortList> ShortLists { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<User> Users { get; set; }

    }
}