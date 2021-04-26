using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyNewPortpolio.Data;
using MyNewPortpolio.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            return View();
        }

        public IActionResult Portpolio()
        {
            return View();
        }

        public   IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Board()
        {
            return View();
        }
    }
}
