using Microsoft.AspNetCore.Mvc;
using Projet_asp.data;
using Projet_asp.Models;

namespace Projet_asp.Controllers
{
    public class ChefController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ChefController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Chef> objCategoryList = _context.Chefs.ToList();
            return View(objCategoryList);
        }
        public IActionResult Create()
        {
            ViewBag.Chef =_context.Chefs.ToList() ;
           
            return View();
            

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Chef obj)
        {

            if(ModelState.IsValid)
            {
                _context.Chefs.Add(obj);
                _context.SaveChanges();
                return RedirectToAction (nameof(Index));

            }
            ViewBag.Chef = _context.Chefs.ToList();

            return View();


        }
    }
}
