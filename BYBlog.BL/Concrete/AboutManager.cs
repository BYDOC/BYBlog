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
    public class AboutManager:IAboutService
    {
        IAbout _about;
        public AboutManager(IAbout about)
        {
            _about = about;
        }

        public void AddT(About t)
        {
            throw new NotImplementedException();
        }

        public void DeleteT(About t)
        {
            throw new NotImplementedException();
        }

        public List<About> GetAll()
        {
            return _about.GetAll();
        }

        public About GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateT(About t)
        {
            throw new NotImplementedException();
        }

     
    }
}
