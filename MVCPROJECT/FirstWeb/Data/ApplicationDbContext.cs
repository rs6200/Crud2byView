using FirstWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstWeb.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
      public  DbSet<CustomerUser> CustomerUsers { get; set; }
      public  DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
