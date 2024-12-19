using Microsoft.AspNetCore.Mvc;
using StoryOfTarniaWebApp.Data;
using StoryOfTarniaWebApp.Models;

namespace StoryOfTarniaWebApp.Controllers
{
    public class AbilitiesController : Controller
    {
        private readonly ApplicationDbContext _db;
        public AbilitiesController(ApplicationDbContext db) 
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Ability> objAbilitiesList = _db.Abilities.ToList();
            return View(objAbilitiesList);
        }
    }
}
