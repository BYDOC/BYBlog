using BYBlog.BL.Concrete;
using BYBlog.DAL.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BYBlog.UI.Controllers
{
    public class UserController : Controller
    {
        UserManager um = new UserManager(new EFUserRepository());
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Test()
        {
            
            return View();
        }
        public PartialViewResult UserNavbarPartial()
        {
            return PartialView();
        }
        public PartialViewResult UserFooterPartial()
        {
            return PartialView();
        }
    }
}
