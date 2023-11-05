using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;
using WebApplication3.Models.StoreProcedures;

namespace WebApplication3.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookCover> BookCovers { get; set; }
        public DbSet<BookWriter> BookWriters { get; set; }
        public DbSet<SpGetCategory> SpGetCategorys { get; set; }


		[DbFunction("dbo", "spGetCategory")]
		public IQueryable<SpGetCategory> GetCategoryResults()
		{
			return SpGetCategorys;
		}

		internal object LoadStoredProc(string v)
		{
			throw new NotImplementedException();
		}
	}
}
