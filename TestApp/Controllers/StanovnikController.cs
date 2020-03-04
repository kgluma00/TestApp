using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestApp.Data;
using TestApp.Models;

namespace TestApp.Controllers
{
    public class StanovnikController : Controller
    {
        private readonly ApplicationContext _context;

        public StanovnikController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult SpremiStanovnika()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SpremiStanovnika(Stanovnik stanovnik)
        {
            stanovnik.GradId = 1;
            _context.Stanovniks.Add(stanovnik);
            _context.SaveChanges();

            return View("PrikaziGrad",stanovnik);
        }

        [HttpGet]
        public IActionResult PokaziSveStanovnikeUnutarGrada()
        {
            ViewData["TempData"] = "Ovo dolazi iz View Data";

            int gradId = 1;
            var gradoviIStanovnici = _context.Grads.Where(i=>i.Id == gradId).Include(s=>s.Stanovnici).FirstOrDefault();

            return View(gradoviIStanovnici);
        }
    }
}