using Microsoft.AspNetCore.Mvc;
using MSWebPROJ2.Models;
using System.Diagnostics;

namespace MSWebPROJ2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProfileContext _context;

        public HomeController(ProfileContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var users = _context.Users.ToList();
            return View(users);
        }
        
    }
}