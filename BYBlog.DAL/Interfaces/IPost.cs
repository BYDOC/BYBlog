using BYBlog.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYBlog.DAL.Interfaces
{
    public interface IPost:IGeneric<Post>
    {
        List<Post> GetAllWithCategory();
        List<Post> GetLastXPost(int x);

    }
}
