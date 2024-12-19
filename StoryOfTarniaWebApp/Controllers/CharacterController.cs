using Microsoft.AspNetCore.Mvc;
using StoryOfTarniaWebApp.Data;

namespace StoryOfTarniaWebApp.Controllers
{
    public class CharacterController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CharacterController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
