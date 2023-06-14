using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BYBlog.UI.Components.Comment
{
    public class AddComment:ViewComponent
    {
        public IViewComponentResult Invoke(int postid)
        {
            ViewData["id"] = postid;
            return View();
        }
    }
}
