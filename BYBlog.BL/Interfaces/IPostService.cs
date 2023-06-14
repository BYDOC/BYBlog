using BYBlog.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYBlog.BL.Interfaces
{
    interface IPostService:IGenericService<Post>
    {
        //void AddPost(Post post);
        //void DeletePost(Post post);
        //void UpdatePost(Post post);
        //List<Post> GetAllPosts();
        //Post GetPostById(int id);
        List<Post> GetAllWithCategory();
        List<Post> GetAllPosts(int id);
        List<Post> GetPostsByUser(int id);
        List<Post> GetLastXPost(int x);
    }
}
