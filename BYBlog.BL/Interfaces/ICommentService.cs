using BYBlog.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYBlog.BL.Interfaces
{
    public interface ICommentService
    {
        void AddComment(Comment comment);
        //void DeleteComment(Comment comment);
        //void UpdateComment(Comment comment);
        List<Comment> GetAllCommentsByPost(int id);
        //Comment GetCommentById(int id);

         
    }
}
