using ASP.netWithJQUERY.Data;
using ASP.netWithJQUERY.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace ASP.netWithJQUERY.Controllers
{
	public class HomeController : Controller

	{
		//private readonly ILogger<HomeController> _logger;
		private readonly ApplicationDbContext _context;
		public HomeController(ApplicationDbContext context)
		{
			_context= context;
		}
		//public HomeController(ILogger<HomeController> logger)
		//{
		//	_logger = logger;
		//}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			ViewBag.countries = _context.Countries.ToList();
			return View();
		}

		public JsonResult getStateById(int id)
		{
			List<State> list = new List<State>();
			list = _context.States.Where(a=> a.Country.Id == id).ToList();
			list.Insert(0, new State { Id = 0, Name = "Please select state" });
			return  Json(new SelectList(list,"Id","Name"));
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

		public string getDateTime()
		{

			return DateTime.Now.ToString();
		}
		public string getInfo(string firstName,string lastName) {
		return firstName + " " + lastName + " Added";
		}
	}
}