using CHEFMANAGEMENT.Models;
using Microsoft.EntityFrameworkCore;

namespace CHEFMANAGEMENT.Data
{
    public class ApplicationDBContext : DbContext

    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> option) : base(option)
        {

        }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Cheff> Cheffs { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<CuisineType> CuisineTypes { get; set; }
        public DbSet<Cuisine> Cuisines { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
