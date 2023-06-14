using BYBlog.BL.Concrete;
using BYBlog.DAL.EntityFramework;
using BYBlog.Entity.Concrete;
using BYBlog.UI.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BYBlog.UI.Controllers
{
    public class AccountController : Controller
    {

        UserManager um = new UserManager(new EFUserRepository());

        [HttpGet("Login")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("Login")]
        public async Task<IActionResult> Validate(LoginViewModel model)
        {
          
            User LoginUser = um.GetUserByEmailandPassword(model.EmailAddress, model.Password);
            
         
            if (LoginUser != null)
            {
                var claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.NameIdentifier,model.EmailAddress));
                var claimsIdentity=new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(claimsPrincipal);

                return RedirectToAction("Index", "Post");
            }
            return View("Index");

        }
        

    }
}
