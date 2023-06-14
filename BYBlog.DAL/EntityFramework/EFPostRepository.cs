using BYBlog.DAL.Concrete;
using BYBlog.DAL.Interfaces;
using BYBlog.DAL.Repositories;
using BYBlog.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYBlog.DAL.EntityFramework
{
    public class EFPostRepository : GenericRepository<Post>, IPost
    {
        public List<Post> GetAllWithCategory()
        {
            using(var c = new BYBlog_DbContext())
            {
                return c.Posts.Include(x => x.Category).ToList();
            }
        }

        public List<Post> GetLastXPost(int x)
        {
            using (var c = new BYBlog_DbContext())
            {
                return c.Posts.Include(x => x.Category).Take(x).ToList();
            }
        }
    }
}
