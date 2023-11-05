using FirstWeb.Data;
using FirstWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace FirstWeb.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
             private readonly ApplicationDbContext _db;
        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(UserLogin userlogin)
        {
            var loginUser = _db.ApplicationUsers.Include(x => x.CustomerUsers).FirstOrDefault(x => x.email == userlogin.Email && x.Password == userlogin.Password);
            //var loginUser = _db.ApplicationUsers.FirstOrDefault(x => x.email == userlogin.Email && x.Password == userlogin.Password);
            if(loginUser == null)
            {
                return BadRequest("User dosen't exist.");
            }
            else
            {
                return RedirectToAction("Register"); ;
            }
            //return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserRegister userRegister) 
        {
            var applicationUser = _db.ApplicationUsers.FirstOrDefault(x => x.email == userRegister.Email);
            if(applicationUser != null)
            {
                return BadRequest("Email is already registered");
            }
            try
            {
                var applicationUser2 = new ApplicationUser
                {
                    email = userRegister.Email,
                    PhoneNumber = userRegister.PhoneNumber,
                    Password = userRegister.Password,
                    UserName = userRegister.PhoneNumber,
                    // Other properties you want to set
                };

                // Save the ApplicationUser to the database
                _db.ApplicationUsers.Add(applicationUser2);
                _db.SaveChanges(); // Use SaveChanges instead of SaveChangesAsync for simplicity

                // Create a related CustomerUser record
                var customerUser = new CustomerUser
                {
                    FirstName = userRegister.FirstName,
                    LastName = userRegister.LastName,
                    ProfilePictureStoragePath= "https://images.pexels.com/photos/220453/pexels-photo-220453.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                    // Other properties you want to set
                   // ApplicationUserId = applicationUser2.UserId // Associate the CustomerUser with the ApplicationUser
                };

                // Save the CustomerUser to the database
                _db.CustomerUsers.Add(customerUser);
                _db.SaveChanges(); // Use SaveChanges instead of SaveChangesAsync for simplicity

                return Ok("User Registered successfully!");
            }
            catch (Exception)
            {
                return BadRequest("Registration failed.");
            }

            //return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public class UserRegister
    {
        //[Required]
        //[Display(Name = "User Type")]
        //[RegularExpression(@"^[a-zA-Z ]{3,20}$", ErrorMessage = "Please enter between 3 to 20 Alphabet only.")]
        //public string UserType { get; set; }
        [Required]
        [Display(Name = "First Name")]
        [RegularExpression(@"^[a-zA-Z ]{3,20}$", ErrorMessage = "Please enter between 3 to 20 Alphabet only.")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [RegularExpression(@"^[a-zA-Z ]{3,20}$", ErrorMessage = "Please enter between 3 to 20 Alphabet only.")]
        public string LastName { get; set; }

        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Please enter a valid email address.")]
        [Display(Name = "Email")]
        public string Email { get; set; }


        [Required, StringLength(10)]
        [Display(Name = "Mobile Number")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid mobile number")]
        public string PhoneNumber { get; set; }

        //[Required]
        //[Display(Name = "User Name")]
        //[RegularExpression(@"^[a-zA-Z0-9]{8,20}$", ErrorMessage = "Please enter between 8 to 20 characters only.")]
        //public string UserName { get; set; }


        [Required]
        [Display(Name = "Password")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[#$^+=!*()%&?_~]).{8,}$", ErrorMessage = "Please follow the below password rules:<br>. Should have at least one lower case[a-z]<br>. Should have at least one upper case[A-Z]<br>. Should have at least one number[0-9]<br>. Should have at least one special character[#$^+=!*()%&?_~]<br>. Minimum 8 characters")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[#$^+=!*()%&?_~]).{8,}$", ErrorMessage = "Please follow the below password rules:<br>. Should have at least one lower case[a-z]<br>. Should have at least one upper case[A-Z]<br>. Should have at least one number[0-9]<br>. Should have at least one special character[#$^+=!*()%&?_~]<br>. Minimum 8 characters")]
        public string ConfirmPassword { get; set; }
    }

    public class UserLogin
    {


        //[Required, StringLength(10)]
        //[Display(Name = "Mobile Number")]
        //[RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid mobile number")]
        //public string PhoneNumber { get; set; }


        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Please enter a valid email address.")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Password")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[#$^+=!*()%&?_~]).{8,}$", ErrorMessage = "Please follow the below password rules:<br>. Should have at least one lower case[a-z]<br>. Should have at least one upper case[A-Z]<br>. Should have at least one number[0-9]<br>. Should have at least one special character[#$^+=!*()%&?_~]<br>. Minimum 8 characters")]
        public string Password { get; set; }
    }

}