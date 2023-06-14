using BYBlog.BL.Concrete;
using BYBlog.DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BYBlog.UI.Components.Post
{
    public class PostListByUser:ViewComponent
    {
        PostManager pm = new PostManager(new EFPostRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = pm.GetPostsByUser(id);
            return View(values);
        }
    }
}
