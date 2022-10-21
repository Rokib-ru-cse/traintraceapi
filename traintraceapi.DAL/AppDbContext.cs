using traintraceapi.Model;
using Microsoft.EntityFrameworkCore;


namespace traintraceapi.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Train> Trains { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
