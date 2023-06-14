using BYBlog.BL.Interfaces;
using BYBlog.DAL.EntityFramework;
using BYBlog.DAL.Interfaces;
using BYBlog.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYBlog.BL.Concrete
{
    //business layerdaki implementasyonlar manager olarak adlandırılıyor
    public class CategoryManager : ICategoryService
    {
        ICategory _category;

        public CategoryManager(ICategory category)
        {
            _category = category;
        }

        public void AddT(Category t)
        {
            _category.Insert(t);
        }

        public void DeleteT(Category t)
        {
            _category.Delete(t);
        }

        public List<Category> GetAll()
        {
            return _category.GetAll();
        }

        public Category GetById(int id)
        {
            return _category.GetById(id);
        }

        public void UpdateT(Category t)
        {
            _category.Update(t);
        }
    }
}
