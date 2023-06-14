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
    public class SubscriberController : Controller
    {

        public IViewComponentResult AddSubscriber()
        {
            return (IViewComponentResult)View();
        }
        [HttpPost]
        public IActionResult AddSubscriber(string Email)
        {
            SubscriberManager sm = new SubscriberManager(new EFSubscriberRepository());
            Subscriber sub = new Subscriber();
            
            sub.Email = Email;
            sub.IsActive = true;
            sm.AddSubscriber(sub);
            //return ViewComponent("AddSubscriber");
            //return Ok();
            return Redirect("/");
        }


    }
}
