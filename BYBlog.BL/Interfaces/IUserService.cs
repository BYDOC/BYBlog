using BYBlog.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BYBlog.BL.Interfaces
{
    public interface IUserService
    {
        void AddUser(User user);
        User GetUserById(int id);
        List<User> GetAllUsers();
        User GetUserByEmailandPassword(string email, string password);
    }
}
