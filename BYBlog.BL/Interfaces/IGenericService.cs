using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYBlog.BL.Interfaces
{
    public interface IGenericService<T>
    {
        void AddT(T t);
        void DeleteT(T t);
        void UpdateT(T t);
        List<T> GetAll();
        T GetById(int id);
    }
}
