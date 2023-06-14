using BYBlog.BL.Concrete;
using BYBlog.DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BYBlog.UI.Components.Category
{
    public class CategoryList:ViewComponent
    {
        CategoryManager cm =new CategoryManager(new EFCategoryRepository());
        public IViewComponentResult Invoke()
        {
            var values = cm.GetAll();
            return View(values);
        }
    }
}
