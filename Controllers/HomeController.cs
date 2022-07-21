using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyFood.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using MyFood.Data;

namespace MyFood.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;
        
        private readonly SignInManager<ApplicationUser> _signInManager;
       
        
        public HomeController( SignInManager<ApplicationUser> signInManager, ApplicationDbContext db)
        {

            _signInManager = signInManager;
            _db = db;
        }


        [HttpGet]
        public IActionResult Index()
        {
            if (_signInManager.IsSignedIn(User))
            {
                var user = _db.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
                if (user != null)
                {
                    ViewBag.Name = user.Name;
                    /*HttpContext.Session.SetString("ssUserId", user.Id);*/
                }
            }
            
             return View();
            
        }


        [HttpGet]
        [Authorize]
        public IActionResult Categories()
        {
            if (_signInManager.IsSignedIn(User))
            {
                var user = _db.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
                if (user != null)
                {
                    return View();
                }
            }

            return RedirectToAction("Index");
        }

        
        
        
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
