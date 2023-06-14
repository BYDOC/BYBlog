using BYBlog.BL.Concrete;
using BYBlog.DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BYBlog.UI.Components.Comment
{
    public class CommentListByPost:ViewComponent
    {
        CommentManager cm = new CommentManager(new EFCommentRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = cm.GetAllCommentsByPost(id);
            return View(values);
        }
    }
}
