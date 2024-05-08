using ASPTask2.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPTask2.DAL
{
    public class AppDbContext:DbContext
    {
       
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<OrganicProduct> OrganicProducts { get; set; }
        public DbSet<Farmer> Farmers { get; set; }
    }
}
