using Identity1.Data;
using Identity1.Models.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Identity1.Controllers
{
    public class AccountsController : Controller
    {
        private readonly ApplecationDbContex contex;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public AccountsController(ApplecationDbContex contex,UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.contex = contex;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model) {
            IdentityUser user = new IdentityUser()
            {
                UserName = model.Name,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
            };
           var result=await userManager.CreateAsync(user,model.Password);
            if(result.Succeeded)
            {
                return RedirectToAction("LogIn");

            }
            return RedirectToAction("Register");
        }
        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LogIn(LogInViewModle model)
        {
            var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe,false);//الترو عشان الريممبر مي
            if (result.Succeeded)
            {
                return RedirectToAction("Index","Home");

            }
            return View(model);
        }
    }
}
