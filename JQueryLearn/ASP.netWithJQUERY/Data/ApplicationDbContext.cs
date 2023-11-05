using ASP.netWithJQUERY.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.netWithJQUERY.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
    }
}
