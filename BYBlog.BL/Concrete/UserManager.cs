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
    public class UserManager : IUserService
    {
        IUser _user;
        public UserManager(IUser user)
        {
            _user = user;
        }
        public void AddUser(User user)
        {
            _user.Insert(user);
        }

        public List<User> GetAllUsers()
        {
            return _user.GetAll();
        }

        public User GetUserByEmailandPassword(string email, string password)
        {
            return _user.GetAll().FirstOrDefault(x=> x.EmailAddress==email && x.Password==password);
        }

        public User GetUserById(int id)
        {
            return _user.GetById(id);
        }

        
    }
}
