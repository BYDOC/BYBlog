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
    public class CommentController : Controller
    {
        PostManager pm = new PostManager(new EFPostRepository());
        public IActionResult Index()
        {
            return View();
        }
     
        [HttpPost]
        public IActionResult AddComment(string Name, string Email, string Subject, string Message, string PostId)
        {
            int pid = Convert.ToInt32(PostId);
            CommentManager cm = new CommentManager(new EFCommentRepository());
            Comment cmt = new Comment();
            cmt.Content = Message;
            cmt.DateCreated = DateTime.Now;
            cmt.IsDeleted = false;
            cmt.PostId = pid;
            cmt.UserName = Name;
            cm.AddComment(cmt);
            return Redirect($"/Post/PostDetail/{pid}");
        }

        public PartialViewResult ListCommentPartial(int id)
        {
            CommentManager cm = new CommentManager(new EFCommentRepository());
            var values = cm.GetAllCommentsByPost(id);
            return PartialView(values);
        }
    }
}
