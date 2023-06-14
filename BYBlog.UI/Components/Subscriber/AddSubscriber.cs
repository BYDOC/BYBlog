using BYBlog.BL.Concrete;
using BYBlog.DAL.EntityFramework;
using BYBlog.DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BYBlog.UI.Components.Subscriber
{
    public class AddSubscriber:ViewComponent
    {
        //SubscriberManager sm = new SubscriberManager(new EFSubscriberRepository());
        
        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
}
