using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using WebApplication3.Data;
using WebApplication3.Models;
using WebApplication3.Models.StoreProcedures;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication3.Controllers
{
	
	[Route("[controller]/[action]")]
	//[Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        // GET: api/<CategoryController>
        private ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return _context.Categories;
        }
        //[HttpGet("propertyByFilter")]
        [HttpGet]
		public async Task<IActionResult> GetPropertyByFilter()
		{
			//string sqlQuery = "EXEC spGetCategory";
			var categories = await _context.Categories.FromSqlRaw("EXEC spGetCategory").ToListAsync();
			//var orderedRows = categories.OrderBy(x => x.Id);

			return new JsonResult(new { Data = categories });
		}

		[HttpGet]
		public async Task<IActionResult> GetCategoryById(int Id)
		{
			//string sqlQuery = "EXEC spGetCategory";
			var categories = await _context.Categories.FromSqlRaw($"EXEC spGetCategoryById {Id}").ToListAsync();
            //var orderedRows = categories.OrderBy(x => x.Id);
            if (categories.IsNullOrEmpty())
            {

			return new JsonResult(new { Text = "Not found any data" });
            }
			return new JsonResult(new { Data = categories });
		}
		// GET api/<CategoryController>/5
		[HttpGet("{id}")]
        public Category Get(int id)
        {
            return _context.Categories.FirstOrDefault(x => x.Id == id);
        }

        // POST api/<CategoryController>
        [HttpPost]
        public void Post([FromBody] AddCategory addcategory)
        {
            //when we use Category in place of AddCategory
            //category.Id = Guid.NewGuid();
            //_context.Categories.Add(category);
            //_context.SaveChanges();
            var category = new Category()
            {
                Title = addcategory.Title,
                DisplayOrder = addcategory.DisplayOrder,
            };
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] AddCategory addcategory)
        {
            var categoryData = _context.Categories.FirstOrDefault(c => c.Id == id);

            if(categoryData == null)
            {
                BadRequest("Error Occurd");
            }
            else
            {
                categoryData.Title = addcategory.Title;
                categoryData.DisplayOrder = addcategory.DisplayOrder;
            _context.Categories.Update(categoryData);
            _context.SaveChanges();
                Ok("Update Successfully");

            }
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var categoryData = _context.Categories.FirstOrDefault(c => c.Id == id);
            _context.Categories.Remove(categoryData);   
            _context.SaveChanges();
        }
    }



    public class AddCategory
    {
        public string Title { get; set; }
        public int DisplayOrder { get; set; }
    }
	public class SllpGetCategory
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public int DisplayOrder { get; set; }
	}
}
