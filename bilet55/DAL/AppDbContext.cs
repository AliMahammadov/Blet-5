using bilet55.Models;
using Microsoft.EntityFrameworkCore;

namespace bilet55.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Team> Teams { get; set; }
    }
}
