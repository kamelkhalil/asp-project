using khalilWebApp.Model;
using Microsoft.EntityFrameworkCore;

namespace khalilWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Category { get; set; } // Renamed to pluralize the table name
        public object Categories { get; internal set; }
    }
}
