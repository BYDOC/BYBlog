using BYBlog.BL.Concrete;
using BYBlog.BL.ValidationRules;
using BYBlog.DAL.EntityFramework;
using BYBlog.Entity.Concrete;
using BYBlog.UI.Models;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BYBlog.UI.Controllers
{
    public class RegisterController : Controller
    {
        UserManager um = new UserManager(new EFUserRepository());
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(User usr)
        {
            UserValidator uv = new UserValidator();
            ValidationResult results = uv.Validate(usr);
            if (results.IsValid)
            {

                usr.About = "test";
                usr.DateCreated = DateTime.Now;
                usr.IsDeleted = false;
                usr.Image = "test";

                um.AddUser(usr);
                return RedirectToAction("Index", "Post");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View(usr);
            
            
            
        }
    }
}
