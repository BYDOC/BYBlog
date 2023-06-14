using BYBlog.DAL.Interfaces;
using BYBlog.DAL.Repositories;
using BYBlog.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYBlog.DAL.EntityFramework
{
    public class EFCommentRepository:GenericRepository<Comment>, IComment
    {
    }
}
