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
    public class PostManager : IPostService
    {
        IPost _post;
        public PostManager(IPost post)
        {
            _post = post;
        }
        //public void AddPost(Post post)
        //{
        //    _post.Insert(post);
        //}

        //public void DeletePost(Post post)
        //{
        //    _post.Delete(post);
        //}

        public List<Post> GetAllPosts()
        {
            return _post.GetAll();
        }
        public List<Post> GetAllPosts(int id)
        {
            return _post.GetAll(x => x.Id == id);
        }
        public Post GetPostById(int id)
        {
            return _post.GetById(id);
        }

        public List<Post> GetAllWithCategory()
        {
            return _post.GetAllWithCategory();
        }

        //public void UpdatePost(Post post)
        //{
        //    _post.Update(post);
        //}

        public List<Post> GetPostsByUser(int id)
        {
            return _post.GetAll(x => x.UserId == id);
        }

        public List<Post> GetLastXPost(int x)
        {
            return _post.GetLastXPost(x);
        }

        public void AddT(Post t)
        {
            _post.Insert(t);
        }

        public void DeleteT(Post t)
        {
            _post.Delete(t);
        }

        public void UpdateT(Post t)
        {
            _post.Update(t);
        }

        public List<Post> GetAll()
        {
            throw new NotImplementedException();
        }

        public Post GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
