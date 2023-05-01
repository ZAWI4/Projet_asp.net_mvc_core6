using Microsoft.AspNetCore.Mvc;
using Projet_asp.data;
using Projet_asp.Models;

namespace Projet_asp.Controllers
{
    public class MenuController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MenuController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Menu> objCategoryList = _context.Menus.ToList();
            return View(objCategoryList);
        }

        public IActionResult Create()
        {
            ViewBag.Menu = _context.Menus.ToList();

            return View();


        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Menu obj)
        {

            if (ModelState.IsValid)
            {
                _context.Menus.Add(obj);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));

            }
            ViewBag.Menu = _context.Menus.ToList();

            return View();


        }
    }
}
