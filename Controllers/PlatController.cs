using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projet_asp.data;
using Projet_asp.Models;

namespace Projet_asp.Controllers
{
    public class PlatController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PlatController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Plat> objCategoryList = _context.Plats.Include(x=>x.Menu).OrderBy(x=>x.Menu.nom).ToList();
            return View(objCategoryList);
        }

        public IActionResult Create()
        {

            ViewBag.Plat = _context.Plats.Include(x => x.Menu).OrderBy(x => x.Menu.nom).ToList();

            return View();


        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Plat obj)
        {

            if (ModelState.IsValid)
            {
                _context.Plats.Add(obj);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));

            }
            ViewBag.Plat = _context.Plats.ToList();

            return View();


        }

    }
}
