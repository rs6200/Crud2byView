using Microsoft.EntityFrameworkCore;
using RazorLearn.Model;

namespace RazorLearn.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}
		public DbSet<Category> category { get; set; }
	}
}
