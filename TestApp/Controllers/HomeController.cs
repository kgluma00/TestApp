using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestApp.Data;
using TestApp.Models;

namespace TestApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationContext context)
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

        public IActionResult Split()
        {
            return View();
        }

        public IActionResult PrikaziGrad()
        {
            //var grad = new Grad()
            //{
            //    ImeGrada = "Split",
            //    BrojStanovnika = 180000,
            //    ImeGradonacelnika = "Tudman"
            //};

            var grad = _context.Grads.FirstOrDefault();

            return View(grad);
        }

        public IActionResult SpremiGrad()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SpremiGrad(Grad grad)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("ImeGrada", "Obavezno polje");
                return View("SpremiGrad");
            }
            _context.Grads.Add(grad);
            _context.SaveChanges();
            return View("PrikaziGrad", grad);
        }

        public IActionResult PrikaziGradove()
        {
            //var gradovi = new List<Grad>()
            //{
            //    new Grad{ ImeGrada = "Split",BrojStanovnika = 2, ImeGradonacelnika="Opara"},
            //    new Grad{ ImeGrada = "Pula",BrojStanovnika = 3, ImeGradonacelnika="Miletic"},
            //    new Grad{ ImeGrada = "Dubrovnik",BrojStanovnika = 1, ImeGradonacelnika="Vlaho"},
            //    new Grad{ ImeGrada = "Zagreb",BrojStanovnika = 10, ImeGradonacelnika="Bandic"},
            //};

            var gradovi = _context.Grads.ToList();

            return View(gradovi);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
