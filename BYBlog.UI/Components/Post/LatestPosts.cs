using BYBlog.BL.Concrete;
using BYBlog.DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BYBlog.UI.Components.Post
{
    public class LatestPosts:ViewComponent
    {
        PostManager pm = new PostManager(new EFPostRepository());
        public IViewComponentResult Invoke()
        {
            var values = pm.GetLastXPost(3);
            return View(values);
        }
    }
}
