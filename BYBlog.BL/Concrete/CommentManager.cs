using BYBlog.BL.Interfaces;
using BYBlog.DAL.Interfaces;
using BYBlog.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYBlog.BL.Concrete
{
    public class CommentManager : ICommentService
    {
        IComment _comment;

        public CommentManager(IComment comment)
        {
            _comment = comment; 
        }

        public void AddComment(Comment comment)
        {
            _comment.Insert(comment);

        }

        public List<Comment> GetAllCommentsByPost(int id)
        {
            return _comment.GetAll(x => x.PostId == id);
        }

    }
}
