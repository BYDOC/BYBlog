using BYBlog.BL.Concrete;
using BYBlog.DAL.EntityFramework;
using BYBlog.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BYBlog.UI.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EFContactRepository());
        public IActionResult Index()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact ct)
        {
            
            Contact cont = new Contact();
            cont.Email = ct.Email;
            cont.DateCreated = DateTime.Now;
            cont.Message = ct.Message;
            cont.Subject = ct.Subject;
            cont.UserName = ct.UserName;
            cm.AddContact(cont);
            return View(ct);
        }
    }
}
