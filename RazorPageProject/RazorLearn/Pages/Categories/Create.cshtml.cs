using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorLearn.Data;
using RazorLearn.Model;

namespace RazorLearn.Pages.Categories
{
    //[BindProperties] // To bind all properties
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        //[BindProperty] // to bind single property 
        public Category Category { get; set; }  
        public CreateModel(ApplicationDbContext db)
        {
            _db = db;

        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost(Category category)
        //public async Task<IActionResult> OnPost() // No need to pass when we use BindProperty
        {
            if(ModelState.IsValid)
            {
            await _db.category.AddAsync(category);
            //await _db.category.AddAsync(Category); // this when we use BindProperty
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
            }
            return Page();

        }
    }
}
