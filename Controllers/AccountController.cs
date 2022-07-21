using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyFood.Data;
using MyFood.Models;
using MyFood.Models.ViewModels;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;

namespace MyFood.Controllers
{
    public class AccountController : Controller
    {
        readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        readonly RoleManager<IdentityRole> _roleManager;


        public AccountController( UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
           
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        
        //Get Login
        [HttpGet]
        public async Task<IActionResult> Login()
        {
            var registerLoginVm = new RegisterLoginVm()
            {
                LoginViewModel = new LoginViewModel(),
                RegisterViewModel = new RegisterViewModel()
                
            };


            if (!_roleManager.RoleExistsAsync(Helper.Helper.Admin).GetAwaiter().GetResult())
            {
                await _roleManager.CreateAsync(new IdentityRole(Helper.Helper.Admin));
                await _roleManager.CreateAsync(new IdentityRole(Helper.Helper.User));

            }
            
            return View(registerLoginVm);
        }
        

        //Post Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(RegisterLoginVm model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.LoginViewModel.Email, model.LoginViewModel.Password, isPersistent: false, false);
                if (result.Succeeded)
                {
                    var user = await _userManager.FindByNameAsync(model.LoginViewModel.Email);
                    HttpContext.Session.SetString("ssUserName",user.Name);
                    HttpContext.Session.SetString("ssUserId",user.Id);
                    TempData["success"] = "Welcome back " + user.Name;
                    
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("","Invalid login attempt");
            }
            return View(model);
        }
        
        

        //Post Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterLoginVm model)
        {

            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    UserName = model.RegisterViewModel.Email,
                    Email = model.RegisterViewModel.Email,
                    Name = model.RegisterViewModel.Name,
                    Password = model.RegisterViewModel.Password,
                };
                
                
                var result = await _userManager.CreateAsync(user, model.RegisterViewModel.Password);
                if (result.Succeeded)
                {
                    
                    await _userManager.AddToRoleAsync(user, model.RegisterViewModel.RoleName);
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    HttpContext.Session.SetString("ssUserId",user.Id);
                    TempData["success"] = "Registered successfully!";       
                    
                    return RedirectToAction("Index", "Home");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("",error.Description);
                }
            }

            return RedirectToAction("Index","Home");
        }
    
        
        
        //Post LogOff
        [HttpPost]
        public async Task<IActionResult> LogOff()
        {
            await _signInManager.SignOutAsync();
            TempData["success"] = "Logged out successfully!";
            
            return RedirectToAction("Login", "Account");
        }
    }
}
