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
    public class PostController : Controller
    {
        PostManager pm = new PostManager(new EFPostRepository());
        
        public IActionResult Index()
        {
            var values = pm.GetAllWithCategory().OrderByDescending(t=>t.DateCreated).ToList();
            return View(values);
        }

        public IActionResult PostDetail(int id)
        {
            var values = pm.GetPostById(id);
            return View(values);
        }
       public IActionResult PostListByAuthor()
        {
            var values = pm.GetPostsByUser(1);
            
            return View(values);
        }
    }
}
