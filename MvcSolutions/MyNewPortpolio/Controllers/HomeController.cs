using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyNewPortpolio.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyNewPortpolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyNewPortpolioContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, MyNewPortpolioContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Profile()
        {
            var profile = _context.Manages.FirstOrDefault(p => p.Cate.Equals("Profile"));
            return View(profile);
        }

    }
}
