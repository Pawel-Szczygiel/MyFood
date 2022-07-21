using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFood.Data;
using MyFood.Models.ViewModels;

namespace MyFood.Controllers
{
    public class AppetizerController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AppetizerController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {

            ViewBag.userId = HttpContext.Session.GetString("ssUserId");

            IEnumerable<Appetizer> objList = _db.Appetizers;

            return View(objList);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Appetizer obj)
        {

            if (ModelState.IsValid)
            {
                obj.UserId = HttpContext.Session.GetString("ssUserId");
                _db.Appetizers.Add(obj);
                await _db.SaveChangesAsync();
                TempData["success"] = "Recipe created successfully!";
                
                return RedirectToAction("Index");
            }

            return View(obj);

        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id is null or 0)
            {
                return NotFound();
            }

            var obj = await _db.Appetizers.FindAsync(id);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpGet]
        public async Task<IActionResult> DeleteGet(int? id)
        {
            if (id is null or 0)
            {
                return NotFound();
            }

            var obj = await _db.Appetizers.FindAsync(id);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null or 0)
            {
                return NotFound();
            }

            var obj = await _db.Appetizers.FindAsync(id);

            if (obj == null)
            {
                return NotFound();
            }

            _db.Appetizers.Remove(obj);
            await _db.SaveChangesAsync();
            TempData["success"] = "Recipe deleted successfully!";
            
            return RedirectToAction("Index");

        }

        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {
            if (id is null or 0)
            {
                return NotFound();
            }

            var obj = await _db.Appetizers.FindAsync(id);
            int timeToPrepare = obj.TimeToPrepare;

            ViewBag.timeToPrepare = timeToPrepare;

         

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Appetizer obj)
        {
            if (ModelState.IsValid)
            {
                obj.UserId = HttpContext.Session.GetString("ssUserId");
                _db.Appetizers.Update(obj);
                await _db.SaveChangesAsync();
                TempData["success"] = "Recipe updated successfully!";
                
                return RedirectToAction("Index");
            }

            return View(obj);

        }
    }
}
