using Microsoft.AspNetCore.Mvc;
using StoryOfTarniaWebApp.Data;
using StoryOfTarniaWebApp.Models;

namespace StoryOfTarniaWebApp.Controllers
{
    public class FeatsController : Controller
    {
        private readonly ApplicationDbContext _db;
        public FeatsController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Feat> objFeatsList = _db.Feats.ToList();
            return View(objFeatsList);
        }

        //CREATE
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Feat _feat)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _db.Feats.Add(_feat);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //EDIT
        public IActionResult Edit(int? featId)
        {
            if(featId == null || featId==0)
            {
                return NotFound();
            }
            Feat? featFound = _db.Feats.SingleOrDefault(f => f.Id == featId);
            if (featFound == null)
            {
                return NotFound();
            }
            return View(featFound);
        }
        [HttpPost]
        public IActionResult Edit(Feat _feat)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _db.Feats.Update(_feat);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
