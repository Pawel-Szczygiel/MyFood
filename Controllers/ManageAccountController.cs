using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyFood.Data;
using MyFood.Models;
using System.Linq;
using System.Threading.Tasks;

namespace MyFood.Controllers
{
    public class ManageAccountController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public ManageAccountController(SignInManager<ApplicationUser> signInManager, ApplicationDbContext db, UserManager<ApplicationUser> userManager)
        {
            _signInManager = signInManager;
            _db = db;
            _userManager = userManager;
        }



        [HttpGet]
        [Authorize]
        public IActionResult Details()
        {
            if (_signInManager.IsSignedIn(User))
            {
                var user = _db.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
                
                if (user != null)
                {
                    return View(user);
                }
            }
            
            return RedirectToAction("Login", "Account");
        }



        [HttpGet]
        public async Task<IActionResult> DeleteGet(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }
            
            var user = await _db.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }

            var user = await _db.Users.FindAsync(id);

            if(user == null)
            {
                return NotFound();
            }

            _db.Users.Remove(user);
            await _db.SaveChangesAsync();
            
            await _signInManager.SignOutAsync();

            TempData["success"] = "Account deleted successfully!";

            return RedirectToAction("Login" ,"Account");

        }

        [HttpGet]
        public async Task<IActionResult> Update(string id)
        {
            if ( string.IsNullOrEmpty(id) )
            {
                return NotFound();
            }

            var user = await _db.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }
            
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(ApplicationUser obj)
        {
            if (ModelState.IsValid)
            {
                
                var oldUser = await _db.Users.FindAsync(obj.Id);

                if (oldUser == null)
                {
                    return NotFound();
                }

                _db.Users.Remove(oldUser);
                await _db.SaveChangesAsync();
                
                var newUser = new ApplicationUser
                {   
                    Id = obj.Id,
                    UserName = obj.Email,
                    Email = obj.Email,
                    Name = obj.Name,
                    Password = obj.Password
                };


                var result = await _userManager.CreateAsync(newUser, obj.Password);
                if (result.Succeeded)
                {
                    
                    await _userManager.AddToRoleAsync(newUser, Helper.Helper.User);
                    await _signInManager.SignInAsync(newUser, isPersistent: false);
                    HttpContext.Session.SetString("ssUserId", newUser.Id);
                    TempData["success"] = "Account updated successfully!";
                    
                    return RedirectToAction("Details", "ManageAccount");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            
            return View(obj);
        }
    }
}
